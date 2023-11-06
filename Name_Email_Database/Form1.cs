using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Name_Email_CRUD
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        // Declare regular expression var for use in create and update event handlers
        private string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        // Create a dictonary
        private Dictionary<string, string> nameEmailDictionary = new Dictionary<string, string>();
        // Declare filepath variable to be used in file I/O
        private string filepath = "data.txt";


        private void LoadDictionaryFromTextFile()
        {
            // This is a function for loading in the txt file into a dictonary 
            // Read the CSV data from the text file and update the nameEmailDictionary
            string[] csvLines = File.ReadAllLines(filepath);
            foreach (var line in csvLines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string email = parts[1];
                    nameEmailDictionary[name] = email;
                }
            }
        }
        static void SaveDictionaryToTextFile(string filePath, Dictionary<string, string> dictionary)
        {
            // Create a list to hold the CSV lines
            List<string> csvLines = new List<string>();

            foreach (var kvp in dictionary)
            {
                string line = $"{kvp.Key},{kvp.Value}";
                csvLines.Add(line);
            }

            // Write the CSV lines to the txt file
            File.WriteAllLines(filePath, csvLines);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Check if the file exists and if it does load it
            if (File.Exists(filepath))
            {
                LoadDictionaryFromTextFile();
            }
            else
            {
                //  Send an error message and tell the user we're using an empty dictonary and you will not save

            }
        }


        private void lookupButton_Click(object sender, EventArgs e)
        {
            // TODO: Create a way to lookup a name from an email? I'd have to use a different data structure which complicates things greatly. 
            
            
            // Check to see if the user entered anything in the textbox before starting
            if (lookupDeleteNameTextBox.Text == "" )
            {
                // Tell the user whats wrong 
                MessageBox.Show("Please enter details in the name field.", "Error! Name field is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Jump out of the onclick
                return;
            }
            // Declare string variable for use within the lookup 
            string key = lookupDeleteNameTextBox.Text;

            // If the key exists within the dictionary 
            if (nameEmailDictionary.ContainsKey(lookupDeleteNameTextBox.Text))
            {
                MessageBox.Show($"The name {key} does exist within the database\nThe email is {nameEmailDictionary[key]}", ("Name does exist!"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // If the key doesn't exist
            else
            {
                MessageBox.Show($"The name {key} doesn't exist within the database", ("Name doesn't exist!"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // If the key exists within the dictionary
            if (nameEmailDictionary.ContainsKey(lookupDeleteNameTextBox.Text))
            {
                // Delcare a key variable
                string key = lookupDeleteNameTextBox.Text;
                // Prompt the user for confirmation just incase they accidentally hit the button
                var confirmation = MessageBox.Show("After deleteing a user you cannot revert this change\nWould you like to continue", "Are you sure?...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // If the user pressed yes, delete it and tell the user that it was deleted
                if (confirmation == DialogResult.Yes)
                {
                    // Delete the record
                    nameEmailDictionary.Remove(key);

                    // TODO: Exception handle on delete.
                    // There really shouldn't be any errors because if a key exists you normally can delete it, but it might be some good measure to put something here for some users who go above and beyond to break this

                    // Tell the user it was done successfully
                    MessageBox.Show("User sucessfully deleted", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If not show the user it is aborting the process
                else
                {
                    // Tell the user it didn't work
                    MessageBox.Show("Aborting!", "Deleting process canceled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Declare Key and Value variables if name and email are entered
            if (createUpdateNameTextBox.Text == "" || createUpdateEmailTextBox.Text == "")
            {
                // Tell the user whats wrong 
                MessageBox.Show("Please enter details in both name and email", "Error! Name or Email is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Jump out of the onclick
                return;
            }
            // Declare key and value strings
            string key = createUpdateNameTextBox.Text;
            string value = createUpdateEmailTextBox.Text;

            // Check to see if the email is a valid email. This isn't super strict
            if (!Regex.IsMatch(value, emailPattern))
            {
                // Tell the user it's not valid
                MessageBox.Show("Please enter a valid email!", "Error! Invalid email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Jump out of the onclick
                return;
            }

            // Check to see if the key is already there, if so tell the user it already exists
            if (nameEmailDictionary.ContainsKey(key))
            {
                // Tell the user the name already exists
                MessageBox.Show("Please enter a new name.", "Error! User already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Jump out of the onclick
                return;
            }




            // Prompt the user for confirmation just incase they accidentally hit the button
            var confirmation = MessageBox.Show($"You are about the create the user{key},{value}\nWould you like to continue", "Are you sure?...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If they pressed yes, create it and tell the user that it was create
            if (confirmation == DialogResult.Yes)
            {
                // Create the record
                nameEmailDictionary[key] = value;

                // TODO: Exception handle on create.
                // Now there REALLY REALLY shouldn't be errors on this but endusers might break something

                // Tell the user it was good
                MessageBox.Show("User sucessfully created", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // If not show the user it is aborting the process
            else
            {
                // Tell the user it was aborted
                MessageBox.Show("Aborting!", "Creation process canceled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Declare Key and Value variables if name and email are entered
            if (createUpdateNameTextBox.Text == "" || createUpdateEmailTextBox.Text == "")
            {
                // Tell the user whats wrong 
                MessageBox.Show("Please enter details in both name and email", "Error! Name or Email is empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Jump out of the onclick
                return;
            }
            // Declare key and value strings
            string key = createUpdateNameTextBox.Text;
            string updatedValue = createUpdateEmailTextBox.Text;
            if (nameEmailDictionary.ContainsKey(key))
            {
                string oldValue = nameEmailDictionary[key];

                // Check to see if the email is a valid email. This isn't super strict
                if (!Regex.IsMatch(updatedValue, emailPattern))
                {
                    // Tell the user it's not valid
                    MessageBox.Show("Please enter a valid email!", "Error! Invalid email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Jump out of the onclick
                    return;
                }

                // Prompt the user for confirmation just incase they accidentally hit the button
                var confirmation = MessageBox.Show($"You are about to change the email from {oldValue} to {updatedValue} ,Would you like to continue", "Are you sure?...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // If they pressed yes, create it and tell the user that it was create
                if (confirmation == DialogResult.Yes)
                {
                    // Create the record
                    nameEmailDictionary[key] = updatedValue;

                    // TODO: Exception handle on update.
                    // Possible errors? I'm not too sure since you're just updating a value, but if it can break it will break

                    // Tell the user it was good
                    MessageBox.Show("User sucessfully updated", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If not show the user it is aborting the process
                else
                {
                    // Tell the user it was aborted
                    MessageBox.Show("Aborting!", "Update process canceled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Aborting!", "The given name doesn't exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Call the save function
            SaveDictionaryToTextFile(filepath, nameEmailDictionary);
            // Tell the user its all good
            MessageBox.Show("Saved sucessfully!","Sucess!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Close
            this.Close();
        }
    }
}

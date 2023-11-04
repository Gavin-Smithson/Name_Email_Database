namespace Name_Email_CRUD
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.LookupDeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lookupButton = new System.Windows.Forms.Button();
            this.lookupDeleteNameLbl = new System.Windows.Forms.Label();
            this.lookupDeleteNameTextBox = new System.Windows.Forms.TextBox();
            this.createUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.createUpdateEmailLbl = new System.Windows.Forms.Label();
            this.createUpdateNameLbl = new System.Windows.Forms.Label();
            this.createUpdateEmailTextBox = new System.Windows.Forms.TextBox();
            this.createUpdateNameTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.LookupDeleteGroupBox.SuspendLayout();
            this.createUpdateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(28, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(517, 38);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Make sure to enter names and emails exactly as they are spelt. \r\nCapitlization ma" +
    "tters";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LookupDeleteGroupBox
            // 
            this.LookupDeleteGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LookupDeleteGroupBox.Controls.Add(this.deleteButton);
            this.LookupDeleteGroupBox.Controls.Add(this.lookupButton);
            this.LookupDeleteGroupBox.Controls.Add(this.lookupDeleteNameLbl);
            this.LookupDeleteGroupBox.Controls.Add(this.lookupDeleteNameTextBox);
            this.LookupDeleteGroupBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupDeleteGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LookupDeleteGroupBox.Location = new System.Drawing.Point(12, 85);
            this.LookupDeleteGroupBox.Name = "LookupDeleteGroupBox";
            this.LookupDeleteGroupBox.Size = new System.Drawing.Size(262, 236);
            this.LookupDeleteGroupBox.TabIndex = 1;
            this.LookupDeleteGroupBox.TabStop = false;
            this.LookupDeleteGroupBox.Text = "Lookup and Delete";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButton.Location = new System.Drawing.Point(169, 164);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 32);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lookupButton
            // 
            this.lookupButton.BackColor = System.Drawing.SystemColors.Control;
            this.lookupButton.FlatAppearance.BorderSize = 0;
            this.lookupButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lookupButton.Location = new System.Drawing.Point(20, 164);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(75, 32);
            this.lookupButton.TabIndex = 2;
            this.lookupButton.Text = "Lookup";
            this.lookupButton.UseVisualStyleBackColor = false;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // lookupDeleteNameLbl
            // 
            this.lookupDeleteNameLbl.AutoSize = true;
            this.lookupDeleteNameLbl.Location = new System.Drawing.Point(6, 32);
            this.lookupDeleteNameLbl.Name = "lookupDeleteNameLbl";
            this.lookupDeleteNameLbl.Size = new System.Drawing.Size(81, 15);
            this.lookupDeleteNameLbl.TabIndex = 1;
            this.lookupDeleteNameLbl.Text = "Enter a name";
            // 
            // lookupDeleteNameTextBox
            // 
            this.lookupDeleteNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lookupDeleteNameTextBox.Location = new System.Drawing.Point(6, 48);
            this.lookupDeleteNameTextBox.Name = "lookupDeleteNameTextBox";
            this.lookupDeleteNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.lookupDeleteNameTextBox.TabIndex = 0;
            // 
            // createUpdateGroupBox
            // 
            this.createUpdateGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.createUpdateGroupBox.Controls.Add(this.updateButton);
            this.createUpdateGroupBox.Controls.Add(this.createButton);
            this.createUpdateGroupBox.Controls.Add(this.createUpdateEmailLbl);
            this.createUpdateGroupBox.Controls.Add(this.createUpdateNameLbl);
            this.createUpdateGroupBox.Controls.Add(this.createUpdateEmailTextBox);
            this.createUpdateGroupBox.Controls.Add(this.createUpdateNameTextBox);
            this.createUpdateGroupBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUpdateGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.createUpdateGroupBox.Location = new System.Drawing.Point(298, 85);
            this.createUpdateGroupBox.Name = "createUpdateGroupBox";
            this.createUpdateGroupBox.Size = new System.Drawing.Size(262, 236);
            this.createUpdateGroupBox.TabIndex = 1;
            this.createUpdateGroupBox.TabStop = false;
            this.createUpdateGroupBox.Text = "Create and Update";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateButton.Location = new System.Drawing.Point(172, 164);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 32);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.Control;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createButton.Location = new System.Drawing.Point(18, 164);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 32);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createUpdateEmailLbl
            // 
            this.createUpdateEmailLbl.AutoSize = true;
            this.createUpdateEmailLbl.Location = new System.Drawing.Point(6, 84);
            this.createUpdateEmailLbl.Name = "createUpdateEmailLbl";
            this.createUpdateEmailLbl.Size = new System.Drawing.Size(87, 15);
            this.createUpdateEmailLbl.TabIndex = 1;
            this.createUpdateEmailLbl.Text = "Enter an email";
            // 
            // createUpdateNameLbl
            // 
            this.createUpdateNameLbl.AutoSize = true;
            this.createUpdateNameLbl.Location = new System.Drawing.Point(6, 32);
            this.createUpdateNameLbl.Name = "createUpdateNameLbl";
            this.createUpdateNameLbl.Size = new System.Drawing.Size(81, 15);
            this.createUpdateNameLbl.TabIndex = 1;
            this.createUpdateNameLbl.Text = "Enter a name";
            // 
            // createUpdateEmailTextBox
            // 
            this.createUpdateEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUpdateEmailTextBox.Location = new System.Drawing.Point(6, 100);
            this.createUpdateEmailTextBox.Name = "createUpdateEmailTextBox";
            this.createUpdateEmailTextBox.Size = new System.Drawing.Size(250, 23);
            this.createUpdateEmailTextBox.TabIndex = 0;
            // 
            // createUpdateNameTextBox
            // 
            this.createUpdateNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUpdateNameTextBox.Location = new System.Drawing.Point(6, 48);
            this.createUpdateNameTextBox.Name = "createUpdateNameTextBox";
            this.createUpdateNameTextBox.Size = new System.Drawing.Size(250, 23);
            this.createUpdateNameTextBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(181, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(204, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Save and exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(572, 424);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createUpdateGroupBox);
            this.Controls.Add(this.LookupDeleteGroupBox);
            this.Controls.Add(this.titleLbl);
            this.Name = "mainForm";
            this.Text = "Name & Email Database";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.LookupDeleteGroupBox.ResumeLayout(false);
            this.LookupDeleteGroupBox.PerformLayout();
            this.createUpdateGroupBox.ResumeLayout(false);
            this.createUpdateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox LookupDeleteGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Label lookupDeleteNameLbl;
        private System.Windows.Forms.TextBox lookupDeleteNameTextBox;
        private System.Windows.Forms.GroupBox createUpdateGroupBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label createUpdateNameLbl;
        private System.Windows.Forms.TextBox createUpdateNameTextBox;
        private System.Windows.Forms.Label createUpdateEmailLbl;
        private System.Windows.Forms.TextBox createUpdateEmailTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}


﻿namespace Banmex.Menu
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(26, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Nombre";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(29, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(29, 107);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(32, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Apellido";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(29, 174);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(205, 22);
            this.addressTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressLabel.Location = new System.Drawing.Point(26, 154);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Domicilio";
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.Location = new System.Drawing.Point(29, 235);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(205, 22);
            this.cellphoneTextBox.TabIndex = 7;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.cellphoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cellphoneLabel.Location = new System.Drawing.Point(26, 215);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(118, 17);
            this.cellphoneLabel.TabIndex = 6;
            this.cellphoneLabel.Text = "Numero Telefono";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(29, 299);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(205, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(26, 279);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 17);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Contraseña";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.positionLabel.Location = new System.Drawing.Point(32, 347);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(61, 17);
            this.positionLabel.TabIndex = 10;
            this.positionLabel.Text = "Posicion";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(258, 430);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 44);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Ingresar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Gerente",
            "Cajero"});
            this.positionComboBox.Location = new System.Drawing.Point(29, 367);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(205, 24);
            this.positionComboBox.TabIndex = 13;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 486);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.cellphoneTextBox);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado BANMEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox positionComboBox;
    }
}
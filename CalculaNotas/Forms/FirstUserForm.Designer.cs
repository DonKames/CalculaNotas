namespace CalculaNotas.Forms
{
    partial class FirstUserForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            titleLabel = new Label();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 73);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre: ";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(75, 70);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(154, 23);
            nameTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(66, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 15);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Registro de Usuario";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(42, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email: ";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(75, 108);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(154, 23);
            emailTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(154, 164);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // FirstUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 199);
            Controls.Add(saveButton);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(titleLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "FirstUserForm";
            Text = "FirstUserForm";
            FormClosing += FirstUserForm_FormClosing;
            FormClosed += FirstUserForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label titleLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button saveButton;
    }
}
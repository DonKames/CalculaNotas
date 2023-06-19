namespace CalculaNotas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            configButton = new Button();
            welcomeLabel = new Label();
            statusStrip1 = new StatusStrip();
            SuspendLayout();
            // 
            // configButton
            // 
            configButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            configButton.Location = new Point(310, 12);
            configButton.Name = "configButton";
            configButton.Size = new Size(75, 23);
            configButton.TabIndex = 0;
            configButton.Text = "Config";
            configButton.UseVisualStyleBackColor = true;
            configButton.Click += configButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(12, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(72, 15);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Bienvenido: ";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(397, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 561);
            Controls.Add(statusStrip1);
            Controls.Add(welcomeLabel);
            Controls.Add(configButton);
            MinimumSize = new Size(400, 600);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button configButton;
        private Label welcomeLabel;
        private StatusStrip statusStrip1;
    }
}
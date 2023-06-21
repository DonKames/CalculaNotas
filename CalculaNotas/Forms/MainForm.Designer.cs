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
            careerMessageLbl = new Label();
            addCareerBtn = new Button();
            semesterMessageLbl = new Label();
            addSemesterBtn = new Button();
            semesterTBox = new TextBox();
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
            // careerMessageLbl
            // 
            careerMessageLbl.AutoSize = true;
            careerMessageLbl.Location = new Point(12, 44);
            careerMessageLbl.Name = "careerMessageLbl";
            careerMessageLbl.Size = new Size(101, 15);
            careerMessageLbl.TabIndex = 3;
            careerMessageLbl.Text = "careerMessageLbl";
            // 
            // addCareerBtn
            // 
            addCareerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addCareerBtn.Location = new Point(310, 43);
            addCareerBtn.Name = "addCareerBtn";
            addCareerBtn.Size = new Size(75, 23);
            addCareerBtn.TabIndex = 4;
            addCareerBtn.Text = "+ Carrera";
            addCareerBtn.UseVisualStyleBackColor = true;
            addCareerBtn.Click += addCareerBtn_Click;
            // 
            // semesterMessageLbl
            // 
            semesterMessageLbl.AutoSize = true;
            semesterMessageLbl.Location = new Point(12, 79);
            semesterMessageLbl.Name = "semesterMessageLbl";
            semesterMessageLbl.Size = new Size(116, 15);
            semesterMessageLbl.TabIndex = 5;
            semesterMessageLbl.Text = "semesterMessageLbl";
            // 
            // addSemesterBtn
            // 
            addSemesterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addSemesterBtn.Location = new Point(310, 75);
            addSemesterBtn.Name = "addSemesterBtn";
            addSemesterBtn.Size = new Size(75, 23);
            addSemesterBtn.TabIndex = 6;
            addSemesterBtn.Text = "+ Semestre";
            addSemesterBtn.UseVisualStyleBackColor = true;
            addSemesterBtn.Click += addSemesterBtn_Click;
            // 
            // semesterTBox
            // 
            semesterTBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            semesterTBox.Location = new Point(253, 75);
            semesterTBox.Name = "semesterTBox";
            semesterTBox.Size = new Size(51, 23);
            semesterTBox.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 561);
            Controls.Add(semesterTBox);
            Controls.Add(addSemesterBtn);
            Controls.Add(semesterMessageLbl);
            Controls.Add(addCareerBtn);
            Controls.Add(careerMessageLbl);
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
        private Label careerMessageLbl;
        private Button addCareerBtn;
        private Label semesterMessageLbl;
        private Button addSemesterBtn;
        private TextBox semesterTBox;
    }
}
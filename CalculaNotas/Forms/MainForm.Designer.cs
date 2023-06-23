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
            careerMessageLbl = new Label();
            addCareerBtn = new Button();
            semesterMessageLbl = new Label();
            addSemesterBtn = new Button();
            semesterTxBox = new TextBox();
            semesterCboBx = new ComboBox();
            courseMessageLbl = new Label();
            addCourseBtn = new Button();
            courseTxBox = new TextBox();
            SuspendLayout();
            // 
            // configButton
            // 
            configButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            configButton.Location = new Point(830, 12);
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
            addCareerBtn.Location = new Point(830, 43);
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
            addSemesterBtn.Location = new Point(830, 75);
            addSemesterBtn.Name = "addSemesterBtn";
            addSemesterBtn.Size = new Size(75, 23);
            addSemesterBtn.TabIndex = 6;
            addSemesterBtn.Text = "+ Semestre";
            addSemesterBtn.UseVisualStyleBackColor = true;
            addSemesterBtn.Click += addSemesterBtn_Click;
            // 
            // semesterTxBox
            // 
            semesterTxBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            semesterTxBox.Location = new Point(773, 75);
            semesterTxBox.Name = "semesterTxBox";
            semesterTxBox.Size = new Size(51, 23);
            semesterTxBox.TabIndex = 7;
            // 
            // semesterCboBx
            // 
            semesterCboBx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            semesterCboBx.FormattingEnabled = true;
            semesterCboBx.Location = new Point(200, 76);
            semesterCboBx.Name = "semesterCboBx";
            semesterCboBx.Size = new Size(567, 23);
            semesterCboBx.TabIndex = 8;
            semesterCboBx.SelectedIndexChanged += semesterCboBx_SelectedIndexChanged;
            // 
            // courseMessageLbl
            // 
            courseMessageLbl.AutoSize = true;
            courseMessageLbl.Location = new Point(12, 111);
            courseMessageLbl.Name = "courseMessageLbl";
            courseMessageLbl.Size = new Size(104, 15);
            courseMessageLbl.TabIndex = 9;
            courseMessageLbl.Text = "courseMessageLbl";
            // 
            // addCourseBtn
            // 
            addCourseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addCourseBtn.Location = new Point(830, 107);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(75, 23);
            addCourseBtn.TabIndex = 10;
            addCourseBtn.Text = "+ Ramo";
            addCourseBtn.UseVisualStyleBackColor = true;
            addCourseBtn.Click += addCourseBtn_Click;
            // 
            // courseTxBox
            // 
            courseTxBox.Location = new Point(200, 107);
            courseTxBox.Name = "courseTxBox";
            courseTxBox.Size = new Size(128, 23);
            courseTxBox.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 561);
            Controls.Add(courseTxBox);
            Controls.Add(addCourseBtn);
            Controls.Add(courseMessageLbl);
            Controls.Add(semesterCboBx);
            Controls.Add(semesterTxBox);
            Controls.Add(addSemesterBtn);
            Controls.Add(semesterMessageLbl);
            Controls.Add(addCareerBtn);
            Controls.Add(careerMessageLbl);
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
        private Label careerMessageLbl;
        private Button addCareerBtn;
        private Label semesterMessageLbl;
        private Button addSemesterBtn;
        private TextBox semesterTxBox;
        private ComboBox semesterCboBx;
        private Label courseMessageLbl;
        private Button addCourseBtn;
        private TextBox courseTxBox;
    }
}
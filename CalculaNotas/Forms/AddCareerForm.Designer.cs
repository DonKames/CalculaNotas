namespace CalculaNotas.Forms
{
    partial class AddCareerForm
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
            titleLbl = new Label();
            careerNameLbl = new Label();
            careerNameTxt = new TextBox();
            addCareerBtn = new Button();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.Location = new Point(12, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(156, 25);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Agregar Carrera";
            // 
            // careerNameLbl
            // 
            careerNameLbl.AutoSize = true;
            careerNameLbl.Location = new Point(12, 54);
            careerNameLbl.Name = "careerNameLbl";
            careerNameLbl.Size = new Size(95, 15);
            careerNameLbl.TabIndex = 1;
            careerNameLbl.Text = "Nombre Carrera:";
            // 
            // careerNameTxt
            // 
            careerNameTxt.Location = new Point(12, 72);
            careerNameTxt.Name = "careerNameTxt";
            careerNameTxt.Size = new Size(347, 23);
            careerNameTxt.TabIndex = 2;
            // 
            // addCareerBtn
            // 
            addCareerBtn.Location = new Point(284, 101);
            addCareerBtn.Name = "addCareerBtn";
            addCareerBtn.Size = new Size(75, 23);
            addCareerBtn.TabIndex = 3;
            addCareerBtn.Text = "Guardar";
            addCareerBtn.UseVisualStyleBackColor = true;
            addCareerBtn.Click += addCareerBtn_Click;
            // 
            // AddCareerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 134);
            Controls.Add(addCareerBtn);
            Controls.Add(careerNameTxt);
            Controls.Add(careerNameLbl);
            Controls.Add(titleLbl);
            Name = "AddCareerForm";
            Text = "AddCareerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label careerNameLbl;
        private TextBox careerNameTxt;
        private Button addCareerBtn;
    }
}
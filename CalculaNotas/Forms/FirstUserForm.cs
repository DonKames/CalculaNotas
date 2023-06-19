using CalculaNotas.Models;
using CalculaNotas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaNotas.Forms
{
    public partial class FirstUserForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private bool userSavedSuccessfully;

        public FirstUserForm( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FirstUserForm_FormClosed);
        }

        void FirstUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!userSavedSuccessfully && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User newUser = new()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text

            };
            try
            {
                _unitOfWork.Users.AddUser(newUser);
                // _userRepository.AddUser(newUser);
                _unitOfWork.Complete();
                MessageBox.Show("Usuario Guardado Exitosamente");
                // MainForm mainForm = new(_unitOfWork);

                // mainForm.Show();

                userSavedSuccessfully = true;

                this.Close();
            }
            catch (Exception)
            {
                // Aquí puedes manejar el error de la manera que consideres apropiada para tu aplicación.
                // Podrías mostrar un mensaje al usuario, escribir el error en un archivo de log, etc.
                MessageBox.Show("Hubo un error al guardar el usuario. Por favor, intenta nuevamente.");
            }



        }
    }
}

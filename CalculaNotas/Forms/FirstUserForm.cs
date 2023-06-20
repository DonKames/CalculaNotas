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

        public User CurrentUser { get; set; }

        public FirstUserForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FirstUserForm_FormClosed);
        }

        void FirstUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!userSavedSuccessfully && e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    // Cancelar el cierre del formulario
                    e.Cancel = true;
                }
            }
        }

        void FirstUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!userSavedSuccessfully && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            User newUser = new()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text

            };

            try
            {
                
                
                
                User user = await _unitOfWork.Users.AddUser(newUser);

                CurrentUser = user;

                // _userRepository.AddUser(newUser);
                _unitOfWork.Complete();
                MessageBox.Show("Usuario Guardado Exitosamente");

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

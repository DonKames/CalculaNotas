using CalculaNotas.Models;
using CalculaNotas.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaNotas.Forms
{
    public partial class AddCareerForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private User User { get; set; }
        public Career Career { get; set; }
        public AddCareerForm(IUnitOfWork unitOfWork, User user)
        {
            _unitOfWork = unitOfWork;
            User = user;
            InitializeComponent();
        }

        private async void addCareerBtn_Click(object sender, EventArgs e)
        {

            Career newCareer = new()
            {
                Name = careerNameTxt.Text,
            };

            // Realizar la validación manualmente
            var validationContext = new ValidationContext(newCareer);
            var validationResults = new List<ValidationResult>();


            if (!Validator.TryValidateObject(newCareer, validationContext, validationResults, true))
            {
                foreach (var validationResult in validationResults)
                {
                    Debug.WriteLine(validationResult.ErrorMessage);
                }
                return;  // Salir del método si la validación falló
            }
            

            try
            {
                Career = await _unitOfWork.Careers.AddCareer(newCareer);

                UserCareer userCareer = new() { 
                    CareerId = newCareer.CareerId,
                    UserId = User.Id,
                };

                await _unitOfWork.UserCareers.AddUserCareer(userCareer);

                _unitOfWork.Complete();

                MessageBox.Show("Carrera Guardada Exitosamente");

                this.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Hubo un error al guardar la Carrera. Por favor, intenta nuevamente.");
                throw;
            }

        }
    }
}

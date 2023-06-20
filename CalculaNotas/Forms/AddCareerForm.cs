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
        public AddCareerForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private async void addCareerBtn_Click(object sender, EventArgs e)
        {
            Career career = new()
            {
                Name = careerNameTxt.Text,
            };

            // Realizar la validación manualmente
            var validationContext = new ValidationContext(career);
            var validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(career, validationContext, validationResults, true))
            {
                foreach (var validationResult in validationResults)
                {
                    Debug.WriteLine(validationResult.ErrorMessage);
                }
                return;  // Salir del método si la validación falló
            }


            try
            {
                Career currentCareer = await _unitOfWork.Careers.AddCareer(career);

                UserCareer userCareer = new() { 
                    CareerId = currentCareer.CareerId,
                    UserId = 
                };

                _unitOfWork.UserCareers.AddUserCareer(userCareer);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

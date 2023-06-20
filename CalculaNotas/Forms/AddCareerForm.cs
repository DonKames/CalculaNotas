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
    public partial class AddCareerForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public AddCareerForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void addCareerBtn_Click(object sender, EventArgs e)
        {
            Career career = new();
            _unitOfWork.Careers.AddCareer(career);
        }
    }
}

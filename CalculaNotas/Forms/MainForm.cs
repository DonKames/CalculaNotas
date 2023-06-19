using CalculaNotas.Forms;
using CalculaNotas.Models;
using CalculaNotas.Repositories;
using System.Diagnostics;

namespace CalculaNotas
{
    public partial class MainForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ;
            InitializeComponent();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("apretando el boton");
            ConfigForm configForm = new();

            configForm.ShowDialog();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            List<User> allUsers = await _unitOfWork.Users.GetAllUsers();
            // Hacer algo con la lista de usuarios...

            if (allUsers != null)
            {
                Debug.WriteLine("No es nulo");
                if (!allUsers.Any())
                {
                    Debug.WriteLine("La lista de usuarios está vacía");

                    FirstUserForm firstUserForm = new(_unitOfWork);

                    firstUserForm.ShowDialog();
                } else
                {
                    Debug.WriteLine("La lista de usuarios no está vacía");

                }
            }
            else
            {
                Debug.WriteLine("puede que sea nulo");
                Debug.WriteLine(allUsers);

            }
        }
    }
}
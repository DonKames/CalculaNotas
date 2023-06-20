using CalculaNotas.Forms;
using CalculaNotas.Models;
using CalculaNotas.Repositories;
using System.Diagnostics;

namespace CalculaNotas
{
    public partial class MainForm : Form
    {
        // El user para usar en toda la APP
        public User CurrentUser { get; set; }

        private readonly IUnitOfWork _unitOfWork;
        public MainForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
            try
            {
                List<User> allUsers = await _unitOfWork.Users.GetAllUsers();
                // Hacer algo con la lista de usuarios...


                Debug.WriteLine("No es nulo");
                if (allUsers.Any())
                {
                    Debug.WriteLine("La lista de usuarios no est� vac�a");
                    CurrentUser = allUsers.First();

                    welcomeLabel.Text = "Bienvenido: " + CurrentUser.Name;
                }
                else
                {
                    Debug.WriteLine("La lista de usuarios est� vac�a");

                    FirstUserForm firstUserForm = new(_unitOfWork);

                    firstUserForm.ShowDialog();

                    CurrentUser = firstUserForm.CurrentUser;

                    welcomeLabel.Text = "Bienvenido: " + CurrentUser.Name;

                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine($"Ocurri� un error al cargar los usuarios: {ex.Message}");
            }

        }
    }
}
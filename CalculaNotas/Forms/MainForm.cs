using CalculaNotas.Forms;
using CalculaNotas.Models;
using CalculaNotas.Repositories;
using System.Diagnostics;

namespace CalculaNotas
{
    public partial class MainForm : Form
    {

        private readonly IUnitOfWork _unitOfWork;


        // El user para usar en toda la APP
        public User CurrentUser { get; set; }
        public Career CurrentCareer { get; set; }
        public Semester CurrentSemester { get; set; }
        public List<Semester> SemesterList { get; set; }


        public MainForm(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;

            InitializeComponent();

        }


        private void configButton_Click(object sender, EventArgs e)
        {

            ConfigForm configForm = new();

            configForm.ShowDialog();

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Peticiones a la BDD
                List<User> allUsers = await _unitOfWork.Users.GetAllUsers();

                List<Career> allCareers = await _unitOfWork.Careers.GetAllCareers();

                List<Semester> allSemesters = new List<Semester>();


                // Comprobacion Usuarios
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


                // Comprobacion Carrera
                if (allCareers.Any())
                {
                    CurrentCareer = allCareers.First();
                    careerMessageLbl.ForeColor = Color.Green;
                    careerMessageLbl.Text = CurrentCareer.Name;

                    allSemesters = await _unitOfWork.Semesters.GetAllSemestersByCareerId(CurrentCareer.CareerId);
                    // Debug.WriteLine(SemesterList.Count);

                    // Comprobacion Semestre
                    if (allSemesters.Any())
                    {
                        semesterMessageLbl.ForeColor = Color.Green;
                        semesterMessageLbl.Text = "Semestre :";
                        SemesterList = allSemesters;

                        semesterCboBx.DataSource = SemesterList;
                        semesterCboBx.DisplayMember = "Name";
                        semesterCboBx.ValueMember = "SemesterId";

                    }
                    else
                    {
                        semesterMessageLbl.ForeColor = Color.Red;
                        semesterMessageLbl.Text = "Agregue el primer numero de Semestre";
                    }

                }
                else
                {
                    // Comprobacion Semestre
                    if (allSemesters.Any())
                    {
                        SemesterList = allSemesters;
                    }
                    else
                    {
                        semesterMessageLbl.ForeColor = Color.Red;
                        semesterMessageLbl.Text = "Agregue el primer numero de Semestre";

                        careerMessageLbl.ForeColor = Color.Red;
                        careerMessageLbl.Text = "Agregue su primera Carrera";
                    }
                }



            }
            catch (Exception ex)
            {

                Debug.WriteLine($"Ocurri� un error al cargar los usuarios: {ex.Message}");
            }

        }

        private void addCareerBtn_Click(object sender, EventArgs e)
        {
            AddCareerForm addCareerForm = new(_unitOfWork, CurrentUser);

            addCareerForm.ShowDialog();

            Career career = addCareerForm.Career;



            if (career != null)
            {
                careerMessageLbl.ForeColor = Color.Green;
                careerMessageLbl.Text = career.Name;
            }

        }

        private async void addSemesterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(semesterTBox.Text))
            {
                try
                {
                    Semester semester = new()
                    {
                        Name = semesterTBox.Text,
                        CareerId = CurrentCareer.CareerId,
                    };

                    // Agrega el semestre nuevo
                    await _unitOfWork.Semesters.AddSemester(semester);

                    semesterMessageLbl.ForeColor = Color.Green;
                    semesterMessageLbl.Text = "Semestre: ";

                    // Recupera todos los semestres de la carrera seleccionada
                    SemesterList = await _unitOfWork.Semesters.GetAllSemestersByCareerId(CurrentCareer.CareerId);



                    Debug.WriteLine(SemesterList.ToString());

                    // Se pobla el semester
                    semesterCboBx.DataSource = SemesterList;
                    semesterCboBx.DisplayMember = "Name";
                    semesterCboBx.ValueMember = "SemesterId";


                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);

                    MessageBox.Show("Para agregar un semestre, debe ingresar un numero o nombre.");

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Para agregar un semestre, debe ingresar un numero o nombre.");
            }
        }

        private void semesterCboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el �tem seleccionado en el ComboBox
            var selectedSemester = semesterCboBx.SelectedItem as Semester;

            if (selectedSemester != null)
            {
                // Actualiza la variable currentSemester
                CurrentSemester = selectedSemester;
            }
        }
    }
}
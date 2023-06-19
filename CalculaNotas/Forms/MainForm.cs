namespace CalculaNotas
{
    using System.Diagnostics;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("apretando el boton");
            ConfigForm configForm = new();

            configForm.ShowDialog();
        }
    }
}
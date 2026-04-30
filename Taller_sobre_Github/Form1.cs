using Taller_sobre_Github.Modelos;

namespace Taller_sobre_Github
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Poblar_cbEstudiante();
        }

        private void Poblar_cbEstudiante()
        {
            Dictionary<string, string> estudiantes = new Dictionary<string, string>
            {
                { "Yeinier_Acuna", "Yeinier Acuña"},
                { "Khesnier_Aguilar", "Khesnier Aguilar"},
                { "Jamil_Arauz", "Jamil Arauz"},
                { "Jose_Benavides", "Jose Benavides"},
                { "Bryan_Benavidez", "Bryan Benavidez"},
                { "Litzy_Blandon", "Litzy Blandon"},
                { "Luis_Carrasco", "Luis Carrasco"},
                { "Ulises_Castellon", "Ulises Castellon"},
                { "Angel_Castillo", "Angel Castillo"},
                { "Indiana_Chavarria", "Indiana Chavarria"},
                { "Johansen_Cruz", "Johansen Cruz"},
                { "Fernando_Duarte", "Fernando Duarte"},
                { "Hamleth_Galeano", "Hamleth Galeano"},
                { "Danny_Garcia", "Danny Garcia"},
                { "Diego_Garcia", "Diego Garcia"},
                { "Enner_Gomez", "Enner Gomez"},
                { "Angel_Gonzalez", "Angel González"},
                { "Merlin_Gutierrez", "Merlin Gutierrez"},
                { "Walder_Gutierrez", "Walder Gutierrez"},
                { "Dorian_Hudiel", "Dorian Hudiel"},
                { "Gerald_Jiron", "Gerald Jiron"},
                { "Jazahell_Lopez", "Jazahell Lopez"},
                { "Gibrham_Lopez", "Gibrham Lopez"},
                { "Wilgen_Melgara", "Wilgen Melgara"},
                { "Mateo_Mendoza", "Mateo Mendoza"},
                { "Adriana_Meza", "Adriana Meza"},
                { "Yorleny_Obregon", "Yorleny Obregon"},
                { "Francisco_Ochoa", "Francisco Ochoa"},
                { "Victor_Palacios", "Victor Palacios"},
                { "Jose_Picado", "Jose Picado"},
                { "Amaru_Pinell", "Amaru Pinell"},
                { "Angy_Rios", "Angy Rios"},
                { "Luis_Torrez", "Luis Torrez"},
                { "Jatniel_Valladares", "Jatniel Valladares"},
                { "Luis_Zelaya", "Luis Zelaya"},
                { "Alonzo_Zeledon", "Alonzo Zeledon"}
            };

            cbEstudiante.Items.Clear();
            cbEstudiante.DataSource = new BindingSource(estudiantes, null);
            cbEstudiante.DisplayMember = "Value";
            cbEstudiante.ValueMember = "Key";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstudiante.SelectedValue != null)
            {
                string nombreClase = cbEstudiante.SelectedValue.ToString();

                Type tipoClase = Type.GetType($"Taller_sobre_Github.Modelos.{nombreClase}");

                if (tipoClase != null)
                {
                    Estudiante alumno = (Estudiante)Activator.CreateInstance(tipoClase);
                    txtAsistencia.Text = alumno.ComprobarAsistencia();
                    txtCarnet.Text = alumno.Carnet;
                    txtNombreCompleto.Text = alumno.NombreCompleto;
                }
                else
                {
                    txtCarnet.Clear();
                    txtNombreCompleto.Clear();
                    txtAsistencia.Text = "Clase no encontrada.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

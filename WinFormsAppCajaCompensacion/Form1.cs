using System.Linq;

namespace WinFormsAppCajaCompensacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listaDatos = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaDatos.Add("1");
            mostratDatos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaDatos.Add("2");
            mostratDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaDatos.Add("3");
            mostratDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaDatos.Add("4");
            mostratDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listaDatos.Add("5");
            mostratDatos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listaDatos.Add("6");
            mostratDatos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listaDatos.Add("7");
            mostratDatos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listaDatos.Add("8");
            mostratDatos();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listaDatos.Add("9");
            mostratDatos();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listaDatos.Clear();
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listaDatos.Add("0");
            mostratDatos();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string contraseñaAcceso = "1357";
            string contraseñaComparar = string.Join("", listaDatos);
            if (contraseñaAcceso != contraseñaComparar)
            {
                MessageBox.Show("la contraseña es incorrecta, intente nuevamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listaDatos.Clear();
                textBox1.Text = "";
            } 
        }
       
        public void mostratDatos()
        {
            if (listaDatos.Count > 0)
            {
                textBox1.Text = string.Join("", listaDatos);
            }
         
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
    }
}

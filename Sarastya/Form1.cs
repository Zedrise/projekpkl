using Npgsql;

namespace Sarastya
{
    public partial class Form1 : Form
    {
        Datalayer dl;
        public Form1()
        {
            var cs = "Host=localhost;Username=postgres;Password=Aurelius_22;Database=Sarastya   ";

            var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM tugassarastya";
            var cmd = new NpgsqlCommand(sql, con);

            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
            }


            //Console.ReadLine();
            dl = new Datalayer();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registrasi sForm = new Registrasi();
            sForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            string qry = "select Username from public.tugassarastya where Username= `"+txt_username.Text"`,u";
            string Password;
            string First_Name;
            string Last_Name;
            string Email;
            int Telephone_Number;
        }
    }
}

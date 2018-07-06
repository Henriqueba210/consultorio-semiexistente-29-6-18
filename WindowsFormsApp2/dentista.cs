using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class dentista : UserControl
    {
        public dentista()
        {
            InitializeComponent();
            Data.Value = DateTime.Today;
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            this.dentistaTableAdapter.Fill(tcc_consultorioDataSet9.dentista);
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Nome_Dentista.Text = "";
            RG_Dentista.Text = "";
            CPF_Dentista.Text = "";
            Data.Value = DateTime.Today;
            Celular_Dentista.Text = "";
            Telefone_Dentista.Text = "";
            Endereco_Dentista.Text = "";
            Email_Dentista.Text = "";
            Especialidade1.Text = "";
            Especialidade2.Text = "";
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Construtor C = new Construtor();
            Dal C1 = new Dal();
            C.nomedentista = Nome_Dentista.Text;
            C.rgdentista = RG_Dentista.Text;
            C.cpfdentista = CPF_Dentista.Text;
            C.nascdentista = Data.Value.ToShortDateString();
            C.celdentista = Celular_Dentista.Text;
            C.teldentista = Telefone_Dentista.Text;
            C.enderecodentista = Endereco_Dentista.Text;
            C.emaildentista = Email_Dentista.Text;
            C.primeiraarea = Especialidade1.Text;
            C.segundaarea = Especialidade2.Text;
            C1.CadastrarDentista(C);
            Nome_Dentista.Text = "";
            RG_Dentista.Text = "";
            CPF_Dentista.Text = "";
            Data.Value = DateTime.Today;
            Celular_Dentista.Text = "";
            Telefone_Dentista.Text = "";
            Endereco_Dentista.Text = "";
            Email_Dentista.Text = "";
            Especialidade1.Text = "";
            Especialidade2.Text = "";

        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            string pesquisa = "select * from dentista where nome_dentista like @valor or id_dentista like @valor";
            MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
            ad.SelectCommand.Parameters.AddWithValue("valor","%" + textBox1.Text + "%");
            DataTable table = new DataTable();
            ad.Fill(table);
            bunifuCustomDataGrid1.DataSource = table;
            con.Close();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            this.dentistaTableAdapter.Fill(tcc_consultorioDataSet9.dentista);
            Consulta.Show();
            con.Close();
            Consulta.BringToFront();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            this.dentistaTableAdapter.Fill(tcc_consultorioDataSet9.dentista);
            Consulta.Hide();
            con.Close();
        }
    }




    }


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
    public partial class Tratamento : UserControl
    {
        public Tratamento()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
                panel7.Show();
                con.Close();
            }
        }

        //Variável para puxar os tratamentos do paciente selecionado
        public Int32 ID_Paciente;

        //Várivel para apagar o tratamento
        public Int32 ID_Tratamento;

        public string ID_Nome_Paciente;

        public void reset()
        {

            ID_Paciente = 0;
            ID_Nome_Paciente = "";
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            tratamentoTableAdapter.FillBy_Tipo(tcc_consultorioDataSet3.tratamento, ID_Paciente);


            nomepaciente.Text = "";
            plano.Text = "";
            nometratamento.Text = "";
            dentesregiao.Text = "";
            precotratamento.Text = "";
            descricaotratamento.Text = "";
            iniciotermino.Text = "";

        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Paciente = Convert.ToInt32(bunifuCustomDataGrid2.CurrentRow.Cells[0].Value);
            ID_Nome_Paciente = Convert.ToString(bunifuCustomDataGrid2.CurrentRow.Cells[1].Value);
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            tratamentoTableAdapter.FillBy_Tipo(tcc_consultorioDataSet3.tratamento, ID_Paciente);
            this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
            panel7.Hide();
            nomepaciente.Text = ID_Nome_Paciente;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (nometratamento.Text == ("") || plano.Text == ("") || precotratamento.Text == ("") || iniciotermino.Text == ("") || descricaotratamento.Text == ("") || dentesregiao.Text == ("") )
            { 
                MessageBox.Show("Campo invalido ou vazio");
            }
            else
            {
                Construtor C = new Construtor();
                Dal C1 = new Dal();
                C.idpacientetratamento = Convert.ToString(ID_Paciente);
                C.plano = plano.Text;
                C.nometratamento = nometratamento.Text;
                C.dentesregiao = dentesregiao.Text;
                C.precotratamento = precotratamento.Text;
                C.descricaotratamento = descricaotratamento.Text;
                C.iniciotratamento = iniciotermino.Text;
                C1.AdicionarTratamento(C);

                plano.Text = "";
                nometratamento.Text = "";
                dentesregiao.Text = "";
                precotratamento.Text = "";
                descricaotratamento.Text = "";
                iniciotermino.Text = "";


                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                tratamentoTableAdapter.FillBy_Tipo(tcc_consultorioDataSet3.tratamento, ID_Paciente);
                this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
                con.Close();
            }
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            Construtor C = new Construtor();
            Dal C1 = new Dal();
            C.idtratamento = ID_Tratamento;
            C1.ExcluirTratamento(C);

            plano.Text = "";
            nometratamento.Text = "";
            dentesregiao.Text = "";
            precotratamento.Text = "";
            descricaotratamento.Text = "";
            iniciotermino.Text = "";


            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            tratamentoTableAdapter.FillBy_Tipo(tcc_consultorioDataSet3.tratamento, ID_Paciente);
            this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
            con.Close();

            MessageBox.Show("Dados excluidos com sucesso");

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
                panel7.Show();
                con.Close();

            }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            panel7.Hide();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);

            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();

            MySqlCommand cmd2 = new MySqlCommand("select ID_Tratamento, ID_Paciente_Tratamento, Nome, Dentes, Inicio, Descricao, Preco, Plano from tratamento where ID_Tratamento = '" + codigo + "'", con);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();
            if (reader.Read())
            {

                nometratamento.Text = reader.GetString(2);
                dentesregiao.Text = reader.GetString(3);
                iniciotermino.Text = reader.GetString(4);
                descricaotratamento.Text = reader.GetString(5);
                precotratamento.Text = reader.GetString(6);
                plano.Text = reader.GetString(7);
                ID_Tratamento = Convert.ToInt32(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);

            }
        }

        private void alterartratamento_Click(object sender, EventArgs e)
        {
            
                Construtor C = new Construtor();
                Dal C1 = new Dal();
                C.idtratamento = ID_Tratamento;
                C.plano = plano.Text;
                C.nometratamento = nometratamento.Text;
                C.dentesregiao = dentesregiao.Text;
                C.precotratamento = precotratamento.Text;
                C.descricaotratamento = descricaotratamento.Text;
                C.iniciotratamento = iniciotermino.Text;
                C1.AlterarTratamento(C);
            
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            tratamentoTableAdapter.FillBy_Tipo(tcc_consultorioDataSet3.tratamento, ID_Paciente);
            this.pacienteTableAdapter.Fill(tcc_consultorioDataSet.paciente);
            con.Close();

            MessageBox.Show("Dados alterados com sucesso");
            }

        private void Tratamento_Load(object sender, EventArgs e)
        {
      
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            plano.Text = "";
            nometratamento.Text = "";
            dentesregiao.Text = "";
            precotratamento.Text = "";
            descricaotratamento.Text = "";
            iniciotermino.Text = "";
        }
    }
}




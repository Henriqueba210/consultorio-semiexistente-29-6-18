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
    public partial class cadastrar_paciente : UserControl
    {
        public cadastrar_paciente()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
        }

        public String codigo;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar um novo paciente", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nome_paciente.Enabled = true;
                rg_paciente.Enabled = true;
                cpf_paciente.Enabled = true;
                nasc_paciente.Enabled = true;
                cel_paciente.Enabled = true;
                tel_paciente.Enabled = true;
                endereco_paciente.Enabled = true;
                email_paciente.Enabled = true;
                estcivil_paciente.Enabled = true;
                profissao_paciente.Enabled = true;
                anotacoes_paciente.Enabled = true;
                Alterar.Enabled = true;
                Excluir.Enabled = true;
                Adicionar.Enabled = true;

                Limpar.Show();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

                Limpar.Hide();
                Alterar.Visible = false;
                Excluir.Visible = false;
                nome_paciente.Text = "";
                rg_paciente.Text = "";
                cpf_paciente.Text = "";
                nasc_paciente.Text = "";
                cel_paciente.Text = "";
                tel_paciente.Text = "";
                endereco_paciente.Text = "";
                email_paciente.Text = "";
                estcivil_paciente.Text = "";
                profissao_paciente.Text = "";
                anotacoes_paciente.Text = "";
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                Id_Paciente.Text = "0";
                tratamentoTableAdapter.FillBy_tratamento(tcc_consultorioDataSet5.tratamento, Convert.ToInt32(Id_Paciente.Text));
                con.Close();
           

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            codigo = Convert.ToString(bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);

            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            this.tratamentoTableAdapter.FillBy_tratamento(this.tcc_consultorioDataSet5.tratamento, Convert.ToInt32(codigo));
            MySqlCommand cmd2 = new MySqlCommand("select id_paciente, nome_paciente, rg_paciente, cpf_paciente, nasc_paciente, cel_paciente,tel_paciente, endereco_paciente, email_paciente, estcivil_paciente, profissao_paciente, anotacoes_paciente from paciente where id_paciente = '" + codigo + "'", con);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();
            if (reader.Read())
            {

                Id_Paciente.Text = reader.GetString(0);
                nome_paciente.Text = reader.GetString(1);
                rg_paciente.Text = reader.GetString(2);
                cpf_paciente.Text = reader.GetString(3);
                nasc_paciente.Text = reader.GetString(4);
                cel_paciente.Text = reader.GetString(5);
                tel_paciente.Text = reader.GetString(6);
                endereco_paciente.Text = reader.GetString(7);
                email_paciente.Text = reader.GetString(8);
                estcivil_paciente.Text = reader.GetString(9);
                profissao_paciente.Text = reader.GetString(10);


            }

            con.Close();
            panel1.Hide();
            
            Limpar.Show();
            Limpar.BringToFront();
            Alterar.Visible = true;
            Excluir.Visible = true;


        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            this.pacienteTableAdapter.Fill(tcc_consultorioDataSet8.paciente);
            panel1.Show();
            con.Close();
            panel1.BringToFront();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (Id_Paciente.Text == (""))
            {
                panel1.Show();
                MessageBox.Show("Seleciona um profissional");
            }
            else
            {
                Construtor C = new Construtor();
                Dal C1 = new Dal();
                C.idpaciente = Convert.ToInt16(Id_Paciente.Text); 
                C1.ExcluirPaciente(C);
                MessageBox.Show("Dados excluidos com sucesso");

                

                Id_Paciente.Text = "";
                nome_paciente.Text = "";
                rg_paciente.Text = "";
                cpf_paciente.Text = "";
                nasc_paciente.Text = "";
                cel_paciente.Text = "";
                tel_paciente.Text = "";
                endereco_paciente.Text = "";
                email_paciente.Text = "";
                estcivil_paciente.Text = "";
                profissao_paciente.Text = "";
                anotacoes_paciente.Text = "";
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                Id_Paciente.Text = "0";
                tratamentoTableAdapter.FillBy_tratamento(tcc_consultorioDataSet5.tratamento, Convert.ToInt32(Id_Paciente.Text));
                con.Close();

                Alterar.Visible = false;
                Excluir.Visible = false;

                Limpar.Hide();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            if (Id_Paciente.Text == (""))
            {
                panel1.Show();
                MessageBox.Show("Seleciona um profissional");
            }
            else
            {
                Construtor C = new Construtor();
                Dal C1 = new Dal();
                C.idpaciente = Convert.ToInt32(Id_Paciente.Text) ;
                C.nomepaciente = nome_paciente.Text;
                C.rgpaciente = rg_paciente.Text;
                C.cpfpaciente = cpf_paciente.Text;
                C.nascpaciente = nasc_paciente.Text ;
                C.celpaciente = cel_paciente.Text;
                C.telpaciente = tel_paciente.Text;
                C.enderecopaciente = endereco_paciente.Text;
                C.emailpaciente = email_paciente.Text;
                C.estcivilpaciente = estcivil_paciente.SelectedText;
                C.profissaopaciente = profissao_paciente.Text;

                C1.AlterarPaciente(C);
                MessageBox.Show("Dados alterados com sucesso");

                Id_Paciente.Text = "";
                nome_paciente.Text = "";
                rg_paciente.Text = "";
                cpf_paciente.Text = "";
                nasc_paciente.Text = "";
                cel_paciente.Text = "";
                tel_paciente.Text = "";
                endereco_paciente.Text = "";
                email_paciente.Text = "";
                estcivil_paciente.Text = "";
                profissao_paciente.Text = "";
                anotacoes_paciente.Text = "";
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                Id_Paciente.Text = "0";
                tratamentoTableAdapter.FillBy_tratamento(tcc_consultorioDataSet5.tratamento, Convert.ToInt32(Id_Paciente.Text));
                con.Close();


                Alterar.Visible = false;
                Excluir.Visible = false;
                Limpar.Hide();

            }
        }

       

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (nome_paciente.Text == ("") || rg_paciente.Text == ("") || cpf_paciente.Text == ("") || nasc_paciente.Text == ("") || cel_paciente.Text == ("") || tel_paciente.Text == ("") || endereco_paciente.Text == ("") || email_paciente.Text == ("") || estcivil_paciente.Text == ("") || profissao_paciente.Text == ("") ) {

                MessageBox.Show("Campo Inválido ou vazio");

            }
            else
            {
                Construtor C = new Construtor();
                Dal C1 = new Dal();
                C.nomepaciente = nome_paciente.Text;
                C.rgpaciente = rg_paciente.Text;
                C.cpfpaciente = cpf_paciente.Text;
                C.nascpaciente = nasc_paciente.Text;
                C.celpaciente = cel_paciente.Text;
                C.telpaciente = tel_paciente.Text;
                C.enderecopaciente = endereco_paciente.Text;
                C.emailpaciente = email_paciente.Text;
                C.estcivilpaciente = estcivil_paciente.Text;
                C.profissaopaciente = profissao_paciente.Text;
                C.anotacoespaciente = anotacoes_paciente.Text;

                C1.CadastrarPaciente(C);
                MessageBox.Show("Dados gravados com sucesso");

                Id_Paciente.Text = "";
                nome_paciente.Text = "";
                rg_paciente.Text = "";
                cpf_paciente.Text = "";
                nasc_paciente.Text = "";
                cel_paciente.Text = "";
                tel_paciente.Text = "";
                endereco_paciente.Text = "";
                email_paciente.Text = "";
                estcivil_paciente.Text = "";
                profissao_paciente.Text = "";
                anotacoes_paciente.Text = "";
                String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                Id_Paciente.Text = "0";
                tratamentoTableAdapter.FillBy_tratamento(tcc_consultorioDataSet5.tratamento, Convert.ToInt32(Id_Paciente.Text));
                con.Close();

                Alterar.Visible = false;
                Excluir.Visible = false;
                Limpar.Hide();


            }
        }

       

        private void fillBy_tratamentoToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobd);
            con.Open();
            string pesquisa = "select * from paciente where nome_paciente like @valor or id_paciente like @valor";
            MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
            ad.SelectCommand.Parameters.AddWithValue("valor", "%" + textBox1.Text + "%");
            DataTable table = new DataTable();
            ad.Fill(table);
            bunifuCustomDataGrid1.DataSource = table;
            con.Close();
        }

      
    }
}


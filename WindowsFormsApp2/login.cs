using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2

{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            panel_login.Hide();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhobd);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE login =?usuario and senha =?senha", cn);
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = bunifuMaterialTextbox4.Text;
            cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = bunifuMaterialTextbox3.Text;
            cn.Open();
            MySqlDataReader nsei = null;
            nsei = cmd.ExecuteReader();
            if (nsei.Read())
            {
                Index index = new Index();
                index.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Construtor A = new Construtor();
            Dal A1 = new Dal();
            A.login = bunifuMaterialTextbox1.Text;
            A.senha = bunifuMaterialTextbox2.Text;
            A1.CadastrarUsuario(A);

            if (bunifuMaterialTextbox1.Text == ("") || bunifuMaterialTextbox2.Text == (""))
            {
                MessageBox.Show("Login ou Senha vazio!!!");
            }

            else
            {
                MessageBox.Show("Cadastrado com Sucesso!!!");
                panel_cadastro.Hide();
                panel_login.Show();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel_login.Hide();
            panel_login.Show();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Index : Form

    {
        public Index()
        {
            InitializeComponent();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            

            if (sidemenu.Width == 56)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 212;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
                sidemenu.BringToFront();
            }
            else
            {
                LogoAnimator.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 56;
                PanelAnimator.ShowSync(sidemenu);

            }
        }
        public interface IRestable
        {
            void ResetControl();
        }
        

        private void Cadastrar_Paciente_Click(object sender, EventArgs e)
        {
            if (cadastrar_paciente1.Visible == false)
            {
                this.tratamento1.reset();
                cadastrar_paciente1.BringToFront();
                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color2;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;
                cadastrar_paciente1.Visible = true;

                tratamento1.Visible = false;
                estoque1.Visible = false;
                dentista1.Visible = false;

                sidemenu.BringToFront();
                
            }
            else
            {
                cadastrar_paciente1.Visible = false;
                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;
            }
        }

        private void cadastrar_paciente1_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Tratamento_Click(object sender, EventArgs e)
        {
            if (tratamento1.Visible == false)
            {
                
                tratamento1.BringToFront();
                tratamento1.Show();
                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color2;
                tratamento1.Visible = true;

                cadastrar_paciente1.Visible = false;
                estoque1.Visible = false;
                dentista1.Visible = false;

                sidemenu.BringToFront();
                MessageBox.Show("Selecione um paciente");
             
                
            }
            else
            {
                tratamento1.Visible = false;
                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;
            }
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            if (estoque1.Visible == false)
            {

                estoque1.BringToFront();
                estoque1.Show();
                estoque1.Visible = true;

                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color2;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;

                tratamento1.Visible = false;
                cadastrar_paciente1.Visible = false;
                dentista1.Visible = false;

                sidemenu.BringToFront();


               
            }
            else
            {
                estoque1.Visible = false;
                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;
            }
        }

        private void CadastrarDentista_Click(object sender, EventArgs e)
        {
            if (dentista1.Visible == false)
            {
                dentista1.BringToFront();
                dentista1.Show();
                dentista1.Visible = true;

                tratamento1.Visible = false;
                cadastrar_paciente1.Visible = false;
                estoque1.Visible = false;

                sidemenu.BringToFront();

                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color2;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;

            }
            else
            {
                dentista1.Visible = false;

                CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
                Estoque.Textcolor = bunifuColorTransition2.Color1;
                CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
                Home.Textcolor = bunifuColorTransition2.Color1;
                tratamento.Textcolor = bunifuColorTransition2.Color1;
            }

        }

        private void Home_Click(object sender, EventArgs e)
        {
            cadastrar_paciente1.Visible = false;
            estoque1.Visible = false;
            tratamento1.Visible = false;
            dentista1.Visible = false;
            CadastrarPaciente.Textcolor = bunifuColorTransition2.Color1;
            Estoque.Textcolor = bunifuColorTransition2.Color1;
            CadastrarDentista.Textcolor = bunifuColorTransition2.Color1;
            Home.Textcolor = bunifuColorTransition2.Color2;
            tratamento.Textcolor = bunifuColorTransition2.Color1;

        }
    }
}

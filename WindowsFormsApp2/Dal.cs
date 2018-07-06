using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2


{
    class Dal
    {

        //dal do usuario
        public void CadastrarUsuario(Construtor A)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string adicionar = "insert into usuario(login,senha)" + "values('" + A.login + "','" + A.senha + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }

        //Cadastrar Paciente
        public void CadastrarPaciente(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string adicionarpaciente = "insert into paciente(nome_paciente, rg_paciente, cpf_paciente, nasc_paciente, cel_paciente,tel_paciente, endereco_paciente, email_paciente, estcivil_paciente, profissao_paciente, anotacoes_paciente)" + "values('" + C.nomepaciente + "','" + C.rgpaciente + "','" + C.cpfpaciente + "','" + C.nascpaciente + "','" + C.celpaciente + "','" + C.telpaciente + "','" + C.enderecopaciente + "','" + C.emailpaciente + "','" + C.estcivilpaciente + "','" + C.profissaopaciente + "','" + C.anotacoespaciente + "')";
                MySqlCommand command = new MySqlCommand(adicionarpaciente, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }

        //alterar paciente
        public void AlterarPaciente(Construtor C)
        {

            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string alterarpaciente = "update paciente set id_paciente = '" + C.idpaciente + "',nome_paciente = '" + C.nomepaciente + "', rg_paciente ='" + C.rgpaciente + "', cpf_paciente='" + C.cpfpaciente + "', nasc_paciente= '" + C.nascpaciente + "', cel_paciente='" + C.celpaciente + "', tel_paciente ='" + C.telpaciente + "', endereco_paciente ='" + C.enderecopaciente + "', email_paciente ='" + C.emailpaciente + "', estcivil_paciente ='" + C.estcivilpaciente + "', profissao_paciente ='" + C.profissaopaciente + "', anotacoes_paciente='" + C.anotacoespaciente + "'where id_paciente ='" + C.idpaciente + "';";
                MySqlCommand command = new MySqlCommand(alterarpaciente, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }

        }
        // Excluir Paciente

        public void ExcluirPaciente(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string excluirpaciente = "delete from tratamento where ID_Paciente_Tratamento = '" + C.idpaciente + "'; delete from paciente where id_paciente = '" + C.idpaciente + ";'";
                MySqlCommand command = new MySqlCommand(excluirpaciente, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }


        // Consulta/Tratamento adicionar
        public void AdicionarTratamento(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();
                string adicionartratamento = "insert into tratamento(ID_Paciente_Tratamento, Nome, Dentes, Inicio, Descricao, Preco, Plano)" + "values(" + C.idpacientetratamento + ",'" + C.nometratamento + "','" + C.dentesregiao + "','" + C.iniciotratamento + "','" + C.descricaotratamento + "','" + C.precotratamento + "','" + C.plano + "')";
                MySqlCommand command = new MySqlCommand(adicionartratamento, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Dados gravados com sucesso");
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
     }


        // Consulta/Tratamento excluir
        public void ExcluirTratamento(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string excluirpaciente = "delete from tratamento where ID_Tratamento = '" + C.idtratamento + ";'";
                MySqlCommand command = new MySqlCommand(excluirpaciente, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }

    
    
            // Consulta/Tratamento alterar

        public void AlterarTratamento(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string alterartratamento = "update tratamento set ID_Tratamento = '" + C.idtratamento + "', Nome ='" + C.nometratamento + "', Dentes='" + C.dentesregiao + "', Inicio = '" + C.iniciotratamento + "', Descricao='" + C.descricaotratamento + "', Preco ='" + C.precotratamento + "', Plano ='" + C.plano + "'where ID_Tratamento ='" + C.idtratamento + "';";
                MySqlCommand command = new MySqlCommand(alterartratamento, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }
        //Cadastrar Dentista
        public void CadastrarDentista(Construtor C)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc_consultorio;UID=root;PASSWORD=";
            try
            {
                MySqlConnection con = new MySqlConnection(caminhobd);
                con.Open();

                string adicionardentista = "insert into dentista(nome_dentista, rg_dentista, cpf_dentista, nasc_dentista, cel_dentista,tel_dentista, endereco_dentista, email_dentista, 1area, 2area)" + "values('" + C.nomedentista + "','" + C.rgdentista + "','" + C.cpfdentista + "','" + C.nascdentista + "','" + C.celdentista + "','" + C.teldentista + "','" + C.enderecodentista + "','" + C.emaildentista + "','" + C.primeiraarea + "','" + C.segundaarea +"')";
                MySqlCommand command = new MySqlCommand(adicionardentista, con);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
                con.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("Deu merda mermao " + ex.Message);
            }
        }
        }
    }




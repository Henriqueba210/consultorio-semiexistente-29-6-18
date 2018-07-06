using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Construtor
    {
        //construtor do usuario
        public int id_usuario { get; set; }
        public String login { get; set; }
        public String senha { get; set; }

        //construtor do dentista
        public int iddentista { get; set; }
        public String nomedentista { get; set; }
        public String rgdentista { get; set; }
        public String cpfdentista { get; set; }
        public String nascdentista { get; set; }
        public String celdentista { get; set; }
        public String teldentista { get; set; }
        public String enderecodentista { get; set; }
        public String cepdentista { get; set; }
        public String emaildentista { get; set; }
        public String primeiraarea { get; set; }
        public String segundaarea { get; set; }

        //construtor do paciente 
        public int idpaciente { get; set; }
        public String nomepaciente { get; set; }
        public String rgpaciente { get; set; }
        public String cpfpaciente { get; set; }
        public String nascpaciente { get; set; }
        public String celpaciente { get; set; }
        public String telpaciente { get; set; }
        public String enderecopaciente { get; set; }
        public String emailpaciente { get; set; }
        public String estcivilpaciente { get; set; }
        public String profissaopaciente { get; set; }
        public String iniciotratamento { get; set; }
        public String terminotratamento { get; set; }
        public String anotacoespaciente { get; set; }



        //Construtor do tratamento
        public Int32 idtratamento { get; set; }
        public String idpacientetratamento { get; set; }
        public String nometratamento { get; set; }
        public String descricaotratamento { get; set; }
        public String plano { get; set; }
        public String tratamento { get; set; }
        public String dentesregiao { get; set; }
        public String precotratamento { get; set; }

        

    }
}

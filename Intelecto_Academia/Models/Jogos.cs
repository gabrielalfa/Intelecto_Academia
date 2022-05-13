using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intelecto_Academia.Models
{
    public class Jogos
    {
        public string n_vd { get; set; }
        public int id_Jogador { get; set; }
        public int id_adversario { get; set; }
        [Required(ErrorMessage = "Informe o nome do adversário")]
        public string Nome_Adversario { get; set; }
        public string Nome_Jogador { get; set; }
        public bool VD { get; set; }
        public string st1_j { get; set; }
        public string st2_j { get; set; }
        public string st3_j { get; set; }
        public string st1_a { get; set; }
        public string st2_a { get; set; }
        public string st3_a { get; set; }
        [Required(ErrorMessage = "Informe o local da partida.")]
        public string local { get; set; }
        [Required(ErrorMessage = "Informe data")]
        public string data { get; set; }

        public int id { get; set; }

        public string n_dr { get; set; }

    }
}
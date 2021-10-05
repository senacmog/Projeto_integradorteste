using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoSiscola.Data
{
    [Table("funcionario")]
    
    public class Funcionario
    {
        [Key]
        public int cod { get; set; }
        public string nome { get; set; }
        public string login{ get; set; }
        public string senha{ get; set; }
        public string cargo{ get; set; }
    }
}

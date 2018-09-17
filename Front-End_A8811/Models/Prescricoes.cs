using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Front-End_A8811.Models
{
    public class Prescricoes
    {
        [Key]
        public int idPrescricao { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [ForeignKey("Consulta")]
        public int ConsultaFK { get; set; }
        public virtual Consultas Consulta { get; set; }

    }
}
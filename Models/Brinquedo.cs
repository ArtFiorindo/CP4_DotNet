using System.ComponentModel.DataAnnotations;

namespace BrinquedosApi.Models
{
    public class Brinquedo
    {
        [Key]  
        public int Id_brinquedo { get; set; }
        
        public string Nome_brinquedo { get; set; }
        public string Tipo_brinquedo { get; set; }
        public string Classificacao { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
    }
}
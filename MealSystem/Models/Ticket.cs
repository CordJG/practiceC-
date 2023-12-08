using MealSystem.Commons.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealSystem.Models
{
    [Table("Ticket")]   
    
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }    
        
        public string? code { get; set; }

        public MealType? mealType { get; set; }  

        public string? compNm { get; set; }

        public DateTime? startDt { get; set; }

        public DateTime? endDt { get; set; }
        
        public DateTime? regDt { get; set; }

        public bool? IsUsed {  get; set; }
    }
}

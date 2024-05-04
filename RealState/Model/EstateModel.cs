using System.ComponentModel.DataAnnotations;

namespace RealState.Model
{
    public class EstateModel
    {
        [Key]
        public  int  Id { get; set; }


        [Required(ErrorMessage ="{0} kann nicht leer sein")]
        [Display(Name ="Title")]
        [MaxLength(200)]

        public string Title { get; set; }
        [Display(Name = "description")]
        [MaxLength(200)]

        public string Description { get; set; }
        [Display(Name = "metrage")]
        [MaxLength(200)]

        public int Metrage { get; set; }
    
        public string? Image { get; set; }

        [Display(Name = "Price")]
        [MaxLength(200)]
        public double Price { get; set; }

        [Display(Name = "Address")]
        [MaxLength(200)]
        public string Address { get; set; }
    }
}

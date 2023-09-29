using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1
{
    public class VCharacter
    {
        [Key]
        public int VRegistrationNumber{ get; set; }
        public string VName { get; set; } = string.Empty;
        public int VQuantity { get; set; }
        public string VModel { get; set; } = string.Empty;
        public string Vcolor { get; set; } = string.Empty;
        public int VYearOfManufacture { get; set; }
        
        public string VImage { get; set; } = string.Empty;
        [NotMapped]
        public IFormFile  ? ImageName { get; set; }
        
    }
}

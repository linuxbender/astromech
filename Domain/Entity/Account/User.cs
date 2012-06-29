using System.ComponentModel.DataAnnotations;
using CrossCutting.Common.Constant;

namespace Domain.Entity.Account
{
    class User : BaseEntity
    {
        [Key]
        [Required]
        [StringLength(NumberConstant.MaxLength60)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(NumberConstant.MaxLength40)]
        public string Name { get; set; }

        [Required]
        [StringLength(NumberConstant.MaxLength40)]
        public string Password  {get; set; }

        [Required]
        [NotMapped]
        [StringLength(NumberConstant.MaxLength40)]
        public string PasswordCoonfirmation { get; set; }        

        [Required]
        [StringLength(NumberConstant.MaxLength40)]
        public string Hash { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace examno_51.Models
{
    public class email
    {


        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

    
        public string Subject { get; set; }

        public string Message { get; set; }



    }
}




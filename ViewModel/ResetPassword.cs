using System.ComponentModel.DataAnnotations;

namespace CompetencyAssesment.ViewModel
{
    

    public class ResetPassword
    {
        [Required(ErrorMessage = "Please enter UserId")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string
     OldPassword
        { get; set; }

        [Required(ErrorMessage = "Please enter New Password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage
         = "Please retype New Password")]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match")]
        public string ReTypeNewPassword { get; set; }
    }
}

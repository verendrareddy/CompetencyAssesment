using System.ComponentModel.DataAnnotations;

namespace CompetencyAssesment.ViewModel
{
    public class LoginUser
    {

        [Required(ErrorMessage = "please enter UserId")]
        public string UserId { get; set; }


        [Required(ErrorMessage = "please enter Password")]
        public string Password { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using CA_Repository.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CompetencyAssesment.ViewModel
{
    public class NewUser
    {

        [Required(ErrorMessage = "please enter UserId")]
        public string UserId { get; set; }


        [Required(ErrorMessage = "please enter Password")]
        public string Password { get; set; }



        [Required(ErrorMessage = "please enter Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "please Enter EmpId")]
        public string EmpID { get; set; }

        [Required(ErrorMessage = "please Enter Email")]
        public string Email { get; set; }

        public int Role { get; set; }

        public bool IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public List<SelectListItem> Roleinfo { get; set; }  
    }
}

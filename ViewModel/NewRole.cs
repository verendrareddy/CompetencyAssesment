using System.ComponentModel.DataAnnotations;

namespace CompetencyAssesment.ViewModel
{
    public class NewRole
    {
        [Required]
        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

    }
}

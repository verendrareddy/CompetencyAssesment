using CA_Bussiness;
using CA_Repository.Model;
using CompetencyAssesment.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CompetencyAssesment.Controllers
{
    public class PL_UserManagementController : Controller
    {
        BL_UserManagement objBL = new BL_UserManagement();



        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult AddNewUser()
        {
           List<RoleDetail> lst = new List<RoleDetail>
           {
               new RoleDetail{RoleID=1,RoleName="Hr"},
                new RoleDetail{RoleID=2,RoleName="ASD"},

           };

            
            lst = objBL.BL_RoleDeatail();

            List<SelectListItem> selectListItems = lst.Select(r => new SelectListItem
            {
                Value = r.RoleID.ToString(), // Assuming RoleId is the property to use as value
                Text = r.RoleName // Assuming RoleName is the property to display as text
            }).ToList();


            NewUser newUser = new NewUser();

            newUser.Roleinfo = selectListItems;
            return View(newUser);
        }

        [HttpPost]

        public IActionResult AddNewUser(UserDetail userDetail)
        {
            userDetail.CreatedBy = userDetail.Name;
            userDetail.CreatedDate = DateTime.Now.Date;
            objBL.BL_Adduser(userDetail);
            return View();
        }


        [HttpGet]

        public IActionResult AddNewRole()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddNewRole(RoleDetail roleDetail)
        {
            string msg;
            roleDetail.CreatedDate = DateTime.Now.Date;

             msg = objBL.BL_AddRole(roleDetail);

            if(msg.Equals("success"))
            {
                ViewBag.msg = "Role added";
            }

            else
            {
                ViewBag.msg = "Failed to add Role";

            }

                
            return View();
        }


        //login user

        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Login(LoginUser loginUser)
        {
            UserDetail usr = new UserDetail();
          
              usr= objBL.GetUserDetails(loginUser.UserId, loginUser.Password);

            if(usr!= null &&usr.PasswordChangeDate == null)
            {

                return RedirectToAction("index","Home");
            }
            return View();
            }

        //reset password
        [HttpGet]
        public IActionResult ResetPassword()
        {

            return View();
        }


        [HttpPost]
        public IActionResult ResetPassword(ResetPassword resetPassword)
        {
            string msg;

            msg = objBL.ResetPassword(resetPassword.UserId, resetPassword.OldPassword, resetPassword.NewPassword);

            if (msg.Equals("success"))
            {
                ViewBag.msg = msg;
            }

            else
            {
                ViewBag.msg = msg;

            }


            return View();


       ;
        }



    }
}

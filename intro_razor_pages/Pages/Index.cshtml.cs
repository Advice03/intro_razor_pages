using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intro_razor_pages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //on post method to get what the user is sending from the form
        public string message = string.Empty;
        public void OnPost()
        {
            //request from the form
            string account_no = Request.Form["acc_no"].ToString();

            //message
            if (account_no !="")
            {
                message = "your account no is"+account_no;
            }
            else
            {
                message ="please enter account no";
            }
        }

        public void OnGet()
        {

        }
    }
}

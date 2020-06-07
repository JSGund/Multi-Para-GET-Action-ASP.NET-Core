using Microsoft.AspNetCore.Mvc;

namespace Multi_Para_GET_Action_ASP.NET_Core.Models
{
    [BindProperties]
    public class GetRequest
    {
        //[BindProperty]
        public int Id { get; set; }

        //[BindProperty]
        public string FrontEnd { get; set; }

        //[BindProperty]
        public string BackEnd { get; set; }
    }
}

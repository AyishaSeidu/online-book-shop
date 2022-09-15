using Microsoft.AspNetCore.Components;

namespace OnlineBookShop.Web.Pages.Bases
{
    public class ErrorMessageBase : ComponentBase
    {
        [Parameter]
        public string Message { get; set; }
    }
}

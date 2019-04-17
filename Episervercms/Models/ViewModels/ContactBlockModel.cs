using EPiServer.Core;
using EPiServer.Web;
using Episervercms.Models.Pages;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Episervercms.Models.ViewModels
{
    public class ContactBlockModel
    {
        [UIHint(UIHint.Image)]
        public ContentReference Image { get; set; }
        public string Heading { get; set; }
        public string LinkText { get; set; }
        public IHtmlString LinkUrl { get; set; }
        public bool ShowLink { get; set; }
        public ContactPage ContactPage { get; set; }
    }
}

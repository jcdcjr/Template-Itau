using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace TemplateItau.Helpers
{
    public static class BreadcrumbHelper
    {
        public static MvcHtmlString Breadcrumb(this HtmlHelper helper, List<KeyValuePair<string, string>> menu)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ol class='breadcrumb'>");
            foreach(var item in menu)
            {
                sb.AppendLine($"<li class='breadcrumb-item'><a href='{item.Key}'>{item.Value}</a></li>");
            }
            sb.AppendLine("</ol>");
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
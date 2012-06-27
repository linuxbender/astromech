using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using CrossCutting.Common.Constant;

namespace Presentation.Web.Utils.Extension
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString AppTitle(this HtmlHelper html)
        {
            if (html.ViewData[StringConstant.APP_VD_TITEL] != null)
            {
                if (!string.IsNullOrWhiteSpace(html.ViewData[StringConstant.APP_VD_TITEL].ToString()))
                {
                    return new MvcHtmlString(
                        string.Format(StringConstant.APP_NAME_EX, html.ViewData[StringConstant.APP_VD_TITEL]));
                }
            }
            return new MvcHtmlString(string.Format(StringConstant.APP_NAME));
        }
        public static MvcHtmlString AktivLink(this HtmlHelper html, string routeName = RouteConstant.HOME ,string css = StringConstant.CSS_B_ACTIVE)
        {
            if (html.ViewContext.RouteData.Route == RouteTable.Routes[routeName])
            {
                return new MvcHtmlString(css);
            }
            return new MvcHtmlString(String.Empty);
        }

        public static MvcHtmlString AppTitle(this HtmlHelper html, string title = StringConstant.EMPTY)
        {
            html.ViewData[StringConstant.APP_VD_TITEL] = title;
            return new MvcHtmlString(String.Empty); 
        }

        public static MvcHtmlString GravatarUrl(this HtmlHelper html, 
                                                string mail = StringConstant.EMPTY, 
                                                string size = StringConstant.GRAVATAR_SIZE)
        {            
            return new MvcHtmlString(ImageSrc(mail, size));
        }

        public static MvcHtmlString Year(this HtmlHelper html)
        {
            return new MvcHtmlString(DateTime.Now.Year.ToString());
        }

        public static MvcHtmlString GravatarFor<TModel, TProperty>( this HtmlHelper<TModel> helper, 
                                                                    Expression<Func<TModel, TProperty>> expression, 
                                                                    object htmlAttributes,
                                                                    string size = StringConstant.GRAVATAR_SIZE)
        {
            var valueGetter = expression.Compile();
            var value = valueGetter(helper.ViewData.Model);
            var mail = ImageSrc(value.ToString(), size);

            var img = new TagBuilder(StringConstant.HTML_TAG_IMG);
            img.MergeAttribute(StringConstant.HTML_ATTRI_IMG_SRC, mail);
            img.MergeAttribute(StringConstant.HTML_ATTRI_IMG_ALT, String.Empty);            

            img.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            img.SetInnerText(value.ToString());

            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));
        }

        private static string ImageSrc(string email = StringConstant.EMPTY, 
                                       string size = StringConstant.GRAVATAR_SIZE)
        {
            var md5 = MD5.Create();
            var md5String = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(email.ToLower())))
                                        .ToLower().Replace(StringConstant.GRAVATAR_MD5_RE, String.Empty);
            md5.Dispose();
            return string.Format(StringConstant.GRAVATAR_LINK , md5String, size);
        }
    }
}
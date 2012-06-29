using System;

namespace CrossCutting.Common.Constant
{
    public static class StringConstant
    {
        public const string EMPTY = "";

        #region astromech Application Setting

        public const string AstromechConnection = "astromech";

        #endregion

        #region HtmlExtensions

        public const string APP_VD_TITEL = "AppTitle";        
        public const string APP_NAME = "Astromech";
        public const string APP_NAME_EX = "Astromech | {0}";
       
        public const string GRAVATAR_SIZE = "80";
        public const string GRAVATAR_LINK = "https://secure.gravatar.com/avatar/{0}?s={1}";
        public const string GRAVATAR_MD5_RE = "-";

        public const string HTML_TAG_IMG = "img";
        public const string HTML_ATTRI_IMG_SRC = "src";
        public const string HTML_ATTRI_IMG_ALT = "alt";
               
        #endregion

        #region Labels and Strings

        public const string LABEL_SIGN_IN = "Sign In";
        public const string LABEL_VIEW_ON = "View On";
        public const string LABEL_GITHUB = "Github";

        public const string LABEL_HOME = "Home";
        public const string LABEL_ABOUT = "About";
        public const string LABEL_HELP = "Help";
        public const string LABEL_CONTACT = "Contact";

        #endregion

        #region CSS Bootstrap

        public const string CSS_B_BRAND = "brand";
        public const string CSS_B_ACTIVE = "active";

        #endregion

        #region URL

        public const string URL_REPO = "https://github.com/linuxbender/astromech";

        #endregion

        #region Helper values for mvc bugs

        public const string BUG_ROUTE = "area";

        #endregion
    }
}

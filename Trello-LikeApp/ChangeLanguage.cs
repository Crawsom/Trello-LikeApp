using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class ChangeLanguage
    {
        private string chLanguage;

        public ChangeLanguage(string chLanguage)
        {
            this.chLanguage = chLanguage;
        }

        public CultureInfo Change()
        {
            if (chLanguage == "English")
            {
                return Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else if (chLanguage == "Spanish")
            {
                return Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            }
            else
            {
                return Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            }
        }
    }
}

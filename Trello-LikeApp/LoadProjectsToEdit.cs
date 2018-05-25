using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class LoadProjectsToEdit
    {
        private Label label11;
        public LoadProjectsToEdit(Label label11)
        {
            this.label11 = label11;
        }
        public void LoadThings()
        {
            label11.Text = "Name project";
        }
    }
}

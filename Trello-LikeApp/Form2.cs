using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void loadForm2(object sender, EventArgs e)
        {
            LoadProjectsToEdit edit = new LoadProjectsToEdit(label11);
            edit.LoadThings();
        }
    }
}

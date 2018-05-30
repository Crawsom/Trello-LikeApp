using System;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    public partial class Form2 : Form
    {
        private string editProject;
        public Form2(string editProject)
        {
            InitializeComponent();
            this.editProject = editProject;
        }

        private void loadForm2(object sender, EventArgs e)
        {

            LoadProjectsToEdit edit = new LoadProjectsToEdit(label11,
                editProject, label12, label13, label14, label15);
            edit.LoadNames();
        }

        private void saveProjectButton(object sender, EventArgs e)
        {
            /*string pName = pNameTxt.Text;
            string pManager = pManagerTxt.Text;
            string shortDesc = shortDescTxt.Text;*/

            Save save = new Save(editProject, pNameTxt.Text, pManagerTxt.Text, shortDescTxt.Text);
            save.Changes();
        }
    }
}

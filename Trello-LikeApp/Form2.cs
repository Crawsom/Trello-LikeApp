using System;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    public partial class Form2 : Form
    {
        private CheckedListBox editProjectsChckBox;
        public Form2(CheckedListBox editProjectsChckBox)
        {
            InitializeComponent();
            this.editProjectsChckBox = editProjectsChckBox;
        }

        private void loadForm2(object sender, EventArgs e)
        {
            LoadProjectsToEdit edit = new LoadProjectsToEdit(label11,
                editProjectsChckBox,label12, label13, label14, label15);
            edit.LoadThings();
        }
    }
}

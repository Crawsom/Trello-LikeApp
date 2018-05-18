using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trello_LikeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveCreatedProject s = new SaveCreatedProject(ProjectNameTextBx,
             ProjectManagerTextBx,  ShortDescTextBx, StartTimeDate, EndTimeDate);
            s.Save();
        }

        private void Timer(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // 
        private void loadForm(object sender, EventArgs e)
        {
            LoadEmployees load = new LoadEmployees();
            foreach (var item in load.Load())
            {
                bxEmployeers.Items.Add(item);
            }
            foreach (var item in load.Load())
            {
                lstBoxEmployees.Items.Add(item);
            }
        }

        private void ProjectsLoad(object sender, EventArgs e)
        {
            lstBxProjects.Items.Clear();
            string[] listFiles = Directory.GetFiles(".", "*.tla");
            foreach (string lf in listFiles)
                lstBxProjects.Items.Add(lf);

        }

        private void SaveSubTasks(object sender, EventArgs e)
        {
            if (txtSTName.Text.Length > 0 && bxEmployeers.Text.Length > 0
                && txtSTDescription.Text.Length > 0
                && lstBxProjects.CheckedItems.Count > 0)
            {
                SubTasks subtasks = new SubTasks(txtSTName.Text, bxEmployeers.Text,
                    txtSTDescription.Text);

                foreach (var st in lstBxProjects.CheckedItems)
                    subtasks.TrySave(st.ToString(), subtasks);

                MessageBox.Show("Save!");
            }
            else
                MessageBox.Show("You must select a project.");

        }

        private void SaveEmployees(object sender, EventArgs e)
        {
            Employees employee = new Employees(TxtBxEmployeeName.Text,
                TxtBxEmployeeSurname.Text);
            employee.Save();
        }

        /*. Refresh the employees page so you can see the new employee in 
          . employee list box*/
        private void refreshForm()
        {
            LoadEmployees load = new LoadEmployees();
            lstBoxEmployees.Items.Clear();
            foreach (var item in load.Load())
            {
                lstBoxEmployees.Items.Add(item);
            }
        }

        private void RefreshButtn(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void lstBxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes the selection mode from double-click to single click.
            lstBxProjects.CheckOnClick = true;
        }
    }
}

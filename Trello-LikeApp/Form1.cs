﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace Trello_LikeApp
{
    public partial class Form1 : Form
    {
        public string language = Properties.Settings.Default.Langue;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
            timer1.Start();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string pName = ProjectNameTextBx.Text;
            string pManager = ProjectManagerTextBx.Text;
            string shortDesc = ShortDescTextBx.Text;
            string dateStart = Convert.ToString(EndTimeDate.Value);
            string dateEnd = Convert.ToString(EndTimeDate.Value);
            SaveCreatedProject s = new SaveCreatedProject(pName, pManager,
                shortDesc, dateStart, dateEnd);
            s.Save();
        }

        private void Timer(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

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

            //Adds the deadlines of projects to the Calendar tab
            SeeDeadLines deadLine = new SeeDeadLines(DeadLinesCalendar,
                ProjectsNearDeadLinelstbx);
            deadLine.DeadLines();

            //Shows alert for deadlines that are at one week to end
            deadLine.AlertDeadLines();

            //
            Extras extra = new Extras(label2, label1, label4, label5,
                save_button);
            extra.ToolTips();

            //Change Language
            languageCmbBx.Items.Add("English");
            languageCmbBx.Items.Add("Spanish");
            languageCmbBx.SelectedIndex = 0;
        }

        private void ProjectsLoad(object sender, EventArgs e)
        {
            lstBxProjects.Items.Clear();
            string[] listFiles = Directory.GetFiles(".", "*.tla");
            foreach (string lf in listFiles)
                lstBxProjects.Items.Add(lf);
            foreach (string lf in listFiles)
                editProjectsChckBox.Items.Add(lf);

        }

        private void SaveSubTasks(object sender, EventArgs e)
        {
            if (txtSTName.Text.Length > 0 && bxEmployeers.Text.Length > 0
                && txtSTDescription.Text.Length > 0
                && lstBxProjects.CheckedItems.Count > 0)
            {
                SubTasks subtasks = new SubTasks(txtSTName.Text, bxEmployeers.Text,
                    txtSTDescription.Text, txtBxSTDuration.Text, TaskPriority.Value);

                foreach (var st in lstBxProjects.CheckedItems)
                    subtasks.TrySave(st.ToString(), subtasks);

                MessageBox.Show("Save!");
            }
            else
                MessageBox.Show("You must select a project.");

        }

        private void SaveEmployees(object sender, EventArgs e)
        {
            //Checks if the fields like DNI is ok or not
            if (Regex.IsMatch(dniTxtBx.Text,
                "/^[0-9]{8}[a-z]?$") || dniTxtBx.Text.Length == 9 &&
                TxtBxEmployeeName.Text.Length > 0 &&
                TxtBxEmployeeSurname.Text.Length > 0)
            {
                Employees employee = new Employees(TxtBxEmployeeName.Text,
                    TxtBxEmployeeSurname.Text, ageTxtBx.Text, dniTxtBx.Text);
                employee.Save();
            }
            else
            {
                MessageBox.Show("Dni must be like 12345678A. \n" +
                    "No textBoxes should be empty.");
            }

            /* 
             * Refresh the employees page so you can see the new employee in 
             * employee list box
             */
            LoadEmployees load = new LoadEmployees();
            lstBoxEmployees.Items.Clear();
            foreach (var item in load.Load())
            {
                lstBoxEmployees.Items.Add(item);
            }
        }

        /*. Refresh the employees page so you can see the new employee in 
          . employee list box
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
        }*/

        private void lstBxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes the selection mode from double-click to single click.
            lstBxProjects.CheckOnClick = true;
        }

        private void loadPrEdit(object sender, EventArgs e)
        {
            string editProject = editProjectsChckBox.Text;
            Form2 form2 = new Form2(editProject);
            form2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageCmbBx.SelectedItem.ToString() == "English")
            {
                ChangeLanguage("en");
            }
            else if (languageCmbBx.SelectedItem.ToString() == "Spanish")
            {
                ChangeLanguage("es");
            }
            else
            {
                ChangeLanguage("en");
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new
                    ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
    }
}

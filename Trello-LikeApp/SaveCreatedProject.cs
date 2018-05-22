using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class SaveCreatedProject 
    {
        private TextBox projectNameTextBx;
        private TextBox projectManagerTextBx;
        private TextBox shortDescTextBx;
        private object startTimeDate;
        private object endTimeDate;

        public SaveCreatedProject(TextBox projectNameTextBx, 
            TextBox projectManagerTextBx, TextBox shortDescTextBx,
            object startTimeDate, object endTimeDate)
        {
            this.projectNameTextBx = projectNameTextBx;
            this.projectManagerTextBx = projectManagerTextBx;
            this.shortDescTextBx = shortDescTextBx;
            this.startTimeDate = startTimeDate;
            this.endTimeDate = endTimeDate;
        }

        //Save Project
        public void Save()
        {
            //Gets the text in the textboxes adds them in a textfile.
            DialogResult result;
            string message = "Saved";
            
            string[] startDate = startTimeDate.ToString().Split(' ');
            string[] endDate = endTimeDate.ToString().Split(' ');
            StreamWriter w = new StreamWriter(projectNameTextBx.Text + "_" +
                DateTime.Now.ToString("yyyy-MM-dd") + ".tla");
            w.WriteLine("Project Name: " + projectNameTextBx.Text);
            w.WriteLine("Project Manager: " + projectManagerTextBx.Text);
            w.WriteLine("Short Description: " + shortDescTextBx.Text);
            w.WriteLine("Start Date: " + startDate[2]);
            w.WriteLine("End Date: " + endDate[2]);
            w.Close();
            result = MessageBox.Show(message);
        }
    }
}

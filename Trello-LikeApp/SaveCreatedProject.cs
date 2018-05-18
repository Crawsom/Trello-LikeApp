using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class SaveCreatedProject 
    {
        private int c;
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
            string[] projectName = projectNameTextBx.ToString().Split(' ');
            string[] projectManager = projectManagerTextBx.ToString().Split(' ');
            string[] shortDescription = shortDescTextBx.ToString().Split(' ');
            string[] startDate = startTimeDate.ToString().Split(' ');
            string[] endDate = endTimeDate.ToString().Split(' ');
            StreamWriter w = new StreamWriter("project" +
                DateTime.Now.ToString("yyyy-MM-dd") + "-N" + (c + 1) + ".tla");
            w.WriteLine("Project Name: " + projectName[2]);
            w.WriteLine("Project Manager: " + projectManager[2]);
            w.WriteLine("Short Description: " + shortDescription[2]);
            w.WriteLine("Start Date: " + startDate[2]);
            w.WriteLine("End Date: " + endDate[2]);
            w.Close();
            c++;
            result = MessageBox.Show(message);
        }
    }
}

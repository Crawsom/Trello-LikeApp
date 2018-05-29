using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class SaveCreatedProject 
    {
        private string pName;
        private string pManager;
        private string shortDesc;
        private string dateStart;
        private string dateEnd;

        public SaveCreatedProject(string pName, string pManager, 
            string shortDesc, string dateStart, string dateEnd)
        {
            this.pName = pName;
            this.pManager = pManager;
            this.shortDesc = shortDesc;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
        }

        //Save Project
        public void Save()
        {
            try
            {
                if (File.Exists(pName + "_" +
                        DateTime.Now.ToString("yyyy-MM-dd") + ".tla"))
                {
                    MessageBox.Show("Already Exists");
                }
                else
                {
                    //Gets the text in the textboxes adds them in a textfile.
                    DialogResult result;
                    string message = "Saved";

                    string[] startDate = dateStart.Split(' ');
                    string[] endDate = dateEnd.Split(' ');
                    MessageBox.Show(dateEnd);
                    StreamWriter w = new StreamWriter(pName + "_" +
                        DateTime.Now.ToString("yyyy-MM-dd") + ".tla");
                    w.WriteLine("Project Name: " + pName);
                    w.WriteLine("Project Manager: " + pManager);
                    w.WriteLine("Short Description: " + shortDesc);
                    w.WriteLine("Start Date: " + startDate[0]);
                    w.WriteLine("End Date: " + endDate[0]);
                    w.Close();
                    result = MessageBox.Show(message);
                }
            }
            catch (PathTooLongException e) { MessageBox.Show(e.Message); }
            catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            catch (IOException e) { MessageBox.Show(e.Message); }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }
    }
}

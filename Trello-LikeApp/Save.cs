using System;
using System.IO;
using System.Windows.Forms;
namespace Trello_LikeApp
{
    class Save
    {
        private string pName;
        private string pManager;
        private string shortDesc;
        private string editProject;
        public Save(string pName, string pManager, string shortDesc, 
            string editProject)
        {
            this.pName = pName;
            this.pManager = pManager;
            this.shortDesc = shortDesc;
            this.editProject = editProject;
        }

        public void Changes()
        {
            try
            {
                StreamReader reader = new StreamReader(editProject);
                StreamWriter writer = new StreamWriter(editProject);
                string line = reader.ReadLine();
                if (line.StartsWith("Project Name:"))
                {
                    writer.WriteLine(pName);
                }
                else if (line.StartsWith("Project Manager"))
                {
                    writer.WriteLine(pManager);
                }
                else if (line.StartsWith("Short Description"))
                {
                    writer.WriteLine(shortDesc);
                }
                reader.Close();
                writer.Close();
            }
            catch (PathTooLongException e) { MessageBox.Show(e.Message); }
            catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            catch (IOException e) { MessageBox.Show(e.Message); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}

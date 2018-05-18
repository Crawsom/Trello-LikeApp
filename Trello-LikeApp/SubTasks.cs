using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    public class SubTasks
    {
        public string name { get; set; }
        public string employeer { get; set; }
        public string description { get; set; }

        public SubTasks(string name, string employeer, string description)
        {
            this.name = name;
            this.employeer = employeer;
            this.description = description;
        }

        public void TrySave(string projectFile, SubTasks s)
        {
            try
            {
                if (!File.Exists(projectFile))
                    MessageBox.Show("Error in project " + projectFile + ". " +
                        "File not Exists.");
                else
                    Save(projectFile, s);
            }
            catch (PathTooLongException e) { MessageBox.Show(e.Message); }
            catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            catch (IOException e) { MessageBox.Show(e.Message); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public void Save(string projectFile, SubTasks s)
        {
            StreamWriter writer;

            writer = File.AppendText(projectFile);
            String st = new String('-', 4);
            writer.WriteLine(st + s.name);
            writer.WriteLine(st + s.employeer);
            writer.WriteLine(st + s.description);

            writer.Close();
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    public class SubTasks
    {
        public string name { get; set; }
        public string employee { get; set; }
        public string description { get; set; }
        public string duration { get; set; }
        public decimal taskpriority { get; set; }

        public SubTasks(string name, string employee, string description,
            string duration, decimal taskpriority )
        {
            this.name = name;
            this.employee = employee;
            this.description = description;
            this.duration = duration;
            this.taskpriority = taskpriority;
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
            writer.WriteLine(st + " SubTask Name: " + s.name);
            writer.WriteLine(st + " Employee: " + s.employee);
            writer.WriteLine(st + " Description: " + s.description);
            writer.WriteLine(st + " Duration: " + s.duration);
            writer.WriteLine(st + " Priority: " + s.taskpriority);

            writer.Close();
        }
    }
}

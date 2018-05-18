using System.IO;
using System.Windows.Forms;
namespace Trello_LikeApp
{
    public class Employees
    {
        public string name { get; set; }
        public string subName { get; set; }

        public Employees(string name,string subName)
        {
            this.name = name;
            this.subName = subName;
        }

        public void Save()
        {
            // Gets the text in the textboxes adds them in the textfile of 
            // employees.
            DialogResult result;
            string message = "Saved";
            StreamWriter w = File.AppendText("employee.tla");
            w.WriteLine(name + " " + subName);
            w.Close();
            result = MessageBox.Show(message);
        }
    }
}

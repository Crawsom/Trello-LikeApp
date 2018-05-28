using System.IO;
using System.Windows.Forms;
namespace Trello_LikeApp
{
    public class Employees
    {
        public string name { get; set; }
        public string subName { get; set; }
        public string age { get; set; }
        public string dni { get; set; }

        public Employees(string name,string subName, string age, string dni)
        {
            this.name = name;
            this.subName = subName;
            this.age = age;
            this.dni = dni;
        }

        public void Save()
        {
            // Gets the text in the textboxes adds them in the textfile of 
            // employees.
            DialogResult result;
            string message = "Saved";
            StreamWriter w = File.AppendText("employee.tla");
            w.WriteLine(name + " " + subName + " " + age + " " + dni);
            w.Close();
            result = MessageBox.Show(message);
        }

    }
}

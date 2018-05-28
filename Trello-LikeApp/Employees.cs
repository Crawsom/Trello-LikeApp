using System.IO;
using System.Windows.Forms;
namespace Trello_LikeApp
{
    struct Employee
    {
        public string name;
        public string subName;
        public string age;
        public string dni;
    }
    public class Employees
    {
        Employee emp = new Employee();

        public Employees(string name,string subName, string age, string dni)
        {
            emp.name = name;
            emp.subName = subName;
            emp.age = age;
            emp.dni = dni;
        }

        public void Save()
        {
            // Gets the text in the textboxes adds them in the textfile of 
            // employees.
            DialogResult result;
            string message = "Saved";
            StreamWriter w = File.AppendText("employee.tla");
            w.WriteLine(emp.name + " " + emp.subName + " " + emp.age + " " + emp.dni);
            w.Close();
            result = MessageBox.Show(message);
        }

    }
}

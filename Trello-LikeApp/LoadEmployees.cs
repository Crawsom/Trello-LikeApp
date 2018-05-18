using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class LoadEmployees
    {
        public List<object> Load()
        {
            List<object> loadEmployees = new List<object>();
            if (!File.Exists("employee.tla"))
                MessageBox.Show("File not exists");
            else
            {
                try
                {
                    StreamReader reader = File.OpenText("employee.tla");
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            loadEmployees.Add(line);
                        }
                    } while (line != null);
                    reader.Close();
                }
                catch (PathTooLongException e) { MessageBox.Show(e.Message); }
                catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
                catch (IOException e) { MessageBox.Show(e.Message); }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
            
            return loadEmployees;
        }
    }
}

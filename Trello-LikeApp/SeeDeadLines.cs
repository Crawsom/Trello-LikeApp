using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class SeeDeadLines
    {
        private MonthCalendar deadLinesCalendar;

        public SeeDeadLines(MonthCalendar deadLinesCalendar)
        {
            this.deadLinesCalendar = deadLinesCalendar;
        }
        //See dead lines of the projects in the calendar
        public void DeadLines()
        {
            string[] listFiles = Directory.GetFiles(".", "*.tla");
            for (int i = 0; i < listFiles.Length; i++)
            {
                try
                {
                    StreamReader reader = File.OpenText(listFiles[i]);
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null && line.StartsWith("End Date:"))
                        {
                            string[] date = line.Split(' ');
                            string[] dateEnd = date[2].Split('/');
                            DateTime end = new DateTime(
                                Convert.ToInt32(dateEnd[2]),
                                Convert.ToInt32(dateEnd[1]),
                                Convert.ToInt32(dateEnd[0]));
                            DateTime endDates = end;
                            deadLinesCalendar.AddBoldedDate(endDates);
                        }
                    } while (line != null);
                    reader.Close();
                }
                catch (PathTooLongException e) { MessageBox.Show(e.Message); }
                catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
                catch (IOException e) { MessageBox.Show(e.Message); }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
        }
    }
}

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
                
                // Do not show the "Today" banner.
                deadLinesCalendar.ShowToday = false;

                // Show the week numbers to the left of each week
                deadLinesCalendar.ShowWeekNumbers = true;
            }
        }
        
        //Shows alert for deadlines that are at one week to end
        public void AlertDeadLines()
        {
            string filesCloseDeadLine="";
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


                            int day = DateTime.Now.Day;
                            switch (Convert.ToInt32(dateEnd[0]) - day)
                            {
                                case 7:

                                case 6:

                                case 5:

                                case 4:

                                case 3:

                                case 2:

                                case 1:
                                    filesCloseDeadLine += listFiles[i] + " \n";
                                    break;
                                default:

                                    break;

                            }
                        }
                    } while (line != null);
                    reader.Close();
                }
                catch (PathTooLongException e) { MessageBox.Show(e.Message); }
                catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
                catch (IOException e) { MessageBox.Show(e.Message); }
                catch (Exception e) { MessageBox.Show(e.Message); }
            }
            MessageBox.Show(filesCloseDeadLine + "These projects are near the" +
                " deadline");
        }
    }
}

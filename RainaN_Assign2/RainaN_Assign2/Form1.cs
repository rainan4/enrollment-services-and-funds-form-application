using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RainaN_Assign2
{
    public partial class Form1 : Form
    {
        //Form Field Member
        List<SchoolInfo> SchoolLists = new List<SchoolInfo>();// delcaring all form field members
        public Form1()
        {
            InitializeComponent();
        }

        private void loadSchoolData_Click(object sender, EventArgs e)
        {
            //question 1 of Event Handlers
            SchoolLists.Clear();
            //using try and catch block to catch any exceptions
            try
            {
                using (StreamReader reader = new StreamReader("schools_input.csv")) // reading the file
                {
                    if (!reader.EndOfStream)
                    {
                       string headerline = reader.ReadLine();
                    }
                    while (!reader.EndOfStream) // using the while block to process data lines
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');
                        string schoolName = fields[0]; //schoolname is first column
                        int maxEnroll;
                        int prevYrEnroll;
                        double fundsPerStud;
                        int studsLeaving;
                        int studsJoining;

                       //

                        int.TryParse(fields[1], out maxEnroll); // max enroll is second comlumn
                        int.TryParse(fields[2], out prevYrEnroll); // third column
                        double.TryParse(fields[3], out fundsPerStud);// fourth column
                        int.TryParse(fields[4], out studsLeaving);//fifth column
                        int.TryParse(fields[5], out studsJoining);// sixth column
                        
                        
                     
                        SchoolInfo eachSchool = new SchoolInfo (schoolName.ToString(), maxEnroll, prevYrEnroll, fundsPerStud, studsLeaving,studsJoining);
                        SchoolLists.Add(eachSchool); //loading it to the list
                    }
                }// loading all the school information from list to listbox
                LoadAllSchoolsToListBox();
                StatusLabel.Text = "Loaded " + SchoolLists.Count + " Schools from schools_input.csv"; // a status label to update how many schools were loaded
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void LoadAllSchoolsToListBox()
        {
            //quest1
            //creating a method to format the listbox when clicking on load school data to display on the liistbox
            SchoolListBox.Items.Clear();
            
            SchoolListBox.Items.Add(string.Format("{0}", "SchoolName") + "\t" + string.Format("{0,5}", "MaxEnroll") + "\t" + string.Format("{0,10}", "PrevYrEnroll") + "\t"
                + string.Format("{0,15}", "FundsPerStud") + "\t" + string.Format("{0,30}", "NumStudsLeaving") + "\t" + string.Format("{0,25}", "NumStudsJoining") + "\t"
                + string.Format("{0,35}", "CurrYrEnroll") + "\t" + string.Format("{0,40}", "TotalFunding")); // creating a header in listbox and using string.format to format the header
            SchoolListBox.Items.ToString();
            foreach (SchoolInfo school in SchoolLists)
            {
                SchoolListBox.Items.Add(school); // using foreach to automatically call school.ToString()
            }
        }

        private void SchoolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //accidentally clicks
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            //accidentally
        }

        private void updateNumStudsLeaving_Click(object sender, EventArgs e)
        {
            //question 2
            //using try catch blocks to catch execeptions when user doesn't put in the correct input
            // if the user puts words instead of numbers then the catch block will display the message
            try
            {
                int listBoxIndex = SchoolListBox.SelectedIndex; //when the user selects then it gets stored in listBoxIndex
                if (listBoxIndex <= 0)
                {
                    MessageBox.Show("Please select a school to update Number of Students Leaving");// when the user doesn't select the school, a message box will display.
                }
                else
                {
                    int dataIndex = listBoxIndex - 1; // headerline won't be included when user inputs data
                    
                   if (!int.TryParse(NumStudsLeavingTextBox.Text, out int numStudsLeaving) || numStudsLeaving <= 0 || numStudsLeaving > SchoolLists[dataIndex].CurrYrEnroll) // using try parse fail if the user doesn't put the right input when clicking the update number of studs leaving
                    {


                        StatusLabel.Text = "Number of Students Leaving for the update must be valid integer > 0 and <= CurrEnroll";
                        
                        NumStudsLeavingTextBox.Clear(); //clearing the textbox

                    }
                   else if (int.TryParse(NumStudsLeavingTextBox.Text, out numStudsLeaving) || numStudsLeaving > 0 && numStudsLeaving < SchoolLists[dataIndex].CurrYrEnroll) // if users input is valid, this else if block will execute
                    {

                        //updating the data
                        SchoolLists[dataIndex].NumStudsLeaving = numStudsLeaving;
                        // updating listbox
                        SchoolListBox.Items[listBoxIndex] = SchoolLists[dataIndex];
                        //updating status
                       StatusLabel.Text = "Number of Students Leaving has been updated for the " + SchoolLists[dataIndex].SchoolName;
                        NumStudsLeavingTextBox.Clear();


                    }





                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateNumStudsJoining_Click(object sender, EventArgs e)
        {
            //ques 3
            
            try
            {
                int listBoxIndex = SchoolListBox.SelectedIndex;
                if (listBoxIndex <= 0)
                {
                    MessageBox.Show("Please select a school to update Number of Students Joining");
                }
                else
                {
                    int dataIndex = listBoxIndex - 1;
                    
                     if (!int.TryParse(NumStudsJoiningTextBox.Text, out int numStudsJoining) || numStudsJoining <= 0 )// similar to question 2 // using if and else if blocks when users input a negative number then it will display a message
                    {


                        StatusLabel.Text = "Number of Students Joining must be valid integer > 0";

                        NumStudsJoiningTextBox.Clear();

                    }
                   else if (int.TryParse(NumStudsJoiningTextBox.Text, out numStudsJoining) || numStudsJoining > 0)// if users inputs a number greater than 0 then it will display the message and update the listbox 
                    {
                        //update data
                        SchoolLists[dataIndex].NumStudsJoining = numStudsJoining;
                        //updating listbox
                        SchoolListBox.Items[listBoxIndex] = SchoolLists[dataIndex];
                         StatusLabel.Text = "Number of Students Joining has been updated for the " + SchoolLists[dataIndex].SchoolName;
                        NumStudsJoiningTextBox.Clear();

                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delSelectedSchool_Click(object sender, EventArgs e)
        {
            //ques4
            int listBoxIndex = SchoolListBox.SelectedIndex;
            if (listBoxIndex <= 0)
            {
                MessageBox.Show("Please select a school to delete"); // when the user did not select a school
            }
            else
            {
                int dataIndex = listBoxIndex - 1; // headerline will be excluded
                StatusLabel.Text = "Deleted " + SchoolLists[dataIndex].SchoolName;// updating the status label when the data gets deleted
                SchoolLists.RemoveAt(dataIndex);// this deletes the data
                SchoolListBox.Items.RemoveAt(listBoxIndex);// this deletes the data in the lsitbox
            }
        }

        private void desenOrderOfTotalFunds_Click(object sender, EventArgs e)
        {
            //ques5
            SchoolLists = SchoolLists.OrderByDescending(school => school.TotalFunding).ToList(); // sorting the list to descending order based on total funding 
            LoadAllSchoolsToListBox();//loading to the listbox
            StatusLabel.Text = "Sorted schools in Descending order of TotalFunding";
        }

        private void writeOutputData_Click(object sender, EventArgs e)
        {
            //ques 6
            try
            {
                int counter = 0;
                using (StreamWriter writer = new StreamWriter("schools_out.txt"))// writing to a new file when user clicks on write output data button after they updated the list with new data
                {
                    writer.WriteLine("SchoolName\tMaxEnroll\tPrevYrEnroll\tNumStudsLeaving\tNumStudsJoining\tFundsPerStud\tCurrYrEnroll\tTotalFunding"); // writing a header for the file
                    foreach(SchoolInfo school in SchoolLists)
                    {
                        writer.WriteLine(school.SchoolName + "\t" + school.MaxEnroll + "\t" + school.PrevYrEnroll + "\t" + school.NumStudsLeaving + "\t"
                            + school.NumStudsJoining + "\t" + school.FundsPerStud + "\t" + school.CurrYrEnroll
                            + "\t" + school.TotalFunding); //the data gets loaded to the file
                        counter++;
                    }
                }
                StatusLabel.Text = "Written " + counter + " Schools to schools_out.txt"; //status label to display the amount of school that were loading to the file
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeEnrollExceedData_Click(object sender, EventArgs e)
        {
            //ques7
            try
            {
                int counter = 0;
                using (StreamWriter writer = new StreamWriter("schools_enrollexceeded.txt")) // writiing to the new file when user clicks on write enrollment exceed data
                {
                    writer.WriteLine("SchoolName,MaxEnroll,PrevYrEnroll,NumStudsLeaving,NumStudsJoining,CurrYrEnroll");// headerline
                    SchoolLists = (from school in SchoolLists where school.CurrYrEnroll > school.MaxEnroll orderby school.SchoolName select school).ToList(); // sorting the list when the current enrollment is greater than max enrollment
                    foreach (SchoolInfo schools in SchoolLists)
                    {
                        writer.WriteLine(schools.SchoolName + "," + schools.MaxEnroll + "," + schools.PrevYrEnroll + "," + schools.NumStudsLeaving + ","
                            + schools.NumStudsJoining + "," +  schools.CurrYrEnroll); //loading the data to the file 
                        counter++;
                    }
                }
                StatusLabel.Text = "Written " + counter + " Schools to schools_enrollexceeded.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeFundsRequestInfo_Click(object sender, EventArgs e)
        {
            //ques8
            try
            {
                int counter = 0;
                using (StreamWriter writer = new StreamWriter ("schools_funds.txt")) //creating a new file when user clicks on write funds request info
                {
                    writer.WriteLine("SchoolName\tFundsPerStud\tCurrYrEnroll\tTotalFunding");//headerline
                    SchoolLists = (from school in SchoolLists where school.TotalFunding > 0 select school).ToList(); //sorting the list when total funds are greater than 0
                    foreach(SchoolInfo school in SchoolLists)
                    {
                        writer.WriteLine(school.SchoolName + 
                             "\t" + school.FundsPerStud + "\t" + school.CurrYrEnroll
                            + "\t" + school.TotalFunding);
                        counter++;
                    }
                }
                StatusLabel.Text = "Written " + counter + " Schools to schools_funds.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

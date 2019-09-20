using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class StudentInformation : Form
    {
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> mobiles = new List<string>();
        List<int> ages = new List<int>();
        List<string> addresses = new List<string>();
        List<double> gpas = new List<double>();
        public StudentInformation()
        {
            InitializeComponent();
        }
        private void AddInfo(int id, string name, string mobile, double gpa)
        {
            ids.Add(id);
            names.Add(name);
            mobiles.Add(mobile);
            ages.Add(Convert.ToInt32(ageTextBox.Text));
            addresses.Add(addressTextBox.Text);
            gpas.Add(gpa);
            string message = "";
            for (int i = 0; i < ids.Count(); i++)
            {
                message += "ID: " + ids[i] + "\n";
                message += "Name: " + names[i] + "\n";
                message += "Mobile: " + mobiles[i] + "\n";
                message += "Age: " + ages[i] + "\n";
                message += "Address" + addresses[i] + "\n";
                message += "GPA: " + gpas[i] + "\n";

            }

            MessageBox.Show("Information Added Successfully");
            informationRichTextBox.Text += (message);


        }

        private void ShowInfo()
        {

            string message = "";
            for (int j = 0; j < ids.Count(); j++)
            {
                message += "ID: " + ids[j] + "\n";
                message += "Name: " + names[j] + "\n";
                message += "Mobile: " + mobiles[j] + "\n";
                message += "Age: " + ages[j] + "\n";
                message += "Address: " + addresses[j] + "\n";
                message += "GPA: " + gpas[j] + "\n";

            }
            int totalAdded = ids.Count();

            informationRichTextBox.Text += ("\nTotal Number of Customer: " + totalAdded + "\n" + message);
        }
        private void GPAInfo()
        {
            double max = gpas.Max();
            double min = gpas.Min();
            double total = gpas.Sum();
            int con = gpas.Count();
            double average = total / con;
            averageTextBox.Text = Convert.ToString(average);
            totalTextBox.Text = Convert.ToString(total);
            try
            {
                if (gpas.Contains(max))
                {
                    maxTextBox.Text = Convert.ToString(max);
                    int i = gpas.IndexOf(max);
                    gpaMaxNameTextBox.Text = Convert.ToString(names[i]);
                }
                if (gpas.Contains(min))
                {
                    minTextBox.Text = Convert.ToString(min);
                    int j = gpas.IndexOf(min);
                    gpaMinNameTextBox.Text = Convert.ToString(names[j]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            informationRichTextBox.Text = "Information here: ";
            try
            {
                if (ids.Contains(Convert.ToInt32(idTextBox.Text)) == true)
                {
                    MessageBox.Show("ID Already Exist");

                }
                else if ((idTextBox.Text).Length < 4)
                {
                    MessageBox.Show("ID Must Be 4 Characters");
                }
                else if ((idTextBox.Text).Length > 4)
                {
                    MessageBox.Show("ID Must Be 4 Characters");
                }
                else if ((nameTextBox.Text).Length > 30)
                {
                    MessageBox.Show("Name Must Be 30 Characters");
                }

                else if (mobiles.Contains(mobileTextBox.Text) == true)
                {
                    MessageBox.Show("Number Already Exist");
                }
                else if ((mobileTextBox.Text).Length > 11)
                {
                    MessageBox.Show("Number Must Be 11 Digit");
                }
                else if ((mobileTextBox.Text).Length < 11)
                {
                    MessageBox.Show("Number Must Be 11 Digit");
                }
                else if (Convert.ToDouble(gpaPointTextBox.Text) < 0)
                {
                    MessageBox.Show("GPA Must Be Greater Than 0");
                }
                else if (Convert.ToDouble(gpaPointTextBox.Text) > 4)
                {
                    MessageBox.Show("GPA Must Be Less Than 4");
                }
                else
                {
                    AddInfo(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, mobileTextBox.Text, Convert.ToDouble(gpaPointTextBox.Text));
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaPointTextBox.Text = "";

        }

        private void SearchInfo()
        {
            if (idRadioButton.Checked)
            {

                try
                {
                    if (ids.Contains(Convert.ToInt32(idTextBox.Text)))
                    {
                        int i = ids.IndexOf(Convert.ToInt32(idTextBox.Text));
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("ID Not Exists");
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
            else if (nameRadioButton.Checked)
            {
                try
                {
                    if (names.Contains(nameTextBox.Text))
                    {
                        int i = names.IndexOf(nameTextBox.Text);
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("Name Not Exists");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else if (mobileRadioButton.Checked)
            {
                try
                {
                    if (mobiles.Contains(mobileTextBox.Text))
                    {
                        int i = mobiles.IndexOf(mobileTextBox.Text);
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("Mobile Number Not Exists");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaPointTextBox.Text = "";
            informationRichTextBox.Text = "Information";
            try
            {
                ShowInfo();
                GPAInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            informationRichTextBox.Text = "Information";
            try
            {
                SearchInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

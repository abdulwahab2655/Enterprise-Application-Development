using System.Collections;
using System.Collections.Generic;

namespace EAD_Assignment_1
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string subjects;
        List<string> textbooks;
        string prerequisiteClear;

        public Form1()
        {
            InitializeComponent();
            textbooks = new List<string>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textBoxFname.Text;
            lastName = textBoxLname.Text;
            subjects = textBoxMulti.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(subjects))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            int lines = textBoxMulti.Lines.Length;

            if (lines < 2)
            {
                MessageBox.Show("Please enter at least two courses.");
                return;
            }

            //Add textbooks to the List
            textbooks.AddRange(textBoxMulti.Lines);

            prerequisiteClear = checkBoxPrerequisite.Checked ? "Yes" : "No";
            string result = $"Registered Details!!\nStudent Name: {firstName} {lastName}\nEnrolled Courses: {string.Join(", ", textbooks)}\nPrerequisite Cleared: {prerequisiteClear}";

            resultLabel.Text = result;
        }

        private void checkedListBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPrerequisite_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void labelSubject_Click(object sender, EventArgs e)
        {
        }

        private void labelLname_Click(object sender, EventArgs e)
        {
        }

        private void labelFname_Click(object sender, EventArgs e)
        {
        }

        private void textBoxLname_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxMulti_TextChanged(object sender, EventArgs e)
        {
        }
    
    }
}
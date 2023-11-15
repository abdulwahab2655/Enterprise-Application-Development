using System.Collections;

namespace EAD_Assignment_1
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string subjects;
        ArrayList textbooks;
        string prerequisiteClear;

        public Form1()
        {
            InitializeComponent();
            textbooks = new ArrayList();
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
            int lines = textBoxMulti.Lines.Count();
            if (lines < 2)
            {
                MessageBox.Show("Please enter at least two courses.");
                return;
            }
            foreach (string line in textBoxMulti.Lines)
            {
                textbooks.Add(line);
            }

            string prerequisiteClear = checkBoxPrerequisite.Checked ? "Yes" : "No";
            string result = $"Registered Details!!\nStudent Name: {firstName} {lastName}\nEnrolled Courses: {string.Join(", ", textbooks.ToArray())}\nPrerequisite Cleared: {prerequisiteClear}";


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
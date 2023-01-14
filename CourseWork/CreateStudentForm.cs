using StudentGroupsLibrary;
using StudentGroupsLibrary.DataAccess;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CreateStudentForm : Form
    {
        // create a variable at the class level to store what is passed in our constructor
        // in order to intigrate the create student to the create group form and group viewer form
        IStudentRequester callingForm;
        public CreateStudentForm(IStudentRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            // Create validation
            if (ValidateForm())
            {
                StudentModel model = new StudentModel();
                model.FirstName = FirstNameValue.Text;
                model.LastName = LastNameValue.Text;
                model.EmailAddress = EmailValue.Text;
                model.CellPhoneNumber = PhoneNrValue.Text;
                model.Weighting = WeightingValue.Text;
                model.AssignedGroup = "N/A";
                // Save the Model in the database
                GlobalConfig.Connection.CreateStudent(model);

                // TODO - Wire up the calling interface form
                //Passing the fully completed model back to create group form and group viewer form
                callingForm.StudentComplete(model);

                // Close the window
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        // Validation method
        private bool ValidateForm()
        {
            bool output = true;

            if (FirstNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (EmailValue.Text.Length == 0)
            {
                output = false;
            }
            if (PhoneNrValue.Text.Length == 0)
            {
                output = false;
            }
            if (WeightingValue.Text.Length > 2 || WeightingValue.Text.Length == 0)
            {
                output = false;
            }

            // Percentage validation
            // Convert from string to int
            int.TryParse(WeightingValue.Text, out int Weighting);
            if (Weighting < 0 || Weighting > 100)
            {
                output = false;
            }
            return output;
        }
    }
}

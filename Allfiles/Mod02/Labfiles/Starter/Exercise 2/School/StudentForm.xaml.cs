using System;
using System.Windows;

namespace School
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        #region Predefined code

        public StudentForm()
        {
            InitializeComponent();
        }

        #endregion

        // If the user clicks OK to save the Student details, validate the information that the user has provided
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Exercise 2: Task 2a: Check that the user has provided a first name
            if (String.IsNullOrEmpty(this.firstName.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // TODO: Exercise 2: Task 2b: Check that the user has provided a last name
            if (String.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // TODO: Exercise 2: Task 3a: Check that the user has entered a valid date for the date of birth
            DateTime result;

            if (!DateTime.TryParse(this.dateOfBirth.Text, out result))
            {
                MessageBox.Show("The date of birth must be a valid date", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // TODO: Exercise 2: Task 3b: Verify that the student is at least 5 years old

            // Indicate that the data is valid
            this.DialogResult = true;
        }
    }
}

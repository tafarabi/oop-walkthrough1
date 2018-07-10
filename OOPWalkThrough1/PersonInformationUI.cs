using System;
using System.Windows.Forms;
using OOPWalkThrough1.Model;

namespace OOPWalkThrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }
        Person aPerson = new Person();
        private void showButton_Click(object sender, EventArgs e)
        {
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetReverseName();
        }
    }
}

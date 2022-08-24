using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefoonboek
{
    public partial class EditPersonForm : Form
    {
        private PersonsListForm personsList;
        private Person currentPerson;
        public EditPersonForm(PersonsListForm formNamesList, Person currentPersonData)
        {
            InitializeComponent();
            this.personsList = formNamesList;
            this.currentPerson = currentPersonData;
 
        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {
            // Set textbox values of the current person
            textBoxFirstName.Text = currentPerson.FirstName;
            textBoxLastName.Text = currentPerson.LastName;
            textBoxAge.Text = currentPerson.Age;
            textBoxPhoneNumber.Text = currentPerson.PhoneNumber;
            textBoxEmail.Text = currentPerson.Email;
        }

        private void EditPersonForm_FormClosing(Object sender, FormClosingEventArgs e)// onClosing event
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)// Assume that X has been clicked
            {
                e.Cancel = true;
            }
        }

        private void buttonSavePerson_Click(object sender, EventArgs e)// Save button click event
        {
            Person personUpdated = new Person(); // Create updated person
            personUpdated.FirstName = textBoxFirstName.Text;
            personUpdated.LastName = textBoxLastName.Text;
            personUpdated.Age = textBoxAge.Text;
            personUpdated.PhoneNumber = textBoxPhoneNumber.Text;
            personUpdated.Email = textBoxEmail.Text;

            currentPerson = personsList.UpdatePerson(currentPerson, personUpdated);// Set new values to current person
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)// Delete button click event
        {
            personsList.DeletePerson(currentPerson);// Delete current person
            this.Dispose();
        }

    }
}

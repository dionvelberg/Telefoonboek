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
    public partial class AddPersonForm : Form
    {
        private PersonsListForm personsList;
        public AddPersonForm(PersonsListForm formNamesList)
        {
            InitializeComponent();
            personsList = formNamesList;
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }
        private void AddPersonForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)// Assume that X has been clicked
            {
                e.Cancel = true;
            }
        }
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();// Set values for new Person
            newPerson.FirstName = textBoxFirstName.Text;
            newPerson.LastName = textBoxLastName.Text;
            newPerson.Age = textBoxAge.Text;
            newPerson.PhoneNumber = textBoxPhoneNumber.Text;
            newPerson.Email = textBoxEmail.Text;
            
            personsList.AddNewPerson(newPerson);// Create new Person


        }
    }
}

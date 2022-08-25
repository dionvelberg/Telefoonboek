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
        private PersonsListForm personsListForm;

        public AddPersonForm(PersonsListForm formNamesList)
        {
            
            InitializeComponent();
            personsListForm = formNamesList;
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
            PersonAddress newPersonAddress = new PersonAddress();
            newPerson.FirstName = textBoxFirstName.Text;
            newPerson.LastName = textBoxLastName.Text;
            newPerson.Age = textBoxAge.Text;
            newPerson.PhoneNumber = textBoxPhoneNumber.Text;
            newPerson.Email = textBoxEmail.Text;

            newPersonAddress.zip_code = textBoxZipcode.Text;
            newPersonAddress.house_number = textBoxNumber.Text;
            newPersonAddress.street = textBoxStreet.Text;
            newPersonAddress.city = textBoxCity.Text;
            newPersonAddress.longitude = textBoxLongitude.Text;
            newPersonAddress.latitude = textBoxLatitude.Text;
            newPersonAddress.province = textBoxProvince.Text;
            newPerson.Address = newPersonAddress;
            
            personsListForm.AddNewPerson(newPerson);// Create new Person


        }

        private async void TextBoxGetAddres_TextChanged(object sender, EventArgs e)// textBoxPostcode or textBoxNumber onChange event
        {
            if ( !String.IsNullOrWhiteSpace(textBoxZipcode.Text) && !String.IsNullOrWhiteSpace(textBoxNumber.Text) )
            {
                string number = textBoxNumber.Text;// Get house number
                string zipcode = textBoxZipcode.Text;// Get zipcode
                PersonAddress result = await personsListForm.getPersonAddressClient.GetPersonAddress(zipcode, number);//Get Request person address

                //Set Address values
                textBoxStreet.Text = result?.street ?? "";
                textBoxCity.Text = result?.city ?? "";
                textBoxProvince.Text = result?.province ?? "";
                textBoxLongitude.Text = result?.longitude ?? "";
                textBoxLatitude.Text = result?.latitude ?? "";
            }
                
        }
    }
}

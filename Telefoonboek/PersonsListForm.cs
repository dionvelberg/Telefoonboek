using System;
using System.Collections;

namespace Telefoonboek
{
    public partial class PersonsListForm : Form
    {
        private AddPersonForm addPersonForm;
        private EditPersonForm editPersonForm;
        public GetPersonAddressClient getPersonAddressClient;
        private List<Person> PersonsList = new List<Person>();// Declare names & initialize names with default values
        public PersonsListForm()
        {
            InitializeComponent();
            getPersonAddressClient = new GetPersonAddressClient();
            addPersonForm = new AddPersonForm(this);
            editPersonForm = new EditPersonForm(this,null);
        }

        private void PersonsListForm_Load(object sender, EventArgs e)
        {
        }

        private void ShowNamesBtn_Click(object sender, EventArgs e)// Show button click event
        {
            string line;
            StreamReader file = new StreamReader("../../../SavedList.txt");
            while ((line = file.ReadLine()) != null)
            {
                bool isSavedPersonInList = false;
                string[] personData = line.Split(',');
                Person savedPerson = new Person();// Get values of current person
                PersonAddress savedPersonAddress = new PersonAddress();
                savedPerson.FirstName = personData[0];
                savedPerson.LastName = personData[1];
                savedPerson.Age = personData[2];
                savedPerson.PhoneNumber = personData[3];
                savedPerson.Email = personData[4];

                savedPersonAddress.street = personData[5];
                savedPersonAddress.city = personData[6];
                savedPersonAddress.house_number = personData[7];
                savedPersonAddress.zip_code = personData[8];
                savedPersonAddress.longitude = personData[9];
                savedPersonAddress.latitude = personData[10];
                savedPersonAddress.province = personData[11];
                savedPerson.Address = savedPersonAddress;
                foreach (Person item in PersonsList)
                {
                    //Check if it doesn't already exist in 'PersonsList'
                    string itemToLine = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                    item.FirstName,
                    item.LastName,
                    item.Age,
                    item.PhoneNumber,
                    item.Email,
                    item.Address?.street,
                    item.Address?.city,
                    item.Address?.house_number,
                    item.Address?.zip_code,
                    item.Address?.longitude,
                    item.Address?.latitude,
                    item.Address?.province);
                    if (itemToLine == line)
                        isSavedPersonInList = true;
                }
                if(!isSavedPersonInList)
                    PersonsList.Add(savedPerson);
            }
            file.Close();
            SetListBoxNames();// Set current listbox values  
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            StreamWriter saveAll = new StreamWriter("../../../SavedList.txt");

            foreach (Person item in PersonsList)
            {
                //Create line in text file
                saveAll.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", 
                    item.FirstName, 
                    item.LastName, 
                    item.Age, 
                    item.PhoneNumber, 
                    item.Email,
                    item.Address?.street,
                    item.Address?.city,
                    item.Address?.house_number,
                    item.Address?.zip_code,
                    item.Address?.longitude,
                    item.Address?.latitude,
                    item.Address?.province));
            }
            saveAll.Close();
        }

        private void AddPersonBtn_Click(object sender, EventArgs e)// AddPerson button click event
        {
            // Show add person form
            if (addPersonForm.IsDisposed)
                addPersonForm = new AddPersonForm(this);
            addPersonForm.Show();

        }

        private void SortNamesBtn_Click(object sender, EventArgs e)// Sort button click event
        {
            List<Person> sortedList = new List<Person>();// Declare & initialize sortedList
            foreach (Person currentItem in PersonsList)
            {// Add values from current list of names to new list
                sortedList.Add(currentItem
                    );
            }
            sortedList = sortedList.OrderBy(o => o.FirstName).ToList();// Sort new list

            PersonsList.Clear();// Clear current list of names
            foreach (Person sortedItem in sortedList)
            {// Add sorted values to list of names
                PersonsList.Add(sortedItem);
            }
            SetListBoxNames();


        }

        private void SearchNamesBtn_Click(object sender, EventArgs e)// Search button click event
        {
            SearchNames();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)// textBoxSearch onChange event
        {
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {// textBoxSearch is null, empty or consists of whitespaces
                SetListBoxNames();
            }
            else
            {
                SearchNames();
            }
        }

        private void ListViewNames_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)// ListviewItem onClick event
        {

            Person findPerson = new Person();// Get values of current person
            findPerson.FirstName = e.Item.Text;
            findPerson.LastName = e.Item.SubItems[1].Text;
            findPerson.Age = e.Item.SubItems[2].Text;
            findPerson.PhoneNumber = e.Item.SubItems[3].Text;
            findPerson.Email = e.Item.SubItems[4].Text;

            if (e.IsSelected)
            {// Show edit person form
                Person currentPerson = PersonsList.FirstOrDefault(e => (
                e.FirstName == findPerson.FirstName
                && e.LastName == findPerson.LastName
                && e.Age == findPerson.Age
                && e.PhoneNumber == findPerson.PhoneNumber
                && e.Email == findPerson.Email)
                );
                if( currentPerson !=null)
                {
                    editPersonForm.Dispose();
                    editPersonForm = new EditPersonForm(this, currentPerson);
                    editPersonForm.Show();
                }
                
            }
        }

        public void AddNewPerson(Person newPerson)// Add new person
        {
            PersonsList.Add(newPerson);
            SetListBoxNames();
        }

        public Person UpdatePerson(Person oldPerson, Person personUpdated)// Update Person
        {
            // get current person index
            int oldPersonIndex = PersonsList.FindIndex(i =>
            i.FirstName == oldPerson.FirstName &&
            i.LastName == oldPerson.LastName &&
            i.Age == oldPerson.Age &&
            i.PhoneNumber == oldPerson.PhoneNumber &&
            i.Email == oldPerson.Email
            );

            if(oldPersonIndex != -1)// If current person exists in 'PersonsList', update it with new values
            {
                PersonsList[oldPersonIndex] = personUpdated;
                SetListBoxNames();
            }
            return personUpdated;
        }

        public void DeletePerson(Person currentPerson) 
        {
            // get current person index
            int currentPersonIndex = PersonsList.FindIndex(i =>
            i.FirstName == currentPerson.FirstName &&
            i.LastName == currentPerson.LastName &&
            i.Age == currentPerson.Age &&
            i.PhoneNumber == currentPerson.PhoneNumber &&
            i.Email == currentPerson.Email
            );

            if (currentPersonIndex != -1)// If current person exists in 'PersonsList', delete it
            {
                PersonsList.RemoveAt(currentPersonIndex);
                SetListBoxNames();
            }
        }

        private void SearchNames()
        {// Search Names
            string searchInput = textBoxSearch.Text.ToLower();// Get textBoxSearch input
            List<Person> tempNamesList = PersonsList;// tempNamesList to display results only
            if (!String.IsNullOrWhiteSpace(searchInput))// Check if there's a value
            {
                listViewNames.Items.Clear();// Reset Listview values
                foreach (Person name in tempNamesList)
                { // Transfer tempNamesList to the Listview
                    if (name.FirstName.ToLower().Contains(searchInput))
                    {
                        ListViewItem newItem = new ListViewItem(name.FirstName);
                        newItem.SubItems.Add(name.LastName);
                        newItem.SubItems.Add(name.Age);
                        newItem.SubItems.Add(name.PhoneNumber);
                        newItem.SubItems.Add(name.Email);
                        listViewNames.Items.Add(newItem);
                    }
                }
            }
        }

        private void SetListBoxNames()// Set Listbox values
        {
            listViewNames.Items.Clear();// Reset Listview
            foreach (Person name in PersonsList)
            { // Transfer namesList to the Listview
                ListViewItem newItem = new ListViewItem(name.FirstName);
                newItem.SubItems.Add(name.LastName);
                newItem.SubItems.Add(name.Age);
                newItem.SubItems.Add(name.PhoneNumber);
                newItem.SubItems.Add(name.Email);
                listViewNames.Items.Add(newItem);
            }
        }

        private void ListViewNames_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ListViewNames_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
using System;
using System.Collections;

namespace Telefoonboek
{
    public partial class PersonsListForm : Form
    {
        private AddPersonForm addPersonForm;
        private EditPersonForm editPersonForm;
        private List<Person> Personen = new List<Person>();// Declare names & initialize names with default values
        public PersonsListForm()
        {
            InitializeComponent();
            addPersonForm = new AddPersonForm(this);
            editPersonForm = new EditPersonForm(this, new Person());
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
                savedPerson.FirstName = personData[0];
                savedPerson.LastName = personData[1];
                savedPerson.Age = personData[2];
                savedPerson.PhoneNumber = personData[3];
                savedPerson.Email = personData[4];
                foreach (Person item in Personen)
                {
                    //Check if it doesn't already exist in 'Listview'
                    string itemToLine = String.Format("{0},{1},{2},{3},{4}", item.FirstName, item.LastName, item.Age, item.PhoneNumber, item.Email);
                    if (itemToLine == line)
                        isSavedPersonInList = true;
                }
                if(!isSavedPersonInList)
                    Personen.Add(savedPerson);
            }
            file.Close();
            SetListBoxNames();// Set current listbox values  
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            StreamWriter saveAll = new StreamWriter("../../../SavedList.txt");

            foreach (Person item in Personen)
            {
                saveAll.WriteLine(String.Format("{0},{1},{2},{3},{4}", item.FirstName, item.LastName, item.Age, item.PhoneNumber, item.Email));
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
            foreach (Person currentItem in Personen)
            {// Add values from current list of names to new list
                sortedList.Add(currentItem
                    );
            }
            sortedList = sortedList.OrderBy(o => o.FirstName).ToList();// Sort new list

            Personen.Clear();// Clear current list of names
            foreach (Person sortedItem in sortedList)
            {// Add sorted values to list of names
                Personen.Add(sortedItem);
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
            Person currentPerson = new Person();// Get values of current person
            currentPerson.FirstName = e.Item.Text;
            currentPerson.LastName = e.Item.SubItems[1].Text;
            currentPerson.Age = e.Item.SubItems[2].Text;
            currentPerson.PhoneNumber = e.Item.SubItems[3].Text;
            currentPerson.Email = e.Item.SubItems[4].Text;

            if (e.IsSelected)
            {// Show edit person form
                editPersonForm = new EditPersonForm(this,currentPerson);
                editPersonForm.Show();
            }
        }

        public void AddNewPerson(Person newPerson)// Add new person
        {
            Personen.Add(newPerson);
            SetListBoxNames();
        }

        public Person UpdatePerson(Person oldPerson, Person personUpdated)// Update Person
        {
            // get current person index
            int oldPersonIndex = Personen.FindIndex(i =>
            i.FirstName == oldPerson.FirstName &&
            i.LastName == oldPerson.LastName &&
            i.Age == oldPerson.Age &&
            i.PhoneNumber == oldPerson.PhoneNumber &&
            i.Email == oldPerson.Email
            );

            if(oldPersonIndex != -1)// If current person exists in 'Personen', update it with new values
            {
                Personen[oldPersonIndex] = personUpdated;
                SetListBoxNames();
            }
            return personUpdated;
        }

        public void DeletePerson(Person currentPerson) 
        {
            // get current person index
            int currentPersonIndex = Personen.FindIndex(i =>
            i.FirstName == currentPerson.FirstName &&
            i.LastName == currentPerson.LastName &&
            i.Age == currentPerson.Age &&
            i.PhoneNumber == currentPerson.PhoneNumber &&
            i.Email == currentPerson.Email
            );

            if (currentPersonIndex != -1)// If current person exists in 'Personen', delete it
            {
                Personen.RemoveAt(currentPersonIndex);
                SetListBoxNames();
            }
        }

        private void SearchNames()
        {// Search Names
            string searchInput = textBoxSearch.Text.ToLower();// Get textBoxSearch input
            List<Person> tempNamesList = Personen;// tempNamesList to display results only
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
            foreach (Person name in Personen)
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
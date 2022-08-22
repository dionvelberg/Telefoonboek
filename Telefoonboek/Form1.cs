using System.Collections;

namespace Telefoonboek
{
    public partial class Form1 : Form
    {
        private List<Persoon> Personen = new List<Persoon>();// Declare names & initialize names with default values
        public Form1()
        {
            InitializeComponent();
            Personen.Add(new Persoon() { FirstName="Frits"});
            Personen.Add(new Persoon() { FirstName = "Joost" });
            Personen.Add(new Persoon() { FirstName = "Karin" });
        }

        private void ShowNamesBtn_Click(object sender, EventArgs e)// Show button click event
        {
            SetListBoxNames();// Set current listbox values
        }

        private void AddNameBtn_Click(object sender, EventArgs e)// Add button click event
        {
            string newName = textBoxAddName.Text;// Get textboxAddName input
            if (!String.IsNullOrWhiteSpace(newName))// Check if there's a value
            {
                Personen.Add(new Persoon() { FirstName=newName});// Add input to namesList
                SetListBoxNames();
                textBoxAddName.Clear();// Reset textbox
            }
        }

        private void SortNamesBtn_Click(object sender, EventArgs e)// Sort button click event
        {
            List<Persoon> sortedList = new List<Persoon>();// Declare & initialize sortedList
            foreach (Persoon currentItem in Personen)
            {// Add values from current list of names to new list
                sortedList.Add(currentItem
                    );
            }
            sortedList = sortedList.OrderBy(o => o.FirstName).ToList();// Sort new list

            Personen.Clear();// Clear current list of names
            foreach (Persoon sortedItem in sortedList)
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

        private void SearchNames() {// Search Names
            string searchInput = textBoxSearch.Text.ToLower();// Get textBoxSearch input
            List<Persoon> tempNamesList = Personen;// tempNamesList to display results only
            if (!String.IsNullOrWhiteSpace(searchInput))// Check if there's a value
            {
                listBoxNames.Items.Clear();// Reset Listbox values
                foreach (Persoon name in tempNamesList)
                { // Transfer tempNamesList to the Listbox
                    if (name.FirstName.ToLower().Contains(searchInput))
                        listBoxNames.Items.Add("First name: " + name.FirstName +
                    ", Last name: " + name.LastName +
                    ", Age: " + name.Age +
                    ", Phone number: " + name.PhoneNumber +
                    ", Email: " + name.Email
                    );
                }
            }
        }

        private void SetListBoxNames()// Set Listbox values
        {
            listBoxNames.Items.Clear();// Reset Listbox
            foreach (Persoon name in Personen)// Transfer namesList to the Listbox
                listBoxNames.Items.Add("First name: " + name.FirstName + 
                    ", Last name: " + name.LastName + 
                    ", Age: " + name.Age + 
                    ", Phone number: " + name.PhoneNumber +
                    ", Email: " + name.Email
                    );
        }

    }
}
using System.Collections;

namespace Telefoonboek
{
    public partial class Form1 : Form
    {
        private List<string> namesList = new List<string> { "Frits", "Joost", "Karin" };// Declare names & initialize names with default values
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNames_Click(object sender, EventArgs e)// Show button click event
        {
            SetListBoxNames();// Set current listbox values
        }

        private void AddName_Click(object sender, EventArgs e)// Add button click event
        {
            string newName = textBoxAddName.Text;// Get textboxAddName input
            if (!String.IsNullOrWhiteSpace(newName))// Check if there's a value
            {
                namesList.Add(newName);// Add input to namesList
                SetListBoxNames();
                textBoxAddName.Clear();// Reset textbox
            }
        }

        private void SortNames_Click(object sender, EventArgs e)// Sort button click event
        {
            List<string> sortedList = new List<string>();// Declare & initialize sortedList
            foreach (string currentItem in namesList)
            {// Add values from current list of names to new list
                sortedList.Add(currentItem);
            }
            sortedList.Sort();// Sort new list

            namesList.Clear();// Clear current list of names
            foreach (string sortedItem in sortedList)
            {// Add sorted values to list of names
                namesList.Add(sortedItem);
            }
            SetListBoxNames();


        }

        private void SearchNames_Click(object sender, EventArgs e)// Search button click event
        {
            string searchInput = textBoxSearch.Text;// Get textBoxSearch input
            List<string> tempNamesList = namesList;// tempNamesList to display results only
            if (!String.IsNullOrWhiteSpace(searchInput))// Check if there's a value
            {
                listBoxNames.Items.Clear();// Reset Listbox values
                foreach (String name in tempNamesList) 
                { // Transfer tempNamesList to the Listbox
                    if(name.Contains(searchInput))
                        listBoxNames.Items.Add("Student: " + name);
                }
            }
        }

        private void SetListBoxNames()// Set Listbox values
        {
            listBoxNames.Items.Clear();// Reset Listbox
            foreach (String name in namesList)// Transfer namesList to the Listbox
                listBoxNames.Items.Add("Student: " + name);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)// textBoxSearch onChange event
        {
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text)) {// textBoxSearch is null, empty or consists of whitespaces
                SetListBoxNames();
            }
        }
    }
}
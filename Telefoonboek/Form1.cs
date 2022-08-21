using System.Collections;

namespace Telefoonboek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNames_Click(object sender, EventArgs e)// Show button click event
        {
            string[] names = { "Frits", "Joost", "Karin" };// Declare names & initialize names with default values
            foreach (String name in names)// Add each name to the listbox
                listBoxNames.Items.Add("Student: " + name);
        }

        private void AddName_Click(object sender, EventArgs e)// Add button click event
        {
            string newName = textBoxAddName.Text;// Get textbox input
            if (newName.Length > 0)// Check if not empty
            {
                listBoxNames.Items.Add("Student: " + newName);// Add input to listbox
                textBoxAddName.Text = "";// Reset textbox
            }
        }

        private void SortNames_Click(object sender, EventArgs e)// Sort button click event
        {
            ArrayList sortedList = new ArrayList();// Declare & initialize sortedList
            foreach (Object o in listBoxNames.Items) {// Add values from current list of names to new list
                sortedList.Add(o);
            }
            sortedList.Sort();// Sort new list

            listBoxNames.Items.Clear();// Clear current list of names
            foreach (Object o in sortedList) {// Add sorted values to list of names
                listBoxNames.Items.Add(o);
            }
            
        }
    }
}
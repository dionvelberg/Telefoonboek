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
            foreach (String name in names)// Foreach to add each name to the listbox
                listBoxNames.Items.Add("Student: " + name);
        }

        private void AddName_Click(object sender, EventArgs e)// Add button click event
        {
            string newName = textBoxAddName.Text;// Get textbox input
            listBoxNames.Items.Add("Student: " + newName);// Add input to listbox
        }

    }
}
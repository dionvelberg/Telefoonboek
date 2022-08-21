namespace Telefoonboek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNames_Click(object sender, EventArgs e)
        {
            string[] names = { "Frits", "Joost", "Karin" };
            foreach (String name in names)
                listBoxNames.Items.Add("Student: " + name);
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            string newName = textBoxAddName.Text;
            listBoxNames.Items.Add("Student: " + newName);
        }

    }
}
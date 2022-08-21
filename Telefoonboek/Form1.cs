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
            String[] names = { "Frits", "Joost", "Karin" };
            foreach (String name in names)
                listBoxNames.Items.Add("Student: " + name);
        }
    }
}
namespace ClickerCount
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
            Click += new EventHandler(ClickHandler);
        }
        private void ClickHandler(object sender, EventArgs e)
        {
            n++;
            label2.Text = n.ToString();
        }
    }
}
namespace DapperTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }   

        private void ok_btn_Click(object sender, EventArgs e)
        {
            bool check = byte.TryParse(prodcost_tbox.Text, out byte result);

            if (check && result < 100)
            { 
                DialogResult = DialogResult.Yes; 
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

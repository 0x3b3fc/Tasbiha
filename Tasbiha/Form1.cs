namespace Tasbiha
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        int k = 0;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_sobhan_Click(object sender, EventArgs e)
        {
            i = i + 1;
            lbl_sobhan.Text = i.ToString();
            counter = counter + 1;
            if (i == 33)
            {
                i = 0;
            }
            lbl_counter.Text = counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_hamd_Click(object sender, EventArgs e)
        {
            j = j + 1;
            lbl_hamd.Text = j.ToString();
            counter = counter + 1;
            if (j == 33)
            {
                j = 0;
            }
            lbl_counter.Text = counter.ToString();
        }

        private void btn_akbar_Click(object sender, EventArgs e)
        {

            k = k + 1;
            lbl_akbar.Text = k.ToString();
            counter = counter + 1;
            if (k == 33)
            {
                k = 0;
            }
            lbl_counter.Text = counter.ToString();
        }

        private void lbl_counter_Click(object sender, EventArgs e)
        {


        }
    }
}
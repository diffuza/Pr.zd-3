namespace Практика_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void чёрныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Black;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Blue ;
        }

        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Green;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // эта строка - ваш введенный код
        }
    }

}
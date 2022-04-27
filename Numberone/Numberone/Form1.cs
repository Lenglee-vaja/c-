namespace Numberone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ວິທີດື່ງຂໍ້ມູນມາຈາກ textBox
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            //ການຄຳນວນຈະຕ້ອງເປັນຕົວເລກເທົ່ານັ້ນ int, double

            int n1 = Convert.ToInt32(num1);//int n1 = Convert.Toint32(textBox1.Text);
            int n2 = Convert.ToInt32(num2);

            //ຄຳນວນຜົນບວກ ເເລ້ວໄປສະເເດງໃນ textBox
            int ans = n1 + n2;
            textBox3.Text = ans.ToString();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "ບວກ";
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "+";
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.LightGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ວິທີດື່ງຂໍ້ມູນມາຈາກ textBox
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            //ການຄຳນວນຈະຕ້ອງເປັນຕົວເລກເທົ່ານັ້ນ int, double

            int n1 = Convert.ToInt32(num1);//int n1 = Convert.Toint32(textBox1.Text);
            int n2 = Convert.ToInt32(num2);

            //ຄຳນວນຜົນລົບ ເເລ້ວໄປສະເເດງໃນ textBox
            int ans = n1 - n2;
            textBox3.Text = ans.ToString();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Text = "ລົບ";
            button4.ForeColor = Color.Black;
            button4.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Text = "-";
            button4.ForeColor = Color.Black;
            button4.BackColor = Color.LightGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ວິທີດື່ງຂໍ້ມູນມາຈາກ textBox
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            //ການຄຳນວນຈະຕ້ອງເປັນຕົວເລກເທົ່ານັ້ນ int, double

            int n1 = Convert.ToInt32(num1);//int n1 = Convert.Toint32(textBox1.Text);
            int n2 = Convert.ToInt32(num2);

            //ຄຳນວນຜົນຄູນ ເເລ້ວໄປສະເເດງໃນ textBox
            int ans = n1 * n2;
            textBox3.Text = ans.ToString();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Text = "ຄູນ";
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "*";
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ວິທີດື່ງຂໍ້ມູນມາຈາກ textBox
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            //ການຄຳນວນຈະຕ້ອງເປັນຕົວເລກເທົ່ານັ້ນ int, double

            int n1 = Convert.ToInt32(num1);//int n1 = Convert.Toint32(textBox1.Text);
            int n2 = Convert.ToInt32(num2);

            //ຄຳນວນຜົນຫານ ເເລ້ວໄປສະເເດງໃນ textBox
            int ans = n1 / n2;
            textBox3.Text = ans.ToString();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Text = "ຫານ";
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "/";
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.LightGray;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
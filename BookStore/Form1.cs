namespace BookStore
{
    public partial class Form1 : Form
    {
        //declaring the variable
        public double[] priceWithIndexedBook = { 12.99, 5.99, 8.99, 12.99 };
        public double total=0.0d, afterTotal=0.0d, currentPrice=0.0d, discount, countItem=0, totalCount=0;

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try//try catch to convert the value
            {
                if (Double.Parse(textBox1.Text) == Int32.Parse(textBox1.Text))//checking whether its integer or not
                {
                    countItem = Convert.ToInt32(textBox1.Text);//converting ot the integer
                    totalCount += countItem;
                    total += countItem * currentPrice;
                    discount = getDiscountPercent() * total;
                    afterTotal = total - discount;
                    if (radioButton2.Checked == false)
                    {
                        afterTotal = afterTotal + (0.06 * afterTotal);
                    }
                    label2.Text = afterTotal.ToString();
                }
                else
                {
                    MessageBox.Show("error in quantity", "R n R Book Summary");
                }
            }
            catch
            {
                MessageBox.Show("error in quantity", "R n R Book Summary");
            }
           
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//exit the program without error
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales Total:" + afterTotal + "\nSales Count:" + totalCount + "\nTotal of " + radioButton1.Text + " discount:" + discount,"R n R Book Summary");//display message box
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
                currentPrice = priceWithIndexedBook[listBox1.SelectedIndex];
                textBox3.Text = listBox1.SelectedItem.ToString();
                textBox2.Text = currentPrice.ToString();
        }
        //private method to get discound percent
        private double getDiscountPercent()
        {
            if (radioButton1.Checked == true)
            {
                return 0.15;
            }
            else if (radioButton2.Checked == true)
            {
                return 0.20;
            }
            else if (radioButton3.Checked == true)
            {
                return 0.10;
            }else if(radioButton4.Checked == true)
            {
                return 0.40;
            }
            else
            {
                return 0.10;
            }
     
        }
    }
}
namespace calculator
{
    public partial class Form1 : Form
    {

        string input = "";
        double expressionFirst;
        double expressionSecond;
        int action = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void seven_Click(object sender, EventArgs e)
        {
            input = input + "7";
            label1.Text = input;
            label2.Text = "";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input = input + "8";
            label1.Text = input;
            label2.Text = "";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input = input + "9";
            label1.Text = input;
            label2.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {   if(action==0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 4;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 4;
            }
            
        }

        private void four_Click(object sender, EventArgs e)
        {
            input = input + "4";
            label1.Text = input;
            label2.Text = "";
        }

        private void five_Click(object sender, EventArgs e)
        {
            input = input + "5";
            label1.Text = input;
            label2.Text = "";
        }

        private void six_Click(object sender, EventArgs e)
        {
            input = input + "6";
            label1.Text = input;
            label2.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if(action==0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 3;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 3;
            }
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            input = input + "1";
            label1.Text = input;
            label2.Text = "";
        }

        private void two_Click(object sender, EventArgs e)
        {
            input = input + "2";
            label1.Text = input;
            label2.Text = "";
        }

        private void three_Click(object sender, EventArgs e)
        {
            input = input + "3";
            label1.Text = input;
            label2.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input = "";
            label1.Text = input;
            label2.Text = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input = input + "0";
            label1.Text = input;
            label2.Text = "";
        }

        private void answer_Click(object sender, EventArgs e)
        {
            
            double answer;
            expressionSecond = Convert.ToDouble(input);
            input = "";
            switch(action)
            {
                case 1:
                    answer = expressionFirst + expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    action = 0;
                    break;
                case 2:
                    answer = expressionFirst - expressionSecond;
                    label2.Text =   Convert.ToString(answer);
                    action = 0;
                    break;
                case 3:
                    answer = expressionFirst * expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    action = 0;
                    break;
                case 4:
                    answer = expressionFirst / expressionSecond;
                    label2.Text = Convert.ToString(answer);
                    action = 0;
                    break;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(action== 0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 1;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 1;
            }
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if(action==0)
            {
                expressionFirst = Convert.ToDouble(input);
                action = 2;
                label1.Text = input;
                input = "";
            }
            else
            {
                action = 2;
            }
           
        }
    }
}
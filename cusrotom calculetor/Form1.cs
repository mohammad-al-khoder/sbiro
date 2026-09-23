namespace cusrotom_calculetor
{
    public partial class Form1 : Form
    {
        string output = "";
        double n1 = 0;
        double n2 = 0;
        double n3 = 0;
        char op1;
        char op2;
        int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output += "2";
            text_input.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_equ_Click(object sender, EventArgs e)
        {
            if (text_input.Text == "") return;



            if (step == 2)
            {
                n2 = double.Parse(text_input.Text);
                double result = 0;

                if (op1 == '+') result = n1 + n2;
                if (op1 == '-') result = n1 - n2;
                if (op1 == '*') result = n1 * n2;
                if (op1 == '/') result = n1 / n2;

                text_input.Text = result.ToString();

            }
            else if (step == 3)
            {
                n3 = double.Parse(text_input.Text);

                double temp = 0;
                double result = 0;

                if (op2 == '*' || op2 == '/')
                {
                    if (op2 == '*') temp = n2 * n3;
                    else temp = n2 / n3;

                    if (op1 == '+') result = n1 + temp;
                    if (op1 == '-') result = n1 - temp;
                    if (op1 == '*') result = n1 * temp;
                    if (op1 == '/') result = n1 / temp;
                }


                text_input.Text = result.ToString();
            }

            step = 1;
        }

        private void text_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            output += "0";
            text_input.Text = output;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            output += "1";
            text_input.Text = output;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            output += "3";
            text_input.Text = output;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            output += "4";
            text_input.Text = output;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            output += "5";
            text_input.Text = output;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            output += "6";
            text_input.Text = output;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            output += "7";
            text_input.Text = output;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            output += "8";
            text_input.Text = output;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            output += "9";
            text_input.Text = output;
        }

        private void btn_x_Click(object sender, EventArgs e)
        {

            if (step == 1)
            {
                n1 = Convert.ToDouble(text_input.Text);
                op1 = '*';

                output = "";
                text_input.Text = "";
                step = 2;
            }
            else if (step == 2)
            {
                n2 = Convert.ToDouble(text_input.Text);
                if (op1 == '+') n1 = n1 + n2;
                if (op1 == '-') n1 = n1 - n2;
                if (op1 == '/') n1 = n1 / n2;
                if (op1 == '*') n1 = n1 * n2;

                output = "";
                op1 = '*';
                text_input.Text = "";


            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

            if (step == 1)
            {
                n1 = Convert.ToDouble(text_input.Text);
                op1 = '/';

                output = "";
                text_input.Text = "";
                step = 2;
            }
            else if (step == 2)
            {
                {
                    n2 = Convert.ToDouble(text_input.Text);
                    if (op1 == '+') n1 = n1 + n2;
                    if (op1 == '-') n1 = n1 - n2;
                    if (op1 == '/') n1 = n1 / n2;
                    if (op1 == '*') n1 = n1 * n2;
                    op1 = '/';
                    text_input.Text = "";
                    output = "";

                }
            }
        }

            private void btn_plus_Click(object sender, EventArgs e)
            {

                if (step == 1)
                {
                    n1 = Convert.ToDouble(text_input.Text);
                    op1 = '+';
                    output = "";
                    text_input.Text = "";


                    text_input.Text = "";
                    step = 2;
                }
                else if (step == 2)
                { n2 = Convert.ToDouble(text_input.Text);
                    if (op1 == '+') n1 = n1 + n2;
                    if (op1 == '-') n1 = n1 - n2;
                    if (op1 == '/') n1 = n1 / n2;
                    if (op1 == '*') n1 = n1 * n2;
                    op1 = '+';
                    output = "";
                    text_input.Text = "";


                }
            }

            private void btn_min_Click(object sender, EventArgs e)
            {

                if (step == 1)
                {
                    n1 = Convert.ToDouble(text_input.Text);
                    op1 = '-';
                    text_input.Text = "";
                    output = "";

                    step = 2;
                }
                else if (step == 2)
                {
                    {
                        n2 = Convert.ToDouble(text_input.Text);
                        if (op1 == '+') n1 = n1 + n2;
                        if (op1 == '-') n1 = n1 - n2;
                        if (op1 == '/') n1 = n1 / n2;
                        if (op1 == '*') n1 = n1 * n2;
                        op1 = '-';
                        text_input.Text = "";
                        output = "";


                    }
                }
            }

                private void btn_remov_Click(object sender, EventArgs e)
                {
                    if (text_input.Text.Length > 0)
                    {
                        text_input.Text = text_input.Text.Remove(text_input.Text.Length - 1, 1);
                        output = text_input.Text;
                    }
                }

                private void btn_dot_Click(object sender, EventArgs e)
                {
                    output += ".";
                    text_input.Text = output;
                }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_input.Text.Length > 0)
            {
                text_input.Text = text_input.Text.Remove(text_input.Text.Length - 100);
                output = text_input.Text;
            }
        }
    }
        } 


//this . hide   لاخفاء الفورم السابقة
// name of form .showdialog();

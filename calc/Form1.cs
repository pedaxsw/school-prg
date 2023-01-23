namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int answer;
        int num1;
        int num2;
        string option;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vysledek_TextChanged(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

            if (option == "+")
                answer = num1 + num2;
            else if (option == "-")
                answer = num1 - num2;
            else if (option == "*")
                answer = num1 * num2;
            else if (option == "/")
                answer = num1 / num2;
            else
                answer = 404;


            vysledek.Text = answer;
        }

        private void vyber_SelectedIndexChanged(object sender, EventArgs e)
        {
            option = vyber.Text;
        }
    }
}
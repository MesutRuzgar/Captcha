namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            

            Random  r = new Random();
            int s1,s2,s3,s4,s5;
            
            s1=r.Next(0,sembol1.Length);
            s2=r.Next(0,sembol2.Length);
            s3 = r.Next(0, 10);
            s4=r.Next(0,5);
            s5=r.Next(0,sembol1.Length);
            label2.Visible= true;   
            label2.Text = sembol1[s1].ToString().ToUpper() + sembol2[s2].ToString() + s3.ToString() + s4.ToString() + sembol1[s5].ToString();  

        }
    }
}
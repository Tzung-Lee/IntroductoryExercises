namespace IntroductoryExercises
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Chung_Load(object sender, EventArgs e)
        {

        }

        ///<summary>
        ///�жϼ�λ��������ӡÿһλ
        ///</summary>
        static int CheckDigit1(int num)
        {
            int digit = 0;
            if (num < 10)
            {
                digit = 1;
            }
            if (num == 1)
            {

            }
            return digit;
        }
    }
}
namespace DemoDelegate
{
    public partial class DemoDelegate : Form
    {
        private Dog dog;
        private Master master;
        public DemoDelegate()
        {
            InitializeComponent();
            InitInfo();
        }

        private void InitInfo()
        {
            dog = new Dog();
            dog.Tiao += TiaoMethod;
            master = new Master();
            master.Han += HanMethod;
        }
        private void TiaoMethod()
        {
            this.textBox2.Text = "狗跳了";
        }

        private void HanMethod()
        {
            this.textBox3.Text = "别叫了";
        }

        private void DemoDelegate_Load(object sender, EventArgs e)
        {

        }
        private void MaioMethod(object sender, EventArgs e)
        {
            this.textBox1.Text = "猫在父页面叫了";
            this.dog.DogTiao();
            this.master.HanJiao();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            catForm catForm = new catForm();
            catForm.MiaoAction += MaioMethod;
            catForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

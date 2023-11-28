using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    public partial class catForm : Form
    {
        private Cat cat;
        public event EventHandler MiaoAction;
        public catForm()
        {
            InitializeComponent();
            InitInfo();
        }

        private void InitInfo()
        {
            cat = new Cat();
            cat.Miao += MaioMethod;

        }

        private void MaioMethod()
        {
            textBox1.Text = "猫叫了";
            var action = MiaoAction;
            if (action != null)
            {
                action(cat, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cat.MiaoMiao();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void catForm_Load(object sender, EventArgs e)
        {

        }
    }
}

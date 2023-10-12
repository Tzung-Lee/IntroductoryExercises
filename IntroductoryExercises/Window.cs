using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

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

        /// <summary>
        /// 读取Person信息
        /// </summary>
        /// <returns>Person类</returns>
        public Person GetPersonInfos()
        {
            string strLove = string.Empty;
            foreach (var v in lsvLove.CheckedItems)
            {
                ListViewItem listViewItem = v as ListViewItem;
                strLove += listViewItem.Text.ToString() + "|";
            }
            strLove = strLove.Substring(0, strLove.Length - 1);
            return new Person()
            {
                Name = txtName.Text.Trim().ToString(),
                Birthday = dtBirthday.Value,
                Gender = rbBoy.Checked ? rbBoy.Text : rbGirl.Text,
                Love = strLove,
            };
        }

        /// <summary>
        /// 设置Person信息
        /// </summary>
        /// <returns>Person类</returns>
        public void SetPersonInfos(Person p)
        {
            if (p != null)
            {
                txtName.Text = p.Name;
                dtBirthday.Value = p.Birthday;
                rbBoy.Checked = rbBoy.Text == p.Gender;
                rbGirl.Checked = rbGirl.Text == p.Gender;
                string[] loves = p.Love.Split('|');
                foreach (var love in loves)
                {
                    foreach (var v in lsvLove.Items)
                    {
                        ListViewItem listViewItem = v as ListViewItem;
                        if (love == listViewItem.Text)
                        {
                            listViewItem.Checked = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 读取Person信息
        /// </summary>
        /// <returns>Dictionary类</returns>
        public Dictionary<string, string> GetDictionaryInfos()
        {
            string strLove = string.Empty;
            foreach (var v in lsvLove.CheckedItems)
            {
                ListViewItem listViewItem = v as ListViewItem;
                strLove += listViewItem.Text.ToString() + "|";
            }
            strLove = strLove.Substring(0, strLove.Length - 1);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Love", strLove);
            dic.Add("Name", txtName.Text.Trim().ToString());
            dic.Add("Birthday", dtBirthday.Text);
            dic.Add("Gender", rbBoy.Checked ? rbBoy.Text : rbGirl.Text);
            return dic;
        }

        private void lsvLove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 保存为文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = GetDictionaryInfos();
            string filePath = "Person.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default))
                {
                    foreach (var v in dic)
                    {
                        streamWriter.WriteLine($"{v.Key}={v.Value}");
                    }
                }
            }
        }

        /// <summary>
        /// 读取文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadTxt_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string filePath = "Person.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        dic.Add(line.Split("=")[0], line.Split("=")[1]);
                    }
                }
            }
            txtName.Text = dic["Name"];
            dtBirthday.Text = dic["Birthday"];
            if (dic["Gender"] == rbBoy.Text)
            {
                rbBoy.Checked = true;
            }
            else
            {
                rbGirl.Checked = true;
            }
            foreach (var v in lsvLove.Items)
            {
                foreach (var vi in dic["Love"].Split("|"))
                {
                    ListViewItem listViewItem = v as ListViewItem;
                    if (vi == listViewItem.Text)
                    {
                        listViewItem.Checked = true;
                    }
                }
            }
        }
        /// <summary>
        /// 保存为Xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            Person p = GetPersonInfos();
            string filePath = "Person.xml";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(fileStream, p);
            }
        }

        /// <summary>
        /// 读取xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadXml_Click(object sender, EventArgs e)
        {
            string filePath = "Person.xml";
            Person p =new Person();
            using (FileStream fileStream =new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer=new XmlSerializer(typeof(Person));
                 p = serializer.Deserialize(fileStream) as Person;
            }
            SetPersonInfos(p);
        }

        /// <summary>
        /// 保存Json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            Person person = GetPersonInfos();
            string strJson = JsonSerializer.Serialize(person);
            string filePath = "Person.json";
            using(FileStream fileStream =new FileStream(filePath, FileMode.Create))
            {
                using(StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default))
                {
                    streamWriter.WriteLine(strJson);
                }
            }
        }

        private void btnReadJson_Click(object sender, EventArgs e)
        {
            Person p;
            string filePath = "Person.json";
            using( FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using(StreamReader streamReader = new StreamReader(fileStream,Encoding.Default))
                {
                    string Json = streamReader.ReadToEnd();
                    p =JsonSerializer.Deserialize<Person>(Json);
                }
            }
            SetPersonInfos(p);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            dtBirthday.ResetText();
            rbBoy.Checked = false;
            rbGirl.Checked = false;
            foreach (var v in lsvLove.Items)
            {
                ListViewItem listViewItem = v as ListViewItem;
                listViewItem.Checked = false;
            }
        }

        private void btnSaveBin_Click(object sender, EventArgs e)
        {

        }

        private void btnReadBin_Click(object sender, EventArgs e)
        {

        }

    }
}
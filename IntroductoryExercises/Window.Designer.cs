namespace IntroductoryExercises
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("篮球");
            ListViewItem listViewItem2 = new ListViewItem("足球");
            ListViewItem listViewItem3 = new ListViewItem("排球");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            groupBox1 = new GroupBox();
            lsvLove = new ListView();
            columnHeader1 = new ColumnHeader();
            dtBirthday = new DateTimePicker();
            rbGirl = new RadioButton();
            rbBoy = new RadioButton();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveTxt = new Button();
            btnSaveXml = new Button();
            btnReadTxt = new Button();
            btnReadXml = new Button();
            btnSaveJson = new Button();
            btnReadJson = new Button();
            btnClear = new Button();
            btnSaveBin = new Button();
            btnReadBin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvLove);
            groupBox1.Controls.Add(dtBirthday);
            groupBox1.Controls.Add(rbGirl);
            groupBox1.Controls.Add(rbBoy);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 34);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(581, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "输入区域";
            // 
            // lsvLove
            // 
            lsvLove.AccessibleRole = AccessibleRole.None;
            lsvLove.Alignment = ListViewAlignment.SnapToGrid;
            lsvLove.AutoArrange = false;
            lsvLove.BackColor = SystemColors.Control;
            lsvLove.BorderStyle = BorderStyle.None;
            lsvLove.CheckBoxes = true;
            lsvLove.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            lsvLove.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lsvLove.LabelWrap = false;
            lsvLove.Location = new Point(318, 91);
            lsvLove.Margin = new Padding(4);
            lsvLove.Name = "lsvLove";
            lsvLove.Scrollable = false;
            lsvLove.Size = new Size(187, 30);
            lsvLove.TabIndex = 8;
            lsvLove.UseCompatibleStateImageBehavior = false;
            lsvLove.View = View.List;
            lsvLove.SelectedIndexChanged += lsvLove_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 55;
            // 
            // dtBirthday
            // 
            dtBirthday.Format = DateTimePickerFormat.Short;
            dtBirthday.Location = new Point(318, 24);
            dtBirthday.Margin = new Padding(4);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(186, 23);
            dtBirthday.TabIndex = 7;
            // 
            // rbGirl
            // 
            rbGirl.AutoSize = true;
            rbGirl.Location = new Point(152, 88);
            rbGirl.Margin = new Padding(4);
            rbGirl.Name = "rbGirl";
            rbGirl.Size = new Size(38, 21);
            rbGirl.TabIndex = 6;
            rbGirl.TabStop = true;
            rbGirl.Text = "女";
            rbGirl.UseVisualStyleBackColor = true;
            // 
            // rbBoy
            // 
            rbBoy.AutoSize = true;
            rbBoy.Location = new Point(104, 88);
            rbBoy.Margin = new Padding(4);
            rbBoy.Name = "rbBoy";
            rbBoy.Size = new Size(38, 21);
            rbBoy.TabIndex = 5;
            rbBoy.TabStop = true;
            rbBoy.Text = "男";
            rbBoy.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 24);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(136, 23);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 91);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "爱好：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "生日：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "性别：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // btnSaveTxt
            // 
            btnSaveTxt.Location = new Point(59, 207);
            btnSaveTxt.Margin = new Padding(4);
            btnSaveTxt.Name = "btnSaveTxt";
            btnSaveTxt.Size = new Size(88, 33);
            btnSaveTxt.TabIndex = 1;
            btnSaveTxt.Text = "保存文本";
            btnSaveTxt.UseVisualStyleBackColor = true;
            btnSaveTxt.Click += btnSaveTxt_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.Location = new Point(175, 207);
            btnSaveXml.Margin = new Padding(4);
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(88, 33);
            btnSaveXml.TabIndex = 2;
            btnSaveXml.Text = "保存Xml";
            btnSaveXml.UseVisualStyleBackColor = true;
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // btnReadTxt
            // 
            btnReadTxt.Location = new Point(59, 279);
            btnReadTxt.Margin = new Padding(4);
            btnReadTxt.Name = "btnReadTxt";
            btnReadTxt.Size = new Size(88, 33);
            btnReadTxt.TabIndex = 3;
            btnReadTxt.Text = "读取文本";
            btnReadTxt.UseVisualStyleBackColor = true;
            btnReadTxt.Click += btnReadTxt_Click;
            // 
            // btnReadXml
            // 
            btnReadXml.Location = new Point(175, 279);
            btnReadXml.Margin = new Padding(4);
            btnReadXml.Name = "btnReadXml";
            btnReadXml.Size = new Size(88, 33);
            btnReadXml.TabIndex = 4;
            btnReadXml.Text = "读取Xml";
            btnReadXml.UseVisualStyleBackColor = true;
            btnReadXml.Click += btnReadXml_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.Location = new Point(290, 207);
            btnSaveJson.Margin = new Padding(4);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(88, 33);
            btnSaveJson.TabIndex = 5;
            btnSaveJson.Text = "保存Json";
            btnSaveJson.UseVisualStyleBackColor = true;
            btnSaveJson.Click += btnSaveJson_Click;
            // 
            // btnReadJson
            // 
            btnReadJson.Location = new Point(290, 279);
            btnReadJson.Margin = new Padding(4);
            btnReadJson.Name = "btnReadJson";
            btnReadJson.Size = new Size(88, 33);
            btnReadJson.TabIndex = 6;
            btnReadJson.Text = "读取Json";
            btnReadJson.UseVisualStyleBackColor = true;
            btnReadJson.Click += btnReadJson_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(522, 207);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 33);
            btnClear.TabIndex = 7;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveBin
            // 
            btnSaveBin.Location = new Point(406, 207);
            btnSaveBin.Margin = new Padding(4);
            btnSaveBin.Name = "btnSaveBin";
            btnSaveBin.Size = new Size(88, 33);
            btnSaveBin.TabIndex = 8;
            btnSaveBin.Text = "保存Bin";
            btnSaveBin.UseVisualStyleBackColor = true;
            btnSaveBin.Click += btnSaveBin_Click;
            // 
            // btnReadBin
            // 
            btnReadBin.Location = new Point(406, 279);
            btnReadBin.Margin = new Padding(4);
            btnReadBin.Name = "btnReadBin";
            btnReadBin.Size = new Size(88, 33);
            btnReadBin.TabIndex = 9;
            btnReadBin.Text = "读取Bin";
            btnReadBin.UseVisualStyleBackColor = true;
            btnReadBin.Click += btnReadBin_Click;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 513);
            Controls.Add(btnReadBin);
            Controls.Add(btnSaveBin);
            Controls.Add(btnClear);
            Controls.Add(btnReadJson);
            Controls.Add(btnSaveJson);
            Controls.Add(btnReadXml);
            Controls.Add(btnReadTxt);
            Controls.Add(btnSaveXml);
            Controls.Add(btnSaveTxt);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Window";
            Text = "ChungForm--Welcome";
            Load += Chung_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtBirthday;
        private RadioButton rbGirl;
        private RadioButton rbBoy;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lsvLove;
        private ColumnHeader columnHeader1;
        private Button btnSaveTxt;
        private Button btnSaveXml;
        private Button btnReadTxt;
        private Button btnReadXml;
        private Button btnSaveJson;
        private Button btnReadJson;
        private Button btnClear;
        private Button btnSaveBin;
        private Button btnReadBin;
    }
}
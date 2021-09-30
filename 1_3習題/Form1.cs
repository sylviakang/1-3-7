using System;
using System.Windows.Forms;

namespace _1_3習題
{
    public partial class Form1 : Form
    {
        //宣告全域變數
        PictureBox[] smallPic;
        int startIndex;
        int endIndex;
        int picAmount;

        public Form1()
        {
            InitializeComponent();
            //將表單上的物件加到物件陣列中
            smallPic = new PictureBox[] {___,___,___,___,___,___ };
        }
       
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                startIndex =___;
                endIndex = ___;
                picAmount = ___;
                lbPath.Text = string.Empty;
                pbBig.Image = null;
                showSmallPic();
            }
        }

        void showSmallPic()
        {
            //控制往左按鈕
            if (startIndex == 0) {
                btnLeft.Enabled = ______;
            }
            else if(startIndex != 0)
            {
                btnLeft.Enabled = ______;
            }
            //控制往右按鈕
            if (endIndex ______ picAmount)
            {
                btnRight.Enabled = ___;
                endIndex = ___;
            }
            else
            {
                btnRight.Enabled = ___;
                endIndex = startIndex + ______;         
            }
            //清空小圖片
            for(int i = 0;i <= 5; i++)
            {
                smallPic[___].Image = null;
                smallPic[___].ImageLocation = null;
                smallPic[___].BorderStyle = BorderStyle.None;
                smallPic[___].Enabled = false;
            }
            //根據指標放入圖片
            for (int i = startIndex; i <= endIndex; i++)
            {
                smallPic[___].Load(openFileDialog1.FileNames[___]);
                smallPic[___].BorderStyle = BorderStyle.FixedSingle;
                smallPic[___].Enabled = true;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            //抓取觸發事件的物件圖片與路徑
            pbBig.Image = (____________).Image;
            lbPath.Text = (____________).ImageLocation;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            startIndex = startIndex + ___;
            endIndex = startIndex + ___;
            btnLeft.Enabled = ___;
            showSmallPic();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            startIndex = startIndex - ___;
            endIndex = startIndex + ___;
            btnRight.Enabled = ___;
            showSmallPic();
        }
    }
}
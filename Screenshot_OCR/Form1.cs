using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot_OCR
{
    public partial class Form1 : Form
    {
        #region 전역
        frmSelecter selecter;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selecter = new frmSelecter();  //팝업호출
        }

        /// <summary>
        /// frmSelecter Form을 보여줄때 디자인적으로 칼무리 프로그램처럼 보이게 보여준다
        /// 일반적인 Form의 디자인 X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            selecter.ShowInTaskbar = false;
            selecter.FrameBorderSize = 4;
            selecter.FrameColor = Color.LightGreen;
            selecter.AllowedTransform = true;
            selecter.Show();
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {

        }

       
    }
}

//using IronOcr;
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
            selecter.eScreenInfoSander += Selecter_eScreenInfoSander;  
        }

        //frmSelecter의 Form DoubleClick 일어날시 delegate event값 받음 
        private void Selecter_eScreenInfoSander(object oSender, Dictionary<string, int> dInfo)
        {
            selecter.Opacity = 0;  
            pboxScreen.Image = imgCapture(dInfo["X"], dInfo["Y"], dInfo["W"], dInfo["H"]);  
            selecter.Opacity = 100;  // 캡쳐 작업 완료하면 다시 보임
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
            selecter.FrameBorderSize = 8;
            selecter.FrameColor = Color.LightGreen;
            selecter.AllowedTransform = true;
            selecter.Show();
        }

        // NuGet 에서 IronOcr 설치 필요. 설치 후 // 풀기
        private void btnOCR_Click(object sender, EventArgs e)
        {
          //    Bitmap oc = (Bitmap)pboxScreen.Image;

          //    var Ocr = new IronTesseract();
          //    Ocr.Language = (cboxKOR_ENG.Checked) ? OcrLanguage.Korean : OcrLanguage.English;  // 설정 값이고 코드가 기니까 3항식으로. 언어 지정 확실히 

          //    using (var Input = new OcrInput(oc))
          //    {
          //        var Result = Ocr.Read(Input);
          //        tboxOCR.Text = Result.Text;
          //    }
        }


        #region Inner Function !!
        /// <summary>
        /// 이미지 캡쳐 하는 부분!!★
        /// Window 화면 비율 기준으로 크기만 맞춤
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private Bitmap imgCapture(int x, int y, int w, int h)
        {
            double dRef = GetScreenScalingFactor();  // 화면 비율을 찾아서 맞춰서 크기를 변환 함

            int scPositionX = (int)(x * dRef);
            int scPositionY = (int)(y * dRef);
            int scWidth = (int)(w * dRef);
            int scHeight = (int)(h * dRef);

            Bitmap bt = new Bitmap(scWidth, scHeight);  

            using (Graphics g = Graphics.FromImage(bt))  // using : 자원을 사용한 뒤 dispose 하지 않아도 알아서 자원을 해제
            {
                g.CopyFromScreen(scPositionX, scPositionY, 0, 0, bt.Size, CopyPixelOperation.SourceCopy);
            }

            // TextBox에 이미지 캡쳐 좌표점을 표시
            tboxSize.Text = $@"x:{scPositionX}, y:{scPositionY}, w:{scWidth}, h:{scHeight}";

            return bt; //imgResize(bt);
        }

        /// <summary>
        /// Image Size 변경을 위해 사용 
        /// </summary>
        /// <param name="orgImg"></param>
        /// <returns></returns>
        private Bitmap imgResize(Bitmap orgImg)
        {
            int width = (int)(orgImg.Width);
            int height = (int)(orgImg.Height);
            Size resize = new Size(width, height);
            return new Bitmap(orgImg, resize);
        }
        #endregion


        #region Window 배율 관련 Function (별도 관리)
        /// <summary>
        /// 장치 정보 구하기
        /// </summary>
        /// <param name="deviceContextHandle">디바이스 컨텍스트 핸들</param>
        /// <param name="index">인덱스</param>
        /// <returns>장치 정보</returns>
        [System.Runtime.InteropServices.DllImport("gdi32")]
        private static extern int GetDeviceCaps(IntPtr deviceContextHandle, int index);

        /// <summary>
        /// 화면 배율 계수 설정하기
        /// </summary>
        /// <returns>배율 계수</returns>
        public float GetScreenScalingFactor()
        {
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);

            IntPtr deviceHandle = graphics.GetHdc();

            int PhysicalScreenHeight = GetDeviceCaps(deviceHandle, 117);
            //int LogicalScreenHeight = GetDeviceCaps(deviceHandle, 10);  // ㅁ캡쳐 화면 사이즈대로 사진 보이게 배율값 
            Size sizeNext = Screen.PrimaryScreen.Bounds.Size;
            int LogicalScreenHeight = sizeNext.Height;

            float scalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return scalingFactor; // 1.25 = 125%
        }
        #endregion

    }
}

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
    public partial class frmSelecter : Form
    {

        #region 폼 사이즈 변경 Code
        private static readonly Color PrimaryTransparencyKey = Color.White;
        private static readonly Color SecondaryTransparencyKey = Color.Black;

        public Rectangle SelectedWindow
        {
            get
            {
                var rect = this.Bounds;
                rect.Inflate(_FrameBorderSize * -1, _FrameBorderSize * -1);
                return rect;
            }
        }

        private Color _FrameColor = Color.Red;

        [DefaultValue(typeof(Color), "Red")]
        public Color FrameColor
        {
            get { return _FrameColor; }
            set
            {
                _FrameColor = value;
                if (_FrameColor == PrimaryTransparencyKey)
                    this.TransparencyKey = SecondaryTransparencyKey;
                else
                    this.TransparencyKey = PrimaryTransparencyKey;
                this.Refresh();
            }
        }

        private int _FrameBorderSize = 5;

        [DefaultValue(5)]
        public int FrameBorderSize
        {
            get { return _FrameBorderSize; }
            set
            {
                _FrameBorderSize = value;
                this.Refresh();
            }
        }


        [DefaultValue(true)]
        public bool AllowedTransform { get; set; } = true;

        Point mousePoint;

        public frmSelecter()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = PrimaryTransparencyKey;
            this.TopMost = true;
        }


        void draw(Graphics g)
        {
            var rct = this.ClientRectangle;
            g.FillRectangle(new SolidBrush(FrameColor), rct);
            rct.Inflate(FrameBorderSize * -1, FrameBorderSize * -1);
            g.FillRectangle(new SolidBrush(TransparencyKey), rct);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (AllowedTransform)
            {
                if (e.X > Width * 2 / 3 && e.Y > Height * 1 / 2)
                    frameTransform(e);
                else
                    frameMove(e);
            }
            else
                frameMove(e);

            base.OnMouseMove(e);
        }

        void frameMove(MouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        void frameTransform(MouseEventArgs e)
        {
            if (AllowedTransform)
            {
                Cursor = Cursors.SizeNWSE;

                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {

                    this.Width += e.X - mousePoint.X;
                    mousePoint.X += e.X - mousePoint.X;

                    this.Height += e.Y - mousePoint.Y;
                    mousePoint.Y += e.Y - mousePoint.Y;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            draw(e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Refresh();
        }
        #endregion


        #region Form Size 전송을 위한 Code
        public delegate void delScreenInfoSender(object oSender, Dictionary<string, int> dInfo);
        public event delScreenInfoSender eScreenInfoSander;


        /// <summary>
        /// Form Double Click 시 해당 위치의 Size를 가져 옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelecter_DoubleClick(object sender, EventArgs e)
        {

            eScreenInfoSander(this, fCaptureInfo());
            this.Hide();
        }


        /// <summary>
        /// 더블클릭해서 캡쳐 하면 그 캡쳐화면 Main의 PBox에 보여줄것임!
        /// 캡쳐 화면크기 Dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> fCaptureInfo()
        {
            Dictionary<string, int> Info = new Dictionary<string, int>();

            Info.Add("X", this.Location.X);
            Info.Add("Y", this.Location.Y);
            Info.Add("W", this.Width);
            Info.Add("H", this.Height);


            return Info;
        }
        #endregion

    }
}

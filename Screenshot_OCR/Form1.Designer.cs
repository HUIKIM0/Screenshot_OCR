
namespace Screenshot_OCR
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxSize = new System.Windows.Forms.TextBox();
            this.cboxKOR_ENG = new System.Windows.Forms.CheckBox();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnOCR = new System.Windows.Forms.Button();
            this.pboxScreen = new System.Windows.Forms.PictureBox();
            this.tboxOCR = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboxScreen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tboxOCR, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOCR);
            this.panel1.Controls.Add(this.btnScreenShot);
            this.panel1.Controls.Add(this.cboxKOR_ENG);
            this.panel1.Controls.Add(this.tboxSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 34);
            this.panel1.TabIndex = 0;
            // 
            // tboxSize
            // 
            this.tboxSize.Location = new System.Drawing.Point(4, 5);
            this.tboxSize.Name = "tboxSize";
            this.tboxSize.Size = new System.Drawing.Size(514, 25);
            this.tboxSize.TabIndex = 0;
            // 
            // cboxKOR_ENG
            // 
            this.cboxKOR_ENG.AutoSize = true;
            this.cboxKOR_ENG.Location = new System.Drawing.Point(528, 9);
            this.cboxKOR_ENG.Name = "cboxKOR_ENG";
            this.cboxKOR_ENG.Size = new System.Drawing.Size(65, 19);
            this.cboxKOR_ENG.TabIndex = 1;
            this.cboxKOR_ENG.Text = "한/영";
            this.cboxKOR_ENG.UseVisualStyleBackColor = true;
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Location = new System.Drawing.Point(600, 0);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(103, 34);
            this.btnScreenShot.TabIndex = 2;
            this.btnScreenShot.Text = "ScreenShot";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            // 
            // btnOCR
            // 
            this.btnOCR.Location = new System.Drawing.Point(709, 0);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(103, 34);
            this.btnOCR.TabIndex = 3;
            this.btnOCR.Text = "OCR";
            this.btnOCR.UseVisualStyleBackColor = true;
            // 
            // pboxScreen
            // 
            this.pboxScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxScreen.Location = new System.Drawing.Point(3, 43);
            this.pboxScreen.Name = "pboxScreen";
            this.pboxScreen.Size = new System.Drawing.Size(816, 257);
            this.pboxScreen.TabIndex = 1;
            this.pboxScreen.TabStop = false;
            // 
            // tboxOCR
            // 
            this.tboxOCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxOCR.Location = new System.Drawing.Point(3, 306);
            this.tboxOCR.Multiline = true;
            this.tboxOCR.Name = "tboxOCR";
            this.tboxOCR.Size = new System.Drawing.Size(816, 257);
            this.tboxOCR.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.CheckBox cboxKOR_ENG;
        private System.Windows.Forms.TextBox tboxSize;
        private System.Windows.Forms.PictureBox pboxScreen;
        private System.Windows.Forms.TextBox tboxOCR;
    }
}


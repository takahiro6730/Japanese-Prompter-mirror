namespace JapanesePrompter
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.group_control = new System.Windows.Forms.GroupBox();
            this.input_fileName = new System.Windows.Forms.TextBox();
            this.btn_text = new System.Windows.Forms.Button();
            this.btn_fullScreen = new System.Windows.Forms.Button();
            this.tbox_font = new System.Windows.Forms.TextBox();
            this.scroll_speed = new System.Windows.Forms.HScrollBar();
            this.btn_paly = new System.Windows.Forms.Button();
            this.btn_fast = new System.Windows.Forms.Button();
            this.btn_hMirror = new System.Windows.Forms.Button();
            this.btn_slow = new System.Windows.Forms.Button();
            this.btn_cMirror = new System.Windows.Forms.Button();
            this.btn_fontUp = new System.Windows.Forms.Button();
            this.lbl_font = new System.Windows.Forms.Label();
            this.btn_fontDown = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.group_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 581);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 728);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.group_control);
            this.panel3.Location = new System.Drawing.Point(48, 616);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 100);
            this.panel3.TabIndex = 10;
            // 
            // group_control
            // 
            this.group_control.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.group_control.Controls.Add(this.input_fileName);
            this.group_control.Controls.Add(this.btn_text);
            this.group_control.Controls.Add(this.btn_fullScreen);
            this.group_control.Controls.Add(this.tbox_font);
            this.group_control.Controls.Add(this.scroll_speed);
            this.group_control.Controls.Add(this.btn_paly);
            this.group_control.Controls.Add(this.btn_fast);
            this.group_control.Controls.Add(this.btn_hMirror);
            this.group_control.Controls.Add(this.btn_slow);
            this.group_control.Controls.Add(this.btn_cMirror);
            this.group_control.Controls.Add(this.btn_fontUp);
            this.group_control.Controls.Add(this.lbl_font);
            this.group_control.Controls.Add(this.btn_fontDown);
            this.group_control.Location = new System.Drawing.Point(155, 3);
            this.group_control.Name = "group_control";
            this.group_control.Size = new System.Drawing.Size(845, 94);
            this.group_control.TabIndex = 11;
            this.group_control.TabStop = false;
            // 
            // input_fileName
            // 
            this.input_fileName.Location = new System.Drawing.Point(97, 53);
            this.input_fileName.Name = "input_fileName";
            this.input_fileName.Size = new System.Drawing.Size(78, 23);
            this.input_fileName.TabIndex = 10;
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(16, 53);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(75, 23);
            this.btn_text.TabIndex = 9;
            this.btn_text.Text = "Text";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_fullScreen
            // 
            this.btn_fullScreen.Location = new System.Drawing.Point(203, 46);
            this.btn_fullScreen.Name = "btn_fullScreen";
            this.btn_fullScreen.Size = new System.Drawing.Size(53, 37);
            this.btn_fullScreen.TabIndex = 8;
            this.btn_fullScreen.Text = "FullScreen";
            this.btn_fullScreen.UseVisualStyleBackColor = true;
            // 
            // tbox_font
            // 
            this.tbox_font.Location = new System.Drawing.Point(539, 46);
            this.tbox_font.Name = "tbox_font";
            this.tbox_font.Size = new System.Drawing.Size(59, 23);
            this.tbox_font.TabIndex = 5;
            // 
            // scroll_speed
            // 
            this.scroll_speed.Location = new System.Drawing.Point(294, 80);
            this.scroll_speed.Name = "scroll_speed";
            this.scroll_speed.Size = new System.Drawing.Size(167, 17);
            this.scroll_speed.TabIndex = 7;
            // 
            // btn_paly
            // 
            this.btn_paly.Location = new System.Drawing.Point(337, 25);
            this.btn_paly.Name = "btn_paly";
            this.btn_paly.Size = new System.Drawing.Size(75, 44);
            this.btn_paly.TabIndex = 0;
            this.btn_paly.Text = "play";
            this.btn_paly.UseVisualStyleBackColor = true;
            // 
            // btn_fast
            // 
            this.btn_fast.Location = new System.Drawing.Point(439, 38);
            this.btn_fast.Name = "btn_fast";
            this.btn_fast.Size = new System.Drawing.Size(41, 23);
            this.btn_fast.TabIndex = 6;
            this.btn_fast.Text = ">>";
            this.btn_fast.UseVisualStyleBackColor = true;
            // 
            // btn_hMirror
            // 
            this.btn_hMirror.Location = new System.Drawing.Point(683, 52);
            this.btn_hMirror.Name = "btn_hMirror";
            this.btn_hMirror.Size = new System.Drawing.Size(68, 29);
            this.btn_hMirror.TabIndex = 1;
            this.btn_hMirror.Text = "hMirror";
            this.btn_hMirror.UseVisualStyleBackColor = true;
            // 
            // btn_slow
            // 
            this.btn_slow.Location = new System.Drawing.Point(275, 39);
            this.btn_slow.Name = "btn_slow";
            this.btn_slow.Size = new System.Drawing.Size(41, 23);
            this.btn_slow.TabIndex = 6;
            this.btn_slow.Text = "<<";
            this.btn_slow.UseVisualStyleBackColor = true;
            // 
            // btn_cMirror
            // 
            this.btn_cMirror.Location = new System.Drawing.Point(632, 39);
            this.btn_cMirror.Name = "btn_cMirror";
            this.btn_cMirror.Size = new System.Drawing.Size(45, 55);
            this.btn_cMirror.TabIndex = 2;
            this.btn_cMirror.Text = "ColorMirror";
            this.btn_cMirror.UseVisualStyleBackColor = true;
            // 
            // btn_fontUp
            // 
            this.btn_fontUp.Location = new System.Drawing.Point(519, 11);
            this.btn_fontUp.Name = "btn_fontUp";
            this.btn_fontUp.Size = new System.Drawing.Size(69, 34);
            this.btn_fontUp.TabIndex = 3;
            this.btn_fontUp.Text = "+";
            this.btn_fontUp.UseVisualStyleBackColor = true;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_font.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_font.Location = new System.Drawing.Point(486, 44);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(49, 25);
            this.lbl_font.TabIndex = 4;
            this.lbl_font.Text = "Font";
            // 
            // btn_fontDown
            // 
            this.btn_fontDown.Location = new System.Drawing.Point(519, 72);
            this.btn_fontDown.Name = "btn_fontDown";
            this.btn_fontDown.Size = new System.Drawing.Size(69, 31);
            this.btn_fontDown.TabIndex = 3;
            this.btn_fontDown.Text = "-";
            this.btn_fontDown.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1234, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainWindow";
            this.Text = "JPP";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.group_control.ResumeLayout(false);
            this.group_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox group_control;
        private TextBox input_fileName;
        private Button btn_text;
        private Button btn_fullScreen;
        private TextBox tbox_font;
        private HScrollBar scroll_speed;
        private Button btn_paly;
        private Button btn_fast;
        private Button btn_hMirror;
        private Button btn_slow;
        private Button btn_cMirror;
        private Button btn_fontUp;
        private Label lbl_font;
        private Button btn_fontDown;
    }
}
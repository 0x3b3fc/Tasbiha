namespace Tasbiha
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_sobhan = new Button();
            lbl_sobhan = new Label();
            lbl_hamd = new Label();
            btn_hamd = new Button();
            lbl_akbar = new Label();
            btn_akbar = new Button();
            label3 = new Label();
            label1 = new Label();
            lbl_counter = new Label();
            SuspendLayout();
            // 
            // btn_sobhan
            // 
            btn_sobhan.BackColor = Color.Teal;
            btn_sobhan.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sobhan.ForeColor = SystemColors.HighlightText;
            btn_sobhan.Location = new Point(517, 349);
            btn_sobhan.Name = "btn_sobhan";
            btn_sobhan.Size = new Size(142, 48);
            btn_sobhan.TabIndex = 0;
            btn_sobhan.Text = "سبحان الله";
            btn_sobhan.UseVisualStyleBackColor = false;
            btn_sobhan.Click += btn_sobhan_Click;
            // 
            // lbl_sobhan
            // 
            lbl_sobhan.AutoSize = true;
            lbl_sobhan.BackColor = Color.Silver;
            lbl_sobhan.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sobhan.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_sobhan.Image = (Image)resources.GetObject("lbl_sobhan.Image");
            lbl_sobhan.Location = new Point(573, 307);
            lbl_sobhan.Name = "lbl_sobhan";
            lbl_sobhan.Size = new Size(30, 27);
            lbl_sobhan.TabIndex = 1;
            lbl_sobhan.Text = "0";
            // 
            // lbl_hamd
            // 
            lbl_hamd.AutoSize = true;
            lbl_hamd.BackColor = Color.Silver;
            lbl_hamd.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hamd.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_hamd.Image = (Image)resources.GetObject("lbl_hamd.Image");
            lbl_hamd.Location = new Point(409, 307);
            lbl_hamd.Name = "lbl_hamd";
            lbl_hamd.Size = new Size(30, 27);
            lbl_hamd.TabIndex = 3;
            lbl_hamd.Text = "0";
            // 
            // btn_hamd
            // 
            btn_hamd.BackColor = Color.Teal;
            btn_hamd.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hamd.ForeColor = SystemColors.HighlightText;
            btn_hamd.Location = new Point(355, 349);
            btn_hamd.Name = "btn_hamd";
            btn_hamd.Size = new Size(142, 48);
            btn_hamd.TabIndex = 2;
            btn_hamd.Text = "الحمد لله";
            btn_hamd.UseVisualStyleBackColor = false;
            btn_hamd.Click += btn_hamd_Click;
            // 
            // lbl_akbar
            // 
            lbl_akbar.AutoSize = true;
            lbl_akbar.BackColor = Color.Silver;
            lbl_akbar.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_akbar.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_akbar.Image = (Image)resources.GetObject("lbl_akbar.Image");
            lbl_akbar.Location = new Point(253, 307);
            lbl_akbar.Name = "lbl_akbar";
            lbl_akbar.Size = new Size(30, 27);
            lbl_akbar.TabIndex = 5;
            lbl_akbar.Text = "0";
            // 
            // btn_akbar
            // 
            btn_akbar.BackColor = Color.Teal;
            btn_akbar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_akbar.ForeColor = SystemColors.HighlightText;
            btn_akbar.Location = new Point(197, 349);
            btn_akbar.Name = "btn_akbar";
            btn_akbar.Size = new Size(142, 48);
            btn_akbar.TabIndex = 4;
            btn_akbar.Text = "الله اكبر";
            btn_akbar.UseVisualStyleBackColor = false;
            btn_akbar.Click += btn_akbar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Simple Indust Shaded", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(229, 29);
            label3.Name = "label3";
            label3.Size = new Size(393, 87);
            label3.TabIndex = 6;
            label3.Text = "برنامج التسبيح";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simple Bold Jut Out", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(573, 171);
            label1.Name = "label1";
            label1.Size = new Size(172, 35);
            label1.TabIndex = 7;
            label1.Text = "عدد التسبيحات";
            // 
            // lbl_counter
            // 
            lbl_counter.AutoSize = true;
            lbl_counter.BackColor = Color.Silver;
            lbl_counter.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_counter.ForeColor = Color.FromArgb(64, 0, 0);
            lbl_counter.Image = (Image)resources.GetObject("lbl_counter.Image");
            lbl_counter.Location = new Point(517, 174);
            lbl_counter.Name = "lbl_counter";
            lbl_counter.Size = new Size(30, 27);
            lbl_counter.TabIndex = 8;
            lbl_counter.Text = "0";
            lbl_counter.Click += lbl_counter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_counter);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lbl_akbar);
            Controls.Add(btn_akbar);
            Controls.Add(lbl_hamd);
            Controls.Add(btn_hamd);
            Controls.Add(lbl_sobhan);
            Controls.Add(btn_sobhan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "تسبيحة";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sobhan;
        private Label lbl_sobhan;
        private Label lbl_hamd;
        private Button btn_hamd;
        private Label lbl_akbar;
        private Button btn_akbar;
        private Label label3;
        private Label label1;
        private Label lbl_counter;
    }
}
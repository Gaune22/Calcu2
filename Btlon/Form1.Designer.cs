namespace Btlon
{
    partial class index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt3so = new System.Windows.Forms.Button();
            this.bt5so = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt4so = new System.Windows.Forms.Button();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Btlon.Properties.Resources.vietlott_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt3so
            // 
            this.bt3so.BackColor = System.Drawing.Color.LightGreen;
            this.bt3so.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt3so.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3so.Location = new System.Drawing.Point(130, 424);
            this.bt3so.Name = "bt3so";
            this.bt3so.Size = new System.Drawing.Size(153, 79);
            this.bt3so.TabIndex = 1;
            this.bt3so.Text = "Chơi 3 số";
            this.bt3so.UseVisualStyleBackColor = false;
            this.bt3so.Click += new System.EventHandler(this.bt3so_Click);
            // 
            // bt5so
            // 
            this.bt5so.BackColor = System.Drawing.Color.LightGreen;
            this.bt5so.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt5so.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5so.Location = new System.Drawing.Point(566, 424);
            this.bt5so.Name = "bt5so";
            this.bt5so.Size = new System.Drawing.Size(153, 79);
            this.bt5so.TabIndex = 1;
            this.bt5so.Text = "Chơi 5 số";
            this.bt5so.UseVisualStyleBackColor = false;
            this.bt5so.Click += new System.EventHandler(this.bt5so_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 130);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hãy chọn cách chơi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt4so
            // 
            this.bt4so.BackColor = System.Drawing.Color.LightGreen;
            this.bt4so.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4so.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt4so.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4so.Location = new System.Drawing.Point(344, 424);
            this.bt4so.Name = "bt4so";
            this.bt4so.Size = new System.Drawing.Size(153, 79);
            this.bt4so.TabIndex = 1;
            this.bt4so.Text = "Chơi 4 số";
            this.bt4so.UseVisualStyleBackColor = false;
            this.bt4so.Click += new System.EventHandler(this.bt4so_Click);
            // 
            // datetxt
            // 
            this.datetxt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Location = new System.Drawing.Point(449, 124);
            this.datetxt.MinDate = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(333, 29);
            this.datetxt.TabIndex = 3;
            // 
            // index
            // 
            this.BackgroundImage = global::Btlon.Properties.Resources.trai_nghiem_san_jackpot_tien_ty_qua_kenh_dien_thoai_16262807931;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 542);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt5so);
            this.Controls.Add(this.bt4so);
            this.Controls.Add(this.bt3so);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Xổ Số VietLott";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt3so;
        private System.Windows.Forms.Button bt5so;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt4so;
        public System.Windows.Forms.DateTimePicker datetxt;
    }
}


namespace Btlon
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Resu,
            this.Chon});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(133, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 320);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Ngày";
            this.Date.Width = 94;
            // 
            // Resu
            // 
            this.Resu.Text = "Số trúng thưởng";
            this.Resu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resu.Width = 228;
            // 
            // Chon
            // 
            this.Chon.Text = "Số đã chọn";
            this.Chon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Chon.Width = 201;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Btlon.Properties.Resources.trai_nghiem_san_jackpot_tien_ty_qua_kenh_dien_thoai_16262807931;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.Text = "Kết quả xổ số";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Resu;
        private System.Windows.Forms.ColumnHeader Chon;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView1;
    }
}
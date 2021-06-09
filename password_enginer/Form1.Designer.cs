
namespace password_enginer
{
    partial class mian_form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sensor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.method_options = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mouse_x = new System.Windows.Forms.Label();
            this.mouse_y = new System.Windows.Forms.Label();
            this.row_hash_count = new System.Windows.Forms.Label();
            this.save_path_explain = new System.Windows.Forms.Label();
            this.save_path = new System.Windows.Forms.TextBox();
            this.save_append = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sensor)).BeginInit();
            this.SuspendLayout();
            // 
            // sensor
            // 
            this.sensor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sensor.Location = new System.Drawing.Point(16, 36);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(1024, 1024);
            this.sensor.TabIndex = 0;
            this.sensor.TabStop = false;
            this.sensor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_collect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "取樣區域";
            // 
            // method_options
            // 
            this.method_options.FormattingEnabled = true;
            this.method_options.Items.AddRange(new object[] {
            "Von Neumann extractor",
            "SHA-256",
            "SHA-512",
            "MD5"});
            this.method_options.Location = new System.Drawing.Point(1171, 33);
            this.method_options.Name = "method_options";
            this.method_options.Size = new System.Drawing.Size(342, 32);
            this.method_options.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1047, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "取樣方法";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "滑鼠位置";
            // 
            // mouse_x
            // 
            this.mouse_x.AutoSize = true;
            this.mouse_x.Location = new System.Drawing.Point(1158, 90);
            this.mouse_x.Name = "mouse_x";
            this.mouse_x.Size = new System.Drawing.Size(21, 24);
            this.mouse_x.TabIndex = 5;
            this.mouse_x.Text = "0";
            // 
            // mouse_y
            // 
            this.mouse_y.AutoSize = true;
            this.mouse_y.Location = new System.Drawing.Point(1215, 90);
            this.mouse_y.Name = "mouse_y";
            this.mouse_y.Size = new System.Drawing.Size(21, 24);
            this.mouse_y.TabIndex = 6;
            this.mouse_y.Text = "0";
            // 
            // row_hash_count
            // 
            this.row_hash_count.AutoSize = true;
            this.row_hash_count.Location = new System.Drawing.Point(1047, 139);
            this.row_hash_count.Name = "row_hash_count";
            this.row_hash_count.Size = new System.Drawing.Size(165, 24);
            this.row_hash_count.TabIndex = 7;
            this.row_hash_count.Text = "已產出亂數：0";
            // 
            // save_path_explain
            // 
            this.save_path_explain.AutoSize = true;
            this.save_path_explain.Location = new System.Drawing.Point(1046, 187);
            this.save_path_explain.Name = "save_path_explain";
            this.save_path_explain.Size = new System.Drawing.Size(130, 24);
            this.save_path_explain.TabIndex = 8;
            this.save_path_explain.Text = "亂數保存於";
            // 
            // save_path
            // 
            this.save_path.Location = new System.Drawing.Point(1193, 184);
            this.save_path.Name = "save_path";
            this.save_path.Size = new System.Drawing.Size(1312, 36);
            this.save_path.TabIndex = 9;
            // 
            // save_append
            // 
            this.save_append.Location = new System.Drawing.Point(2347, 230);
            this.save_append.Name = "save_append";
            this.save_append.Size = new System.Drawing.Size(158, 36);
            this.save_append.TabIndex = 11;
            this.save_append.Text = "存檔並添加";
            this.save_append.UseVisualStyleBackColor = true;
            this.save_append.Click += new System.EventHandler(this.Save_append);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1047, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "亂數倍率";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(1159, 233);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 36);
            this.rate.TabIndex = 13;
            this.rate.Text = "1";
            // 
            // mian_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2517, 1087);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_append);
            this.Controls.Add(this.save_path);
            this.Controls.Add(this.save_path_explain);
            this.Controls.Add(this.row_hash_count);
            this.Controls.Add(this.mouse_y);
            this.Controls.Add(this.mouse_x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.method_options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sensor);
            this.Name = "mian_form";
            this.Text = "密碼工程：亂數提取器";
            ((System.ComponentModel.ISupportInitialize)(this.sensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sensor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox method_options;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mouse_x;
        private System.Windows.Forms.Label mouse_y;
        private System.Windows.Forms.Label row_hash_count;
        private System.Windows.Forms.Label save_path_explain;
        private System.Windows.Forms.TextBox save_path;
        private System.Windows.Forms.Button save_append;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rate;
    }
}


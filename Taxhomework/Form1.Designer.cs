
namespace Taxhomework
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.cbxcc = new System.Windows.Forms.ComboBox();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.使用牌照稅應納稅額試算 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(51, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "汽缸CC數/馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(114, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(99, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(480, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(480, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "從";
            // 
            // DTP2
            // 
            this.DTP2.Location = new System.Drawing.Point(516, 179);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(200, 25);
            this.DTP2.TabIndex = 24;
            this.DTP2.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(516, 130);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 25);
            this.DTP1.TabIndex = 23;
            this.DTP1.Value = new System.DateTime(2021, 7, 14, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(451, 306);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 49);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "清除重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(246, 306);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 49);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "確定送出";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad2.Location = new System.Drawing.Point(356, 149);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(90, 24);
            this.rad2.TabIndex = 20;
            this.rad2.TabStop = true;
            this.rad2.Text = "依期間";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rad1.Location = new System.Drawing.Point(246, 149);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(90, 24);
            this.rad1.TabIndex = 19;
            this.rad1.TabStop = true;
            this.rad1.Text = "全年度";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // cbxcc
            // 
            this.cbxcc.FormattingEnabled = true;
            this.cbxcc.Location = new System.Drawing.Point(246, 264);
            this.cbxcc.Name = "cbxcc";
            this.cbxcc.Size = new System.Drawing.Size(263, 23);
            this.cbxcc.TabIndex = 18;
            // 
            // cbx1
            // 
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbx1.Location = new System.Drawing.Point(246, 207);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(210, 23);
            this.cbx1.TabIndex = 17;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(96, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // 使用牌照稅應納稅額試算
            // 
            this.使用牌照稅應納稅額試算.AutoSize = true;
            this.使用牌照稅應納稅額試算.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.使用牌照稅應納稅額試算.Location = new System.Drawing.Point(240, 46);
            this.使用牌照稅應納稅額試算.Name = "使用牌照稅應納稅額試算";
            this.使用牌照稅應納稅額試算.Size = new System.Drawing.Size(378, 33);
            this.使用牌照稅應納稅額試算.TabIndex = 30;
            this.使用牌照稅應納稅額試算.Text = "使用牌照稅應納稅額試算";
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(246, 389);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 394);
            this.listBox1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 811);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.使用牌照稅應納稅額試算);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.cbxcc);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.ComboBox cbxcc;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label 使用牌照稅應納稅額試算;
        private System.Windows.Forms.ListBox listBox1;
    }
}


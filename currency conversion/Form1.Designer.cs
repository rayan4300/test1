namespace currency_conversion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.amo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fm = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.frombox = new System.Windows.Forms.ComboBox();
            this.tobox = new System.Windows.Forms.ComboBox();
            this.convertbutt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Conversion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // amo
            // 
            this.amo.AutoSize = true;
            this.amo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amo.ForeColor = System.Drawing.Color.Red;
            this.amo.Location = new System.Drawing.Point(40, 65);
            this.amo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amo.Name = "amo";
            this.amo.Size = new System.Drawing.Size(99, 28);
            this.amo.TabIndex = 1;
            this.amo.Tag = "";
            this.amo.Text = "Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(151, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fm
            // 
            this.fm.AutoSize = true;
            this.fm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fm.ForeColor = System.Drawing.Color.Red;
            this.fm.Location = new System.Drawing.Point(70, 121);
            this.fm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fm.Name = "fm";
            this.fm.Size = new System.Drawing.Size(55, 24);
            this.fm.TabIndex = 1;
            this.fm.Tag = "";
            this.fm.Text = "From";
            this.fm.Click += new System.EventHandler(this.fm_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ForeColor = System.Drawing.Color.Red;
            this.t.Location = new System.Drawing.Point(82, 174);
            this.t.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(25, 21);
            this.t.TabIndex = 1;
            this.t.Tag = "";
            this.t.Text = "to";
            this.t.Click += new System.EventHandler(this.t_Click);
            // 
            // frombox
            // 
            this.frombox.BackColor = System.Drawing.SystemColors.Window;
            this.frombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frombox.FormattingEnabled = true;
            this.frombox.Items.AddRange(new object[] {
            "USD",
            "SAR",
            "YER",
            ""});
            this.frombox.Location = new System.Drawing.Point(151, 119);
            this.frombox.Margin = new System.Windows.Forms.Padding(4);
            this.frombox.Name = "frombox";
            this.frombox.Size = new System.Drawing.Size(140, 24);
            this.frombox.TabIndex = 3;
            this.frombox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tobox
            // 
            this.tobox.BackColor = System.Drawing.SystemColors.Window;
            this.tobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tobox.FormattingEnabled = true;
            this.tobox.Items.AddRange(new object[] {
            "USD",
            "SAR",
            "YER"});
            this.tobox.Location = new System.Drawing.Point(151, 167);
            this.tobox.Margin = new System.Windows.Forms.Padding(4);
            this.tobox.Name = "tobox";
            this.tobox.Size = new System.Drawing.Size(140, 24);
            this.tobox.TabIndex = 3;
            this.tobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertbutt
            // 
            this.convertbutt.BackColor = System.Drawing.Color.DarkRed;
            this.convertbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertbutt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertbutt.ForeColor = System.Drawing.SystemColors.Window;
            this.convertbutt.Location = new System.Drawing.Point(45, 234);
            this.convertbutt.Margin = new System.Windows.Forms.Padding(4);
            this.convertbutt.Name = "convertbutt";
            this.convertbutt.Size = new System.Drawing.Size(271, 54);
            this.convertbutt.TabIndex = 4;
            this.convertbutt.Text = "CONVERT";
            this.convertbutt.UseVisualStyleBackColor = false;
            this.convertbutt.Click += new System.EventHandler(this.convertbutt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "RESULT:";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(116, 323);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(167, 28);
            this.result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(367, 383);
            this.Controls.Add(this.result);
            this.Controls.Add(this.convertbutt);
            this.Controls.Add(this.tobox);
            this.Controls.Add(this.frombox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.fm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "تحويل عملات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label fm;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.ComboBox frombox;
        private System.Windows.Forms.ComboBox tobox;
        private System.Windows.Forms.Button convertbutt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
    }
}


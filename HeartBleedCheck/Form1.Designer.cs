namespace HeartBleedCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ip1 = new System.Windows.Forms.NumericUpDown();
            this.ip2 = new System.Windows.Forms.NumericUpDown();
            this.ip4 = new System.Windows.Forms.NumericUpDown();
            this.ip3 = new System.Windows.Forms.NumericUpDown();
            this.Check = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portnum = new System.Windows.Forms.NumericUpDown();
            this.showtec = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portnum)).BeginInit();
            this.SuspendLayout();
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(90, 17);
            this.ip1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(55, 20);
            this.ip1.TabIndex = 0;
            this.ip1.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(151, 17);
            this.ip2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(55, 20);
            this.ip2.TabIndex = 1;
            this.ip2.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(273, 17);
            this.ip4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(55, 20);
            this.ip4.TabIndex = 3;
            this.ip4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(212, 17);
            this.ip3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(55, 20);
            this.ip3.TabIndex = 2;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(424, 17);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(96, 40);
            this.Check.TabIndex = 4;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(15, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IP:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(15, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Host:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "localhost";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 123);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(508, 22);
            this.result.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Port:";
            // 
            // portnum
            // 
            this.portnum.Location = new System.Drawing.Point(273, 84);
            this.portnum.Maximum = new decimal(new int[] {
            25500,
            0,
            0,
            0});
            this.portnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portnum.Name = "portnum";
            this.portnum.Size = new System.Drawing.Size(55, 20);
            this.portnum.TabIndex = 11;
            this.portnum.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            // 
            // showtec
            // 
            this.showtec.AutoSize = true;
            this.showtec.Location = new System.Drawing.Point(15, 86);
            this.showtec.Name = "showtec";
            this.showtec.Size = new System.Drawing.Size(132, 17);
            this.showtec.TabIndex = 12;
            this.showtec.Text = "Show technical details";
            this.showtec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 157);
            this.Controls.Add(this.showtec);
            this.Controls.Add(this.portnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeartBleedCheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ip1;
        private System.Windows.Forms.NumericUpDown ip2;
        private System.Windows.Forms.NumericUpDown ip4;
        private System.Windows.Forms.NumericUpDown ip3;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown portnum;
        private System.Windows.Forms.CheckBox showtec;
    }
}


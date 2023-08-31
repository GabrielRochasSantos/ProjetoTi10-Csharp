
namespace mercadoSA
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
            this.LBL = new System.Windows.Forms.Label();
            this.rdb = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.CKB = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rtb = new System.Windows.Forms.RadioButton();
            this.enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(377, 35);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(33, 13);
            this.LBL.TabIndex = 0;
            this.LBL.Text = "nome";
            this.LBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdb
            // 
            this.rdb.Location = new System.Drawing.Point(232, 254);
            this.rdb.Name = "rdb";
            this.rdb.Size = new System.Drawing.Size(100, 20);
            this.rdb.TabIndex = 1;
            this.rdb.Text = "feminino";
            this.rdb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(156, 95);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(120, 95);
            this.lstProdutos.TabIndex = 2;
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CKB
            // 
            this.CKB.AutoSize = true;
            this.CKB.Location = new System.Drawing.Point(457, 116);
            this.CKB.Name = "CKB";
            this.CKB.Size = new System.Drawing.Size(49, 17);
            this.CKB.TabIndex = 3;
            this.CKB.Text = "Livro";
            this.CKB.UseVisualStyleBackColor = true;
            this.CKB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(409, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(444, 217);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 5;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rtb
            // 
            this.rtb.AutoSize = true;
            this.rtb.Location = new System.Drawing.Point(191, 379);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(85, 17);
            this.rtb.TabIndex = 6;
            this.rtb.TabStop = true;
            this.rtb.Text = "radioButton1";
            this.rtb.UseVisualStyleBackColor = true;
            this.rtb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(35, 51);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CKB);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.rdb);
            this.Controls.Add(this.LBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.TextBox rdb;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.CheckBox CKB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rtb;
        private System.Windows.Forms.Button enviar;
    }
}


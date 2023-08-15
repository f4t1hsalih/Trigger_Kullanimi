namespace Trigger_Kullanimi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnEkle = new Button();
            txtTur = new TextBox();
            txtYayinevi = new TextBox();
            txtSayfa = new TextBox();
            txtYazar = new TextBox();
            txtAd = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            lblToplamAdet = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(txtTur);
            groupBox1.Controls.Add(txtYayinevi);
            groupBox1.Controls.Add(txtSayfa);
            groupBox1.Controls.Add(txtYazar);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.FromArgb(70, 67, 87);
            btnSil.Location = new Point(52, 245);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 33);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.ForeColor = Color.FromArgb(70, 67, 87);
            btnEkle.Location = new Point(172, 245);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 33);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(95, 200);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(163, 28);
            txtTur.TabIndex = 4;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(95, 166);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(163, 28);
            txtYayinevi.TabIndex = 3;
            // 
            // txtSayfa
            // 
            txtSayfa.Location = new Point(95, 132);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(163, 28);
            txtSayfa.TabIndex = 2;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(95, 98);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(163, 28);
            txtYazar.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(95, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(163, 28);
            txtAd.TabIndex = 0;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(95, 30);
            txtid.Name = "txtid";
            txtid.Size = new Size(163, 28);
            txtid.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 203);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 5;
            label6.Text = "TÜR: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 169);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 4;
            label5.Text = "YAYINEVİ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 3;
            label4.Text = "SAYFA: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "YAZAR: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 1;
            label2.Text = "AD: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 0;
            label1.Text = "ID: ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(299, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(70, 67, 87);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(181, 187, 212);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(410, 223);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblToplamAdet);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(302, 268);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(410, 50);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lblToplamAdet
            // 
            lblToplamAdet.AutoSize = true;
            lblToplamAdet.Location = new Point(130, 18);
            lblToplamAdet.Name = "lblToplamAdet";
            lblToplamAdet.Size = new Size(34, 23);
            lblToplamAdet.TabIndex = 7;
            lblToplamAdet.Text = "***";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 18);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 6;
            label7.Text = "TOPLAM ADET: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 67, 87);
            ClientSize = new Size(727, 330);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Sitka Display", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(181, 187, 212);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trigger Kullanımı";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSil;
        private Button btnEkle;
        private TextBox txtTur;
        private TextBox txtYayinevi;
        private TextBox txtSayfa;
        private TextBox txtYazar;
        private TextBox txtAd;
        private TextBox txtid;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label lblToplamAdet;
        private Label label7;
    }
}
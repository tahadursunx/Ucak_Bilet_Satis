namespace UcakBiletRezervasyon
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ucusBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.oTDataSet4 = new UcakBiletRezervasyon.OTDataSet4();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ucusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oTDataSet2 = new UcakBiletRezervasyon.OTDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ucusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTDataSet1 = new UcakBiletRezervasyon.OTDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ucusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.oTDataSet3 = new UcakBiletRezervasyon.OTDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ucusTableAdapter = new UcakBiletRezervasyon.OTDataSet1TableAdapters.ucusTableAdapter();
            this.ucusTableAdapter1 = new UcakBiletRezervasyon.OTDataSet2TableAdapters.ucusTableAdapter();
            this.ucusTableAdapter2 = new UcakBiletRezervasyon.OTDataSet3TableAdapters.ucusTableAdapter();
            this.ucusTableAdapter3 = new UcakBiletRezervasyon.OTDataSet4TableAdapters.ucusTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(104, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçuş Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.ucusBindingSource3;
            this.comboBox4.DisplayMember = "varis_noktasi";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(123, 91);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(194, 29);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "varis_noktasi";
            // 
            // ucusBindingSource3
            // 
            this.ucusBindingSource3.DataMember = "ucus";
            this.ucusBindingSource3.DataSource = this.oTDataSet4;
            // 
            // oTDataSet4
            // 
            this.oTDataSet4.DataSetName = "OTDataSet4";
            this.oTDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.ucusBindingSource1;
            this.comboBox3.DisplayMember = "kalkis_saati";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(469, 91);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(194, 29);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "kalkis_saati";
            // 
            // ucusBindingSource1
            // 
            this.ucusBindingSource1.DataMember = "ucus";
            this.ucusBindingSource1.DataSource = this.oTDataSet2;
            // 
            // oTDataSet2
            // 
            this.oTDataSet2.DataSetName = "OTDataSet2";
            this.oTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(710, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 11;
            this.button1.Text = "Uçuş Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(323, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "⇅";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(381, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nereye";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ucusBindingSource;
            this.comboBox2.DisplayMember = "kalkis_tarihi";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(469, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 29);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "kalkis_tarihi";
            // 
            // ucusBindingSource
            // 
            this.ucusBindingSource.DataMember = "ucus";
            this.ucusBindingSource.DataSource = this.oTDataSet1;
            // 
            // oTDataSet1
            // 
            this.oTDataSet1.DataSetName = "OTDataSet1";
            this.oTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ucusBindingSource2;
            this.comboBox1.DisplayMember = "kalkis_noktasi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "kalkis_noktasi";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ucusBindingSource2
            // 
            this.ucusBindingSource2.DataMember = "ucus";
            this.ucusBindingSource2.DataSource = this.oTDataSet3;
            // 
            // oTDataSet3
            // 
            this.oTDataSet3.DataSetName = "OTDataSet3";
            this.oTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereden";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(104, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 129);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(347, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 69);
            this.label8.TabIndex = 10;
            this.label8.Text = "ETESO Bilet";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(814, 179);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(104, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uçuşlar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(439, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Bilet al";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(643, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(454, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 26);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sorgula";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ucusTableAdapter
            // 
            this.ucusTableAdapter.ClearBeforeFill = true;
            // 
            // ucusTableAdapter1
            // 
            this.ucusTableAdapter1.ClearBeforeFill = true;
            // 
            // ucusTableAdapter2
            // 
            this.ucusTableAdapter2.ClearBeforeFill = true;
            // 
            // ucusTableAdapter3
            // 
            this.ucusTableAdapter3.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 615);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Bilet Satış";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private OTDataSet1 oTDataSet1;
        private System.Windows.Forms.BindingSource ucusBindingSource;
        private OTDataSet1TableAdapters.ucusTableAdapter ucusTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private OTDataSet2 oTDataSet2;
        private System.Windows.Forms.BindingSource ucusBindingSource1;
        private OTDataSet2TableAdapters.ucusTableAdapter ucusTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox4;
        private OTDataSet3 oTDataSet3;
        private System.Windows.Forms.BindingSource ucusBindingSource2;
        private OTDataSet3TableAdapters.ucusTableAdapter ucusTableAdapter2;
        private OTDataSet4 oTDataSet4;
        private System.Windows.Forms.BindingSource ucusBindingSource3;
        private OTDataSet4TableAdapters.ucusTableAdapter ucusTableAdapter3;
    }
}
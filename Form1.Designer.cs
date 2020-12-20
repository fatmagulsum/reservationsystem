
namespace rezarvasyon_sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskodano = new System.Windows.Forms.MaskedTextBox();
            this.mskkimlik = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dtpcikistarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpgiristarihi = new System.Windows.Forms.DateTimePicker();
            this.msktxttel = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnoda203 = new System.Windows.Forms.Button();
            this.btnoda202 = new System.Windows.Forms.Button();
            this.btnoda201 = new System.Windows.Forms.Button();
            this.btnoda109 = new System.Windows.Forms.Button();
            this.btnoda108 = new System.Windows.Forms.Button();
            this.btnoda107 = new System.Windows.Forms.Button();
            this.btnoda106 = new System.Windows.Forms.Button();
            this.btnoda105 = new System.Windows.Forms.Button();
            this.btnoda104 = new System.Windows.Forms.Button();
            this.btnoda103 = new System.Windows.Forms.Button();
            this.btnoda102 = new System.Windows.Forms.Button();
            this.btnoda101 = new System.Windows.Forms.Button();
            this.btndoluoda = new System.Windows.Forms.Button();
            this.btnbosoda = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskodano);
            this.groupBox1.Controls.Add(this.mskkimlik);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtucret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btntemizle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.dtpcikistarihi);
            this.groupBox1.Controls.Add(this.dtpgiristarihi);
            this.groupBox1.Controls.Add(this.msktxttel);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.txtsoyadi);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgiler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mskodano
            // 
            this.mskodano.Location = new System.Drawing.Point(199, 345);
            this.mskodano.Mask = "000";
            this.mskodano.Name = "mskodano";
            this.mskodano.Size = new System.Drawing.Size(269, 27);
            this.mskodano.TabIndex = 46;
            // 
            // mskkimlik
            // 
            this.mskkimlik.Location = new System.Drawing.Point(199, 293);
            this.mskkimlik.Mask = "00000000000";
            this.mskkimlik.Name = "mskkimlik";
            this.mskkimlik.Size = new System.Drawing.Size(268, 27);
            this.mskkimlik.TabIndex = 45;
            this.mskkimlik.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskkimlik_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboBox1.Location = new System.Drawing.Point(198, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cinsiyet:";
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(198, 406);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(269, 27);
            this.txtucret.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ücret:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Oda No:";
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemizle.Location = new System.Drawing.Point(376, 580);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(136, 35);
            this.btntemizle.TabIndex = 37;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(199, 580);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(136, 35);
            this.btnsil.TabIndex = 36;
            this.btnsil.Text = "Sil ";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Location = new System.Drawing.Point(31, 580);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(136, 34);
            this.btnkaydet.TabIndex = 35;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dtpcikistarihi
            // 
            this.dtpcikistarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcikistarihi.Location = new System.Drawing.Point(198, 515);
            this.dtpcikistarihi.Name = "dtpcikistarihi";
            this.dtpcikistarihi.Size = new System.Drawing.Size(272, 31);
            this.dtpcikistarihi.TabIndex = 34;
            this.dtpcikistarihi.ValueChanged += new System.EventHandler(this.dtpcikis_ValueChanged);
            // 
            // dtpgiristarihi
            // 
            this.dtpgiristarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpgiristarihi.Location = new System.Drawing.Point(198, 456);
            this.dtpgiristarihi.Name = "dtpgiristarihi";
            this.dtpgiristarihi.Size = new System.Drawing.Size(270, 31);
            this.dtpgiristarihi.TabIndex = 33;
            this.dtpgiristarihi.ValueChanged += new System.EventHandler(this.dtpgiris_ValueChanged);
            // 
            // msktxttel
            // 
            this.msktxttel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.msktxttel.Location = new System.Drawing.Point(199, 182);
            this.msktxttel.Mask = "(999) 000-0000";
            this.msktxttel.Name = "msktxttel";
            this.msktxttel.Size = new System.Drawing.Size(272, 27);
            this.msktxttel.TabIndex = 31;
            this.msktxttel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtmail.Location = new System.Drawing.Point(199, 235);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(272, 27);
            this.txtmail.TabIndex = 30;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtsoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoyadi.Location = new System.Drawing.Point(198, 82);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(272, 31);
            this.txtsoyadi.TabIndex = 29;
            this.txtsoyadi.TextChanged += new System.EventHandler(this.txtsoyadi_TextChanged);
            // 
            // txtadi
            // 
            this.txtadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadi.Location = new System.Drawing.Point(198, 30);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(272, 31);
            this.txtadi.TabIndex = 28;
            this.txtadi.TextChanged += new System.EventHandler(this.txtadi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = " T.C Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnoda203);
            this.groupBox2.Controls.Add(this.btnoda202);
            this.groupBox2.Controls.Add(this.btnoda201);
            this.groupBox2.Controls.Add(this.btnoda109);
            this.groupBox2.Controls.Add(this.btnoda108);
            this.groupBox2.Controls.Add(this.btnoda107);
            this.groupBox2.Controls.Add(this.btnoda106);
            this.groupBox2.Controls.Add(this.btnoda105);
            this.groupBox2.Controls.Add(this.btnoda104);
            this.groupBox2.Controls.Add(this.btnoda103);
            this.groupBox2.Controls.Add(this.btnoda102);
            this.groupBox2.Controls.Add(this.btnoda101);
            this.groupBox2.Location = new System.Drawing.Point(611, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 629);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnoda203
            // 
            this.btnoda203.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda203.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda203.Location = new System.Drawing.Point(380, 431);
            this.btnoda203.Name = "btnoda203";
            this.btnoda203.Size = new System.Drawing.Size(95, 39);
            this.btnoda203.TabIndex = 11;
            this.btnoda203.Text = "203";
            this.btnoda203.UseVisualStyleBackColor = false;
            this.btnoda203.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnoda202
            // 
            this.btnoda202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda202.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda202.Location = new System.Drawing.Point(227, 431);
            this.btnoda202.Name = "btnoda202";
            this.btnoda202.Size = new System.Drawing.Size(95, 39);
            this.btnoda202.TabIndex = 10;
            this.btnoda202.Text = "202";
            this.btnoda202.UseVisualStyleBackColor = false;
            this.btnoda202.Click += new System.EventHandler(this.btnoda202_Click);
            // 
            // btnoda201
            // 
            this.btnoda201.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda201.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda201.Location = new System.Drawing.Point(75, 431);
            this.btnoda201.Name = "btnoda201";
            this.btnoda201.Size = new System.Drawing.Size(95, 39);
            this.btnoda201.TabIndex = 9;
            this.btnoda201.Text = "201";
            this.btnoda201.UseVisualStyleBackColor = false;
            this.btnoda201.Click += new System.EventHandler(this.btnoda201_Click);
            // 
            // btnoda109
            // 
            this.btnoda109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda109.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda109.Location = new System.Drawing.Point(380, 309);
            this.btnoda109.Name = "btnoda109";
            this.btnoda109.Size = new System.Drawing.Size(95, 40);
            this.btnoda109.TabIndex = 8;
            this.btnoda109.Text = "109";
            this.btnoda109.UseVisualStyleBackColor = false;
            this.btnoda109.Click += new System.EventHandler(this.btn109_Click);
            // 
            // btnoda108
            // 
            this.btnoda108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda108.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoda108.Location = new System.Drawing.Point(227, 309);
            this.btnoda108.Name = "btnoda108";
            this.btnoda108.Size = new System.Drawing.Size(95, 40);
            this.btnoda108.TabIndex = 7;
            this.btnoda108.Text = "108";
            this.btnoda108.UseVisualStyleBackColor = false;
            this.btnoda108.Click += new System.EventHandler(this.btn108_Click);
            // 
            // btnoda107
            // 
            this.btnoda107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda107.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda107.Location = new System.Drawing.Point(75, 309);
            this.btnoda107.Name = "btnoda107";
            this.btnoda107.Size = new System.Drawing.Size(95, 40);
            this.btnoda107.TabIndex = 6;
            this.btnoda107.Text = "107";
            this.btnoda107.UseVisualStyleBackColor = false;
            this.btnoda107.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnoda106
            // 
            this.btnoda106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda106.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda106.Location = new System.Drawing.Point(380, 191);
            this.btnoda106.Name = "btnoda106";
            this.btnoda106.Size = new System.Drawing.Size(95, 40);
            this.btnoda106.TabIndex = 5;
            this.btnoda106.Text = "106";
            this.btnoda106.UseVisualStyleBackColor = false;
            this.btnoda106.Click += new System.EventHandler(this.btnoda106_Click);
            // 
            // btnoda105
            // 
            this.btnoda105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda105.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda105.Location = new System.Drawing.Point(227, 198);
            this.btnoda105.Name = "btnoda105";
            this.btnoda105.Size = new System.Drawing.Size(95, 41);
            this.btnoda105.TabIndex = 4;
            this.btnoda105.Text = "105";
            this.btnoda105.UseVisualStyleBackColor = false;
            this.btnoda105.Click += new System.EventHandler(this.btnoda105_Click);
            // 
            // btnoda104
            // 
            this.btnoda104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda104.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda104.Location = new System.Drawing.Point(75, 198);
            this.btnoda104.Name = "btnoda104";
            this.btnoda104.Size = new System.Drawing.Size(95, 39);
            this.btnoda104.TabIndex = 3;
            this.btnoda104.Text = "104";
            this.btnoda104.UseVisualStyleBackColor = false;
            this.btnoda104.Click += new System.EventHandler(this.btnoda104_Click);
            // 
            // btnoda103
            // 
            this.btnoda103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda103.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda103.Location = new System.Drawing.Point(380, 74);
            this.btnoda103.Name = "btnoda103";
            this.btnoda103.Size = new System.Drawing.Size(95, 39);
            this.btnoda103.TabIndex = 2;
            this.btnoda103.Text = "103";
            this.btnoda103.UseVisualStyleBackColor = false;
            this.btnoda103.Click += new System.EventHandler(this.btnoda103_Click);
            // 
            // btnoda102
            // 
            this.btnoda102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda102.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda102.Location = new System.Drawing.Point(227, 74);
            this.btnoda102.Name = "btnoda102";
            this.btnoda102.Size = new System.Drawing.Size(95, 39);
            this.btnoda102.TabIndex = 1;
            this.btnoda102.Text = "102";
            this.btnoda102.UseVisualStyleBackColor = false;
            this.btnoda102.Click += new System.EventHandler(this.btnoda102_Click);
            // 
            // btnoda101
            // 
            this.btnoda101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnoda101.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoda101.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnoda101.Location = new System.Drawing.Point(75, 74);
            this.btnoda101.Name = "btnoda101";
            this.btnoda101.Size = new System.Drawing.Size(95, 39);
            this.btnoda101.TabIndex = 0;
            this.btnoda101.Text = "101";
            this.btnoda101.UseVisualStyleBackColor = false;
            this.btnoda101.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndoluoda
            // 
            this.btndoluoda.BackColor = System.Drawing.Color.Red;
            this.btndoluoda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoluoda.ForeColor = System.Drawing.Color.Black;
            this.btndoluoda.Location = new System.Drawing.Point(838, 638);
            this.btndoluoda.Name = "btndoluoda";
            this.btndoluoda.Size = new System.Drawing.Size(95, 35);
            this.btndoluoda.TabIndex = 2;
            this.btndoluoda.Text = "Dolu";
            this.btndoluoda.UseVisualStyleBackColor = false;
            this.btndoluoda.Click += new System.EventHandler(this.btndoluoda_Click);
            // 
            // btnbosoda
            // 
            this.btnbosoda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbosoda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbosoda.Location = new System.Drawing.Point(991, 638);
            this.btnbosoda.Name = "btnbosoda";
            this.btnbosoda.Size = new System.Drawing.Size(95, 35);
            this.btnbosoda.TabIndex = 3;
            this.btnbosoda.Text = "Boş";
            this.btnbosoda.UseVisualStyleBackColor = false;
            this.btnbosoda.Click += new System.EventHandler(this.btnbosoda_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(20, 708);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1129, 159);
            this.listBox1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1174, 884);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnbosoda);
            this.Controls.Add(this.btndoluoda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DateTimePicker dtpcikistarihi;
        private System.Windows.Forms.DateTimePicker dtpgiristarihi;
        private System.Windows.Forms.MaskedTextBox msktxttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnoda203;
        private System.Windows.Forms.Button btnoda202;
        private System.Windows.Forms.Button btnoda201;
        private System.Windows.Forms.Button btnoda109;
        private System.Windows.Forms.Button btnoda108;
        private System.Windows.Forms.Button btnoda107;
        private System.Windows.Forms.Button btnoda106;
        private System.Windows.Forms.Button btnoda105;
        private System.Windows.Forms.Button btnoda104;
        private System.Windows.Forms.Button btnoda103;
        private System.Windows.Forms.Button btnoda102;
        private System.Windows.Forms.Button btnoda101;
        private System.Windows.Forms.Button btndoluoda;
        private System.Windows.Forms.Button btnbosoda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox mskkimlik;
        private System.Windows.Forms.MaskedTextBox mskodano;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


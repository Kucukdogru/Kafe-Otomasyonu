namespace KafeOtomasyonu
{
    partial class FrmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kafe1 = new KafeOtomasyonu.Kafe();
            this.button2 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productGroupTableAdapter1 = new KafeOtomasyonu.KafeTableAdapters.ProductGroupTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.productTableAdapter1 = new KafeOtomasyonu.KafeTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem,
            this.ürünleriListeleToolStripMenuItem});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // ürünleriListeleToolStripMenuItem
            // 
            this.ürünleriListeleToolStripMenuItem.Name = "ürünleriListeleToolStripMenuItem";
            this.ürünleriListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ürünleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.ürünleriListeleToolStripMenuItem.Click += new System.EventHandler(this.ürünleriListeleToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::KafeOtomasyonu.Properties.Resources.iconfinder_Delete_1493279;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(66, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "İptal";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productGroupBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "ProductGroupId";
            // 
            // productGroupBindingSource
            // 
            this.productGroupBindingSource.DataMember = "ProductGroup";
            this.productGroupBindingSource.DataSource = this.kafe1;
            // 
            // kafe1
            // 
            this.kafe1.DataSetName = "Kafe";
            this.kafe1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(401, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "Gözat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Lime;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update.Image = global::KafeOtomasyonu.Properties.Resources.iconfinder_new_24_103173;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.Location = new System.Drawing.Point(269, 240);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 42);
            this.update.TabIndex = 33;
            this.update.Text = "Güncelle";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 120);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(119, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 23);
            this.textBox4.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(119, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(119, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Resim Yolu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ürün Grubu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ürün Adı:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // productGroupTableAdapter1
            // 
            this.productGroupTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = global::KafeOtomasyonu.Properties.Resources.iconfinder_add_134224;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(168, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 42);
            this.button4.TabIndex = 37;
            this.button4.Text = "Ekle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = global::KafeOtomasyonu.Properties.Resources.iconfinder_trash_bin_1370026;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(391, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 42);
            this.button5.TabIndex = 38;
            this.button5.Text = "Sil";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunListele";
            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productGroupBindingSource;
        private Kafe kafe1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private KafeTableAdapters.ProductGroupTableAdapter productGroupTableAdapter1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button5;
        private KafeTableAdapters.ProductTableAdapter productTableAdapter1;
    }
}
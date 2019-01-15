namespace XMLVeriIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnVeriBul = new System.Windows.Forms.Button();
            this.btnXPathileTekBul = new System.Windows.Forms.Button();
            this.btnXPathileVerileriBul = new System.Windows.Forms.Button();
            this.btnVeriDegistir = new System.Windows.Forms.Button();
            this.btnXMLVeriSil = new System.Windows.Forms.Button();
            this.btnXMLSchemaDogrula = new System.Windows.Forms.Button();
            this.btnSQLdenSchema = new System.Windows.Forms.Button();
            this.btnSchemaOlustur = new System.Windows.Forms.Button();
            this.btnXMLtoSQL = new System.Windows.Forms.Button();
            this.btnSQLtoXML = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(12, 165);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(142, 31);
            this.btnVeriOku.TabIndex = 1;
            this.btnVeriOku.Text = "xml dosyadan veri oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnVeriBul
            // 
            this.btnVeriBul.Location = new System.Drawing.Point(12, 202);
            this.btnVeriBul.Name = "btnVeriBul";
            this.btnVeriBul.Size = new System.Drawing.Size(142, 31);
            this.btnVeriBul.TabIndex = 1;
            this.btnVeriBul.Text = "xml içindeki veriyi bul";
            this.btnVeriBul.UseVisualStyleBackColor = true;
            this.btnVeriBul.Click += new System.EventHandler(this.btnVeriBul_Click);
            // 
            // btnXPathileTekBul
            // 
            this.btnXPathileTekBul.Location = new System.Drawing.Point(12, 239);
            this.btnXPathileTekBul.Name = "btnXPathileTekBul";
            this.btnXPathileTekBul.Size = new System.Drawing.Size(142, 31);
            this.btnXPathileTekBul.TabIndex = 1;
            this.btnXPathileTekBul.Text = "xml de veriyi xpath ile bul";
            this.btnXPathileTekBul.UseVisualStyleBackColor = true;
            this.btnXPathileTekBul.Click += new System.EventHandler(this.btnXPathileTekBul_Click);
            // 
            // btnXPathileVerileriBul
            // 
            this.btnXPathileVerileriBul.Location = new System.Drawing.Point(12, 276);
            this.btnXPathileVerileriBul.Name = "btnXPathileVerileriBul";
            this.btnXPathileVerileriBul.Size = new System.Drawing.Size(142, 31);
            this.btnXPathileVerileriBul.TabIndex = 1;
            this.btnXPathileVerileriBul.Text = "xml de verileri xpath ile bul";
            this.btnXPathileVerileriBul.UseVisualStyleBackColor = true;
            this.btnXPathileVerileriBul.Click += new System.EventHandler(this.btnXPathileVerileriBul_Click);
            // 
            // btnVeriDegistir
            // 
            this.btnVeriDegistir.Location = new System.Drawing.Point(12, 313);
            this.btnVeriDegistir.Name = "btnVeriDegistir";
            this.btnVeriDegistir.Size = new System.Drawing.Size(142, 31);
            this.btnVeriDegistir.TabIndex = 1;
            this.btnVeriDegistir.Text = "xml içindeki veriyi değiştir";
            this.btnVeriDegistir.UseVisualStyleBackColor = true;
            this.btnVeriDegistir.Click += new System.EventHandler(this.btnVeriDegistir_Click);
            // 
            // btnXMLVeriSil
            // 
            this.btnXMLVeriSil.Location = new System.Drawing.Point(12, 350);
            this.btnXMLVeriSil.Name = "btnXMLVeriSil";
            this.btnXMLVeriSil.Size = new System.Drawing.Size(142, 31);
            this.btnXMLVeriSil.TabIndex = 1;
            this.btnXMLVeriSil.Text = "xml den veri sil";
            this.btnXMLVeriSil.UseVisualStyleBackColor = true;
            this.btnXMLVeriSil.Click += new System.EventHandler(this.btnXMLVeriSil_Click);
            // 
            // btnXMLSchemaDogrula
            // 
            this.btnXMLSchemaDogrula.Location = new System.Drawing.Point(191, 364);
            this.btnXMLSchemaDogrula.Name = "btnXMLSchemaDogrula";
            this.btnXMLSchemaDogrula.Size = new System.Drawing.Size(142, 31);
            this.btnXMLSchemaDogrula.TabIndex = 2;
            this.btnXMLSchemaDogrula.Text = "xml schema dogrulama";
            this.btnXMLSchemaDogrula.UseVisualStyleBackColor = true;
            this.btnXMLSchemaDogrula.Click += new System.EventHandler(this.btnXMLSchemaDogrula_Click);
            // 
            // btnSQLdenSchema
            // 
            this.btnSQLdenSchema.Location = new System.Drawing.Point(191, 313);
            this.btnSQLdenSchema.Name = "btnSQLdenSchema";
            this.btnSQLdenSchema.Size = new System.Drawing.Size(142, 45);
            this.btnSQLdenSchema.TabIndex = 3;
            this.btnSQLdenSchema.Text = "sql den istenen semaya uygun xml olustur";
            this.btnSQLdenSchema.UseVisualStyleBackColor = true;
            this.btnSQLdenSchema.Click += new System.EventHandler(this.btnSQLdenSchema_Click);
            // 
            // btnSchemaOlustur
            // 
            this.btnSchemaOlustur.Location = new System.Drawing.Point(191, 276);
            this.btnSchemaOlustur.Name = "btnSchemaOlustur";
            this.btnSchemaOlustur.Size = new System.Drawing.Size(142, 31);
            this.btnSchemaOlustur.TabIndex = 4;
            this.btnSchemaOlustur.Text = "xml schemalarını oluştur";
            this.btnSchemaOlustur.UseVisualStyleBackColor = true;
            this.btnSchemaOlustur.Click += new System.EventHandler(this.btnSchemaOlustur_Click);
            // 
            // btnXMLtoSQL
            // 
            this.btnXMLtoSQL.Location = new System.Drawing.Point(191, 239);
            this.btnXMLtoSQL.Name = "btnXMLtoSQL";
            this.btnXMLtoSQL.Size = new System.Drawing.Size(142, 31);
            this.btnXMLtoSQL.TabIndex = 5;
            this.btnXMLtoSQL.Text = "xml den veri tabanına yaz";
            this.btnXMLtoSQL.UseVisualStyleBackColor = true;
            this.btnXMLtoSQL.Click += new System.EventHandler(this.btnXMLtoSQL_Click);
            // 
            // btnSQLtoXML
            // 
            this.btnSQLtoXML.Location = new System.Drawing.Point(191, 202);
            this.btnSQLtoXML.Name = "btnSQLtoXML";
            this.btnSQLtoXML.Size = new System.Drawing.Size(142, 31);
            this.btnSQLtoXML.TabIndex = 6;
            this.btnSQLtoXML.Text = "veri tabanından xmle oku";
            this.btnSQLtoXML.UseVisualStyleBackColor = true;
            this.btnSQLtoXML.Click += new System.EventHandler(this.btnSQLtoXML_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(191, 165);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(142, 31);
            this.btnAddChild.TabIndex = 7;
            this.btnAddChild.Text = "xml e veri ekle";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(362, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(315, 369);
            this.webBrowser1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnXMLSchemaDogrula);
            this.Controls.Add(this.btnSQLdenSchema);
            this.Controls.Add(this.btnSchemaOlustur);
            this.Controls.Add(this.btnXMLtoSQL);
            this.Controls.Add(this.btnSQLtoXML);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnXMLVeriSil);
            this.Controls.Add(this.btnVeriDegistir);
            this.Controls.Add(this.btnXPathileVerileriBul);
            this.Controls.Add(this.btnXPathileTekBul);
            this.Controls.Add(this.btnVeriBul);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnVeriBul;
        private System.Windows.Forms.Button btnXPathileTekBul;
        private System.Windows.Forms.Button btnXPathileVerileriBul;
        private System.Windows.Forms.Button btnVeriDegistir;
        private System.Windows.Forms.Button btnXMLVeriSil;
        private System.Windows.Forms.Button btnXMLSchemaDogrula;
        private System.Windows.Forms.Button btnSQLdenSchema;
        private System.Windows.Forms.Button btnSchemaOlustur;
        private System.Windows.Forms.Button btnXMLtoSQL;
        private System.Windows.Forms.Button btnSQLtoXML;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


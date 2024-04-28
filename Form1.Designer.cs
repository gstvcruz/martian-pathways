namespace apMartianPathways
{
  partial class FrmPaths
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaths));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCities = new System.Windows.Forms.TabPage();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.lsbCities = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.udY = new System.Windows.Forms.NumericUpDown();
            this.udX = new System.Windows.Forms.NumericUpDown();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rbDoubleHashing = new System.Windows.Forms.RadioButton();
            this.rbQuadraticProbing = new System.Windows.Forms.RadioButton();
            this.rbLinearProbing = new System.Windows.Forms.RadioButton();
            this.rbBucketHashing = new System.Windows.Forms.RadioButton();
            this.tpPaths = new System.Windows.Forms.TabPage();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCities);
            this.tabControl1.Controls.Add(this.tpPaths);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1871, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCities
            // 
            this.tpCities.Controls.Add(this.pbMap);
            this.tpCities.Controls.Add(this.lsbCities);
            this.tpCities.Controls.Add(this.btnList);
            this.tpCities.Controls.Add(this.btnSearch);
            this.tpCities.Controls.Add(this.btnRemove);
            this.tpCities.Controls.Add(this.btnInsert);
            this.tpCities.Controls.Add(this.udY);
            this.tpCities.Controls.Add(this.udX);
            this.tpCities.Controls.Add(this.txtCity);
            this.tpCities.Controls.Add(this.label3);
            this.tpCities.Controls.Add(this.label2);
            this.tpCities.Controls.Add(this.label1);
            this.tpCities.Controls.Add(this.groupBox1);
            this.tpCities.Location = new System.Drawing.Point(4, 22);
            this.tpCities.Name = "tpCities";
            this.tpCities.Padding = new System.Windows.Forms.Padding(3);
            this.tpCities.Size = new System.Drawing.Size(1863, 674);
            this.tpCities.TabIndex = 0;
            this.tpCities.Text = "Cities";
            this.tpCities.UseVisualStyleBackColor = true;
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(275, 60);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1585, 602);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 12;
            this.pbMap.TabStop = false;
            // 
            // lsbCities
            // 
            this.lsbCities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbCities.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCities.FormattingEnabled = true;
            this.lsbCities.ItemHeight = 14;
            this.lsbCities.Location = new System.Drawing.Point(10, 193);
            this.lsbCities.Name = "lsbCities";
            this.lsbCities.ScrollAlwaysVisible = true;
            this.lsbCities.Size = new System.Drawing.Size(259, 466);
            this.lsbCities.Sorted = true;
            this.lsbCities.TabIndex = 11;
            // 
            // btnList
            // 
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(148, 156);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(40, 30);
            this.btnList.TabIndex = 10;
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(102, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 156);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 30);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(10, 156);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(40, 30);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "+";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // udY
            // 
            this.udY.DecimalPlaces = 5;
            this.udY.Location = new System.Drawing.Point(56, 126);
            this.udY.Name = "udY";
            this.udY.Size = new System.Drawing.Size(75, 20);
            this.udY.TabIndex = 6;
            // 
            // udX
            // 
            this.udX.DecimalPlaces = 5;
            this.udX.Location = new System.Drawing.Point(56, 100);
            this.udX.Name = "udX";
            this.udX.Size = new System.Drawing.Size(75, 20);
            this.udX.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(56, 71);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.rbDoubleHashing);
            this.groupBox1.Controls.Add(this.rbQuadraticProbing);
            this.groupBox1.Controls.Add(this.rbLinearProbing);
            this.groupBox1.Controls.Add(this.rbBucketHashing);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1857, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected hashing technique";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.Location = new System.Drawing.Point(1775, 16);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(76, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // rbDoubleHashing
            // 
            this.rbDoubleHashing.AutoSize = true;
            this.rbDoubleHashing.Location = new System.Drawing.Point(374, 19);
            this.rbDoubleHashing.Name = "rbDoubleHashing";
            this.rbDoubleHashing.Size = new System.Drawing.Size(101, 17);
            this.rbDoubleHashing.TabIndex = 3;
            this.rbDoubleHashing.Text = "Double Hashing";
            this.rbDoubleHashing.UseVisualStyleBackColor = true;
            // 
            // rbQuadraticProbing
            // 
            this.rbQuadraticProbing.AutoSize = true;
            this.rbQuadraticProbing.Location = new System.Drawing.Point(246, 19);
            this.rbQuadraticProbing.Name = "rbQuadraticProbing";
            this.rbQuadraticProbing.Size = new System.Drawing.Size(110, 17);
            this.rbQuadraticProbing.TabIndex = 2;
            this.rbQuadraticProbing.Text = "Quadratic Probing";
            this.rbQuadraticProbing.UseVisualStyleBackColor = true;
            // 
            // rbLinearProbing
            // 
            this.rbLinearProbing.AutoSize = true;
            this.rbLinearProbing.Location = new System.Drawing.Point(135, 19);
            this.rbLinearProbing.Name = "rbLinearProbing";
            this.rbLinearProbing.Size = new System.Drawing.Size(93, 17);
            this.rbLinearProbing.TabIndex = 1;
            this.rbLinearProbing.Text = "Linear Probing";
            this.rbLinearProbing.UseVisualStyleBackColor = true;
            // 
            // rbBucketHashing
            // 
            this.rbBucketHashing.AutoSize = true;
            this.rbBucketHashing.Checked = true;
            this.rbBucketHashing.Location = new System.Drawing.Point(16, 19);
            this.rbBucketHashing.Name = "rbBucketHashing";
            this.rbBucketHashing.Size = new System.Drawing.Size(101, 17);
            this.rbBucketHashing.TabIndex = 0;
            this.rbBucketHashing.TabStop = true;
            this.rbBucketHashing.Text = "Bucket Hashing";
            this.rbBucketHashing.UseVisualStyleBackColor = true;
            // 
            // tpPaths
            // 
            this.tpPaths.Location = new System.Drawing.Point(4, 22);
            this.tpPaths.Name = "tpPaths";
            this.tpPaths.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaths.Size = new System.Drawing.Size(1863, 674);
            this.tpPaths.TabIndex = 1;
            this.tpPaths.Text = "Paths";
            this.tpPaths.UseVisualStyleBackColor = true;
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "*.txt";
            // 
            // FrmPaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 702);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPaths";
            this.Text = "Martian Pathways - 23513 - 23521";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPaths_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tpCities.ResumeLayout(false);
            this.tpCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCities;
    private System.Windows.Forms.TabPage tpPaths;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbDoubleHashing;
    private System.Windows.Forms.RadioButton rbQuadraticProbing;
    private System.Windows.Forms.RadioButton rbLinearProbing;
    private System.Windows.Forms.RadioButton rbBucketHashing;
    private System.Windows.Forms.Button btnOpenFile;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown udX;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.NumericUpDown udY;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnList;
    private System.Windows.Forms.ListBox lsbCities;
    private System.Windows.Forms.PictureBox pbMap;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
  }
}

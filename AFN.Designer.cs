namespace Teoria_Computacional {
    partial class AFN {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
			this.tblAFN = new System.Windows.Forms.TableLayoutPanel();
			this.btnOpenFile = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnConvert = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnSaveFile = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtTransiciones = new System.Windows.Forms.TextBox();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.sfAFD = new System.Windows.Forms.SaveFileDialog();
			this.OFAFN = new System.Windows.Forms.OpenFileDialog();
			this.tblAFN.SuspendLayout();
			this.SuspendLayout();
			// 
			// tblAFN
			// 
			this.tblAFN.ColumnCount = 2;
			this.tblAFN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblAFN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblAFN.Controls.Add(this.btnOpenFile, 0, 1);
			this.tblAFN.Controls.Add(this.btnConvert, 1, 2);
			this.tblAFN.Controls.Add(this.btnSaveFile, 1, 4);
			this.tblAFN.Controls.Add(this.materialLabel1, 0, 0);
			this.tblAFN.Controls.Add(this.txtTransiciones, 0, 3);
			this.tblAFN.Controls.Add(this.materialFlatButton1, 0, 2);
			this.tblAFN.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblAFN.Location = new System.Drawing.Point(0, 0);
			this.tblAFN.Name = "tblAFN";
			this.tblAFN.RowCount = 5;
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.631599F));
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44738F));
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72502F));
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.25163F));
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72502F));
			this.tblAFN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21936F));
			this.tblAFN.Size = new System.Drawing.Size(414, 354);
			this.tblAFN.TabIndex = 0;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOpenFile.AutoSize = true;
			this.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tblAFN.SetColumnSpan(this.btnOpenFile, 2);
			this.btnOpenFile.Depth = 0;
			this.btnOpenFile.Icon = null;
			this.btnOpenFile.Location = new System.Drawing.Point(120, 41);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Primary = false;
			this.btnOpenFile.Size = new System.Drawing.Size(173, 36);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Seleccionar Archivo";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnConvert.AutoSize = true;
			this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnConvert.Depth = 0;
			this.btnConvert.Enabled = false;
			this.btnConvert.Icon = null;
			this.btnConvert.Location = new System.Drawing.Point(248, 91);
			this.btnConvert.Margin = new System.Windows.Forms.Padding(0);
			this.btnConvert.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Primary = false;
			this.btnConvert.Size = new System.Drawing.Size(125, 36);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Convertir AFN";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSaveFile.AutoSize = true;
			this.btnSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tblAFN.SetColumnSpan(this.btnSaveFile, 2);
			this.btnSaveFile.Depth = 0;
			this.btnSaveFile.Icon = null;
			this.btnSaveFile.Location = new System.Drawing.Point(109, 311);
			this.btnSaveFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnSaveFile.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Primary = false;
			this.btnSaveFile.Size = new System.Drawing.Size(195, 36);
			this.btnSaveFile.TabIndex = 3;
			this.btnSaveFile.Text = "Guardar Configuracion";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel1.AutoSize = true;
			this.tblAFN.SetColumnSpan(this.materialLabel1, 2);
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(129, 7);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(155, 19);
			this.materialLabel1.TabIndex = 4;
			this.materialLabel1.Text = "Convertir AFN en AFD";
			// 
			// txtTransiciones
			// 
			this.tblAFN.SetColumnSpan(this.txtTransiciones, 2);
			this.txtTransiciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTransiciones.Location = new System.Drawing.Point(8, 141);
			this.txtTransiciones.Margin = new System.Windows.Forms.Padding(8);
			this.txtTransiciones.Multiline = true;
			this.txtTransiciones.Name = "txtTransiciones";
			this.tblAFN.SetRowSpan(this.txtTransiciones, 2);
			this.txtTransiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTransiciones.Size = new System.Drawing.Size(398, 156);
			this.txtTransiciones.TabIndex = 5;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(58, 91);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(0);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
			this.materialFlatButton1.TabIndex = 6;
			this.materialFlatButton1.Text = "Cancelar";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
			// 
			// sfAFD
			// 
			this.sfAFD.DefaultExt = "json";
			this.sfAFD.Filter = "Archivos JSON | *.json";
			this.sfAFD.Title = "Guardar Configuracion";
			// 
			// OFAFN
			// 
			this.OFAFN.Filter = "Archivos JSON | *.json";
			// 
			// AFN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 354);
			this.Controls.Add(this.tblAFN);
			this.Name = "AFN";
			this.Text = "AFN";
			this.tblAFN.ResumeLayout(false);
			this.tblAFN.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAFN;
        private MaterialSkin.Controls.MaterialFlatButton btnOpenFile;
        private MaterialSkin.Controls.MaterialFlatButton btnConvert;
        private MaterialSkin.Controls.MaterialFlatButton btnSaveFile;
        private System.Windows.Forms.SaveFileDialog sfAFD;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtTransiciones;
        private System.Windows.Forms.OpenFileDialog OFAFN;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
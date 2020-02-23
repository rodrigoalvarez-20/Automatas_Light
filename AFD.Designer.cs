namespace Teoria_Computacional {
    partial class AFD {
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
			this.TBLAFD = new System.Windows.Forms.TableLayoutPanel();
			this.btnOpenFile = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtCadena = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lblResult = new MaterialSkin.Controls.MaterialLabel();
			this.btnValidate = new MaterialSkin.Controls.MaterialFlatButton();
			this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
			this.OFAFD = new System.Windows.Forms.OpenFileDialog();
			this.TBLAFD.SuspendLayout();
			this.SuspendLayout();
			// 
			// TBLAFD
			// 
			this.TBLAFD.ColumnCount = 2;
			this.TBLAFD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TBLAFD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TBLAFD.Controls.Add(this.btnOpenFile, 0, 0);
			this.TBLAFD.Controls.Add(this.materialLabel1, 0, 1);
			this.TBLAFD.Controls.Add(this.txtCadena, 0, 2);
			this.TBLAFD.Controls.Add(this.lblResult, 0, 4);
			this.TBLAFD.Controls.Add(this.btnValidate, 1, 3);
			this.TBLAFD.Controls.Add(this.btnBack, 0, 3);
			this.TBLAFD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TBLAFD.Location = new System.Drawing.Point(0, 0);
			this.TBLAFD.Name = "TBLAFD";
			this.TBLAFD.RowCount = 5;
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TBLAFD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TBLAFD.Size = new System.Drawing.Size(340, 249);
			this.TBLAFD.TabIndex = 0;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOpenFile.AutoSize = true;
			this.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TBLAFD.SetColumnSpan(this.btnOpenFile, 2);
			this.btnOpenFile.Depth = 0;
			this.btnOpenFile.Icon = null;
			this.btnOpenFile.Location = new System.Drawing.Point(83, 6);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Primary = false;
			this.btnOpenFile.Size = new System.Drawing.Size(173, 25);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Seleccionar Archivo";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel1.AutoSize = true;
			this.TBLAFD.SetColumnSpan(this.materialLabel1, 2);
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(73, 39);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(194, 19);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "Ingrese la cadena a evaluar:";
			// 
			// txtCadena
			// 
			this.txtCadena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TBLAFD.SetColumnSpan(this.txtCadena, 2);
			this.txtCadena.Depth = 0;
			this.txtCadena.Enabled = false;
			this.txtCadena.Hint = "10101010";
			this.txtCadena.Location = new System.Drawing.Point(30, 93);
			this.txtCadena.MaxLength = 32767;
			this.txtCadena.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtCadena.Name = "txtCadena";
			this.txtCadena.PasswordChar = '\0';
			this.txtCadena.SelectedText = "";
			this.txtCadena.SelectionLength = 0;
			this.txtCadena.SelectionStart = 0;
			this.txtCadena.Size = new System.Drawing.Size(280, 23);
			this.txtCadena.TabIndex = 2;
			this.txtCadena.TabStop = false;
			this.txtCadena.UseSystemPasswordChar = false;
			// 
			// lblResult
			// 
			this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblResult.AutoSize = true;
			this.TBLAFD.SetColumnSpan(this.lblResult, 2);
			this.lblResult.Depth = 0;
			this.lblResult.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblResult.Location = new System.Drawing.Point(119, 207);
			this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(101, 19);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "La cadena es:";
			// 
			// btnValidate
			// 
			this.btnValidate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnValidate.AutoSize = true;
			this.btnValidate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnValidate.Depth = 0;
			this.btnValidate.Icon = null;
			this.btnValidate.Location = new System.Drawing.Point(239, 152);
			this.btnValidate.Margin = new System.Windows.Forms.Padding(4, 4, 24, 4);
			this.btnValidate.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Primary = false;
			this.btnValidate.Size = new System.Drawing.Size(77, 29);
			this.btnValidate.TabIndex = 4;
			this.btnValidate.Text = "Validar";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// btnBack
			// 
			this.btnBack.AutoSize = true;
			this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBack.Depth = 0;
			this.btnBack.Icon = null;
			this.btnBack.Location = new System.Drawing.Point(20, 154);
			this.btnBack.Margin = new System.Windows.Forms.Padding(20, 6, 4, 6);
			this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnBack.Name = "btnBack";
			this.btnBack.Primary = false;
			this.btnBack.Size = new System.Drawing.Size(89, 25);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "Regresar";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// OFAFD
			// 
			this.OFAFD.Filter = "Archivos JSON | *.json";
			this.OFAFD.Title = "Abrir Configuracion";
			// 
			// AFD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 249);
			this.Controls.Add(this.TBLAFD);
			this.Name = "AFD";
			this.Text = "AFD";
			this.TBLAFD.ResumeLayout(false);
			this.TBLAFD.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TBLAFD;
        private MaterialSkin.Controls.MaterialFlatButton btnOpenFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCadena;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private System.Windows.Forms.OpenFileDialog OFAFD;
        private MaterialSkin.Controls.MaterialFlatButton btnValidate;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
    }
}
namespace Teoria_Computacional {
    partial class frmInicio {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose (bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent () {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnAFD = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAFN = new MaterialSkin.Controls.MaterialFlatButton();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.btnAFD, 0, 1);
            this.tblMain.Controls.Add(this.btnAFN, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Size = new System.Drawing.Size(322, 267);
            this.tblMain.TabIndex = 0;
            // 
            // btnAFD
            // 
            this.btnAFD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAFD.AutoSize = true;
            this.btnAFD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.SetColumnSpan(this.btnAFD, 2);
            this.btnAFD.Depth = 0;
            this.btnAFD.Location = new System.Drawing.Point(114, 81);
            this.btnAFD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAFD.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAFD.Name = "btnAFD";
            this.btnAFD.Primary = false;
            this.btnAFD.Size = new System.Drawing.Size(94, 36);
            this.btnAFD.TabIndex = 7;
            this.btnAFD.Text = "Probar AFD";
            this.btnAFD.UseVisualStyleBackColor = true;
            this.btnAFD.Click += new System.EventHandler(this.btnAFD_Click);
            // 
            // btnAFN
            // 
            this.btnAFN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAFN.AutoSize = true;
            this.btnAFN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.SetColumnSpan(this.btnAFN, 2);
            this.btnAFN.Depth = 0;
            this.btnAFN.Location = new System.Drawing.Point(103, 147);
            this.btnAFN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAFN.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAFN.Name = "btnAFN";
            this.btnAFN.Primary = false;
            this.btnAFN.Size = new System.Drawing.Size(116, 36);
            this.btnAFN.TabIndex = 6;
            this.btnAFN.Text = "Convertir AFN";
            this.btnAFN.UseVisualStyleBackColor = true;
            this.btnAFN.Click += new System.EventHandler(this.btnAFN_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 267);
            this.Controls.Add(this.tblMain);
            this.Name = "frmInicio";
            this.Text = "Automatas";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private MaterialSkin.Controls.MaterialFlatButton btnAFD;
        private MaterialSkin.Controls.MaterialFlatButton btnAFN;
    }
}


namespace CacaNiquel
{
    partial class FrmCacaNiquel
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
            this.lblNiquel1 = new System.Windows.Forms.Label();
            this.lblNiquel2 = new System.Windows.Forms.Label();
            this.lblNiquel3 = new System.Windows.Forms.Label();
            this.btGirar = new System.Windows.Forms.Button();
            this.tmrSorteioGeral = new System.Windows.Forms.Timer(this.components);
            this.btnJogar = new System.Windows.Forms.Button();
            this.tmrNiquel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNiquel1
            // 
            this.lblNiquel1.BackColor = System.Drawing.Color.Lime;
            this.lblNiquel1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel1.Location = new System.Drawing.Point(152, 119);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(60, 55);
            this.lblNiquel1.TabIndex = 0;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNiquel1.Click += new System.EventHandler(this.lblNiquel1_Click);
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.BackColor = System.Drawing.Color.Lime;
            this.lblNiquel2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel2.Location = new System.Drawing.Point(240, 119);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(59, 55);
            this.lblNiquel2.TabIndex = 1;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.BackColor = System.Drawing.Color.Lime;
            this.lblNiquel3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel3.Location = new System.Drawing.Point(327, 119);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(56, 55);
            this.lblNiquel3.TabIndex = 2;
            this.lblNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btGirar
            // 
            this.btGirar.Location = new System.Drawing.Point(21, 379);
            this.btGirar.Name = "btGirar";
            this.btGirar.Size = new System.Drawing.Size(100, 59);
            this.btGirar.TabIndex = 3;
            this.btGirar.Text = "&Girar";
            this.btGirar.UseVisualStyleBackColor = true;
            this.btGirar.Click += new System.EventHandler(this.btGirar_Click);
            // 
            // tmrSorteioGeral
            // 
            this.tmrSorteioGeral.Interval = 1000;
            this.tmrSorteioGeral.Tick += new System.EventHandler(this.tmrSorteioGeral_Tick);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(192, 213);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(158, 59);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Tick += new System.EventHandler(this.tmrNiquel_Tick);
            // 
            // FrmCacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btGirar);
            this.Controls.Add(this.lblNiquel3);
            this.Controls.Add(this.lblNiquel2);
            this.Controls.Add(this.lblNiquel1);
            this.Name = "FrmCacaNiquel";
            this.Text = "CacaNiquel";
            this.Load += new System.EventHandler(this.FrmCacaNiquel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNiquel1;
        private System.Windows.Forms.Label lblNiquel2;
        private System.Windows.Forms.Label lblNiquel3;
        private System.Windows.Forms.Button btGirar;
        private System.Windows.Forms.Timer tmrSorteioGeral;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Timer tmrNiquel;
    }
}


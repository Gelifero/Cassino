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
            this.lblNiquel1.AutoSize = true;
            this.lblNiquel1.Location = new System.Drawing.Point(245, 117);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(0, 13);
            this.lblNiquel1.TabIndex = 0;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.AutoSize = true;
            this.lblNiquel2.Location = new System.Drawing.Point(289, 117);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(0, 13);
            this.lblNiquel2.TabIndex = 1;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.AutoSize = true;
            this.lblNiquel3.Location = new System.Drawing.Point(331, 117);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(0, 13);
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
            this.btnJogar.Location = new System.Drawing.Point(212, 230);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(158, 59);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Interval = 300;
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
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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


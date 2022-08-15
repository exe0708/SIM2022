
namespace TP1_Sim_GrupoE
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_metodoLibre = new System.Windows.Forms.Button();
            this.btn_metodoSugerido = new System.Windows.Forms.Button();
            this.btn_metodoRNDC = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_metodoLibre
            // 
            this.btn_metodoLibre.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources._5f463b0e803a0d0004146be2;
            this.btn_metodoLibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_metodoLibre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_metodoLibre.Image = ((System.Drawing.Image)(resources.GetObject("btn_metodoLibre.Image")));
            this.btn_metodoLibre.Location = new System.Drawing.Point(703, 402);
            this.btn_metodoLibre.Name = "btn_metodoLibre";
            this.btn_metodoLibre.Size = new System.Drawing.Size(143, 23);
            this.btn_metodoLibre.TabIndex = 0;
            this.btn_metodoLibre.Text = "Método Libre";
            this.btn_metodoLibre.UseVisualStyleBackColor = true;
            this.btn_metodoLibre.Click += new System.EventHandler(this.btn_metodoLibre_Click);
            // 
            // btn_metodoSugerido
            // 
            this.btn_metodoSugerido.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources._5f463b0e803a0d0004146be2;
            this.btn_metodoSugerido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_metodoSugerido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_metodoSugerido.Image = ((System.Drawing.Image)(resources.GetObject("btn_metodoSugerido.Image")));
            this.btn_metodoSugerido.Location = new System.Drawing.Point(703, 445);
            this.btn_metodoSugerido.Name = "btn_metodoSugerido";
            this.btn_metodoSugerido.Size = new System.Drawing.Size(143, 23);
            this.btn_metodoSugerido.TabIndex = 0;
            this.btn_metodoSugerido.Text = "Método Sugerido";
            this.btn_metodoSugerido.UseVisualStyleBackColor = true;
            // 
            // btn_metodoRNDC
            // 
            this.btn_metodoRNDC.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources._5f463b0e803a0d0004146be2;
            this.btn_metodoRNDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_metodoRNDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_metodoRNDC.Image = ((System.Drawing.Image)(resources.GetObject("btn_metodoRNDC.Image")));
            this.btn_metodoRNDC.Location = new System.Drawing.Point(703, 486);
            this.btn_metodoRNDC.Name = "btn_metodoRNDC";
            this.btn_metodoRNDC.Size = new System.Drawing.Size(143, 23);
            this.btn_metodoRNDC.TabIndex = 0;
            this.btn_metodoRNDC.Text = "Método RND C#";
            this.btn_metodoRNDC.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources.Diamont_Select1;
            this.pictureBox2.Location = new System.Drawing.Point(657, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 118);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources.Diseño_sin_título__2_;
            this.ClientSize = new System.Drawing.Size(931, 523);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_metodoRNDC);
            this.Controls.Add(this.btn_metodoSugerido);
            this.Controls.Add(this.btn_metodoLibre);
            this.Name = "Principal";
            this.Text = "Tp1_Sim_GrupoE";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_metodoLibre;
        private System.Windows.Forms.Button btn_metodoSugerido;
        private System.Windows.Forms.Button btn_metodoRNDC;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


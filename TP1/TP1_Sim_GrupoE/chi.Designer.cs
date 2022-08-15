
namespace TP1_Sim_GrupoE
{
    partial class chi
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
            this.gb_parametros_chi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_testchi = new System.Windows.Forms.Button();
            this.txt_gradoslibertad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_significancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_intervalos_chi = new System.Windows.Forms.ComboBox();
            this.gb_iteraciones = new System.Windows.Forms.GroupBox();
            this.dg_iteraciones_chi = new System.Windows.Forms.DataGridView();
            this.gb_chi = new System.Windows.Forms.GroupBox();
            this.txt_hipotesis = new System.Windows.Forms.Label();
            this.txt_xtabulado = new System.Windows.Forms.Label();
            this.txt_xcalculado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_parametros_chi.SuspendLayout();
            this.gb_iteraciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones_chi)).BeginInit();
            this.gb_chi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_parametros_chi
            // 
            this.gb_parametros_chi.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_parametros_chi.Controls.Add(this.label2);
            this.gb_parametros_chi.Controls.Add(this.btn_testchi);
            this.gb_parametros_chi.Controls.Add(this.txt_gradoslibertad);
            this.gb_parametros_chi.Controls.Add(this.label1);
            this.gb_parametros_chi.Controls.Add(this.txt_significancia);
            this.gb_parametros_chi.Controls.Add(this.label5);
            this.gb_parametros_chi.Controls.Add(this.cmb_intervalos_chi);
            this.gb_parametros_chi.Location = new System.Drawing.Point(32, 26);
            this.gb_parametros_chi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_parametros_chi.Name = "gb_parametros_chi";
            this.gb_parametros_chi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_parametros_chi.Size = new System.Drawing.Size(325, 134);
            this.gb_parametros_chi.TabIndex = 0;
            this.gb_parametros_chi.TabStop = false;
            this.gb_parametros_chi.Text = "Parámetros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Libertad (V)";
            // 
            // btn_testchi
            // 
            this.btn_testchi.Location = new System.Drawing.Point(217, 47);
            this.btn_testchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_testchi.Name = "btn_testchi";
            this.btn_testchi.Size = new System.Drawing.Size(100, 48);
            this.btn_testchi.TabIndex = 16;
            this.btn_testchi.Text = "Realizar Test";
            this.btn_testchi.UseVisualStyleBackColor = true;
            // 
            // txt_gradoslibertad
            // 
            this.txt_gradoslibertad.Location = new System.Drawing.Point(8, 89);
            this.txt_gradoslibertad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gradoslibertad.Name = "txt_gradoslibertad";
            this.txt_gradoslibertad.Size = new System.Drawing.Size(64, 22);
            this.txt_gradoslibertad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Significancia";
            // 
            // txt_significancia
            // 
            this.txt_significancia.Location = new System.Drawing.Point(8, 57);
            this.txt_significancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_significancia.Name = "txt_significancia";
            this.txt_significancia.ReadOnly = true;
            this.txt_significancia.Size = new System.Drawing.Size(64, 22);
            this.txt_significancia.TabIndex = 11;
            this.txt_significancia.Text = "5%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intervalos";
            // 
            // cmb_intervalos_chi
            // 
            this.cmb_intervalos_chi.FormattingEnabled = true;
            this.cmb_intervalos_chi.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12"});
            this.cmb_intervalos_chi.Location = new System.Drawing.Point(8, 23);
            this.cmb_intervalos_chi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_intervalos_chi.Name = "cmb_intervalos_chi";
            this.cmb_intervalos_chi.Size = new System.Drawing.Size(64, 24);
            this.cmb_intervalos_chi.TabIndex = 9;
            // 
            // gb_iteraciones
            // 
            this.gb_iteraciones.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_iteraciones.Controls.Add(this.dg_iteraciones_chi);
            this.gb_iteraciones.Location = new System.Drawing.Point(628, 15);
            this.gb_iteraciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_iteraciones.Name = "gb_iteraciones";
            this.gb_iteraciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_iteraciones.Size = new System.Drawing.Size(443, 420);
            this.gb_iteraciones.TabIndex = 15;
            this.gb_iteraciones.TabStop = false;
            this.gb_iteraciones.Text = "Iteraciones";
            // 
            // dg_iteraciones_chi
            // 
            this.dg_iteraciones_chi.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dg_iteraciones_chi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_iteraciones_chi.Location = new System.Drawing.Point(8, 42);
            this.dg_iteraciones_chi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_iteraciones_chi.Name = "dg_iteraciones_chi";
            this.dg_iteraciones_chi.RowHeadersWidth = 51;
            this.dg_iteraciones_chi.Size = new System.Drawing.Size(427, 370);
            this.dg_iteraciones_chi.TabIndex = 8;
            // 
            // gb_chi
            // 
            this.gb_chi.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_chi.Controls.Add(this.txt_hipotesis);
            this.gb_chi.Controls.Add(this.txt_xtabulado);
            this.gb_chi.Controls.Add(this.txt_xcalculado);
            this.gb_chi.Controls.Add(this.label3);
            this.gb_chi.Controls.Add(this.label4);
            this.gb_chi.Controls.Add(this.label6);
            this.gb_chi.Location = new System.Drawing.Point(16, 260);
            this.gb_chi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_chi.Name = "gb_chi";
            this.gb_chi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_chi.Size = new System.Drawing.Size(215, 134);
            this.gb_chi.TabIndex = 15;
            this.gb_chi.TabStop = false;
            this.gb_chi.Text = "Parámetros";
            // 
            // txt_hipotesis
            // 
            this.txt_hipotesis.AutoSize = true;
            this.txt_hipotesis.Location = new System.Drawing.Point(121, 97);
            this.txt_hipotesis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_hipotesis.Name = "txt_hipotesis";
            this.txt_hipotesis.Size = new System.Drawing.Size(20, 17);
            this.txt_hipotesis.TabIndex = 17;
            this.txt_hipotesis.Text = "0 ";
            // 
            // txt_xtabulado
            // 
            this.txt_xtabulado.AutoSize = true;
            this.txt_xtabulado.Location = new System.Drawing.Point(121, 66);
            this.txt_xtabulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_xtabulado.Name = "txt_xtabulado";
            this.txt_xtabulado.Size = new System.Drawing.Size(20, 17);
            this.txt_xtabulado.TabIndex = 16;
            this.txt_xtabulado.Text = "0 ";
            // 
            // txt_xcalculado
            // 
            this.txt_xcalculado.AutoSize = true;
            this.txt_xcalculado.Location = new System.Drawing.Point(121, 34);
            this.txt_xcalculado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_xcalculado.Name = "txt_xcalculado";
            this.txt_xcalculado.Size = new System.Drawing.Size(20, 17);
            this.txt_xcalculado.TabIndex = 15;
            this.txt_xcalculado.Text = "0 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hipótesis: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "X Tabulado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "X Calculado: ";
            // 
            // chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources.the_simpson_s_living_room_zoom_background_design_template_0a144384f561d786222db3f214a8042b_screen;
            this.ClientSize = new System.Drawing.Size(1081, 448);
            this.Controls.Add(this.gb_chi);
            this.Controls.Add(this.gb_iteraciones);
            this.Controls.Add(this.gb_parametros_chi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "chi";
            this.Text = "chi";
            this.gb_parametros_chi.ResumeLayout(false);
            this.gb_parametros_chi.PerformLayout();
            this.gb_iteraciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_iteraciones_chi)).EndInit();
            this.gb_chi.ResumeLayout(false);
            this.gb_chi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_parametros_chi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_intervalos_chi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_significancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gradoslibertad;
        private System.Windows.Forms.GroupBox gb_iteraciones;
        private System.Windows.Forms.DataGridView dg_iteraciones_chi;
        private System.Windows.Forms.Button btn_testchi;
        private System.Windows.Forms.GroupBox gb_chi;
        private System.Windows.Forms.Label txt_hipotesis;
        private System.Windows.Forms.Label txt_xtabulado;
        private System.Windows.Forms.Label txt_xcalculado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
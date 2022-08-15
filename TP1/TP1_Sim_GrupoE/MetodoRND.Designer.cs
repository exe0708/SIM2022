
namespace TP1_Sim_GrupoE
{
    partial class MetodoRND
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
            this.gb_grafico_Sugerido = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_metodo = new System.Windows.Forms.ComboBox();
            this.chk_incluir1_sugerido = new System.Windows.Forms.CheckBox();
            this.txt_graficar_sugerido = new System.Windows.Forms.Button();
            this.txt_calcular_sugerido = new System.Windows.Forms.Button();
            this.txt_tamañoMuestra_rnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_generados_sugeridos = new System.Windows.Forms.GroupBox();
            this.btn_chi_sugerido = new System.Windows.Forms.Button();
            this.btn_ultimo_sugerido = new System.Windows.Forms.Button();
            this.btn_20nuevos_sugerido = new System.Windows.Forms.Button();
            this.dg_random = new System.Windows.Forms.DataGridView();
            this.btn_unomas_sugerido = new System.Windows.Forms.Button();
            this.gb_grafico_rnd = new System.Windows.Forms.GroupBox();
            this.gb_grafico_Sugerido.SuspendLayout();
            this.gb_generados_sugeridos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_random)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_grafico_Sugerido
            // 
            this.gb_grafico_Sugerido.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_grafico_Sugerido.Controls.Add(this.label7);
            this.gb_grafico_Sugerido.Controls.Add(this.cmb_metodo);
            this.gb_grafico_Sugerido.Controls.Add(this.chk_incluir1_sugerido);
            this.gb_grafico_Sugerido.Controls.Add(this.txt_graficar_sugerido);
            this.gb_grafico_Sugerido.Controls.Add(this.txt_calcular_sugerido);
            this.gb_grafico_Sugerido.Controls.Add(this.txt_tamañoMuestra_rnd);
            this.gb_grafico_Sugerido.Controls.Add(this.label6);
            this.gb_grafico_Sugerido.Location = new System.Drawing.Point(12, 12);
            this.gb_grafico_Sugerido.Name = "gb_grafico_Sugerido";
            this.gb_grafico_Sugerido.Size = new System.Drawing.Size(255, 165);
            this.gb_grafico_Sugerido.TabIndex = 10;
            this.gb_grafico_Sugerido.TabStop = false;
            this.gb_grafico_Sugerido.Text = "Parámetros_RND";
            this.gb_grafico_Sugerido.Enter += new System.EventHandler(this.gb_grafico_Sugerido_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Método";
            // 
            // cmb_metodo
            // 
            this.cmb_metodo.FormattingEnabled = true;
            this.cmb_metodo.Items.AddRange(new object[] {
            "Congruencial Mixto",
            "Congruencial Multiplicativo",
            "Congruencial Aditivo"});
            this.cmb_metodo.Location = new System.Drawing.Point(11, 61);
            this.cmb_metodo.Name = "cmb_metodo";
            this.cmb_metodo.Size = new System.Drawing.Size(121, 21);
            this.cmb_metodo.TabIndex = 20;
            // 
            // chk_incluir1_sugerido
            // 
            this.chk_incluir1_sugerido.AutoSize = true;
            this.chk_incluir1_sugerido.Location = new System.Drawing.Point(128, 118);
            this.chk_incluir1_sugerido.Name = "chk_incluir1_sugerido";
            this.chk_incluir1_sugerido.Size = new System.Drawing.Size(63, 17);
            this.chk_incluir1_sugerido.TabIndex = 13;
            this.chk_incluir1_sugerido.Text = "Incluir 1";
            this.chk_incluir1_sugerido.UseVisualStyleBackColor = true;
            // 
            // txt_graficar_sugerido
            // 
            this.txt_graficar_sugerido.Location = new System.Drawing.Point(11, 131);
            this.txt_graficar_sugerido.Name = "txt_graficar_sugerido";
            this.txt_graficar_sugerido.Size = new System.Drawing.Size(75, 23);
            this.txt_graficar_sugerido.TabIndex = 11;
            this.txt_graficar_sugerido.Text = "Graficar";
            this.txt_graficar_sugerido.UseVisualStyleBackColor = true;
            // 
            // txt_calcular_sugerido
            // 
            this.txt_calcular_sugerido.Location = new System.Drawing.Point(11, 102);
            this.txt_calcular_sugerido.Name = "txt_calcular_sugerido";
            this.txt_calcular_sugerido.Size = new System.Drawing.Size(75, 23);
            this.txt_calcular_sugerido.TabIndex = 12;
            this.txt_calcular_sugerido.Text = "Calcular";
            this.txt_calcular_sugerido.UseVisualStyleBackColor = true;
            // 
            // txt_tamañoMuestra_rnd
            // 
            this.txt_tamañoMuestra_rnd.Location = new System.Drawing.Point(11, 29);
            this.txt_tamañoMuestra_rnd.Name = "txt_tamañoMuestra_rnd";
            this.txt_tamañoMuestra_rnd.Size = new System.Drawing.Size(121, 20);
            this.txt_tamañoMuestra_rnd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tamaño Muestra";
            // 
            // gb_generados_sugeridos
            // 
            this.gb_generados_sugeridos.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_generados_sugeridos.Controls.Add(this.btn_chi_sugerido);
            this.gb_generados_sugeridos.Controls.Add(this.btn_ultimo_sugerido);
            this.gb_generados_sugeridos.Controls.Add(this.btn_20nuevos_sugerido);
            this.gb_generados_sugeridos.Controls.Add(this.dg_random);
            this.gb_generados_sugeridos.Controls.Add(this.btn_unomas_sugerido);
            this.gb_generados_sugeridos.Location = new System.Drawing.Point(367, 12);
            this.gb_generados_sugeridos.Name = "gb_generados_sugeridos";
            this.gb_generados_sugeridos.Size = new System.Drawing.Size(445, 367);
            this.gb_generados_sugeridos.TabIndex = 11;
            this.gb_generados_sugeridos.TabStop = false;
            this.gb_generados_sugeridos.Text = "Valores Generados";
            // 
            // btn_chi_sugerido
            // 
            this.btn_chi_sugerido.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources._5895d300cba9841eabab607b;
            this.btn_chi_sugerido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_chi_sugerido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chi_sugerido.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chi_sugerido.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_chi_sugerido.Location = new System.Drawing.Point(330, 316);
            this.btn_chi_sugerido.Name = "btn_chi_sugerido";
            this.btn_chi_sugerido.Size = new System.Drawing.Size(84, 48);
            this.btn_chi_sugerido.TabIndex = 13;
            this.btn_chi_sugerido.Text = "Chi";
            this.btn_chi_sugerido.UseVisualStyleBackColor = false;
            // 
            // btn_ultimo_sugerido
            // 
            this.btn_ultimo_sugerido.Location = new System.Drawing.Point(249, 319);
            this.btn_ultimo_sugerido.Name = "btn_ultimo_sugerido";
            this.btn_ultimo_sugerido.Size = new System.Drawing.Size(75, 39);
            this.btn_ultimo_sugerido.TabIndex = 12;
            this.btn_ultimo_sugerido.Text = "Último de 10000";
            this.btn_ultimo_sugerido.UseVisualStyleBackColor = true;
            // 
            // btn_20nuevos_sugerido
            // 
            this.btn_20nuevos_sugerido.Location = new System.Drawing.Point(149, 319);
            this.btn_20nuevos_sugerido.Name = "btn_20nuevos_sugerido";
            this.btn_20nuevos_sugerido.Size = new System.Drawing.Size(75, 39);
            this.btn_20nuevos_sugerido.TabIndex = 11;
            this.btn_20nuevos_sugerido.Text = "20 números nuevos";
            this.btn_20nuevos_sugerido.UseVisualStyleBackColor = true;
            // 
            // dg_random
            // 
            this.dg_random.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dg_random.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_random.Location = new System.Drawing.Point(6, 16);
            this.dg_random.Name = "dg_random";
            this.dg_random.Size = new System.Drawing.Size(433, 294);
            this.dg_random.TabIndex = 7;
            // 
            // btn_unomas_sugerido
            // 
            this.btn_unomas_sugerido.Location = new System.Drawing.Point(46, 319);
            this.btn_unomas_sugerido.Name = "btn_unomas_sugerido";
            this.btn_unomas_sugerido.Size = new System.Drawing.Size(75, 39);
            this.btn_unomas_sugerido.TabIndex = 11;
            this.btn_unomas_sugerido.Text = "Un valor mas";
            this.btn_unomas_sugerido.UseVisualStyleBackColor = true;
            // 
            // gb_grafico_rnd
            // 
            this.gb_grafico_rnd.BackColor = System.Drawing.Color.DarkSalmon;
            this.gb_grafico_rnd.Location = new System.Drawing.Point(12, 197);
            this.gb_grafico_rnd.Name = "gb_grafico_rnd";
            this.gb_grafico_rnd.Size = new System.Drawing.Size(255, 229);
            this.gb_grafico_rnd.TabIndex = 12;
            this.gb_grafico_rnd.TabStop = false;
            this.gb_grafico_rnd.Text = "Gráfico";
            // 
            // MetodoRND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1_Sim_GrupoE.Properties.Resources.e8563feb6e4cb710fd9b22e8b11ef6be;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Controls.Add(this.gb_grafico_rnd);
            this.Controls.Add(this.gb_generados_sugeridos);
            this.Controls.Add(this.gb_grafico_Sugerido);
            this.Name = "MetodoRND";
            this.Text = "MetodoRND";
            this.gb_grafico_Sugerido.ResumeLayout(false);
            this.gb_grafico_Sugerido.PerformLayout();
            this.gb_generados_sugeridos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_random)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_grafico_Sugerido;
        private System.Windows.Forms.TextBox txt_tamañoMuestra_rnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_incluir1_sugerido;
        private System.Windows.Forms.Button txt_graficar_sugerido;
        private System.Windows.Forms.Button txt_calcular_sugerido;
        private System.Windows.Forms.GroupBox gb_generados_sugeridos;
        private System.Windows.Forms.Button btn_chi_sugerido;
        private System.Windows.Forms.Button btn_ultimo_sugerido;
        private System.Windows.Forms.Button btn_20nuevos_sugerido;
        private System.Windows.Forms.DataGridView dg_random;
        private System.Windows.Forms.Button btn_unomas_sugerido;
        private System.Windows.Forms.GroupBox gb_grafico_rnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_metodo;
    }
}
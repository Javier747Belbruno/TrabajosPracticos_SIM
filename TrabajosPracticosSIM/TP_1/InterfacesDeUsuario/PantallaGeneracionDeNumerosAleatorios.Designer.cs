
namespace TrabajosPracticosSIM.TP_1.InterfacesDeUsuario
{
    partial class Frm_PantallaGeneracionDeNumerosAleatorios
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
            this.btn_cerrar_ventana = new System.Windows.Forms.Button();
            this.btn_Prox_20 = new System.Windows.Forms.Button();
            this.btn_listar_todo = new System.Windows.Forms.Button();
            this.btn_desde_hasta = new System.Windows.Forms.Button();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Aleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_semilla = new System.Windows.Forms.Label();
            this.tb_semilla = new System.Windows.Forms.TextBox();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sel_Congr_Mixto = new System.Windows.Forms.Button();
            this.btn_sel_Congr_Mult = new System.Windows.Forms.Button();
            this.pnl_IngresoDatos = new System.Windows.Forms.Panel();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_desde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hasta = new System.Windows.Forms.TextBox();
            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Prox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            this.pnl_IngresoDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_ventana
            // 
            this.btn_cerrar_ventana.Location = new System.Drawing.Point(684, 800);
            this.btn_cerrar_ventana.Name = "btn_cerrar_ventana";
            this.btn_cerrar_ventana.Size = new System.Drawing.Size(113, 51);
            this.btn_cerrar_ventana.TabIndex = 0;
            this.btn_cerrar_ventana.Text = "Cerrar ventana";
            this.btn_cerrar_ventana.UseVisualStyleBackColor = true;
            this.btn_cerrar_ventana.Click += new System.EventHandler(this.btn_cerrar_ventana_Click);
            // 
            // btn_Prox_20
            // 
            this.btn_Prox_20.Location = new System.Drawing.Point(74, 130);
            this.btn_Prox_20.Name = "btn_Prox_20";
            this.btn_Prox_20.Size = new System.Drawing.Size(139, 68);
            this.btn_Prox_20.TabIndex = 1;
            this.btn_Prox_20.Text = "Continuar con los próx. 20";
            this.btn_Prox_20.UseVisualStyleBackColor = true;
            this.btn_Prox_20.Click += new System.EventHandler(this.btn_Prox_20_Click);
            // 
            // btn_listar_todo
            // 
            this.btn_listar_todo.Location = new System.Drawing.Point(74, 236);
            this.btn_listar_todo.Name = "btn_listar_todo";
            this.btn_listar_todo.Size = new System.Drawing.Size(139, 68);
            this.btn_listar_todo.TabIndex = 2;
            this.btn_listar_todo.Text = "Listar todo";
            this.btn_listar_todo.UseVisualStyleBackColor = true;
            this.btn_listar_todo.Click += new System.EventHandler(this.btn_listar_todo_Click);
            // 
            // btn_desde_hasta
            // 
            this.btn_desde_hasta.Location = new System.Drawing.Point(74, 424);
            this.btn_desde_hasta.Name = "btn_desde_hasta";
            this.btn_desde_hasta.Size = new System.Drawing.Size(139, 69);
            this.btn_desde_hasta.TabIndex = 3;
            this.btn_desde_hasta.Text = "Listar con Rango";
            this.btn_desde_hasta.UseVisualStyleBackColor = true;
            this.btn_desde_hasta.Click += new System.EventHandler(this.btn_desde_hasta_Click);
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Numero_Aleatorio});
            this.dgv_numeros.Location = new System.Drawing.Point(295, 3);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.RowHeadersWidth = 51;
            this.dgv_numeros.RowTemplate.Height = 24;
            this.dgv_numeros.Size = new System.Drawing.Size(400, 490);
            this.dgv_numeros.TabIndex = 4;
            // 
            // Posicion
            // 
            this.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            // 
            // Numero_Aleatorio
            // 
            this.Numero_Aleatorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero_Aleatorio.HeaderText = "Número Aleatorio";
            this.Numero_Aleatorio.MinimumWidth = 6;
            this.Numero_Aleatorio.Name = "Numero_Aleatorio";
            // 
            // lbl_semilla
            // 
            this.lbl_semilla.AutoSize = true;
            this.lbl_semilla.Location = new System.Drawing.Point(48, 47);
            this.lbl_semilla.Name = "lbl_semilla";
            this.lbl_semilla.Size = new System.Drawing.Size(51, 17);
            this.lbl_semilla.TabIndex = 5;
            this.lbl_semilla.Text = "semilla";
            // 
            // tb_semilla
            // 
            this.tb_semilla.Location = new System.Drawing.Point(105, 47);
            this.tb_semilla.Name = "tb_semilla";
            this.tb_semilla.Size = new System.Drawing.Size(100, 22);
            this.tb_semilla.TabIndex = 6;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(306, 47);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 22);
            this.tb_a.TabIndex = 8;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(284, 47);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(16, 17);
            this.lbl_a.TabIndex = 7;
            this.lbl_a.Text = "a";
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(529, 47);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(100, 22);
            this.tb_c.TabIndex = 10;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(508, 47);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(15, 17);
            this.lbl_c.TabIndex = 9;
            this.lbl_c.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ingrese los datos";
            // 
            // btn_sel_Congr_Mixto
            // 
            this.btn_sel_Congr_Mixto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sel_Congr_Mixto.Location = new System.Drawing.Point(90, 42);
            this.btn_sel_Congr_Mixto.Name = "btn_sel_Congr_Mixto";
            this.btn_sel_Congr_Mixto.Size = new System.Drawing.Size(173, 47);
            this.btn_sel_Congr_Mixto.TabIndex = 12;
            this.btn_sel_Congr_Mixto.Text = "Congruencial Mixto";
            this.btn_sel_Congr_Mixto.UseVisualStyleBackColor = true;
            this.btn_sel_Congr_Mixto.Click += new System.EventHandler(this.btn_sel_Congr_Mixto_Click);
            // 
            // btn_sel_Congr_Mult
            // 
            this.btn_sel_Congr_Mult.BackColor = System.Drawing.Color.LightGray;
            this.btn_sel_Congr_Mult.Location = new System.Drawing.Point(439, 42);
            this.btn_sel_Congr_Mult.Name = "btn_sel_Congr_Mult";
            this.btn_sel_Congr_Mult.Size = new System.Drawing.Size(176, 47);
            this.btn_sel_Congr_Mult.TabIndex = 13;
            this.btn_sel_Congr_Mult.Text = "Congruencial Multiplicativo";
            this.btn_sel_Congr_Mult.UseVisualStyleBackColor = false;
            this.btn_sel_Congr_Mult.Click += new System.EventHandler(this.btn_sel_Congr_Mult_Click);
            // 
            // pnl_IngresoDatos
            // 
            this.pnl_IngresoDatos.Controls.Add(this.btn_Generar);
            this.pnl_IngresoDatos.Controls.Add(this.label4);
            this.pnl_IngresoDatos.Controls.Add(this.tb_a);
            this.pnl_IngresoDatos.Controls.Add(this.lbl_semilla);
            this.pnl_IngresoDatos.Controls.Add(this.tb_c);
            this.pnl_IngresoDatos.Controls.Add(this.tb_semilla);
            this.pnl_IngresoDatos.Controls.Add(this.lbl_c);
            this.pnl_IngresoDatos.Controls.Add(this.lbl_a);
            this.pnl_IngresoDatos.Location = new System.Drawing.Point(87, 143);
            this.pnl_IngresoDatos.Name = "pnl_IngresoDatos";
            this.pnl_IngresoDatos.Size = new System.Drawing.Size(729, 139);
            this.pnl_IngresoDatos.TabIndex = 14;
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(264, 87);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(190, 36);
            this.btn_Generar.TabIndex = 12;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_sel_Congr_Mixto);
            this.panel2.Controls.Add(this.btn_sel_Congr_Mult);
            this.panel2.Location = new System.Drawing.Point(87, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 116);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleccione el Método";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_desde
            // 
            this.tb_desde.Location = new System.Drawing.Point(87, 339);
            this.tb_desde.Name = "tb_desde";
            this.tb_desde.Size = new System.Drawing.Size(114, 22);
            this.tb_desde.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "-";
            // 
            // tb_hasta
            // 
            this.tb_hasta.Location = new System.Drawing.Point(87, 384);
            this.tb_hasta.Name = "tb_hasta";
            this.tb_hasta.Size = new System.Drawing.Size(114, 22);
            this.tb_hasta.TabIndex = 18;
            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Controls.Add(this.label2);
            this.pnl_tabla.Controls.Add(this.label1);
            this.pnl_tabla.Controls.Add(this.btn_Prox);
            this.pnl_tabla.Controls.Add(this.dgv_numeros);
            this.pnl_tabla.Controls.Add(this.tb_hasta);
            this.pnl_tabla.Controls.Add(this.btn_desde_hasta);
            this.pnl_tabla.Controls.Add(this.label6);
            this.pnl_tabla.Controls.Add(this.btn_Prox_20);
            this.pnl_tabla.Controls.Add(this.tb_desde);
            this.pnl_tabla.Controls.Add(this.btn_listar_todo);
            this.pnl_tabla.Location = new System.Drawing.Point(87, 288);
            this.pnl_tabla.Name = "pnl_tabla";
            this.pnl_tabla.Size = new System.Drawing.Size(733, 506);
            this.pnl_tabla.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Desde";
            // 
            // btn_Prox
            // 
            this.btn_Prox.Location = new System.Drawing.Point(74, 38);
            this.btn_Prox.Name = "btn_Prox";
            this.btn_Prox.Size = new System.Drawing.Size(139, 49);
            this.btn_Prox.TabIndex = 20;
            this.btn_Prox.Text = "Próximo";
            this.btn_Prox.UseVisualStyleBackColor = true;
            this.btn_Prox.Click += new System.EventHandler(this.btn_Prox_Click_1);
            // 
            // Frm_PantallaGeneracionDeNumerosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(920, 940);
            this.Controls.Add(this.pnl_tabla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_IngresoDatos);
            this.Controls.Add(this.btn_cerrar_ventana);
            this.Name = "Frm_PantallaGeneracionDeNumerosAleatorios";
            this.Text = "PantallaGeneracionDeNumerosAleatorios";
            this.Load += new System.EventHandler(this.Frm_PantallaGeneracionDeNumerosAleatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            this.pnl_IngresoDatos.ResumeLayout(false);
            this.pnl_IngresoDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_tabla.ResumeLayout(false);
            this.pnl_tabla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_ventana;
        private System.Windows.Forms.Button btn_Prox_20;
        private System.Windows.Forms.Button btn_listar_todo;
        private System.Windows.Forms.Button btn_desde_hasta;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.Label lbl_semilla;
        private System.Windows.Forms.TextBox tb_semilla;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sel_Congr_Mixto;
        private System.Windows.Forms.Button btn_sel_Congr_Mult;
        private System.Windows.Forms.Panel pnl_IngresoDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_hasta;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Panel pnl_tabla;
        private System.Windows.Forms.Button btn_Prox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Aleatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
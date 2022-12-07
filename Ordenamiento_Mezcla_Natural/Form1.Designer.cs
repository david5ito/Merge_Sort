namespace Ordenamiento_Mezcla_Natural
{
    partial class Form1
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.btnRecAsc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lvwMostar = new System.Windows.Forms.ListView();
            this.lblStadistica = new System.Windows.Forms.Label();
            this.lvwOrdenado = new System.Windows.Forms.ListView();
            this.lblEstadisticaNombre = new System.Windows.Forms.Label();
            this.btnRDescendenteDirecta = new System.Windows.Forms.Button();
            this.btnRAscendenteDirecta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(353, 109);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(85, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Vector";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(245, 112);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(77, 20);
            this.txtElementos.TabIndex = 1;
            // 
            // btnRecAsc
            // 
            this.btnRecAsc.Location = new System.Drawing.Point(15, 172);
            this.btnRecAsc.Name = "btnRecAsc";
            this.btnRecAsc.Size = new System.Drawing.Size(161, 23);
            this.btnRecAsc.TabIndex = 2;
            this.btnRecAsc.Text = "Recorrido Ascendente";
            this.btnRecAsc.UseVisualStyleBackColor = true;
            this.btnRecAsc.Click += new System.EventHandler(this.btnRecAsc_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Recorrido Descendente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de elementos del vector:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(444, 109);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Vector";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lvwMostar
            // 
            this.lvwMostar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostar.HideSelection = false;
            this.lvwMostar.Location = new System.Drawing.Point(0, 0);
            this.lvwMostar.Name = "lvwMostar";
            this.lvwMostar.Size = new System.Drawing.Size(644, 38);
            this.lvwMostar.TabIndex = 6;
            this.lvwMostar.UseCompatibleStateImageBehavior = false;
            // 
            // lblStadistica
            // 
            this.lblStadistica.AutoSize = true;
            this.lblStadistica.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadistica.Location = new System.Drawing.Point(427, 155);
            this.lblStadistica.Name = "lblStadistica";
            this.lblStadistica.Size = new System.Drawing.Size(32, 40);
            this.lblStadistica.TabIndex = 7;
            this.lblStadistica.Text = "---";
            // 
            // lvwOrdenado
            // 
            this.lvwOrdenado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwOrdenado.HideSelection = false;
            this.lvwOrdenado.Location = new System.Drawing.Point(0, 38);
            this.lvwOrdenado.Name = "lvwOrdenado";
            this.lvwOrdenado.Size = new System.Drawing.Size(644, 35);
            this.lvwOrdenado.TabIndex = 8;
            this.lvwOrdenado.UseCompatibleStateImageBehavior = false;
            // 
            // lblEstadisticaNombre
            // 
            this.lblEstadisticaNombre.AutoSize = true;
            this.lblEstadisticaNombre.Location = new System.Drawing.Point(431, 195);
            this.lblEstadisticaNombre.Name = "lblEstadisticaNombre";
            this.lblEstadisticaNombre.Size = new System.Drawing.Size(13, 13);
            this.lblEstadisticaNombre.TabIndex = 9;
            this.lblEstadisticaNombre.Text = "--";
            // 
            // btnRDescendenteDirecta
            // 
            this.btnRDescendenteDirecta.Location = new System.Drawing.Point(198, 201);
            this.btnRDescendenteDirecta.Name = "btnRDescendenteDirecta";
            this.btnRDescendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRDescendenteDirecta.TabIndex = 11;
            this.btnRDescendenteDirecta.Text = "Recorrido Descendente";
            this.btnRDescendenteDirecta.UseVisualStyleBackColor = true;
            this.btnRDescendenteDirecta.Click += new System.EventHandler(this.btnRDescendenteDirecta_Click);
            // 
            // btnRAscendenteDirecta
            // 
            this.btnRAscendenteDirecta.Location = new System.Drawing.Point(198, 172);
            this.btnRAscendenteDirecta.Name = "btnRAscendenteDirecta";
            this.btnRAscendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRAscendenteDirecta.TabIndex = 10;
            this.btnRAscendenteDirecta.Text = "Recorrido Ascendente";
            this.btnRAscendenteDirecta.UseVisualStyleBackColor = true;
            this.btnRAscendenteDirecta.Click += new System.EventHandler(this.btnRAscendenteDirecta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(535, 109);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mezcla Natural:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mezcla Directa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRDescendenteDirecta);
            this.Controls.Add(this.btnRAscendenteDirecta);
            this.Controls.Add(this.lblEstadisticaNombre);
            this.Controls.Add(this.lvwOrdenado);
            this.Controls.Add(this.lblStadistica);
            this.Controls.Add(this.lvwMostar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRecAsc);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Mezcla Natural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Button btnRecAsc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lvwMostar;
        private System.Windows.Forms.Label lblStadistica;
        private System.Windows.Forms.ListView lvwOrdenado;
        private System.Windows.Forms.Label lblEstadisticaNombre;
        private System.Windows.Forms.Button btnRDescendenteDirecta;
        private System.Windows.Forms.Button btnRAscendenteDirecta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


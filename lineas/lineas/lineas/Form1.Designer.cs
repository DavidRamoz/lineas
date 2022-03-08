
namespace wLineas
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
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.xInicial = new System.Windows.Forms.Label();
            this.xFinal = new System.Windows.Forms.Label();
            this.yInicial = new System.Windows.Forms.Label();
            this.yFinal = new System.Windows.Forms.Label();
            this.cantidadlineas = new System.Windows.Forms.Label();
            this.txtcantidadLineas = new System.Windows.Forms.TextBox();
            this.btndibujarLineas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(138, 123);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(100, 20);
            this.txtXInicial.TabIndex = 1;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(138, 173);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(100, 20);
            this.txtXFinal.TabIndex = 2;
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(406, 123);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(100, 20);
            this.txtYInicial.TabIndex = 3;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(406, 173);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(100, 20);
            this.txtYFinal.TabIndex = 4;
            // 
            // xInicial
            // 
            this.xInicial.AutoSize = true;
            this.xInicial.Location = new System.Drawing.Point(70, 123);
            this.xInicial.Name = "xInicial";
            this.xInicial.Size = new System.Drawing.Size(44, 13);
            this.xInicial.TabIndex = 5;
            this.xInicial.Text = "X Inicial";
            // 
            // xFinal
            // 
            this.xFinal.AutoSize = true;
            this.xFinal.Location = new System.Drawing.Point(70, 180);
            this.xFinal.Name = "xFinal";
            this.xFinal.Size = new System.Drawing.Size(39, 13);
            this.xFinal.TabIndex = 6;
            this.xFinal.Text = "X Final";
            // 
            // yInicial
            // 
            this.yInicial.AutoSize = true;
            this.yInicial.Location = new System.Drawing.Point(346, 126);
            this.yInicial.Name = "yInicial";
            this.yInicial.Size = new System.Drawing.Size(44, 13);
            this.yInicial.TabIndex = 7;
            this.yInicial.Text = "Y Inicial";
            // 
            // yFinal
            // 
            this.yFinal.AutoSize = true;
            this.yFinal.Location = new System.Drawing.Point(346, 176);
            this.yFinal.Name = "yFinal";
            this.yFinal.Size = new System.Drawing.Size(39, 13);
            this.yFinal.TabIndex = 8;
            this.yFinal.Text = "Y Final";
            // 
            // cantidadlineas
            // 
            this.cantidadlineas.AutoSize = true;
            this.cantidadlineas.Location = new System.Drawing.Point(378, 286);
            this.cantidadlineas.Name = "cantidadlineas";
            this.cantidadlineas.Size = new System.Drawing.Size(98, 13);
            this.cantidadlineas.TabIndex = 9;
            this.cantidadlineas.Text = "Cantidad de Lineas";
            // 
            // txtcantidadLineas
            // 
            this.txtcantidadLineas.Location = new System.Drawing.Point(371, 317);
            this.txtcantidadLineas.Name = "txtcantidadLineas";
            this.txtcantidadLineas.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadLineas.TabIndex = 10;
            // 
            // btndibujarLineas
            // 
            this.btndibujarLineas.Location = new System.Drawing.Point(138, 305);
            this.btndibujarLineas.Name = "btndibujarLineas";
            this.btndibujarLineas.Size = new System.Drawing.Size(92, 32);
            this.btndibujarLineas.TabIndex = 0;
            this.btndibujarLineas.Text = "Dibujar Lineas";
            this.btndibujarLineas.UseVisualStyleBackColor = true;
            this.btndibujarLineas.Click += new System.EventHandler(this.btndibujarLineas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcantidadLineas);
            this.Controls.Add(this.cantidadlineas);
            this.Controls.Add(this.yFinal);
            this.Controls.Add(this.yInicial);
            this.Controls.Add(this.xFinal);
            this.Controls.Add(this.xInicial);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.btndibujarLineas);
            this.Name = "Form1";
            this.Text = "Dibujar Lineas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.Label xInicial;
        private System.Windows.Forms.Label xFinal;
        private System.Windows.Forms.Label yInicial;
        private System.Windows.Forms.Label yFinal;
        private System.Windows.Forms.Label cantidadlineas;
        private System.Windows.Forms.TextBox txtcantidadLineas;
        private System.Windows.Forms.Button btndibujarLineas;
    }
}


namespace EjercicioFacu.Windows
{
    partial class AreaVolumen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.labelGeneratriz = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Radio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generatriz:";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(63, 158);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(315, 95);
            this.listBoxResultado.TabIndex = 9;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(193, 36);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 0;
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(193, 73);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadio.TabIndex = 1;
            // 
            // labelGeneratriz
            // 
            this.labelGeneratriz.AutoSize = true;
            this.labelGeneratriz.Location = new System.Drawing.Point(190, 115);
            this.labelGeneratriz.Name = "labelGeneratriz";
            this.labelGeneratriz.Size = new System.Drawing.Size(13, 13);
            this.labelGeneratriz.TabIndex = 5;
            this.labelGeneratriz.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::EjercicioFacu.Windows.Properties.Resources.restart_40px;
            this.btnRestart.Location = new System.Drawing.Point(173, 280);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(96, 74);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::EjercicioFacu.Windows.Properties.Resources.shutdown_40px;
            this.btnCancel.Location = new System.Drawing.Point(282, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 74);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = global::EjercicioFacu.Windows.Properties.Resources.checked_40px;
            this.btnOk.Location = new System.Drawing.Point(63, 280);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 74);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AreaVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelGeneratriz);
            this.Controls.Add(this.textBoxRadio);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximumSize = new System.Drawing.Size(463, 436);
            this.MinimumSize = new System.Drawing.Size(463, 436);
            this.Name = "AreaVolumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.Label labelGeneratriz;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRestart;
    }
}


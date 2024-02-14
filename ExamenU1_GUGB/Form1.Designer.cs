namespace ExamenU1_GUGB
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.txt_calif = new System.Windows.Forms.TextBox();
            this.btn_conv = new System.Windows.Forms.Button();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(92, 87);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(361, 16);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "Ingresa la calificación para convertirla al sistema alfabético:";
            this.lbl_text.Click += new System.EventHandler(this.lbl_text_Click);
            // 
            // txt_calif
            // 
            this.txt_calif.Location = new System.Drawing.Point(181, 161);
            this.txt_calif.Name = "txt_calif";
            this.txt_calif.Size = new System.Drawing.Size(137, 22);
            this.txt_calif.TabIndex = 1;
            // 
            // btn_conv
            // 
            this.btn_conv.Location = new System.Drawing.Point(212, 220);
            this.btn_conv.Name = "btn_conv";
            this.btn_conv.Size = new System.Drawing.Size(75, 23);
            this.btn_conv.TabIndex = 2;
            this.btn_conv.Text = "Calcular!";
            this.btn_conv.UseVisualStyleBackColor = true;
            this.btn_conv.Click += new System.EventHandler(this.btn_conv_Click);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(132, 103);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(251, 16);
            this.lbl_nota.TabIndex = 3;
            this.lbl_nota.Text = "Nota: La calificación debe ser de 0 a 100.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 326);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.btn_conv);
            this.Controls.Add(this.txt_calif);
            this.Controls.Add(this.lbl_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txt_calif;
        private System.Windows.Forms.Button btn_conv;
        private System.Windows.Forms.Label lbl_nota;
    }
}


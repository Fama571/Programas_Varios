namespace AppCifrado
{
    partial class FormCifrado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Vector = new System.Windows.Forms.TextBox();
            this.txt_Saltos = new System.Windows.Forms.TextBox();
            this.txt_TextoaCifrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cifrar = new System.Windows.Forms.Button();
            this.btn_otraVentana = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_TextoCifrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(292, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto a cifrar";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Password.Location = new System.Drawing.Point(44, 114);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(200, 30);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Vector
            // 
            this.txt_Vector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Vector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Vector.Location = new System.Drawing.Point(250, 114);
            this.txt_Vector.Name = "txt_Vector";
            this.txt_Vector.Size = new System.Drawing.Size(200, 30);
            this.txt_Vector.TabIndex = 2;
            // 
            // txt_Saltos
            // 
            this.txt_Saltos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Saltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Saltos.Location = new System.Drawing.Point(456, 114);
            this.txt_Saltos.Name = "txt_Saltos";
            this.txt_Saltos.Size = new System.Drawing.Size(200, 30);
            this.txt_Saltos.TabIndex = 3;
            // 
            // txt_TextoaCifrar
            // 
            this.txt_TextoaCifrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TextoaCifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TextoaCifrar.Location = new System.Drawing.Point(50, 34);
            this.txt_TextoaCifrar.Name = "txt_TextoaCifrar";
            this.txt_TextoaCifrar.Size = new System.Drawing.Size(612, 30);
            this.txt_TextoaCifrar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(72, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(314, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(521, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saltos";
            // 
            // btn_Cifrar
            // 
            this.btn_Cifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Cifrar.Location = new System.Drawing.Point(297, 254);
            this.btn_Cifrar.Name = "btn_Cifrar";
            this.btn_Cifrar.Size = new System.Drawing.Size(120, 40);
            this.btn_Cifrar.TabIndex = 10;
            this.btn_Cifrar.Text = "Cifrar";
            this.btn_Cifrar.UseVisualStyleBackColor = true;
            this.btn_Cifrar.Click += new System.EventHandler(this.btn_Cifrar_Click);
            // 
            // btn_otraVentana
            // 
            this.btn_otraVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_otraVentana.Location = new System.Drawing.Point(526, 254);
            this.btn_otraVentana.Name = "btn_otraVentana";
            this.btn_otraVentana.Size = new System.Drawing.Size(136, 40);
            this.btn_otraVentana.TabIndex = 11;
            this.btn_otraVentana.Text = "Descifrar";
            this.btn_otraVentana.UseVisualStyleBackColor = true;
            this.btn_otraVentana.Click += new System.EventHandler(this.btn_otraVentana_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Guardar.Location = new System.Drawing.Point(50, 260);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(120, 40);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_TextoCifrado
            // 
            this.txt_TextoCifrado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TextoCifrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TextoCifrado.Location = new System.Drawing.Point(50, 202);
            this.txt_TextoCifrado.Name = "txt_TextoCifrado";
            this.txt_TextoCifrado.ReadOnly = true;
            this.txt_TextoCifrado.Size = new System.Drawing.Size(612, 30);
            this.txt_TextoCifrado.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(292, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Texto cifrado";
            // 
            // FormCifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(702, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TextoCifrado);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_otraVentana);
            this.Controls.Add(this.btn_Cifrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TextoaCifrar);
            this.Controls.Add(this.txt_Saltos);
            this.Controls.Add(this.txt_Vector);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCifrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCifrado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCifrado_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Vector;
        private System.Windows.Forms.TextBox txt_Saltos;
        private System.Windows.Forms.TextBox txt_TextoaCifrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Cifrar;
        private System.Windows.Forms.Button btn_otraVentana;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_TextoCifrado;
        private System.Windows.Forms.Label label5;
    }
}


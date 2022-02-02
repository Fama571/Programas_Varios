namespace AppDescifrado
{
    partial class FormDescifrado
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
            this.btn_Descifrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.txt_Saltos = new System.Windows.Forms.TextBox();
            this.txt_Vector = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Desencriptar = new System.Windows.Forms.TextBox();
            this.Visor = new System.Windows.Forms.DataGridView();
            this.btn_Cifrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Descifrar
            // 
            this.btn_Descifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Descifrar.Location = new System.Drawing.Point(156, 164);
            this.btn_Descifrar.Name = "btn_Descifrar";
            this.btn_Descifrar.Size = new System.Drawing.Size(131, 40);
            this.btn_Descifrar.TabIndex = 19;
            this.btn_Descifrar.Text = "Descifrar";
            this.btn_Descifrar.UseVisualStyleBackColor = true;
            this.btn_Descifrar.Click += new System.EventHandler(this.btn_Descifrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(520, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Saltos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(302, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // txt_Text
            // 
            this.txt_Text.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Text.Location = new System.Drawing.Point(32, 49);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(612, 30);
            this.txt_Text.TabIndex = 15;
            // 
            // txt_Saltos
            // 
            this.txt_Saltos.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Saltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Saltos.Location = new System.Drawing.Point(444, 119);
            this.txt_Saltos.Name = "txt_Saltos";
            this.txt_Saltos.Size = new System.Drawing.Size(200, 30);
            this.txt_Saltos.TabIndex = 14;
            // 
            // txt_Vector
            // 
            this.txt_Vector.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Vector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Vector.Location = new System.Drawing.Point(238, 119);
            this.txt_Vector.Name = "txt_Vector";
            this.txt_Vector.Size = new System.Drawing.Size(200, 30);
            this.txt_Vector.TabIndex = 13;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Password.Location = new System.Drawing.Point(32, 119);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(200, 30);
            this.txt_Password.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texto a descifrar";
            // 
            // txt_Desencriptar
            // 
            this.txt_Desencriptar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Desencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Desencriptar.Location = new System.Drawing.Point(32, 243);
            this.txt_Desencriptar.Name = "txt_Desencriptar";
            this.txt_Desencriptar.ReadOnly = true;
            this.txt_Desencriptar.Size = new System.Drawing.Size(612, 30);
            this.txt_Desencriptar.TabIndex = 20;
            // 
            // Visor
            // 
            this.Visor.AllowUserToAddRows = false;
            this.Visor.AllowUserToDeleteRows = false;
            this.Visor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visor.Location = new System.Drawing.Point(32, 305);
            this.Visor.Name = "Visor";
            this.Visor.ReadOnly = true;
            this.Visor.RowHeadersWidth = 51;
            this.Visor.RowTemplate.Height = 24;
            this.Visor.Size = new System.Drawing.Size(612, 150);
            this.Visor.TabIndex = 21;
            // 
            // btn_Cifrar
            // 
            this.btn_Cifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Cifrar.Location = new System.Drawing.Point(402, 164);
            this.btn_Cifrar.Name = "btn_Cifrar";
            this.btn_Cifrar.Size = new System.Drawing.Size(120, 40);
            this.btn_Cifrar.TabIndex = 22;
            this.btn_Cifrar.Text = "Cifrar";
            this.btn_Cifrar.UseVisualStyleBackColor = true;
            this.btn_Cifrar.Click += new System.EventHandler(this.btn_Cifrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(274, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Texto descifrado";
            // 
            // FormDescifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(692, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Cifrar);
            this.Controls.Add(this.Visor);
            this.Controls.Add(this.txt_Desencriptar);
            this.Controls.Add(this.btn_Descifrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.txt_Saltos);
            this.Controls.Add(this.txt_Vector);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Name = "FormDescifrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDescifrado";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDescifrado_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Descifrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.TextBox txt_Saltos;
        private System.Windows.Forms.TextBox txt_Vector;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Desencriptar;
        private System.Windows.Forms.DataGridView Visor;
        private System.Windows.Forms.Button btn_Cifrar;
        private System.Windows.Forms.Label label5;
    }
}


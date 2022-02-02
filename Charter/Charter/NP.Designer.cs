namespace Charter
{
    partial class NP
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
            this.Ingresar = new System.Windows.Forms.Button();
            this.Clave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_clave = new System.Windows.Forms.TextBox();
            this.txtbox_des = new System.Windows.Forms.TextBox();
            this.txtbox_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.OrangeRed;
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.Color.White;
            this.Ingresar.Location = new System.Drawing.Point(339, 214);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(183, 48);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.BackColor = System.Drawing.Color.Transparent;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(149, 100);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(63, 25);
            this.Clave.TabIndex = 1;
            this.Clave.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // txtbox_clave
            // 
            this.txtbox_clave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_clave.Location = new System.Drawing.Point(218, 102);
            this.txtbox_clave.Name = "txtbox_clave";
            this.txtbox_clave.Size = new System.Drawing.Size(100, 23);
            this.txtbox_clave.TabIndex = 4;
            this.txtbox_clave.TextChanged += new System.EventHandler(this.txtbox_clave_TextChanged);
            this.txtbox_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_clave_KeyPress);
            // 
            // txtbox_des
            // 
            this.txtbox_des.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_des.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_des.Location = new System.Drawing.Point(495, 102);
            this.txtbox_des.Name = "txtbox_des";
            this.txtbox_des.Size = new System.Drawing.Size(185, 23);
            this.txtbox_des.TabIndex = 5;
            // 
            // txtbox_cantidad
            // 
            this.txtbox_cantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cantidad.Location = new System.Drawing.Point(218, 168);
            this.txtbox_cantidad.Name = "txtbox_cantidad";
            this.txtbox_cantidad.Size = new System.Drawing.Size(100, 23);
            this.txtbox_cantidad.TabIndex = 6;
            this.txtbox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo Producto";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(495, 168);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(118, 23);
            this.TxtPrecio.TabIndex = 9;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // NP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_cantidad);
            this.Controls.Add(this.txtbox_des);
            this.Controls.Add(this.txtbox_clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Ingresar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NP_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_clave;
        private System.Windows.Forms.TextBox txtbox_des;
        private System.Windows.Forms.TextBox txtbox_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label4;
    }
}
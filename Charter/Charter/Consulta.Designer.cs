namespace Charter
{
    partial class Consulta
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
            this.Clave = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxDes = new System.Windows.Forms.TextBox();
            this.TextbClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.GridConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.BackColor = System.Drawing.Color.Transparent;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(72, 86);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(63, 25);
            this.Clave.TabIndex = 20;
            this.Clave.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Consulta";
            // 
            // TextboxDes
            // 
            this.TextboxDes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextboxDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDes.Location = new System.Drawing.Point(367, 86);
            this.TextboxDes.Name = "TextboxDes";
            this.TextboxDes.Size = new System.Drawing.Size(179, 23);
            this.TextboxDes.TabIndex = 18;
            // 
            // TextbClave
            // 
            this.TextbClave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextbClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextbClave.Location = new System.Drawing.Point(141, 86);
            this.TextbClave.Name = "TextbClave";
            this.TextbClave.Size = new System.Drawing.Size(100, 23);
            this.TextbClave.TabIndex = 17;
            this.TextbClave.TextChanged += new System.EventHandler(this.TextbClave_TextChanged);
            this.TextbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextbClave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripción";
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.OrangeRed;
            this.Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.Color.White;
            this.Consultar.Location = new System.Drawing.Point(552, 74);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(183, 48);
            this.Consultar.TabIndex = 21;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // GridConsulta
            // 
            this.GridConsulta.AllowUserToAddRows = false;
            this.GridConsulta.AllowUserToDeleteRows = false;
            this.GridConsulta.BackgroundColor = System.Drawing.Color.White;
            this.GridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsulta.Location = new System.Drawing.Point(77, 190);
            this.GridConsulta.Name = "GridConsulta";
            this.GridConsulta.RowHeadersWidth = 51;
            this.GridConsulta.RowTemplate.Height = 24;
            this.GridConsulta.Size = new System.Drawing.Size(658, 202);
            this.GridConsulta.TabIndex = 22;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridConsulta);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxDes);
            this.Controls.Add(this.TextbClave);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consulta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxDes;
        private System.Windows.Forms.TextBox TextbClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.DataGridView GridConsulta;
    }
}
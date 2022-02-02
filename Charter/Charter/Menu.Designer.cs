namespace Charter
{
    partial class Menu
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
            this.btn_np = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pe = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_ti = new System.Windows.Forms.Button();
            this.btn_ci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_np
            // 
            this.btn_np.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_np.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_np.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_np.ForeColor = System.Drawing.Color.White;
            this.btn_np.Location = new System.Drawing.Point(26, 111);
            this.btn_np.Name = "btn_np";
            this.btn_np.Size = new System.Drawing.Size(235, 107);
            this.btn_np.TabIndex = 0;
            this.btn_np.Text = "Nuevo Producto";
            this.btn_np.UseVisualStyleBackColor = false;
            this.btn_np.Click += new System.EventHandler(this.btn_np_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú";
            // 
            // btn_pe
            // 
            this.btn_pe.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_pe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pe.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pe.ForeColor = System.Drawing.Color.White;
            this.btn_pe.Location = new System.Drawing.Point(287, 111);
            this.btn_pe.Name = "btn_pe";
            this.btn_pe.Size = new System.Drawing.Size(235, 107);
            this.btn_pe.TabIndex = 6;
            this.btn_pe.Text = "Producto Existente";
            this.btn_pe.UseVisualStyleBackColor = false;
            this.btn_pe.Click += new System.EventHandler(this.btn_pe_Click);
            // 
            // btn_sp
            // 
            this.btn_sp.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_sp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sp.ForeColor = System.Drawing.Color.White;
            this.btn_sp.Location = new System.Drawing.Point(543, 111);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(235, 107);
            this.btn_sp.TabIndex = 7;
            this.btn_sp.Text = "Salida de Producto";
            this.btn_sp.UseVisualStyleBackColor = false;
            this.btn_sp.Click += new System.EventHandler(this.btn_sp_Click);
            // 
            // btn_ti
            // 
            this.btn_ti.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ti.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ti.ForeColor = System.Drawing.Color.White;
            this.btn_ti.Location = new System.Drawing.Point(148, 260);
            this.btn_ti.Name = "btn_ti";
            this.btn_ti.Size = new System.Drawing.Size(235, 107);
            this.btn_ti.TabIndex = 8;
            this.btn_ti.Text = "Total de Inventario";
            this.btn_ti.UseVisualStyleBackColor = false;
            this.btn_ti.Click += new System.EventHandler(this.btn_ti_Click);
            // 
            // btn_ci
            // 
            this.btn_ci.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ci.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ci.ForeColor = System.Drawing.Color.White;
            this.btn_ci.Location = new System.Drawing.Point(409, 260);
            this.btn_ci.Name = "btn_ci";
            this.btn_ci.Size = new System.Drawing.Size(235, 107);
            this.btn_ci.TabIndex = 9;
            this.btn_ci.Text = "Consultar Inventario";
            this.btn_ci.UseVisualStyleBackColor = false;
            this.btn_ci.Click += new System.EventHandler(this.btn_ci_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ci);
            this.Controls.Add(this.btn_ti);
            this.Controls.Add(this.btn_sp);
            this.Controls.Add(this.btn_pe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_np);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_np;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pe;
        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_ti;
        private System.Windows.Forms.Button btn_ci;
    }
}
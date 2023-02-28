namespace SO
{
    partial class FormEscalonador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscalonador));
            this.ListaEsperaTXB = new System.Windows.Forms.RichTextBox();
            this.ProcessadorTXB = new System.Windows.Forms.RichTextBox();
            this.ListaFinalizadosTXB = new System.Windows.Forms.RichTextBox();
            this.ListaProntoTXB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ExecutaThreadTS = new System.Windows.Forms.ToolStripButton();
            this.PausarTS = new System.Windows.Forms.ToolStripButton();
            this.FinalizarTS = new System.Windows.Forms.ToolStripButton();
            this.ConfiguracaoTS = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaEsperaTXB
            // 
            this.ListaEsperaTXB.BackColor = System.Drawing.Color.Black;
            this.ListaEsperaTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaEsperaTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ListaEsperaTXB.Location = new System.Drawing.Point(36, 121);
            this.ListaEsperaTXB.Name = "ListaEsperaTXB";
            this.ListaEsperaTXB.ReadOnly = true;
            this.ListaEsperaTXB.Size = new System.Drawing.Size(276, 475);
            this.ListaEsperaTXB.TabIndex = 3;
            this.ListaEsperaTXB.Text = "";
            // 
            // ProcessadorTXB
            // 
            this.ProcessadorTXB.BackColor = System.Drawing.Color.Black;
            this.ProcessadorTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ProcessadorTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ProcessadorTXB.Location = new System.Drawing.Point(961, 179);
            this.ProcessadorTXB.Name = "ProcessadorTXB";
            this.ProcessadorTXB.ReadOnly = true;
            this.ProcessadorTXB.Size = new System.Drawing.Size(345, 45);
            this.ProcessadorTXB.TabIndex = 4;
            this.ProcessadorTXB.Text = "";
            // 
            // ListaFinalizadosTXB
            // 
            this.ListaFinalizadosTXB.BackColor = System.Drawing.Color.Black;
            this.ListaFinalizadosTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ListaFinalizadosTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ListaFinalizadosTXB.Location = new System.Drawing.Point(636, 122);
            this.ListaFinalizadosTXB.Name = "ListaFinalizadosTXB";
            this.ListaFinalizadosTXB.ReadOnly = true;
            this.ListaFinalizadosTXB.Size = new System.Drawing.Size(276, 473);
            this.ListaFinalizadosTXB.TabIndex = 5;
            this.ListaFinalizadosTXB.Text = "";
            // 
            // ListaProntoTXB
            // 
            this.ListaProntoTXB.BackColor = System.Drawing.Color.Black;
            this.ListaProntoTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProntoTXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ListaProntoTXB.Location = new System.Drawing.Point(336, 121);
            this.ListaProntoTXB.Name = "ListaProntoTXB";
            this.ListaProntoTXB.ReadOnly = true;
            this.ListaProntoTXB.Size = new System.Drawing.Size(276, 473);
            this.ListaProntoTXB.TabIndex = 6;
            this.ListaProntoTXB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(103, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(703, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Finalizados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(407, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de Prontos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1084, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Processador";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecutaThreadTS,
            this.PausarTS,
            this.ConfiguracaoTS,
            this.FinalizarTS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1358, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ExecutaThreadTS
            // 
            this.ExecutaThreadTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecutaThreadTS.Image = ((System.Drawing.Image)(resources.GetObject("ExecutaThreadTS.Image")));
            this.ExecutaThreadTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExecutaThreadTS.Name = "ExecutaThreadTS";
            this.ExecutaThreadTS.Size = new System.Drawing.Size(23, 22);
            this.ExecutaThreadTS.Text = "ExecutarThread";
            this.ExecutaThreadTS.Click += new System.EventHandler(this.ExecutaThreadTS_Click);
            // 
            // PausarTS
            // 
            this.PausarTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PausarTS.Image = ((System.Drawing.Image)(resources.GetObject("PausarTS.Image")));
            this.PausarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PausarTS.Name = "PausarTS";
            this.PausarTS.Size = new System.Drawing.Size(23, 22);
            this.PausarTS.Text = "Pausar";
            this.PausarTS.Click += new System.EventHandler(this.PausarTS_Click);
            // 
            // FinalizarTS
            // 
            this.FinalizarTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FinalizarTS.Image = ((System.Drawing.Image)(resources.GetObject("FinalizarTS.Image")));
            this.FinalizarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FinalizarTS.Name = "FinalizarTS";
            this.FinalizarTS.Size = new System.Drawing.Size(23, 22);
            this.FinalizarTS.Text = "toolStripButton3";
            this.FinalizarTS.ToolTipText = "Finalizar";
            this.FinalizarTS.Click += new System.EventHandler(this.FinalizarTS_Click);
            // 
            // ConfiguracaoTS
            // 
            this.ConfiguracaoTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConfiguracaoTS.Image = ((System.Drawing.Image)(resources.GetObject("ConfiguracaoTS.Image")));
            this.ConfiguracaoTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConfiguracaoTS.Name = "ConfiguracaoTS";
            this.ConfiguracaoTS.Size = new System.Drawing.Size(23, 22);
            this.ConfiguracaoTS.Text = "ConfiguracaoTS";
            this.ConfiguracaoTS.ToolTipText = "Configurações";
            this.ConfiguracaoTS.Click += new System.EventHandler(this.ConfiguracaoTS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(2, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Carregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEscalonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaProntoTXB);
            this.Controls.Add(this.ListaFinalizadosTXB);
            this.Controls.Add(this.ProcessadorTXB);
            this.Controls.Add(this.ListaEsperaTXB);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormEscalonador";
            this.Text = "Escalonador";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox ListaEsperaTXB;
        private System.Windows.Forms.RichTextBox ProcessadorTXB;
        private System.Windows.Forms.RichTextBox ListaFinalizadosTXB;
        private System.Windows.Forms.RichTextBox ListaProntoTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExecutaThreadTS;
        private System.Windows.Forms.ToolStripButton PausarTS;
        private System.Windows.Forms.ToolStripButton FinalizarTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton ConfiguracaoTS;
    }
}


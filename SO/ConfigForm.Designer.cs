namespace SO
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThreadExec = new System.Windows.Forms.ComboBox();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantConfig = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.bttonBusca = new System.Windows.Forms.Button();
            this.PriorTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BttonAltera = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thread:";
            // 
            // ThreadExec
            // 
            this.ThreadExec.BackColor = System.Drawing.Color.Black;
            this.ThreadExec.Cursor = System.Windows.Forms.Cursors.Default;
            this.ThreadExec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThreadExec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThreadExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ThreadExec.ForeColor = System.Drawing.Color.White;
            this.ThreadExec.FormattingEnabled = true;
            this.ThreadExec.Items.AddRange(new object[] {
            "10",
            "100",
            "300",
            "800",
            "1000",
            "2000"});
            this.ThreadExec.Location = new System.Drawing.Point(165, 34);
            this.ThreadExec.Name = "ThreadExec";
            this.ThreadExec.Size = new System.Drawing.Size(84, 24);
            this.ThreadExec.TabIndex = 3;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.BackColor = System.Drawing.Color.Black;
            this.ConfirmarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmarButton.Location = new System.Drawing.Point(139, 343);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(93, 41);
            this.ConfirmarButton.TabIndex = 4;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = false;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantum:";
            // 
            // QuantConfig
            // 
            this.QuantConfig.BackColor = System.Drawing.Color.Black;
            this.QuantConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.QuantConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuantConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuantConfig.ForeColor = System.Drawing.Color.White;
            this.QuantConfig.FormattingEnabled = true;
            this.QuantConfig.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "50"});
            this.QuantConfig.Location = new System.Drawing.Point(165, 80);
            this.QuantConfig.Name = "QuantConfig";
            this.QuantConfig.Size = new System.Drawing.Size(84, 24);
            this.QuantConfig.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(90, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Altera prioridade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.Black;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.ForeColor = System.Drawing.Color.White;
            this.IdTB.Location = new System.Drawing.Point(84, 154);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(100, 22);
            this.IdTB.TabIndex = 11;
            this.IdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttonBusca
            // 
            this.bttonBusca.BackColor = System.Drawing.Color.Black;
            this.bttonBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttonBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttonBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttonBusca.Location = new System.Drawing.Point(205, 154);
            this.bttonBusca.Name = "bttonBusca";
            this.bttonBusca.Size = new System.Drawing.Size(75, 23);
            this.bttonBusca.TabIndex = 13;
            this.bttonBusca.Text = "Buscar";
            this.bttonBusca.UseVisualStyleBackColor = false;
            this.bttonBusca.Click += new System.EventHandler(this.bttonBusca_Click);
            // 
            // PriorTX
            // 
            this.PriorTX.BackColor = System.Drawing.SystemColors.WindowText;
            this.PriorTX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriorTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorTX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PriorTX.Location = new System.Drawing.Point(139, 254);
            this.PriorTX.Name = "PriorTX";
            this.PriorTX.Size = new System.Drawing.Size(45, 22);
            this.PriorTX.TabIndex = 14;
            this.PriorTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(61, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prioridade";
            // 
            // BttonAltera
            // 
            this.BttonAltera.BackColor = System.Drawing.Color.Black;
            this.BttonAltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttonAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttonAltera.Location = new System.Drawing.Point(200, 252);
            this.BttonAltera.Name = "BttonAltera";
            this.BttonAltera.Size = new System.Drawing.Size(80, 25);
            this.BttonAltera.TabIndex = 16;
            this.BttonAltera.Text = "Alterar";
            this.BttonAltera.UseVisualStyleBackColor = false;
            this.BttonAltera.Click += new System.EventHandler(this.BttonAltera_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prioridade";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Execução";
            this.columnHeader4.Width = 74;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listView1.Location = new System.Drawing.Point(14, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 60);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(420, 436);
            this.Controls.Add(this.BttonAltera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriorTX);
            this.Controls.Add(this.bttonBusca);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.ThreadExec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigForm";
            this.Text = "Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ThreadExec;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox QuantConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Button bttonBusca;
        private System.Windows.Forms.TextBox PriorTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttonAltera;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
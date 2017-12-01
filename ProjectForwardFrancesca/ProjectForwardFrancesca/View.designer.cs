namespace ProjectForwardFrancesca
{
    partial class View
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnRW = new System.Windows.Forms.Button();
            this.rbSQLServer = new System.Windows.Forms.RadioButton();
            this.rbSQLite = new System.Windows.Forms.RadioButton();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnForcast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewRead = new System.Windows.Forms.RadioButton();
            this.rbtViaFactory = new System.Windows.Forms.RadioButton();
            this.gbServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(213, 102);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(379, 331);
            this.txtConsole.TabIndex = 1;
            // 
            // btnRW
            // 
            this.btnRW.Location = new System.Drawing.Point(12, 140);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(100, 24);
            this.btnRW.TabIndex = 2;
            this.btnRW.Text = "Read View";
            this.btnRW.UseVisualStyleBackColor = true;
            this.btnRW.Click += new System.EventHandler(this.btnRW_Click);
            // 
            // rbSQLServer
            // 
            this.rbSQLServer.AutoSize = true;
            this.rbSQLServer.Checked = true;
            this.rbSQLServer.Location = new System.Drawing.Point(6, 41);
            this.rbSQLServer.Name = "rbSQLServer";
            this.rbSQLServer.Size = new System.Drawing.Size(99, 21);
            this.rbSQLServer.TabIndex = 3;
            this.rbSQLServer.TabStop = true;
            this.rbSQLServer.Text = "SQLServer";
            this.rbSQLServer.UseVisualStyleBackColor = true;
            // 
            // rbSQLite
            // 
            this.rbSQLite.AutoSize = true;
            this.rbSQLite.Location = new System.Drawing.Point(6, 21);
            this.rbSQLite.Name = "rbSQLite";
            this.rbSQLite.Size = new System.Drawing.Size(72, 21);
            this.rbSQLite.TabIndex = 4;
            this.rbSQLite.TabStop = true;
            this.rbSQLite.Text = "SQLite";
            this.rbSQLite.UseVisualStyleBackColor = true;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.rbSQLite);
            this.gbServer.Controls.Add(this.rbSQLServer);
            this.gbServer.Location = new System.Drawing.Point(193, 13);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(143, 68);
            this.gbServer.TabIndex = 5;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "DBMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(69, 102);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 7;
            // 
            // btnForcast
            // 
            this.btnForcast.Location = new System.Drawing.Point(12, 170);
            this.btnForcast.Name = "btnForcast";
            this.btnForcast.Size = new System.Drawing.Size(135, 23);
            this.btnForcast.TabIndex = 8;
            this.btnForcast.Text = "Forcast";
            this.btnForcast.UseVisualStyleBackColor = true;
            this.btnForcast.Click += new System.EventHandler(this.btnForcast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewRead);
            this.groupBox1.Controls.Add(this.rbtViaFactory);
            this.groupBox1.Location = new System.Drawing.Point(406, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read via";
            // 
            // viewRead
            // 
            this.viewRead.AutoSize = true;
            this.viewRead.Location = new System.Drawing.Point(6, 21);
            this.viewRead.Name = "viewRead";
            this.viewRead.Size = new System.Drawing.Size(58, 21);
            this.viewRead.TabIndex = 4;
            this.viewRead.TabStop = true;
            this.viewRead.Text = "View";
            this.viewRead.UseVisualStyleBackColor = true;
            // 
            // rbtViaFactory
            // 
            this.rbtViaFactory.AutoSize = true;
            this.rbtViaFactory.Checked = true;
            this.rbtViaFactory.Location = new System.Drawing.Point(6, 41);
            this.rbtViaFactory.Name = "rbtViaFactory";
            this.rbtViaFactory.Size = new System.Drawing.Size(76, 21);
            this.rbtViaFactory.TabIndex = 3;
            this.rbtViaFactory.TabStop = true;
            this.rbtViaFactory.Text = "Factory";
            this.rbtViaFactory.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnForcast);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.btnRW);
            this.Controls.Add(this.txtConsole);
            this.Name = "View";
            this.Text = "Form1";
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.RadioButton rbSQLServer;
        private System.Windows.Forms.RadioButton rbSQLite;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnForcast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton viewRead;
        private System.Windows.Forms.RadioButton rbtViaFactory;
    }
}


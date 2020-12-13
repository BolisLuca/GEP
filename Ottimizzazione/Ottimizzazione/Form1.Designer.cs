namespace Ottimizzazione
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewTabella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownProduttori = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConsumatori = new System.Windows.Forms.NumericUpDown();
            this.buttonCreaTabella = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMaxCosti = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinCosti = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCosto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMaxProdFabb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinProdFabb = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProdFabb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProdFabb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabella
            // 
            this.dataGridViewTabella.AllowUserToAddRows = false;
            this.dataGridViewTabella.AllowUserToDeleteRows = false;
            this.dataGridViewTabella.AllowUserToResizeColumns = false;
            this.dataGridViewTabella.AllowUserToResizeRows = false;
            this.dataGridViewTabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabella.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewTabella.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewTabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabella.Location = new System.Drawing.Point(28, 144);
            this.dataGridViewTabella.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTabella.Name = "dataGridViewTabella";
            this.dataGridViewTabella.RowHeadersWidth = 51;
            this.dataGridViewTabella.RowTemplate.Height = 24;
            this.dataGridViewTabella.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTabella.Size = new System.Drawing.Size(662, 168);
            this.dataGridViewTabella.TabIndex = 0;
            this.dataGridViewTabella.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewTabella_CellBeginEdit);
            this.dataGridViewTabella.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewTabella_EditingControlShowing);
            this.dataGridViewTabella.SelectionChanged += new System.EventHandler(this.dataGridViewTabella_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produttori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumatori:";
            // 
            // numericUpDownProduttori
            // 
            this.numericUpDownProduttori.Location = new System.Drawing.Point(24, 53);
            this.numericUpDownProduttori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownProduttori.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownProduttori.Name = "numericUpDownProduttori";
            this.numericUpDownProduttori.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownProduttori.TabIndex = 3;
            this.numericUpDownProduttori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownProduttori.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownConsumatori
            // 
            this.numericUpDownConsumatori.Location = new System.Drawing.Point(133, 53);
            this.numericUpDownConsumatori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownConsumatori.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownConsumatori.Name = "numericUpDownConsumatori";
            this.numericUpDownConsumatori.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownConsumatori.TabIndex = 4;
            this.numericUpDownConsumatori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownConsumatori.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonCreaTabella
            // 
            this.buttonCreaTabella.Location = new System.Drawing.Point(90, 76);
            this.buttonCreaTabella.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreaTabella.Name = "buttonCreaTabella";
            this.buttonCreaTabella.Size = new System.Drawing.Size(74, 28);
            this.buttonCreaTabella.TabIndex = 5;
            this.buttonCreaTabella.Text = "Crea";
            this.buttonCreaTabella.UseVisualStyleBackColor = true;
            this.buttonCreaTabella.Click += new System.EventHandler(this.buttonCreaTabella_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creazione Tabella";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo trasporti";
            // 
            // numericUpDownMaxCosti
            // 
            this.numericUpDownMaxCosti.Location = new System.Drawing.Point(449, 53);
            this.numericUpDownMaxCosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMaxCosti.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownMaxCosti.Name = "numericUpDownMaxCosti";
            this.numericUpDownMaxCosti.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMaxCosti.TabIndex = 10;
            this.numericUpDownMaxCosti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownMinCosti
            // 
            this.numericUpDownMinCosti.Location = new System.Drawing.Point(340, 53);
            this.numericUpDownMinCosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMinCosti.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownMinCosti.Name = "numericUpDownMinCosti";
            this.numericUpDownMinCosti.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMinCosti.TabIndex = 9;
            this.numericUpDownMinCosti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Massimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minimo:";
            // 
            // buttonCosto
            // 
            this.buttonCosto.Location = new System.Drawing.Point(624, 30);
            this.buttonCosto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCosto.Name = "buttonCosto";
            this.buttonCosto.Size = new System.Drawing.Size(84, 73);
            this.buttonCosto.TabIndex = 12;
            this.buttonCosto.Text = "Genera";
            this.buttonCosto.UseVisualStyleBackColor = true;
            this.buttonCosto.Click += new System.EventHandler(this.buttonCosto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Range costi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Range Produzioni/Fabbisogni";
            // 
            // numericUpDownMaxProdFabb
            // 
            this.numericUpDownMaxProdFabb.Location = new System.Drawing.Point(530, 92);
            this.numericUpDownMaxProdFabb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMaxProdFabb.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownMaxProdFabb.Name = "numericUpDownMaxProdFabb";
            this.numericUpDownMaxProdFabb.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMaxProdFabb.TabIndex = 18;
            this.numericUpDownMaxProdFabb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownMinProdFabb
            // 
            this.numericUpDownMinProdFabb.Location = new System.Drawing.Point(421, 92);
            this.numericUpDownMinProdFabb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownMinProdFabb.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownMinProdFabb.Name = "numericUpDownMinProdFabb";
            this.numericUpDownMinProdFabb.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMinProdFabb.TabIndex = 17;
            this.numericUpDownMinProdFabb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Massimo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Minimo:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(716, 336);
            this.Controls.Add(this.numericUpDownMaxProdFabb);
            this.Controls.Add(this.numericUpDownMinProdFabb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMaxCosti);
            this.Controls.Add(this.numericUpDownMinCosti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreaTabella);
            this.Controls.Add(this.numericUpDownConsumatori);
            this.Controls.Add(this.numericUpDownProduttori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTabella);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ottimizzazione";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProduttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsumatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinCosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxProdFabb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinProdFabb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownProduttori;
        private System.Windows.Forms.NumericUpDown numericUpDownConsumatori;
        private System.Windows.Forms.Button buttonCreaTabella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCosti;
        private System.Windows.Forms.NumericUpDown numericUpDownMinCosti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxProdFabb;
        private System.Windows.Forms.NumericUpDown numericUpDownMinProdFabb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


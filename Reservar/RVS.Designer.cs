namespace Sistema_de_Aerolinea.Reservar
{
    partial class RVS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RVS));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPasajeros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvreservas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.comboBoxIdReserva = new System.Windows.Forms.ComboBox();
            this.ㅤㅤ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservar";
            // 
            // comboBoxPasajeros
            // 
            this.comboBoxPasajeros.AccessibleName = "";
            this.comboBoxPasajeros.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPasajeros.FormattingEnabled = true;
            this.comboBoxPasajeros.Location = new System.Drawing.Point(143, 106);
            this.comboBoxPasajeros.Name = "comboBoxPasajeros";
            this.comboBoxPasajeros.Size = new System.Drawing.Size(171, 26);
            this.comboBoxPasajeros.TabIndex = 2;
            this.comboBoxPasajeros.SelectedIndexChanged += new System.EventHandler(this.comboBoxPasajeros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasajero";
            // 
            // dgvreservas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvreservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvreservas.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvreservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvreservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvreservas.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvreservas.Location = new System.Drawing.Point(-12, 159);
            this.dgvreservas.Name = "dgvreservas";
            this.dgvreservas.Size = new System.Drawing.Size(452, 189);
            this.dgvreservas.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(458, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RRESERVAS);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Yellow;
            this.Cancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(550, 335);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(167, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "CANCELAR RESERVA";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.CancelarReserva);
            // 
            // comboBoxIdReserva
            // 
            this.comboBoxIdReserva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxIdReserva.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdReserva.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxIdReserva.FormattingEnabled = true;
            this.comboBoxIdReserva.Location = new System.Drawing.Point(600, 364);
            this.comboBoxIdReserva.Name = "comboBoxIdReserva";
            this.comboBoxIdReserva.Size = new System.Drawing.Size(41, 23);
            this.comboBoxIdReserva.TabIndex = 9;
            // 
            // ㅤㅤ
            // 
            this.ㅤㅤ.AutoSize = true;
            this.ㅤㅤ.BackColor = System.Drawing.Color.Navy;
            this.ㅤㅤ.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ㅤㅤ.Image = ((System.Drawing.Image)(resources.GetObject("ㅤㅤ.Image")));
            this.ㅤㅤ.Location = new System.Drawing.Point(394, 33);
            this.ㅤㅤ.Name = "ㅤㅤ";
            this.ㅤㅤ.Size = new System.Drawing.Size(380, 96);
            this.ㅤㅤ.TabIndex = 10;
            this.ㅤㅤ.Text = "ㅤㅤㅤㅤㅤ";
            this.ㅤㅤ.Click += new System.EventHandler(this.ㅤㅤㅤㅤㅤ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(536, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID reserva";
            // 
            // RVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ㅤㅤ);
            this.Controls.Add(this.comboBoxIdReserva);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvreservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPasajeros);
            this.Controls.Add(this.label1);
            this.Name = "RVS";
            this.Text = "RVS";
            this.Load += new System.EventHandler(this.Vuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPasajeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvreservas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox comboBoxIdReserva;
        private System.Windows.Forms.Label ㅤㅤ;
        private System.Windows.Forms.Label label3;
    }
}
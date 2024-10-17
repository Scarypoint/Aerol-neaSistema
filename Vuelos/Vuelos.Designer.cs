namespace Sistema_de_Aerolinea.Vuelo
{
    partial class RegistrarVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVuelos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroVuelo = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.NumeroVuelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAviones = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(338, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuelos";
            // 
            // txtNumeroVuelo
            // 
            this.txtNumeroVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVuelo.Location = new System.Drawing.Point(219, 96);
            this.txtNumeroVuelo.Name = "txtNumeroVuelo";
            this.txtNumeroVuelo.Size = new System.Drawing.Size(100, 29);
            this.txtNumeroVuelo.TabIndex = 1;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(219, 135);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 29);
            this.txtDestino.TabIndex = 2;
            // 
            // NumeroVuelo
            // 
            this.NumeroVuelo.AutoSize = true;
            this.NumeroVuelo.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroVuelo.ForeColor = System.Drawing.Color.Yellow;
            this.NumeroVuelo.Location = new System.Drawing.Point(17, 99);
            this.NumeroVuelo.Name = "NumeroVuelo";
            this.NumeroVuelo.Size = new System.Drawing.Size(178, 25);
            this.NumeroVuelo.TabIndex = 4;
            this.NumeroVuelo.Text = "Numero De Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(111, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(129, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(219, 177);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(164, 26);
            this.dtpFechaSalida.TabIndex = 9;
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(245, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Registrar);
            // 
            // comboBoxAviones
            // 
            this.comboBoxAviones.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAviones.FormattingEnabled = true;
            this.comboBoxAviones.Location = new System.Drawing.Point(534, 218);
            this.comboBoxAviones.Name = "comboBoxAviones";
            this.comboBoxAviones.Size = new System.Drawing.Size(177, 30);
            this.comboBoxAviones.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(124, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar Vuelo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cancelar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(521, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona un avion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-12, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 90);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 158);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.ClientSizeChanged += new System.EventHandler(this.pictureBox1_ClientSizeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(9, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Para Cancelar Solo Necesitas el Numero De Vuelo";
            // 
            // RegistrarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxAviones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumeroVuelo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtNumeroVuelo);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "RegistrarVuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.RegistrarVuelos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroVuelo;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label NumeroVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAviones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}
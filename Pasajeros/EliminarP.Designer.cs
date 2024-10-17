namespace Sistema_de_Aerolinea.Pasajeros
{
    partial class EliminarP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarP));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEliminarPasajero = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(55, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 31);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EliminarPasajeros);
            // 
            // comboBoxEliminarPasajero
            // 
            this.comboBoxEliminarPasajero.BackColor = System.Drawing.Color.White;
            this.comboBoxEliminarPasajero.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEliminarPasajero.FormattingEnabled = true;
            this.comboBoxEliminarPasajero.Location = new System.Drawing.Point(89, 157);
            this.comboBoxEliminarPasajero.Name = "comboBoxEliminarPasajero";
            this.comboBoxEliminarPasajero.Size = new System.Drawing.Size(231, 32);
            this.comboBoxEliminarPasajero.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borrar Pasajero";
            // 
            // EliminarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(448, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxEliminarPasajero);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "EliminarP";
            this.Text = "EliminarP";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxEliminarPasajero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
namespace Calificaciones
{
    partial class RegistrarAvion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(113, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Registar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(53, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacidad";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(56, 52);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(196, 20);
            this.txtmodelo.TabIndex = 4;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(56, 91);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(196, 20);
            this.txtmatricula.TabIndex = 5;
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(56, 130);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(196, 20);
            this.txtcapacidad.TabIndex = 6;
            // 
            // RegistrarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(295, 193);
            this.Controls.Add(this.txtcapacidad);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegistrarAvion";
            this.Text = "Registrar Avion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtcapacidad;
    }
}
namespace Sistema_de_Aerolinea
{
    partial class EliminarAvion1
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
            this.txtELI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtELI
            // 
            this.txtELI.BackColor = System.Drawing.Color.Gold;
            this.txtELI.Location = new System.Drawing.Point(136, 140);
            this.txtELI.Name = "txtELI";
            this.txtELI.Size = new System.Drawing.Size(75, 23);
            this.txtELI.TabIndex = 0;
            this.txtELI.Text = "Eliminar";
            this.txtELI.UseVisualStyleBackColor = false;
            this.txtELI.Click += new System.EventHandler(this.EliminarAvion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(136, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(123, 100);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 2;
            // 
            // EliminarAvion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 216);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtELI);
            this.Name = "EliminarAvion1";
            this.Text = "EliminarAvion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtELI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodelo;
    }
}
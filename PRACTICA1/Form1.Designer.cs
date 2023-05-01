
namespace PRACTICA1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnDOS = new System.Windows.Forms.Button();
            this.labelSALUDO = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.labelNOMBRE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnDOS
            // 
            this.bttnDOS.Location = new System.Drawing.Point(183, 83);
            this.bttnDOS.Name = "bttnDOS";
            this.bttnDOS.Size = new System.Drawing.Size(297, 218);
            this.bttnDOS.TabIndex = 0;
            this.bttnDOS.Text = "saludar";
            this.bttnDOS.UseVisualStyleBackColor = true;
            this.bttnDOS.Click += new System.EventHandler(this.bttnDOS_Click);
            // 
            // labelSALUDO
            // 
            this.labelSALUDO.AutoSize = true;
            this.labelSALUDO.Location = new System.Drawing.Point(304, 355);
            this.labelSALUDO.Name = "labelSALUDO";
            this.labelSALUDO.Size = new System.Drawing.Size(0, 13);
            this.labelSALUDO.TabIndex = 1;
            this.labelSALUDO.Click += new System.EventHandler(this.bttnDOS_Click);
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(214, 57);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(266, 20);
            this.txtNOMBRE.TabIndex = 2;
            // 
            // labelNOMBRE
            // 
            this.labelNOMBRE.AutoSize = true;
            this.labelNOMBRE.Location = new System.Drawing.Point(154, 60);
            this.labelNOMBRE.Name = "labelNOMBRE";
            this.labelNOMBRE.Size = new System.Drawing.Size(54, 13);
            this.labelNOMBRE.TabIndex = 3;
            this.labelNOMBRE.Text = "NOMBRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNOMBRE);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.labelSALUDO);
            this.Controls.Add(this.bttnDOS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TextChanged += new System.EventHandler(this.NO);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnDOS;
        private System.Windows.Forms.Label labelSALUDO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label labelNOMBRE;
    }
}



namespace CLASE_DATETIME
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
            this.dtpDias = new System.Windows.Forms.DateTimePicker();
            this.mesCalendario = new System.Windows.Forms.MonthCalendar();
            this.bttnPicker = new System.Windows.Forms.Button();
            this.bttnCalendario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDias
            // 
            this.dtpDias.Location = new System.Drawing.Point(234, 52);
            this.dtpDias.Name = "dtpDias";
            this.dtpDias.Size = new System.Drawing.Size(200, 20);
            this.dtpDias.TabIndex = 0;
            this.dtpDias.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mesCalendario
            // 
            this.mesCalendario.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.mesCalendario.Location = new System.Drawing.Point(106, 121);
            this.mesCalendario.Name = "mesCalendario";
            this.mesCalendario.TabIndex = 1;
            // 
            // bttnPicker
            // 
            this.bttnPicker.Location = new System.Drawing.Point(455, 49);
            this.bttnPicker.Name = "bttnPicker";
            this.bttnPicker.Size = new System.Drawing.Size(75, 23);
            this.bttnPicker.TabIndex = 2;
            this.bttnPicker.Text = "prueba 1";
            this.bttnPicker.UseVisualStyleBackColor = true;
            this.bttnPicker.Click += new System.EventHandler(this.bttnPicker_Click);
            // 
            // bttnCalendario
            // 
            this.bttnCalendario.Location = new System.Drawing.Point(618, 248);
            this.bttnCalendario.Name = "bttnCalendario";
            this.bttnCalendario.Size = new System.Drawing.Size(75, 23);
            this.bttnCalendario.TabIndex = 3;
            this.bttnCalendario.Text = "Prueba 2";
            this.bttnCalendario.UseVisualStyleBackColor = true;
            this.bttnCalendario.Click += new System.EventHandler(this.bttnCalendario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCalendario);
            this.Controls.Add(this.bttnPicker);
            this.Controls.Add(this.mesCalendario);
            this.Controls.Add(this.dtpDias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDias;
        private System.Windows.Forms.MonthCalendar mesCalendario;
        private System.Windows.Forms.Button bttnPicker;
        private System.Windows.Forms.Button bttnCalendario;
    }
}


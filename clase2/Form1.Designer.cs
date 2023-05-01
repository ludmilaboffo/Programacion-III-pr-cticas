
namespace clase2
{
    partial class FormUno
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
            this.bttnElemento = new System.Windows.Forms.Button();
            this.listViewElementos = new System.Windows.Forms.ListView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtPNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxChoco = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.rbSemi = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.cboColorFav = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.nupNumFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumFav = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumFav)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnElemento
            // 
            this.bttnElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnElemento.Location = new System.Drawing.Point(169, 511);
            this.bttnElemento.Name = "bttnElemento";
            this.bttnElemento.Size = new System.Drawing.Size(75, 23);
            this.bttnElemento.TabIndex = 8;
            this.bttnElemento.Text = "Agregar";
            this.bttnElemento.UseVisualStyleBackColor = true;
            this.bttnElemento.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewElementos
            // 
            this.listViewElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewElementos.HideSelection = false;
            this.listViewElementos.Location = new System.Drawing.Point(291, 391);
            this.listViewElementos.Name = "listViewElementos";
            this.listViewElementos.Size = new System.Drawing.Size(408, 103);
            this.listViewElementos.TabIndex = 7;
            this.listViewElementos.UseCompatibleStateImageBehavior = false;
            this.listViewElementos.View = System.Windows.Forms.View.List;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(169, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(495, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(118, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(57, 115);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // dtPNacimiento
            // 
            this.dtPNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPNacimiento.Location = new System.Drawing.Point(169, 109);
            this.dtPNacimiento.Name = "dtPNacimiento";
            this.dtPNacimiento.Size = new System.Drawing.Size(495, 20);
            this.dtPNacimiento.TabIndex = 1;
            // 
            // cbxChoco
            // 
            this.cbxChoco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChoco.AutoSize = true;
            this.cbxChoco.Location = new System.Drawing.Point(297, 217);
            this.cbxChoco.Name = "cbxChoco";
            this.cbxChoco.Size = new System.Drawing.Size(141, 17);
            this.cbxChoco.TabIndex = 4;
            this.cbxChoco.Text = "¿Te gusta el chocolate?";
            this.cbxChoco.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(102, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 49);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "PERFIL PERSONA";
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(139, 19);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(68, 17);
            this.rbBlanco.TabIndex = 1;
            this.rbBlanco.Text = "BLANCO";
            this.rbBlanco.UseVisualStyleBackColor = true;
            this.rbBlanco.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSemi
            // 
            this.rbSemi.AutoSize = true;
            this.rbSemi.Checked = true;
            this.rbSemi.Location = new System.Drawing.Point(24, 19);
            this.rbSemi.Name = "rbSemi";
            this.rbSemi.Size = new System.Drawing.Size(101, 17);
            this.rbSemi.TabIndex = 0;
            this.rbSemi.TabStop = true;
            this.rbSemi.Text = "SEMI AMARGO";
            this.rbSemi.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTipo.Controls.Add(this.rbNegro);
            this.gbTipo.Controls.Add(this.rbSemi);
            this.gbTipo.Controls.Add(this.rbBlanco);
            this.gbTipo.Location = new System.Drawing.Point(158, 240);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(534, 100);
            this.gbTipo.TabIndex = 5;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "TIPO";
            this.gbTipo.Enter += new System.EventHandler(this.gbTipo_Enter);
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(216, 19);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(64, 17);
            this.rbNegro.TabIndex = 2;
            this.rbNegro.Text = "NEGRO";
            this.rbNegro.UseVisualStyleBackColor = true;
            // 
            // cboColorFav
            // 
            this.cboColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFav.FormattingEnabled = true;
            this.cboColorFav.Location = new System.Drawing.Point(167, 145);
            this.cboColorFav.Name = "cboColorFav";
            this.cboColorFav.Size = new System.Drawing.Size(501, 21);
            this.cboColorFav.TabIndex = 2;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(90, 148);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(67, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "COLOR FAV";
            this.lblColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // nupNumFav
            // 
            this.nupNumFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupNumFav.Location = new System.Drawing.Point(169, 191);
            this.nupNumFav.Name = "nupNumFav";
            this.nupNumFav.Size = new System.Drawing.Size(495, 20);
            this.nupNumFav.TabIndex = 3;
            // 
            // lblNumFav
            // 
            this.lblNumFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumFav.AutoSize = true;
            this.lblNumFav.Location = new System.Drawing.Point(51, 193);
            this.lblNumFav.Name = "lblNumFav";
            this.lblNumFav.Size = new System.Drawing.Size(112, 13);
            this.lblNumFav.TabIndex = 15;
            this.lblNumFav.Text = "NUMERO FAVORITO";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPerfil.FlatAppearance.BorderSize = 2;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(158, 365);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(125, 24);
            this.btnPerfil.TabIndex = 6;
            this.btnPerfil.Text = "VER PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // FormUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 592);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lblNumFav);
            this.Controls.Add(this.nupNumFav);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColorFav);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxChoco);
            this.Controls.Add(this.dtPNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listViewElementos);
            this.Controls.Add(this.bttnElemento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(849, 631);
            this.MinimumSize = new System.Drawing.Size(549, 431);
            this.Name = "FormUno";
            this.Tag = "4";
            this.Text = "4";
            this.Load += new System.EventHandler(this.FormUno_Load_1);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnElemento;
        private System.Windows.Forms.ListView listViewElementos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtPNacimiento;
        private System.Windows.Forms.CheckBox cbxChoco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.RadioButton rbSemi;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.ComboBox cboColorFav;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown nupNumFav;
        private System.Windows.Forms.Label lblNumFav;
        private System.Windows.Forms.Button btnPerfil;
    }
}


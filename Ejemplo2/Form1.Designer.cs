namespace Ejemplo2
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
            this.lwNombres = new System.Windows.Forms.ListView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbSquibs = new System.Windows.Forms.RadioButton();
            this.rdbMuggle = new System.Windows.Forms.RadioButton();
            this.rdbWizard = new System.Windows.Forms.RadioButton();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.btnVerperfil = new System.Windows.Forms.Button();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwNombres
            // 
            this.lwNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwNombres.HideSelection = false;
            this.lwNombres.Location = new System.Drawing.Point(77, 344);
            this.lwNombres.Name = "lwNombres";
            this.lwNombres.Size = new System.Drawing.Size(317, 144);
            this.lwNombres.TabIndex = 6;
            this.lwNombres.UseCompatibleStateImageBehavior = false;
            this.lwNombres.View = System.Windows.Forms.View.List;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(159, 70);
            this.txtNombre.MinimumSize = new System.Drawing.Size(194, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(75, 494);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(48, 110);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(91, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(159, 104);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(219, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // gpbTipo
            // 
            this.gpbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbTipo.Controls.Add(this.rdbSquibs);
            this.gpbTipo.Controls.Add(this.rdbMuggle);
            this.gpbTipo.Controls.Add(this.rdbWizard);
            this.gpbTipo.Location = new System.Drawing.Point(89, 192);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(384, 58);
            this.gpbTipo.TabIndex = 3;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // rdbSquibs
            // 
            this.rdbSquibs.AutoSize = true;
            this.rdbSquibs.Location = new System.Drawing.Point(263, 19);
            this.rdbSquibs.Name = "rdbSquibs";
            this.rdbSquibs.Size = new System.Drawing.Size(57, 17);
            this.rdbSquibs.TabIndex = 2;
            this.rdbSquibs.TabStop = true;
            this.rdbSquibs.Text = "Squibs";
            this.rdbSquibs.UseVisualStyleBackColor = true;
            // 
            // rdbMuggle
            // 
            this.rdbMuggle.AutoSize = true;
            this.rdbMuggle.Location = new System.Drawing.Point(125, 19);
            this.rdbMuggle.Name = "rdbMuggle";
            this.rdbMuggle.Size = new System.Drawing.Size(60, 17);
            this.rdbMuggle.TabIndex = 1;
            this.rdbMuggle.TabStop = true;
            this.rdbMuggle.Text = "Muggle";
            this.rdbMuggle.UseVisualStyleBackColor = true;
            // 
            // rdbWizard
            // 
            this.rdbWizard.AutoSize = true;
            this.rdbWizard.Location = new System.Drawing.Point(19, 19);
            this.rdbWizard.Name = "rdbWizard";
            this.rdbWizard.Size = new System.Drawing.Size(58, 17);
            this.rdbWizard.TabIndex = 0;
            this.rdbWizard.TabStop = true;
            this.rdbWizard.Text = "Wizard";
            this.rdbWizard.UseVisualStyleBackColor = true;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(159, 147);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(159, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(104, 265);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(165, 262);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(182, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // btnVerperfil
            // 
            this.btnVerperfil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerperfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerperfil.FlatAppearance.BorderSize = 2;
            this.btnVerperfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVerperfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVerperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerperfil.Location = new System.Drawing.Point(89, 306);
            this.btnVerperfil.Name = "btnVerperfil";
            this.btnVerperfil.Size = new System.Drawing.Size(75, 32);
            this.btnVerperfil.TabIndex = 5;
            this.btnVerperfil.Text = "Ver Perfil";
            this.btnVerperfil.UseVisualStyleBackColor = false;
            this.btnVerperfil.Click += new System.EventHandler(this.btnVerperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 531);
            this.Controls.Add(this.btnVerperfil);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lwNombres);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 687);
            this.MinimumSize = new System.Drawing.Size(528, 570);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwNombres;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbSquibs;
        private System.Windows.Forms.RadioButton rdbMuggle;
        private System.Windows.Forms.RadioButton rdbWizard;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Button btnVerperfil;
    }
}


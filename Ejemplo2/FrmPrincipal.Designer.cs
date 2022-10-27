namespace Ejemplo2
{
    partial class FrmPrincipal
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MnPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPersonaMn = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnPerfil,
            this.MnOption});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu";
            // 
            // MnPerfil
            // 
            this.MnPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilPersonaMn,
            this.buscarPerfilToolStripMenuItem});
            this.MnPerfil.Name = "MnPerfil";
            this.MnPerfil.Size = new System.Drawing.Size(46, 20);
            this.MnPerfil.Text = "&Perfil";
            // 
            // perfilPersonaMn
            // 
            this.perfilPersonaMn.Name = "perfilPersonaMn";
            this.perfilPersonaMn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.perfilPersonaMn.Size = new System.Drawing.Size(187, 22);
            this.perfilPersonaMn.Text = "Perfil Persona";
            this.perfilPersonaMn.Click += new System.EventHandler(this.perfilPersonaMn_Click);
            // 
            // buscarPerfilToolStripMenuItem
            // 
            this.buscarPerfilToolStripMenuItem.Name = "buscarPerfilToolStripMenuItem";
            this.buscarPerfilToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.buscarPerfilToolStripMenuItem.Text = "Buscar Perfil";
            // 
            // MnOption
            // 
            this.MnOption.Name = "MnOption";
            this.MnOption.Size = new System.Drawing.Size(61, 20);
            this.MnOption.Text = "&Options";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnPerfil;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaMn;
        private System.Windows.Forms.ToolStripMenuItem buscarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnOption;
    }
}
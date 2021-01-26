namespace FrmProyecto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OPERACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATEMATICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIBONACIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPERACIONESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OPERACIONESToolStripMenuItem
            // 
            this.OPERACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mATEMATICASToolStripMenuItem,
            this.bINARIASToolStripMenuItem,
            this.fIBONACIToolStripMenuItem});
            this.OPERACIONESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPERACIONESToolStripMenuItem.Name = "OPERACIONESToolStripMenuItem";
            this.OPERACIONESToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.OPERACIONESToolStripMenuItem.Text = "OPERACIONES ";
            this.OPERACIONESToolStripMenuItem.Click += new System.EventHandler(this.OPERACIONESToolStripMenuItem_Click);
            // 
            // mATEMATICASToolStripMenuItem
            // 
            this.mATEMATICASToolStripMenuItem.Name = "mATEMATICASToolStripMenuItem";
            this.mATEMATICASToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.mATEMATICASToolStripMenuItem.Text = "MATEMATICAS ";
            this.mATEMATICASToolStripMenuItem.Click += new System.EventHandler(this.mATEMATICASToolStripMenuItem_Click);
            // 
            // bINARIASToolStripMenuItem
            // 
            this.bINARIASToolStripMenuItem.Name = "bINARIASToolStripMenuItem";
            this.bINARIASToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.bINARIASToolStripMenuItem.Text = "BINARIAS ";
            this.bINARIASToolStripMenuItem.Click += new System.EventHandler(this.bINARIASToolStripMenuItem_Click);
            // 
            // fIBONACIToolStripMenuItem
            // 
            this.fIBONACIToolStripMenuItem.Name = "fIBONACIToolStripMenuItem";
            this.fIBONACIToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.fIBONACIToolStripMenuItem.Text = "FIBONACI";
            this.fIBONACIToolStripMenuItem.Click += new System.EventHandler(this.fIBONACIToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.sALIRToolStripMenuItem.Text = "SALIR ";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Proyecto 3 ro \"C\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OPERACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATEMATICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIBONACIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}
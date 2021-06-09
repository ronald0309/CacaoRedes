
namespace Cacao
{
    partial class VistaJuego
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
            this.tableroPoblado2 = new Cacao.TableroPoblado();
            this.SuspendLayout();
            // 
            // tableroPoblado2
            // 
            this.tableroPoblado2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableroPoblado2.Location = new System.Drawing.Point(24, 609);
            this.tableroPoblado2.Name = "tableroPoblado2";
            this.tableroPoblado2.Size = new System.Drawing.Size(419, 399);
            this.tableroPoblado2.TabIndex = 1;
            // 
            // VistaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableroPoblado2);
            this.Name = "VistaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VistaJuego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private TableroPoblado tableroPoblado2;
    }
}
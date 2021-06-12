
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
            this.tableroPoblado1 = new Cacao.TableroPoblado();
            this.tableroJuego1 = new Cacao.Vistas.TableroJuego();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableroPoblado2
            // 
            this.tableroPoblado2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableroPoblado2.Location = new System.Drawing.Point(12, 98);
            this.tableroPoblado2.Name = "tableroPoblado2";
            this.tableroPoblado2.Size = new System.Drawing.Size(419, 399);
            this.tableroPoblado2.TabIndex = 1;
            // 
            // tableroPoblado1
            // 
            this.tableroPoblado1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableroPoblado1.Location = new System.Drawing.Point(12, 564);
            this.tableroPoblado1.Name = "tableroPoblado1";
            this.tableroPoblado1.Size = new System.Drawing.Size(419, 399);
            this.tableroPoblado1.TabIndex = 3;
            // 
            // tableroJuego1
            // 
            this.tableroJuego1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableroJuego1.Location = new System.Drawing.Point(450, 63);
            this.tableroJuego1.Name = "tableroJuego1";
            this.tableroJuego1.Size = new System.Drawing.Size(1431, 900);
            this.tableroJuego1.TabIndex = 4;
            this.tableroJuego1.Load += new System.EventHandler(this.tableroJuego1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador en turno.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MAPA POBLADO";
            // 
            // VistaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableroJuego1);
            this.Controls.Add(this.tableroPoblado1);
            this.Controls.Add(this.tableroPoblado2);
            this.Name = "VistaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VistaJuego";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableroPoblado tableroPoblado2;
        private TableroPoblado tableroPoblado1;
        private Vistas.TableroJuego tableroJuego1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
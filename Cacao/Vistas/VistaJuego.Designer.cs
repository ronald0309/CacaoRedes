
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaJuego));
            this.tableroJuego1 = new Cacao.Vistas.TableroJuego();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpMazoMano = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLosetaJungla = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tableroJuego1
            // 
            this.tableroJuego1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableroJuego1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableroJuego1.BackgroundImage")));
            this.tableroJuego1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableroJuego1.Location = new System.Drawing.Point(450, 63);
            this.tableroJuego1.Margin = new System.Windows.Forms.Padding(0);
            this.tableroJuego1.Name = "tableroJuego1";
            this.tableroJuego1.Size = new System.Drawing.Size(1429, 869);
            this.tableroJuego1.TabIndex = 4;
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
            // flpMazoMano
            // 
            this.flpMazoMano.Location = new System.Drawing.Point(1166, 950);
            this.flpMazoMano.Name = "flpMazoMano";
            this.flpMazoMano.Size = new System.Drawing.Size(240, 79);
            this.flpMazoMano.TabIndex = 7;
            // 
            // flpLosetaJungla
            // 
            this.flpLosetaJungla.Location = new System.Drawing.Point(503, 950);
            this.flpLosetaJungla.Margin = new System.Windows.Forms.Padding(0);
            this.flpLosetaJungla.Name = "flpLosetaJungla";
            this.flpLosetaJungla.Size = new System.Drawing.Size(160, 79);
            this.flpLosetaJungla.TabIndex = 8;
            // 
            // VistaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.flpLosetaJungla);
            this.Controls.Add(this.flpMazoMano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableroJuego1);
            this.Controls.Add(this.label1);
            this.Name = "VistaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vistas.TableroJuego tableroJuego1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpMazoMano;
        private System.Windows.Forms.FlowLayoutPanel flpLosetaJungla;
    }
}
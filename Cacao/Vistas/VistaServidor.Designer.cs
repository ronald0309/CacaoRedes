
namespace Cacao.Vistas
{
    partial class VistaServidor
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
            this.lblIP = new System.Windows.Forms.Label();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIP.Location = new System.Drawing.Point(740, 110);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(358, 20);
            this.lblIP.TabIndex = 13;
            this.lblIP.Text = "Ingrese la direccion IP del servidor";
            // 
            // btnUnirse
            // 
            this.btnUnirse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnirse.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUnirse.Location = new System.Drawing.Point(772, 543);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(355, 39);
            this.btnUnirse.TabIndex = 12;
            this.btnUnirse.Text = "Crear partida";
            this.btnUnirse.UseVisualStyleBackColor = false;
            this.btnUnirse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCrear_MouseClick);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.Location = new System.Drawing.Point(740, 150);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(420, 26);
            this.txtIP.TabIndex = 11;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIniciarPartida.Location = new System.Drawing.Point(772, 808);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(355, 39);
            this.btnIniciarPartida.TabIndex = 20;
            this.btnIniciarPartida.Text = "Iniciar Juego ";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuarios.Location = new System.Drawing.Point(772, 613);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(355, 165);
            this.lblUsuarios.TabIndex = 21;
            this.lblUsuarios.Text = "Usuarios Conectados";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(268, 411);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 135);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VistaServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.txtIP);
            this.Name = "VistaServidor";
            this.Text = "VistaServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.ListView listView1;
    }
}
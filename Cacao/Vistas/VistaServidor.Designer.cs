
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
            this.txtNombrePartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNumeroJugadores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnUnirse.Location = new System.Drawing.Point(743, 456);
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
            this.btnIniciarPartida.Location = new System.Drawing.Point(743, 882);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(355, 39);
            this.btnIniciarPartida.TabIndex = 20;
            this.btnIniciarPartida.Text = "Iniciar Juego ";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarios.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuarios.Location = new System.Drawing.Point(743, 511);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(417, 165);
            this.lblUsuarios.TabIndex = 21;
            this.lblUsuarios.Text = "Usuarios Conectados";
            // 
            // txtNombrePartida
            // 
            this.txtNombrePartida.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePartida.Location = new System.Drawing.Point(740, 240);
            this.txtNombrePartida.Name = "txtNombrePartida";
            this.txtNombrePartida.Size = new System.Drawing.Size(420, 26);
            this.txtNombrePartida.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(740, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingrese el nombre de la partida";
            // 
            // cbxNumeroJugadores
            // 
            this.cbxNumeroJugadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumeroJugadores.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNumeroJugadores.FormattingEnabled = true;
            this.cbxNumeroJugadores.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbxNumeroJugadores.Location = new System.Drawing.Point(740, 333);
            this.cbxNumeroJugadores.Name = "cbxNumeroJugadores";
            this.cbxNumeroJugadores.Size = new System.Drawing.Size(420, 26);
            this.cbxNumeroJugadores.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(740, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Seleccione la cantidad de jugadores de la partida";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(740, 953);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Prueba juego";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cacao.Properties.Resources.FondoMenu;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxNumeroJugadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombrePartida);
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
        private System.Windows.Forms.TextBox txtNombrePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNumeroJugadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
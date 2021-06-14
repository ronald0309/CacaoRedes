
namespace Cacao
{
    partial class VCliente
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIP.Location = new System.Drawing.Point(751, 150);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(420, 26);
            this.txtIP.TabIndex = 0;
            // 
            // btnUnirse
            // 
            this.btnUnirse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnirse.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUnirse.Location = new System.Drawing.Point(783, 653);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(355, 39);
            this.btnUnirse.TabIndex = 1;
            this.btnUnirse.Text = "Unirse a partida.";
            this.btnUnirse.UseVisualStyleBackColor = false;
            this.btnUnirse.Click += new System.EventHandler(this.actBtnUnirse);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIP.Location = new System.Drawing.Point(751, 110);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(358, 20);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "Ingrese la direccion IP del servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(751, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(751, 250);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(751, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su fecha de nacimiento.";
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbxColor.Location = new System.Drawing.Point(751, 450);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(420, 26);
            this.cbxColor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(751, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione un color de juego.";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(751, 350);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(420, 26);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // VCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cacao.Properties.Resources.FondoMenu;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.txtIP);
            this.Name = "VCliente";
            this.Text = "Cacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}
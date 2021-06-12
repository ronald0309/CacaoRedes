
namespace Cacao
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrear.Location = new System.Drawing.Point(103, 801);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(286, 41);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear partida";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.ActCrear);
            // 
            // btnUnirse
            // 
            this.btnUnirse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnirse.Location = new System.Drawing.Point(1465, 801);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(286, 41);
            this.btnUnirse.TabIndex = 1;
            this.btnUnirse.Text = "Unirse a partida";
            this.btnUnirse.UseVisualStyleBackColor = false;
            this.btnUnirse.Click += new System.EventHandler(this.ActUnirse);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTitulo.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(884, 143);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bienvenido";
            // 
            // pbx1
            // 
            this.pbx1.Image = global::Cacao.Properties.Resources.FondoMenu;
            this.pbx1.Location = new System.Drawing.Point(0, 0);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(1920, 1080);
            this.pbx1.TabIndex = 3;
            this.pbx1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pbx1);
            this.Name = "Menu";
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbx1;
    }
}


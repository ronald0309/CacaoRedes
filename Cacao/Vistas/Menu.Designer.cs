
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.prueba = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(103, 819);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(286, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear partida";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.ActCrear);
            // 
            // btnUnirse
            // 
            this.btnUnirse.Location = new System.Drawing.Point(1465, 819);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(286, 23);
            this.btnUnirse.TabIndex = 1;
            this.btnUnirse.Text = "Unirse a partida";
            this.btnUnirse.UseVisualStyleBackColor = true;
            this.btnUnirse.Click += new System.EventHandler(this.ActUnirse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(289, 180);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 109);
            this.img.TabIndex = 3;
            this.img.TabStop = false;
            // 
            // prueba
            // 
            this.prueba.AccessibleName = "";
            this.prueba.Location = new System.Drawing.Point(202, 454);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(294, 181);
            this.prueba.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.btnCrear);
            this.Name = "Menu";
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Panel prueba;
    }
}


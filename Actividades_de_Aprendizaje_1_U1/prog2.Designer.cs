
namespace Actividades_de_Aprendizaje_1_U1
{
    partial class prog2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnAvanzado = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnElip = new System.Windows.Forms.Button();
            this.btnRectInter = new System.Windows.Forms.Button();
            this.btnElipRect = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(12, 12);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(106, 30);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnAvanzado
            // 
            this.btnAvanzado.Location = new System.Drawing.Point(12, 48);
            this.btnAvanzado.Name = "btnAvanzado";
            this.btnAvanzado.Size = new System.Drawing.Size(106, 30);
            this.btnAvanzado.TabIndex = 2;
            this.btnAvanzado.Text = "Modo Avanzado";
            this.btnAvanzado.UseVisualStyleBackColor = true;
            this.btnAvanzado.Click += new System.EventHandler(this.btnAvanzado_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(12, 114);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(106, 30);
            this.btnRect.TabIndex = 3;
            this.btnRect.Text = "Rectángulo";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Visible = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnElip
            // 
            this.btnElip.Location = new System.Drawing.Point(12, 150);
            this.btnElip.Name = "btnElip";
            this.btnElip.Size = new System.Drawing.Size(106, 30);
            this.btnElip.TabIndex = 4;
            this.btnElip.Text = "Elipse";
            this.btnElip.UseVisualStyleBackColor = true;
            this.btnElip.Visible = false;
            this.btnElip.Click += new System.EventHandler(this.btnElip_Click);
            // 
            // btnRectInter
            // 
            this.btnRectInter.Location = new System.Drawing.Point(12, 186);
            this.btnRectInter.Name = "btnRectInter";
            this.btnRectInter.Size = new System.Drawing.Size(106, 52);
            this.btnRectInter.TabIndex = 5;
            this.btnRectInter.Text = "Rectangulo Intesectado";
            this.btnRectInter.UseVisualStyleBackColor = true;
            this.btnRectInter.Visible = false;
            this.btnRectInter.Click += new System.EventHandler(this.btnRectInter_Click);
            // 
            // btnElipRect
            // 
            this.btnElipRect.Location = new System.Drawing.Point(12, 244);
            this.btnElipRect.Name = "btnElipRect";
            this.btnElipRect.Size = new System.Drawing.Size(106, 43);
            this.btnElipRect.TabIndex = 6;
            this.btnElipRect.Text = "Circulo en Rectangulo";
            this.btnElipRect.UseVisualStyleBackColor = true;
            this.btnElipRect.Visible = false;
            this.btnElipRect.Click += new System.EventHandler(this.btnElipRect_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(12, 293);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(106, 43);
            this.btnImagen.TabIndex = 7;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Visible = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnElipRect);
            this.Controls.Add(this.btnRectInter);
            this.Controls.Add(this.btnElip);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnAvanzado);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "prog2";
            this.Text = "Algunas Formas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnAvanzado;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnElip;
        private System.Windows.Forms.Button btnRectInter;
        private System.Windows.Forms.Button btnElipRect;
        private System.Windows.Forms.Button btnImagen;
    }
}
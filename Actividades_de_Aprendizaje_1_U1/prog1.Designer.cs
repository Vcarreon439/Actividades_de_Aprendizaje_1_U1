﻿
namespace Actividades_de_Aprendizaje_1_U1
{
    partial class prog1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prog1));
            this.pctAreaDibujo = new System.Windows.Forms.PictureBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.icnPctBoxFlecha = new FontAwesome.Sharp.IconPictureBox();
            this.txtCoordX = new System.Windows.Forms.TextBox();
            this.lbXcoords = new System.Windows.Forms.Label();
            this.txtCoordY = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAreaDibujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBoxFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAreaDibujo
            // 
            this.pctAreaDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctAreaDibujo.Location = new System.Drawing.Point(12, 12);
            this.pctAreaDibujo.Name = "pctAreaDibujo";
            this.pctAreaDibujo.Size = new System.Drawing.Size(349, 232);
            this.pctAreaDibujo.TabIndex = 0;
            this.pctAreaDibujo.TabStop = false;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(139, 267);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Dibujar";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // icnPctBoxFlecha
            // 
            this.icnPctBoxFlecha.BackColor = System.Drawing.SystemColors.Control;
            this.icnPctBoxFlecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icnPctBoxFlecha.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.icnPctBoxFlecha.IconColor = System.Drawing.SystemColors.ControlText;
            this.icnPctBoxFlecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnPctBoxFlecha.Location = new System.Drawing.Point(329, 267);
            this.icnPctBoxFlecha.Name = "icnPctBoxFlecha";
            this.icnPctBoxFlecha.Size = new System.Drawing.Size(32, 32);
            this.icnPctBoxFlecha.TabIndex = 2;
            this.icnPctBoxFlecha.TabStop = false;
            this.icnPctBoxFlecha.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // txtCoordX
            // 
            this.txtCoordX.Location = new System.Drawing.Point(12, 359);
            this.txtCoordX.Name = "txtCoordX";
            this.txtCoordX.Size = new System.Drawing.Size(82, 20);
            this.txtCoordX.TabIndex = 3;
            // 
            // lbXcoords
            // 
            this.lbXcoords.AutoSize = true;
            this.lbXcoords.Location = new System.Drawing.Point(12, 343);
            this.lbXcoords.Name = "lbXcoords";
            this.lbXcoords.Size = new System.Drawing.Size(14, 13);
            this.lbXcoords.TabIndex = 7;
            this.lbXcoords.Text = "X";
            // 
            // txtCoordY
            // 
            this.txtCoordY.Location = new System.Drawing.Point(100, 359);
            this.txtCoordY.Name = "txtCoordY";
            this.txtCoordY.Size = new System.Drawing.Size(82, 20);
            this.txtCoordY.TabIndex = 8;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(188, 359);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(82, 20);
            this.txtAncho.TabIndex = 9;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(276, 359);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(85, 20);
            this.txtAlto.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alto";
            // 
            // prog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtCoordY);
            this.Controls.Add(this.lbXcoords);
            this.Controls.Add(this.txtCoordX);
            this.Controls.Add(this.icnPctBoxFlecha);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.pctAreaDibujo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "prog1";
            this.Text = "Primer Programa";
            ((System.ComponentModel.ISupportInitialize)(this.pctAreaDibujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnPctBoxFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAreaDibujo;
        private System.Windows.Forms.Button btnRectangulo;
        private FontAwesome.Sharp.IconPictureBox icnPctBoxFlecha;
        private System.Windows.Forms.TextBox txtCoordX;
        private System.Windows.Forms.Label lbXcoords;
        private System.Windows.Forms.TextBox txtCoordY;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
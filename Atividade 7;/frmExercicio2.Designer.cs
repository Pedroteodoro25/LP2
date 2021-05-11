
namespace PAtividade7
{
    partial class frmExercicio2
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
            this.btnEspaçoBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.rchTxtR = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEspaçoBranco
            // 
            this.btnEspaçoBranco.Location = new System.Drawing.Point(91, 200);
            this.btnEspaçoBranco.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspaçoBranco.Name = "btnEspaçoBranco";
            this.btnEspaçoBranco.Size = new System.Drawing.Size(139, 82);
            this.btnEspaçoBranco.TabIndex = 0;
            this.btnEspaçoBranco.Text = "Espaço em Branco";
            this.btnEspaçoBranco.UseVisualStyleBackColor = true;
            this.btnEspaçoBranco.Click += new System.EventHandler(this.btnEspaçoBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(358, 200);
            this.btnLetraR.Margin = new System.Windows.Forms.Padding(4);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(133, 82);
            this.btnLetraR.TabIndex = 1;
            this.btnLetraR.Text = "Letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(642, 200);
            this.btnParLetras.Margin = new System.Windows.Forms.Padding(4);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(129, 82);
            this.btnParLetras.TabIndex = 2;
            this.btnParLetras.Text = "Par de Letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // rchTxtR
            // 
            this.rchTxtR.Location = new System.Drawing.Point(227, 13);
            this.rchTxtR.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxtR.MaxLength = 100;
            this.rchTxtR.Name = "rchTxtR";
            this.rchTxtR.Size = new System.Drawing.Size(403, 138);
            this.rchTxtR.TabIndex = 3;
            this.rchTxtR.Text = "";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.rchTxtR);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspaçoBranco);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEspaçoBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParLetras;
        private System.Windows.Forms.RichTextBox rchTxtR;
    }
}
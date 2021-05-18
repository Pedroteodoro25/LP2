
namespace PAtividade8
{
    partial class frm4
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
            this.btnQtdeLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQtdeLetras
            // 
            this.btnQtdeLetras.Location = new System.Drawing.Point(274, 140);
            this.btnQtdeLetras.Name = "btnQtdeLetras";
            this.btnQtdeLetras.Size = new System.Drawing.Size(194, 133);
            this.btnQtdeLetras.TabIndex = 0;
            this.btnQtdeLetras.Text = "Qtde Letras";
            this.btnQtdeLetras.UseVisualStyleBackColor = true;
            this.btnQtdeLetras.Click += new System.EventHandler(this.btnQtdeLetras_Click);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQtdeLetras);
            this.Name = "frm4";
            this.Text = "frm4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQtdeLetras;
    }
}
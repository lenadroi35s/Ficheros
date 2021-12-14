
namespace Ficheros
{
    partial class frmExplorador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.listaArchivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(91, 42);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(268, 20);
            this.txtList.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(396, 39);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(77, 25);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaArchivos
            // 
            this.listaArchivos.FormattingEnabled = true;
            this.listaArchivos.Location = new System.Drawing.Point(91, 89);
            this.listaArchivos.Name = "listaArchivos";
            this.listaArchivos.Size = new System.Drawing.Size(182, 238);
            this.listaArchivos.TabIndex = 3;
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaArchivos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.label1);
            this.Name = "frmExplorador";
            this.Text = "Explorar de archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listaArchivos;
    }
}
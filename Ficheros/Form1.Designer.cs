
namespace Ficheros
{
    partial class frmCargar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn_Leer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre del archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(261, 58);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(362, 20);
            this.txtArchivo.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(141, 122);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(482, 209);
            this.txtResultado.TabIndex = 3;
            // 
            // btn_Leer
            // 
            this.btn_Leer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Leer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Leer.Location = new System.Drawing.Point(650, 65);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(87, 28);
            this.btn_Leer.TabIndex = 4;
            this.btn_Leer.Text = "Cargar archivo";
            this.btn_Leer.UseVisualStyleBackColor = false;
            this.btn_Leer.Click += new System.EventHandler(this.btn_Leer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Open";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Leer);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCargar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn_Leer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}


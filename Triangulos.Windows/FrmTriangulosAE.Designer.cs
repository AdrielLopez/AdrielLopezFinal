
namespace Triangulos.Windows
{
    partial class FrmTriangulosAE
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 62);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(47, 162);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 62);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "OK";
            this.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(87, 122);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(124, 20);
            this.txtLado3.TabIndex = 17;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(87, 66);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(124, 20);
            this.txtLado2.TabIndex = 15;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(87, 22);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(124, 20);
            this.txtLado1.TabIndex = 13;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(44, 125);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(37, 13);
            this.lblLado3.TabIndex = 18;
            this.lblLado3.Text = "Lado3";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(44, 69);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(37, 13);
            this.lblLado2.TabIndex = 16;
            this.lblLado2.Text = "Lado2";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(44, 25);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(37, 13);
            this.lblLado1.TabIndex = 14;
            this.lblLado1.Text = "Lado1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmTriangulosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 249);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Name = "FrmTriangulosAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
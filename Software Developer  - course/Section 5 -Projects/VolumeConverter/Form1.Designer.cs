namespace VolumeConverter
{
    partial class Form1
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
            this.lblTtile = new System.Windows.Forms.Label();
            this.tbCL = new System.Windows.Forms.TextBox();
            this.tbLitru = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCL = new System.Windows.Forms.Label();
            this.lblLitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTtile
            // 
            this.lblTtile.AutoSize = true;
            this.lblTtile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtile.Location = new System.Drawing.Point(117, 42);
            this.lblTtile.Name = "lblTtile";
            this.lblTtile.Size = new System.Drawing.Size(141, 20);
            this.lblTtile.TabIndex = 0;
            this.lblTtile.Text = "Convert CL to Litre";
            // 
            // tbCL
            // 
            this.tbCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCL.Location = new System.Drawing.Point(115, 99);
            this.tbCL.Name = "tbCL";
            this.tbCL.Size = new System.Drawing.Size(119, 26);
            this.tbCL.TabIndex = 1;
            // 
            // tbLitru
            // 
            this.tbLitru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLitru.Location = new System.Drawing.Point(115, 157);
            this.tbLitru.Name = "tbLitru";
            this.tbLitru.ReadOnly = true;
            this.tbLitru.Size = new System.Drawing.Size(119, 26);
            this.tbLitru.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(120, 219);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 37);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(251, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCL
            // 
            this.lblCL.AutoSize = true;
            this.lblCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCL.Location = new System.Drawing.Point(240, 102);
            this.lblCL.Name = "lblCL";
            this.lblCL.Size = new System.Drawing.Size(29, 20);
            this.lblCL.TabIndex = 5;
            this.lblCL.Text = "CL";
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitre.Location = new System.Drawing.Point(240, 160);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(40, 20);
            this.lblLitre.TabIndex = 6;
            this.lblLitre.Text = "Litre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 347);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.lblCL);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbLitru);
            this.Controls.Add(this.tbCL);
            this.Controls.Add(this.lblTtile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTtile;
        private System.Windows.Forms.TextBox tbCL;
        private System.Windows.Forms.TextBox tbLitru;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCL;
        private System.Windows.Forms.Label lblLitre;
    }
}


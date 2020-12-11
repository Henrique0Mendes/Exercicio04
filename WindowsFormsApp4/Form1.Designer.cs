
namespace WindowsFormsApp4
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
            this.labelnome = new System.Windows.Forms.Label();
            this.labelapelido = new System.Windows.Forms.Label();
            this.labelmorada = new System.Windows.Forms.Label();
            this.buttonsubmeter = new System.Windows.Forms.Button();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxapelido = new System.Windows.Forms.TextBox();
            this.textBoxmorada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(159, 92);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(49, 17);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome:";
            // 
            // labelapelido
            // 
            this.labelapelido.AutoSize = true;
            this.labelapelido.Location = new System.Drawing.Point(159, 141);
            this.labelapelido.Name = "labelapelido";
            this.labelapelido.Size = new System.Drawing.Size(59, 17);
            this.labelapelido.TabIndex = 1;
            this.labelapelido.Text = "Apelido:";
            // 
            // labelmorada
            // 
            this.labelmorada.AutoSize = true;
            this.labelmorada.Location = new System.Drawing.Point(159, 198);
            this.labelmorada.Name = "labelmorada";
            this.labelmorada.Size = new System.Drawing.Size(60, 17);
            this.labelmorada.TabIndex = 2;
            this.labelmorada.Text = "Morada:";
            // 
            // buttonsubmeter
            // 
            this.buttonsubmeter.Location = new System.Drawing.Point(233, 287);
            this.buttonsubmeter.Name = "buttonsubmeter";
            this.buttonsubmeter.Size = new System.Drawing.Size(86, 31);
            this.buttonsubmeter.TabIndex = 3;
            this.buttonsubmeter.Text = "Submeter";
            this.buttonsubmeter.UseVisualStyleBackColor = true;
            this.buttonsubmeter.Click += new System.EventHandler(this.buttonsubmeter_Click);
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(233, 92);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(181, 22);
            this.textBoxnome.TabIndex = 4;
            // 
            // textBoxapelido
            // 
            this.textBoxapelido.Location = new System.Drawing.Point(233, 141);
            this.textBoxapelido.Name = "textBoxapelido";
            this.textBoxapelido.Size = new System.Drawing.Size(181, 22);
            this.textBoxapelido.TabIndex = 5;
            // 
            // textBoxmorada
            // 
            this.textBoxmorada.Location = new System.Drawing.Point(233, 198);
            this.textBoxmorada.Name = "textBoxmorada";
            this.textBoxmorada.Size = new System.Drawing.Size(181, 22);
            this.textBoxmorada.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 417);
            this.Controls.Add(this.textBoxmorada);
            this.Controls.Add(this.textBoxapelido);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.buttonsubmeter);
            this.Controls.Add(this.labelmorada);
            this.Controls.Add(this.labelapelido);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelapelido;
        private System.Windows.Forms.Label labelmorada;
        private System.Windows.Forms.Button buttonsubmeter;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxapelido;
        private System.Windows.Forms.TextBox textBoxmorada;
    }
}


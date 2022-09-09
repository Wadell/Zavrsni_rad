namespace Ucitavanje_validacija_slike
{
    partial class ValidacijaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.prikazSlikePicBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rezultatOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlikePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(911, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Učitaj sliku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ucitajButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // prikazSlikePicBox
            // 
            this.prikazSlikePicBox.Location = new System.Drawing.Point(17, 17);
            this.prikazSlikePicBox.Margin = new System.Windows.Forms.Padding(4);
            this.prikazSlikePicBox.Name = "prikazSlikePicBox";
            this.prikazSlikePicBox.Size = new System.Drawing.Size(856, 602);
            this.prikazSlikePicBox.TabIndex = 1;
            this.prikazSlikePicBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(227)))), ((int)(((byte)(79)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(911, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 106);
            this.button2.TabIndex = 2;
            this.button2.Text = "Validacija";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.validirajButton_Click);
            // 
            // rezultatOutput
            // 
            this.rezultatOutput.AutoSize = true;
            this.rezultatOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rezultatOutput.Location = new System.Drawing.Point(911, 342);
            this.rezultatOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rezultatOutput.Name = "rezultatOutput";
            this.rezultatOutput.Size = new System.Drawing.Size(0, 21);
            this.rezultatOutput.TabIndex = 3;
            // 
            // ValidacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 636);
            this.Controls.Add(this.rezultatOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prikazSlikePicBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidacijaForm";
            this.Text = "Klasifikacija životinja";
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlikePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private PictureBox prikazSlikePicBox;
        private Button button2;
        private Label rezultatOutput;
    }
}
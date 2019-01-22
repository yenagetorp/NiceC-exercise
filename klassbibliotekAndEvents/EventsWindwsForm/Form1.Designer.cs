namespace EventsWindwsForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstEvenNumbers = new System.Windows.Forms.ListBox();
            this.lstOddNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::EventsWindwsForm.Properties.Resources.nature_01;
            this.btnStart.Location = new System.Drawing.Point(234, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstEvenNumbers
            // 
            this.lstEvenNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lstEvenNumbers.ForeColor = System.Drawing.Color.Teal;
            this.lstEvenNumbers.FormattingEnabled = true;
            this.lstEvenNumbers.Location = new System.Drawing.Point(12, 12);
            this.lstEvenNumbers.Name = "lstEvenNumbers";
            this.lstEvenNumbers.Size = new System.Drawing.Size(145, 225);
            this.lstEvenNumbers.TabIndex = 1;
            // 
            // lstOddNumbers
            // 
            this.lstOddNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstOddNumbers.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOddNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lstOddNumbers.FormattingEnabled = true;
            this.lstOddNumbers.ItemHeight = 17;
            this.lstOddNumbers.Location = new System.Drawing.Point(213, 12);
            this.lstOddNumbers.Name = "lstOddNumbers";
            this.lstOddNumbers.Size = new System.Drawing.Size(153, 225);
            this.lstOddNumbers.TabIndex = 2;
            this.lstOddNumbers.SelectedIndexChanged += new System.EventHandler(this.lstOddNumbers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOddNumbers);
            this.Controls.Add(this.lstEvenNumbers);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstEvenNumbers;
        private System.Windows.Forms.ListBox lstOddNumbers;
    }
}


namespace InYourFace
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
            this.components = new System.ComponentModel.Container();
            this.labelChosenNumber = new System.Windows.Forms.Label();
            this.labelCurrentNumber = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelChosenNumber
            // 
            this.labelChosenNumber.AutoSize = true;
            this.labelChosenNumber.Location = new System.Drawing.Point(12, 21);
            this.labelChosenNumber.MaximumSize = new System.Drawing.Size(1000, 200);
            this.labelChosenNumber.MinimumSize = new System.Drawing.Size(1300, 200);
            this.labelChosenNumber.Name = "labelChosenNumber";
            this.labelChosenNumber.Size = new System.Drawing.Size(1300, 200);
            this.labelChosenNumber.TabIndex = 0;
            this.labelChosenNumber.Text = "ChosenNumber";
            this.labelChosenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentNumber
            // 
            this.labelCurrentNumber.AutoSize = true;
            this.labelCurrentNumber.Location = new System.Drawing.Point(215, 233);
            this.labelCurrentNumber.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelCurrentNumber.MinimumSize = new System.Drawing.Size(200, 200);
            this.labelCurrentNumber.Name = "labelCurrentNumber";
            this.labelCurrentNumber.Size = new System.Drawing.Size(200, 200);
            this.labelCurrentNumber.TabIndex = 2;
            this.labelCurrentNumber.Text = "CurrentNumber";
            this.labelCurrentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 465);
            this.Controls.Add(this.labelCurrentNumber);
            this.Controls.Add(this.labelChosenNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChosenNumber;
        private System.Windows.Forms.Label labelCurrentNumber;
        private System.Windows.Forms.Timer timer;
    }
}


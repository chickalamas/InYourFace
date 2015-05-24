namespace InYourFace
{
    partial class MainForm
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
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.labelPlayer4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChosenNumber
            // 
            this.labelChosenNumber.AutoSize = true;
            this.labelChosenNumber.BackColor = System.Drawing.Color.LimeGreen;
            this.labelChosenNumber.Font = new System.Drawing.Font("David", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.labelCurrentNumber.BackColor = System.Drawing.Color.Aquamarine;
            this.labelCurrentNumber.Font = new System.Drawing.Font("David", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCurrentNumber.Location = new System.Drawing.Point(12, 231);
            this.labelCurrentNumber.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelCurrentNumber.MinimumSize = new System.Drawing.Size(1300, 200);
            this.labelCurrentNumber.Name = "labelCurrentNumber";
            this.labelCurrentNumber.Size = new System.Drawing.Size(1300, 200);
            this.labelCurrentNumber.TabIndex = 2;
            this.labelCurrentNumber.Text = "CurrentNumber";
            this.labelCurrentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer1.Location = new System.Drawing.Point(12, 447);
            this.labelPlayer1.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelPlayer1.MinimumSize = new System.Drawing.Size(300, 200);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(300, 200);
            this.labelPlayer1.TabIndex = 3;
            this.labelPlayer1.Text = "Player1Number";
            this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Coral;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer2.Location = new System.Drawing.Point(318, 447);
            this.labelPlayer2.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelPlayer2.MinimumSize = new System.Drawing.Size(300, 200);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(300, 200);
            this.labelPlayer2.TabIndex = 4;
            this.labelPlayer2.Text = "Player2Number";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer3.Location = new System.Drawing.Point(629, 447);
            this.labelPlayer3.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelPlayer3.MinimumSize = new System.Drawing.Size(300, 200);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(300, 200);
            this.labelPlayer3.TabIndex = 5;
            this.labelPlayer3.Text = "Player3Number";
            this.labelPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer4
            // 
            this.labelPlayer4.AutoSize = true;
            this.labelPlayer4.BackColor = System.Drawing.Color.Gold;
            this.labelPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer4.Location = new System.Drawing.Point(941, 447);
            this.labelPlayer4.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelPlayer4.MinimumSize = new System.Drawing.Size(300, 200);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.Size = new System.Drawing.Size(300, 200);
            this.labelPlayer4.TabIndex = 6;
            this.labelPlayer4.Text = "Player4Number";
            this.labelPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 748);
            this.Controls.Add(this.labelPlayer4);
            this.Controls.Add(this.labelPlayer3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelCurrentNumber);
            this.Controls.Add(this.labelChosenNumber);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChosenNumber;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelCurrentNumber;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.Label labelPlayer4;
    }
}


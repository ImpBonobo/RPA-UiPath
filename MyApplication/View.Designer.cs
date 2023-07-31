using System.Windows.Forms;

namespace MainProgramm
{
    partial class View
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPlusSign = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(327, 278);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(197, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Berechne";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblPlusSign
            // 
            this.lblPlusSign.AutoSize = true;
            this.lblPlusSign.Location = new System.Drawing.Point(324, 205);
            this.lblPlusSign.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblPlusSign.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblPlusSign.Name = "lblPlusSign";
            this.lblPlusSign.Size = new System.Drawing.Size(200, 13);
            this.lblPlusSign.TabIndex = 1;
            this.lblPlusSign.Text = "+";
            this.lblPlusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(327, 238);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(196, 20);
            this.txtNumber2.TabIndex = 2;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(327, 172);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(196, 20);
            this.txtNumber1.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(324, 337);
            this.lblResult.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblResult.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblPlusSign);
            this.Controls.Add(this.btnCalculate);
            this.Name = "View";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalculate;
        private Label lblPlusSign;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Label lblResult;

        public Button BtnCalculate { get => btnCalculate; set => btnCalculate = value; }
        public Label LblPlusSign { get => lblPlusSign; set => lblPlusSign = value; }
        public TextBox TxtNumber2 { get => txtNumber2; set => txtNumber2 = value; }
        public TextBox TxtNumber1 { get => txtNumber1; set => txtNumber1 = value; }
        public Label LblResult { get => lblResult; set => lblResult = value; }
    }

}
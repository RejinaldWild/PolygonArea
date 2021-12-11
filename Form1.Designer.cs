
namespace PolygonArea
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelAnswerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(153, 183);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Location = new System.Drawing.Point(42, 183);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(17, 86);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(153, 86);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(63, 53);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "x:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(195, 53);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(15, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "y:";
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(28, 9);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(225, 26);
            this.labelRequest.TabIndex = 6;
            this.labelRequest.Text = "Input array of integer x and y using commas\n Attention! Quantity of x and y has t" +
    "o be equal!";
            this.labelRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnswerInfo
            // 
            this.labelAnswerInfo.AutoSize = true;
            this.labelAnswerInfo.Location = new System.Drawing.Point(28, 129);
            this.labelAnswerInfo.Name = "labelAnswerInfo";
            this.labelAnswerInfo.Size = new System.Drawing.Size(55, 13);
            this.labelAnswerInfo.TabIndex = 7;
            this.labelAnswerInfo.Text = "Answer is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 227);
            this.Controls.Add(this.labelAnswerInfo);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "PolygonArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelAnswerInfo;
    }
}


namespace Lab02
{
    partial class Form1
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(12, 12);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(148, 137);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(180, 50);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQueue
            // 
            lblQueue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(180, 87);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(191, 37);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "-";
            lblQueue.TextAlign = ContentAlignment.MiddleCenter;
            lblQueue.Click += lblQueue_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 155);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 3;
            button1.Text = "*CLICK: GET NUMBER*";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(405, 202);
            Controls.Add(button1);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Button button1;
    }
}
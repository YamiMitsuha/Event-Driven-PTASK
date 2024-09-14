namespace Lab02
{
    partial class CustomerView
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
            label1 = new Label();
            lblServing = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(338, 45);
            label1.TabIndex = 2;
            label1.Text = "*Now Serving*";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblServing
            // 
            lblServing.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblServing.Location = new Point(25, 89);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(338, 37);
            lblServing.TabIndex = 3;
            lblServing.Text = "-";
            lblServing.TextAlign = ContentAlignment.MiddleCenter;
            lblServing.Click += lblQueue_Click;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(392, 160);
            Controls.Add(lblServing);
            Controls.Add(label1);
            Name = "CustomerView";
            Text = "CustomerView";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblServing;
    }
}
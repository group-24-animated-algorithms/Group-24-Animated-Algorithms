namespace Group_24_Animated_Algorithms
{
    partial class OutputScreen
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
            this.lb_operations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_operations
            // 
            this.lb_operations.AutoSize = true;
            this.lb_operations.BackColor = System.Drawing.SystemColors.Control;
            this.lb_operations.Location = new System.Drawing.Point(13, 13);
            this.lb_operations.Name = "lb_operations";
            this.lb_operations.Size = new System.Drawing.Size(114, 13);
            this.lb_operations.TabIndex = 0;
            this.lb_operations.Text = "Number of operations: ";
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lb_operations);
            this.Name = "OutputScreen";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_operations;
    }
}
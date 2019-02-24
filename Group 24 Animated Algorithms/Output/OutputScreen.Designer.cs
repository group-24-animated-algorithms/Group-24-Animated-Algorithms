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
            this.grp_algorithminfo = new System.Windows.Forms.GroupBox();
            this.grp_showingcode = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lb_operations
            // 
            this.lb_operations.AutoSize = true;
            this.lb_operations.BackColor = System.Drawing.SystemColors.Control;
            this.lb_operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_operations.Location = new System.Drawing.Point(13, 13);
            this.lb_operations.Name = "lb_operations";
            this.lb_operations.Size = new System.Drawing.Size(136, 13);
            this.lb_operations.TabIndex = 0;
            this.lb_operations.Text = "Number of operations: ";
            // 
            // grp_algorithminfo
            // 
            this.grp_algorithminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_algorithminfo.Location = new System.Drawing.Point(13, 311);
            this.grp_algorithminfo.Name = "grp_algorithminfo";
            this.grp_algorithminfo.Size = new System.Drawing.Size(454, 138);
            this.grp_algorithminfo.TabIndex = 1;
            this.grp_algorithminfo.TabStop = false;
            this.grp_algorithminfo.Text = "Information on the algorithm chosen:";
            // 
            // grp_showingcode
            // 
            this.grp_showingcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_showingcode.Location = new System.Drawing.Point(518, 311);
            this.grp_showingcode.Name = "grp_showingcode";
            this.grp_showingcode.Size = new System.Drawing.Size(454, 138);
            this.grp_showingcode.TabIndex = 2;
            this.grp_showingcode.TabStop = false;
            this.grp_showingcode.Text = "How the code works:";
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.grp_showingcode);
            this.Controls.Add(this.grp_algorithminfo);
            this.Controls.Add(this.lb_operations);
            this.Name = "OutputScreen";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_operations;
        private System.Windows.Forms.GroupBox grp_algorithminfo;
        private System.Windows.Forms.GroupBox grp_showingcode;
    }
}
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
            this.grp_algorithminfo = new System.Windows.Forms.GroupBox();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.TB_How = new System.Windows.Forms.TextBox();
            this.grp_operations = new System.Windows.Forms.GroupBox();
            this.tb_operations = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.grp_showingcode = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp_algorithminfo.SuspendLayout();
            this.grp_operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.grp_showingcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_algorithminfo
            // 
            this.grp_algorithminfo.Controls.Add(this.TB_Info);
            this.grp_algorithminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_algorithminfo.Location = new System.Drawing.Point(6, 117);
            this.grp_algorithminfo.Name = "grp_algorithminfo";
            this.grp_algorithminfo.Size = new System.Drawing.Size(238, 175);
            this.grp_algorithminfo.TabIndex = 1;
            this.grp_algorithminfo.TabStop = false;
            this.grp_algorithminfo.Text = "Information on the algorithm chosen:";
            // 
            // TB_Info
            // 
            this.TB_Info.Location = new System.Drawing.Point(6, 19);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.ReadOnly = true;
            this.TB_Info.Size = new System.Drawing.Size(226, 150);
            this.TB_Info.TabIndex = 0;
            // 
            // TB_How
            // 
            this.TB_How.Location = new System.Drawing.Point(6, 19);
            this.TB_How.Multiline = true;
            this.TB_How.Name = "TB_How";
            this.TB_How.ReadOnly = true;
            this.TB_How.Size = new System.Drawing.Size(225, 150);
            this.TB_How.TabIndex = 0;
            // 
            // grp_operations
            // 
            this.grp_operations.Controls.Add(this.tb_operations);
            this.grp_operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_operations.Location = new System.Drawing.Point(6, 12);
            this.grp_operations.Name = "grp_operations";
            this.grp_operations.Size = new System.Drawing.Size(238, 47);
            this.grp_operations.TabIndex = 3;
            this.grp_operations.TabStop = false;
            this.grp_operations.Text = "Number of operations: ";
            // 
            // tb_operations
            // 
            this.tb_operations.Location = new System.Drawing.Point(6, 19);
            this.tb_operations.Name = "tb_operations";
            this.tb_operations.ReadOnly = true;
            this.tb_operations.Size = new System.Drawing.Size(226, 20);
            this.tb_operations.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grp_result);
            this.groupBox1.Controls.Add(this.grp_operations);
            this.groupBox1.Controls.Add(this.grp_showingcode);
            this.groupBox1.Controls.Add(this.grp_algorithminfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(734, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 479);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.TB_Result);
            this.grp_result.Enabled = false;
            this.grp_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_result.Location = new System.Drawing.Point(6, 65);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(238, 47);
            this.grp_result.TabIndex = 5;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Search Result: ";
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(6, 19);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(226, 20);
            this.TB_Result.TabIndex = 4;
            // 
            // grp_showingcode
            // 
            this.grp_showingcode.Controls.Add(this.TB_How);
            this.grp_showingcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_showingcode.Location = new System.Drawing.Point(6, 298);
            this.grp_showingcode.Name = "grp_showingcode";
            this.grp_showingcode.Size = new System.Drawing.Size(238, 175);
            this.grp_showingcode.TabIndex = 2;
            this.grp_showingcode.TabStop = false;
            this.grp_showingcode.Text = "How the code works:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 479);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OutputScreen";
            this.Text = "Output";
            this.grp_algorithminfo.ResumeLayout(false);
            this.grp_algorithminfo.PerformLayout();
            this.grp_operations.ResumeLayout(false);
            this.grp_operations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grp_result.ResumeLayout(false);
            this.grp_result.PerformLayout();
            this.grp_showingcode.ResumeLayout(false);
            this.grp_showingcode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_algorithminfo;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.TextBox TB_How;
        private System.Windows.Forms.GroupBox grp_operations;
        private System.Windows.Forms.TextBox tb_operations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_showingcode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.TextBox TB_Result;
    }
}
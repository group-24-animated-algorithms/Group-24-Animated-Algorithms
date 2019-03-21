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
            this.grp_operations = new System.Windows.Forms.GroupBox();
            this.tb_operations = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_algorithminfo = new System.Windows.Forms.GroupBox();
            this.TB_Info = new System.Windows.Forms.RichTextBox();
            this.BT_Pause = new System.Windows.Forms.Button();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_SearchFor = new System.Windows.Forms.TextBox();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_Space = new System.Windows.Forms.Label();
            this.LB_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grp_operations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_algorithminfo.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_operations
            // 
            this.grp_operations.BackColor = System.Drawing.SystemColors.Control;
            this.grp_operations.Controls.Add(this.tb_operations);
            this.grp_operations.Font = new System.Drawing.Font("Open Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_operations.Location = new System.Drawing.Point(6, 12);
            this.grp_operations.Name = "grp_operations";
            this.grp_operations.Size = new System.Drawing.Size(488, 63);
            this.grp_operations.TabIndex = 3;
            this.grp_operations.TabStop = false;
            this.grp_operations.Text = "Number of operations: ";
            // 
            // tb_operations
            // 
            this.tb_operations.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operations.Location = new System.Drawing.Point(6, 29);
            this.tb_operations.Name = "tb_operations";
            this.tb_operations.ReadOnly = true;
            this.tb_operations.Size = new System.Drawing.Size(476, 28);
            this.tb_operations.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grp_algorithminfo);
            this.groupBox1.Controls.Add(this.BT_Pause);
            this.groupBox1.Controls.Add(this.grp_result);
            this.groupBox1.Controls.Add(this.grp_operations);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(484, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 761);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // grp_algorithminfo
            // 
            this.grp_algorithminfo.BackColor = System.Drawing.SystemColors.Control;
            this.grp_algorithminfo.Controls.Add(this.TB_Info);
            this.grp_algorithminfo.Font = new System.Drawing.Font("Open Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_algorithminfo.Location = new System.Drawing.Point(6, 203);
            this.grp_algorithminfo.Name = "grp_algorithminfo";
            this.grp_algorithminfo.Size = new System.Drawing.Size(488, 552);
            this.grp_algorithminfo.TabIndex = 4;
            this.grp_algorithminfo.TabStop = false;
            this.grp_algorithminfo.Text = "Information on the algorithm chosen:";
            // 
            // TB_Info
            // 
            this.TB_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Info.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Info.Location = new System.Drawing.Point(6, 26);
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.ReadOnly = true;
            this.TB_Info.Size = new System.Drawing.Size(476, 503);
            this.TB_Info.TabIndex = 2;
            this.TB_Info.Text = "";
            this.TB_Info.WordWrap = false;
            // 
            // BT_Pause
            // 
            this.BT_Pause.Location = new System.Drawing.Point(6, 168);
            this.BT_Pause.Name = "BT_Pause";
            this.BT_Pause.Size = new System.Drawing.Size(488, 29);
            this.BT_Pause.TabIndex = 4;
            this.BT_Pause.Text = "Pause";
            this.BT_Pause.UseVisualStyleBackColor = true;
            this.BT_Pause.Click += new System.EventHandler(this.BT_Pause_Click);
            // 
            // grp_result
            // 
            this.grp_result.BackColor = System.Drawing.SystemColors.Control;
            this.grp_result.Controls.Add(this.label4);
            this.grp_result.Controls.Add(this.label3);
            this.grp_result.Controls.Add(this.TB_SearchFor);
            this.grp_result.Controls.Add(this.TB_Result);
            this.grp_result.Enabled = false;
            this.grp_result.Font = new System.Drawing.Font("Open Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_result.Location = new System.Drawing.Point(6, 83);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(488, 79);
            this.grp_result.TabIndex = 5;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Search: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Found at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Searching for:";
            // 
            // TB_SearchFor
            // 
            this.TB_SearchFor.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SearchFor.Location = new System.Drawing.Point(6, 45);
            this.TB_SearchFor.Name = "TB_SearchFor";
            this.TB_SearchFor.ReadOnly = true;
            this.TB_SearchFor.Size = new System.Drawing.Size(226, 28);
            this.TB_SearchFor.TabIndex = 5;
            // 
            // TB_Result
            // 
            this.TB_Result.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Result.Location = new System.Drawing.Point(256, 45);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(226, 28);
            this.TB_Result.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Complexity:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LB_Space);
            this.groupBox2.Controls.Add(this.LB_Time);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // LB_Space
            // 
            this.LB_Space.AutoSize = true;
            this.LB_Space.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Space.Location = new System.Drawing.Point(441, 34);
            this.LB_Space.Name = "LB_Space";
            this.LB_Space.Size = new System.Drawing.Size(37, 20);
            this.LB_Space.TabIndex = 5;
            this.LB_Space.Text = "tmp";
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.Location = new System.Drawing.Point(147, 34);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(37, 20);
            this.LB_Time.TabIndex = 4;
            this.LB_Time.Text = "tmp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Space Complexity:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OutputScreen";
            this.Text = "Output";
            this.grp_operations.ResumeLayout(false);
            this.grp_operations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grp_algorithminfo.ResumeLayout(false);
            this.grp_result.ResumeLayout(false);
            this.grp_result.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_operations;
        private System.Windows.Forms.TextBox tb_operations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_Space;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button BT_Pause;
        private System.Windows.Forms.GroupBox grp_algorithminfo;
        private System.Windows.Forms.RichTextBox TB_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_SearchFor;
    }
}
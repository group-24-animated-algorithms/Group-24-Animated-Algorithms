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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bar_Speed = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Bar_Zoom = new System.Windows.Forms.TrackBar();
            this.BT_Step = new System.Windows.Forms.Button();
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
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Speed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Zoom)).BeginInit();
            this.grp_algorithminfo.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_operations
            // 
            this.grp_operations.BackColor = System.Drawing.SystemColors.Control;
            this.grp_operations.Controls.Add(this.tb_operations);
            this.grp_operations.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_operations.Location = new System.Drawing.Point(6, 12);
            this.grp_operations.Name = "grp_operations";
            this.grp_operations.Size = new System.Drawing.Size(240, 63);
            this.grp_operations.TabIndex = 3;
            this.grp_operations.TabStop = false;
            this.grp_operations.Text = "Number of operations: ";
            // 
            // tb_operations
            // 
            this.tb_operations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_operations.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operations.Location = new System.Drawing.Point(6, 29);
            this.tb_operations.Name = "tb_operations";
            this.tb_operations.ReadOnly = true;
            this.tb_operations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_operations.Size = new System.Drawing.Size(228, 27);
            this.tb_operations.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BT_Step);
            this.groupBox1.Controls.Add(this.grp_algorithminfo);
            this.groupBox1.Controls.Add(this.BT_Pause);
            this.groupBox1.Controls.Add(this.grp_result);
            this.groupBox1.Controls.Add(this.grp_operations);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(834, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 761);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Bar_Speed);
            this.groupBox4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(254, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(240, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Speed: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // Bar_Speed
            // 
            this.Bar_Speed.LargeChange = 250;
            this.Bar_Speed.Location = new System.Drawing.Point(6, 24);
            this.Bar_Speed.Maximum = 5000;
            this.Bar_Speed.Name = "Bar_Speed";
            this.Bar_Speed.Size = new System.Drawing.Size(228, 45);
            this.Bar_Speed.SmallChange = 50;
            this.Bar_Speed.TabIndex = 0;
            this.Bar_Speed.TickFrequency = 250;
            this.Bar_Speed.Value = 1;
            this.Bar_Speed.Scroll += new System.EventHandler(this.Bar_Speed_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Bar_Zoom);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(254, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zoom level: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            // 
            // Bar_Zoom
            // 
            this.Bar_Zoom.LargeChange = 25;
            this.Bar_Zoom.Location = new System.Drawing.Point(6, 24);
            this.Bar_Zoom.Maximum = 200;
            this.Bar_Zoom.Minimum = 25;
            this.Bar_Zoom.Name = "Bar_Zoom";
            this.Bar_Zoom.Size = new System.Drawing.Size(228, 45);
            this.Bar_Zoom.SmallChange = 5;
            this.Bar_Zoom.TabIndex = 0;
            this.Bar_Zoom.TickFrequency = 25;
            this.Bar_Zoom.Value = 50;
            this.Bar_Zoom.Scroll += new System.EventHandler(this.Bar_Zoom_Scroll);
            // 
            // BT_Step
            // 
            this.BT_Step.Enabled = false;
            this.BT_Step.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Step.Location = new System.Drawing.Point(254, 174);
            this.BT_Step.Name = "BT_Step";
            this.BT_Step.Size = new System.Drawing.Size(240, 29);
            this.BT_Step.TabIndex = 6;
            this.BT_Step.Text = "Step";
            this.BT_Step.UseVisualStyleBackColor = true;
            this.BT_Step.Click += new System.EventHandler(this.BT_Step_Click);
            // 
            // grp_algorithminfo
            // 
            this.grp_algorithminfo.BackColor = System.Drawing.SystemColors.Control;
            this.grp_algorithminfo.Controls.Add(this.TB_Info);
            this.grp_algorithminfo.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_algorithminfo.Location = new System.Drawing.Point(6, 209);
            this.grp_algorithminfo.Name = "grp_algorithminfo";
            this.grp_algorithminfo.Size = new System.Drawing.Size(738, 546);
            this.grp_algorithminfo.TabIndex = 4;
            this.grp_algorithminfo.TabStop = false;
            this.grp_algorithminfo.Text = "Information on the algorithm chosen:";
            // 
            // TB_Info
            // 
            this.TB_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Info.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Info.Location = new System.Drawing.Point(6, 26);
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.ReadOnly = true;
            this.TB_Info.Size = new System.Drawing.Size(482, 514);
            this.TB_Info.TabIndex = 2;
            this.TB_Info.Text = "";
            this.TB_Info.WordWrap = false;
            // 
            // BT_Pause
            // 
            this.BT_Pause.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pause.Location = new System.Drawing.Point(6, 174);
            this.BT_Pause.Name = "BT_Pause";
            this.BT_Pause.Size = new System.Drawing.Size(240, 29);
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
            this.grp_result.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_result.Location = new System.Drawing.Point(6, 81);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(240, 87);
            this.grp_result.TabIndex = 5;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Search: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Found at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Searching for:";
            // 
            // TB_SearchFor
            // 
            this.TB_SearchFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_SearchFor.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SearchFor.Location = new System.Drawing.Point(107, 17);
            this.TB_SearchFor.Name = "TB_SearchFor";
            this.TB_SearchFor.ReadOnly = true;
            this.TB_SearchFor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TB_SearchFor.Size = new System.Drawing.Size(127, 27);
            this.TB_SearchFor.TabIndex = 5;
            // 
            // TB_Result
            // 
            this.TB_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Result.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Result.Location = new System.Drawing.Point(107, 54);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TB_Result.Size = new System.Drawing.Size(127, 27);
            this.TB_Result.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_Sort);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // LB_Space
            // 
            this.LB_Space.AutoSize = true;
            this.LB_Space.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Space.Location = new System.Drawing.Point(541, 34);
            this.LB_Space.Name = "LB_Space";
            this.LB_Space.Size = new System.Drawing.Size(37, 20);
            this.LB_Space.TabIndex = 5;
            this.LB_Space.Text = "tmp";
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.Location = new System.Drawing.Point(147, 34);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(37, 20);
            this.LB_Time.TabIndex = 4;
            this.LB_Time.Text = "tmp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Space Complexity:";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_Search);
            // 
            // OutputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1334, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OutputScreen";
            this.Text = "Output";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutputScreen_FormClosing);
            this.Resize += new System.EventHandler(this.OutputScreen_Resize);
            this.grp_operations.ResumeLayout(false);
            this.grp_operations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Speed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Zoom)).EndInit();
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
        private System.Windows.Forms.Button BT_Step;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar Bar_Speed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar Bar_Zoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
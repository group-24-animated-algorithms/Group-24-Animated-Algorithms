namespace Group_24_Animated_Algorithms
{
    partial class Input
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
            this.grp_algorithms = new System.Windows.Forms.GroupBox();
            this.lb_bubble = new System.Windows.Forms.Label();
            this.bt_bubble_go = new System.Windows.Forms.Button();
            this.tb_array = new System.Windows.Forms.TextBox();
            this.grp_options = new System.Windows.Forms.GroupBox();
            this.tb_realmin = new System.Windows.Forms.TextBox();
            this.tb_realmax = new System.Windows.Forms.TextBox();
            this.cb_decimals = new System.Windows.Forms.CheckBox();
            this.lb_sortby = new System.Windows.Forms.Label();
            this.lb_array = new System.Windows.Forms.Label();
            this.lb_arraysize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.tb_arraysize = new System.Windows.Forms.TextBox();
            this.rb_descending = new System.Windows.Forms.RadioButton();
            this.rb_ascending = new System.Windows.Forms.RadioButton();
            this.bt_generatearray = new System.Windows.Forms.Button();
            this.grp_algorithms.SuspendLayout();
            this.grp_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_algorithms
            // 
            this.grp_algorithms.Controls.Add(this.lb_bubble);
            this.grp_algorithms.Controls.Add(this.bt_bubble_go);
            this.grp_algorithms.Location = new System.Drawing.Point(12, 12);
            this.grp_algorithms.Name = "grp_algorithms";
            this.grp_algorithms.Size = new System.Drawing.Size(242, 481);
            this.grp_algorithms.TabIndex = 0;
            this.grp_algorithms.TabStop = false;
            this.grp_algorithms.Text = "Sorting Algorithms";
            // 
            // lb_bubble
            // 
            this.lb_bubble.AutoSize = true;
            this.lb_bubble.Location = new System.Drawing.Point(6, 24);
            this.lb_bubble.Name = "lb_bubble";
            this.lb_bubble.Size = new System.Drawing.Size(59, 13);
            this.lb_bubble.TabIndex = 1;
            this.lb_bubble.Text = "BubbleSort";
            // 
            // bt_bubble_go
            // 
            this.bt_bubble_go.Location = new System.Drawing.Point(161, 19);
            this.bt_bubble_go.Name = "bt_bubble_go";
            this.bt_bubble_go.Size = new System.Drawing.Size(75, 23);
            this.bt_bubble_go.TabIndex = 0;
            this.bt_bubble_go.Text = "Go";
            this.bt_bubble_go.UseVisualStyleBackColor = true;
            this.bt_bubble_go.Click += new System.EventHandler(this.Bt_Bubble_Click);
            // 
            // tb_array
            // 
            this.tb_array.Location = new System.Drawing.Point(46, 19);
            this.tb_array.Multiline = true;
            this.tb_array.Name = "tb_array";
            this.tb_array.ReadOnly = true;
            this.tb_array.Size = new System.Drawing.Size(336, 20);
            this.tb_array.TabIndex = 1;
            // 
            // grp_options
            // 
            this.grp_options.Controls.Add(this.tb_realmin);
            this.grp_options.Controls.Add(this.tb_realmax);
            this.grp_options.Controls.Add(this.cb_decimals);
            this.grp_options.Controls.Add(this.lb_sortby);
            this.grp_options.Controls.Add(this.lb_array);
            this.grp_options.Controls.Add(this.lb_arraysize);
            this.grp_options.Controls.Add(this.label2);
            this.grp_options.Controls.Add(this.label1);
            this.grp_options.Controls.Add(this.tb_min);
            this.grp_options.Controls.Add(this.tb_max);
            this.grp_options.Controls.Add(this.tb_arraysize);
            this.grp_options.Controls.Add(this.rb_descending);
            this.grp_options.Controls.Add(this.rb_ascending);
            this.grp_options.Controls.Add(this.bt_generatearray);
            this.grp_options.Controls.Add(this.tb_array);
            this.grp_options.Location = new System.Drawing.Point(260, 12);
            this.grp_options.Name = "grp_options";
            this.grp_options.Size = new System.Drawing.Size(388, 481);
            this.grp_options.TabIndex = 2;
            this.grp_options.TabStop = false;
            this.grp_options.Text = "Array and Sorting Options";
            // 
            // tb_realmin
            // 
            this.tb_realmin.Enabled = false;
            this.tb_realmin.Location = new System.Drawing.Point(338, 97);
            this.tb_realmin.Name = "tb_realmin";
            this.tb_realmin.Size = new System.Drawing.Size(44, 20);
            this.tb_realmin.TabIndex = 16;
            // 
            // tb_realmax
            // 
            this.tb_realmax.Enabled = false;
            this.tb_realmax.Location = new System.Drawing.Point(338, 71);
            this.tb_realmax.Name = "tb_realmax";
            this.tb_realmax.Size = new System.Drawing.Size(44, 20);
            this.tb_realmax.TabIndex = 15;
            // 
            // cb_decimals
            // 
            this.cb_decimals.AutoSize = true;
            this.cb_decimals.Location = new System.Drawing.Point(9, 126);
            this.cb_decimals.Name = "cb_decimals";
            this.cb_decimals.Size = new System.Drawing.Size(95, 17);
            this.cb_decimals.TabIndex = 14;
            this.cb_decimals.Text = "Allow decimals";
            this.cb_decimals.UseVisualStyleBackColor = true;
            this.cb_decimals.CheckedChanged += new System.EventHandler(this.Bt_GenerateArray_Click);
            // 
            // lb_sortby
            // 
            this.lb_sortby.AutoSize = true;
            this.lb_sortby.Location = new System.Drawing.Point(6, 199);
            this.lb_sortby.Name = "lb_sortby";
            this.lb_sortby.Size = new System.Drawing.Size(43, 13);
            this.lb_sortby.TabIndex = 13;
            this.lb_sortby.Text = "Sort by:";
            // 
            // lb_array
            // 
            this.lb_array.AutoSize = true;
            this.lb_array.Location = new System.Drawing.Point(6, 22);
            this.lb_array.Name = "lb_array";
            this.lb_array.Size = new System.Drawing.Size(34, 13);
            this.lb_array.TabIndex = 12;
            this.lb_array.Text = "Array:";
            // 
            // lb_arraysize
            // 
            this.lb_arraysize.AutoSize = true;
            this.lb_arraysize.Location = new System.Drawing.Point(6, 48);
            this.lb_arraysize.Name = "lb_arraysize";
            this.lb_arraysize.Size = new System.Drawing.Size(68, 13);
            this.lb_arraysize.TabIndex = 11;
            this.lb_arraysize.Text = "Size of array:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Min:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Max:";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(288, 97);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(44, 20);
            this.tb_min.TabIndex = 8;
            this.tb_min.Text = "1";
            this.tb_min.TextChanged += new System.EventHandler(this.Bt_GenerateArray_Click);
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(288, 71);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(44, 20);
            this.tb_max.TabIndex = 7;
            this.tb_max.Text = "100";
            this.tb_max.TextChanged += new System.EventHandler(this.Bt_GenerateArray_Click);
            // 
            // tb_arraysize
            // 
            this.tb_arraysize.Location = new System.Drawing.Point(338, 45);
            this.tb_arraysize.Name = "tb_arraysize";
            this.tb_arraysize.Size = new System.Drawing.Size(44, 20);
            this.tb_arraysize.TabIndex = 6;
            this.tb_arraysize.Text = "100";
            this.tb_arraysize.TextChanged += new System.EventHandler(this.Bt_GenerateArray_Click);
            // 
            // rb_descending
            // 
            this.rb_descending.AutoSize = true;
            this.rb_descending.Location = new System.Drawing.Point(300, 197);
            this.rb_descending.Name = "rb_descending";
            this.rb_descending.Size = new System.Drawing.Size(82, 17);
            this.rb_descending.TabIndex = 5;
            this.rb_descending.TabStop = true;
            this.rb_descending.Text = "Descending";
            this.rb_descending.UseVisualStyleBackColor = true;
            // 
            // rb_ascending
            // 
            this.rb_ascending.AutoSize = true;
            this.rb_ascending.Location = new System.Drawing.Point(219, 197);
            this.rb_ascending.Name = "rb_ascending";
            this.rb_ascending.Size = new System.Drawing.Size(75, 17);
            this.rb_ascending.TabIndex = 4;
            this.rb_ascending.TabStop = true;
            this.rb_ascending.Text = "Ascending";
            this.rb_ascending.UseVisualStyleBackColor = true;
            // 
            // bt_generatearray
            // 
            this.bt_generatearray.Location = new System.Drawing.Point(9, 149);
            this.bt_generatearray.Name = "bt_generatearray";
            this.bt_generatearray.Size = new System.Drawing.Size(376, 23);
            this.bt_generatearray.TabIndex = 2;
            this.bt_generatearray.Text = "Generate new array";
            this.bt_generatearray.UseVisualStyleBackColor = true;
            this.bt_generatearray.Click += new System.EventHandler(this.Bt_GenerateArray_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 505);
            this.Controls.Add(this.grp_options);
            this.Controls.Add(this.grp_algorithms);
            this.Name = "Input";
            this.Text = "Group24 Animated Algorithms";
            this.grp_algorithms.ResumeLayout(false);
            this.grp_algorithms.PerformLayout();
            this.grp_options.ResumeLayout(false);
            this.grp_options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_algorithms;
        private System.Windows.Forms.Label lb_bubble;
        private System.Windows.Forms.Button bt_bubble_go;
        private System.Windows.Forms.TextBox tb_array;
        private System.Windows.Forms.GroupBox grp_options;
        private System.Windows.Forms.Button bt_generatearray;
        private System.Windows.Forms.RadioButton rb_descending;
        private System.Windows.Forms.RadioButton rb_ascending;
        private System.Windows.Forms.Label lb_arraysize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.TextBox tb_arraysize;
        private System.Windows.Forms.Label lb_array;
        private System.Windows.Forms.CheckBox cb_decimals;
        private System.Windows.Forms.Label lb_sortby;
        private System.Windows.Forms.TextBox tb_realmin;
        private System.Windows.Forms.TextBox tb_realmax;
    }
}


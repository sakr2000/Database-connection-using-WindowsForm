namespace DB_with_WF
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
            dgv_courses = new DataGridView();
            txt_Crs_Name = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_Crs_Id = new NumericUpDown();
            txt_Crs_Duration = new NumericUpDown();
            cb_Top_Id = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_Crs_Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_Crs_Duration).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_courses.BorderStyle = BorderStyle.None;
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(0, 211);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.Size = new Size(859, 437);
            dgv_courses.TabIndex = 12;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // txt_Crs_Name
            // 
            txt_Crs_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Crs_Name.Location = new Point(175, 71);
            txt_Crs_Name.Name = "txt_Crs_Name";
            txt_Crs_Name.Size = new Size(435, 27);
            txt_Crs_Name.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.AutoSize = true;
            btn_add.Location = new Point(702, 31);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(125, 44);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_update.AutoSize = true;
            btn_update.Location = new Point(702, 87);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(125, 44);
            btn_update.TabIndex = 5;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += button_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_delete.AutoSize = true;
            btn_delete.Location = new Point(702, 143);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(125, 44);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += button_Click;
            // 
            // txt_Crs_Id
            // 
            txt_Crs_Id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Crs_Id.Location = new Point(175, 27);
            txt_Crs_Id.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            txt_Crs_Id.Name = "txt_Crs_Id";
            txt_Crs_Id.Size = new Size(435, 27);
            txt_Crs_Id.TabIndex = 0;
            txt_Crs_Id.KeyUp += txt_Crs_Id_KeyUp;
            // 
            // txt_Crs_Duration
            // 
            txt_Crs_Duration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Crs_Duration.Location = new Point(175, 115);
            txt_Crs_Duration.Name = "txt_Crs_Duration";
            txt_Crs_Duration.Size = new Size(435, 27);
            txt_Crs_Duration.TabIndex = 2;
            // 
            // cb_Top_Id
            // 
            cb_Top_Id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Top_Id.FormattingEnabled = true;
            cb_Top_Id.Location = new Point(175, 159);
            cb_Top_Id.Name = "cb_Top_Id";
            cb_Top_Id.Size = new Size(435, 28);
            cb_Top_Id.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 8;
            label1.Text = "Course ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 9;
            label2.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(18, 119);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 10;
            label3.Text = "Course Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(18, 164);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 11;
            label4.Text = "Topic";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 648);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_Top_Id);
            Controls.Add(txt_Crs_Duration);
            Controls.Add(txt_Crs_Id);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_Crs_Name);
            Controls.Add(dgv_courses);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_Crs_Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_Crs_Duration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private TextBox txt_Crs_Name;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private NumericUpDown txt_Crs_Id;
        private NumericUpDown txt_Crs_Duration;
        private ComboBox cb_Top_Id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

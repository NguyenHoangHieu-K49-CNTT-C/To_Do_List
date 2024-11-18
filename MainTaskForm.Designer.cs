namespace long_bong_midterm
{
    partial class MainTaskForm
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
            lbl_type = new Label();
            lbl_note = new Label();
            lbl_taskname = new Label();
            lbl_date = new Label();
            txt_taskname = new TextBox();
            richTextBox1 = new RichTextBox();
            tc_all = new TabControl();
            All = new TabPage();
            liv_all = new ListView();
            Date = new ColumnHeader();
            Task = new ColumnHeader();
            Time = new ColumnHeader();
            Note = new ColumnHeader();
            Type = new ColumnHeader();
            complete = new ColumnHeader();
            Work = new TabPage();
            liv_work = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            Personal = new TabPage();
            liv_personal = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            NoCatagory = new TabPage();
            liv_nocatagory = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            btn_add = new Button();
            btn_delete = new Button();
            btn_fix = new Button();
            btn_detail = new Button();
            btn_savefile = new Button();
            cbbox_type = new ComboBox();
            cbbox_repeatation = new ComboBox();
            txt_repeat = new TextBox();
            lbl_repeat = new Label();
            pic_calender = new PictureBox();
            lbl_table = new Label();
            textBox1 = new TextBox();
            cbbox_hours = new ComboBox();
            cbbox_minutes = new ComboBox();
            tc_all.SuspendLayout();
            All.SuspendLayout();
            Work.SuspendLayout();
            Personal.SuspendLayout();
            NoCatagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_calender).BeginInit();
            SuspendLayout();
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new Point(120, 188);
            lbl_type.Margin = new Padding(4, 0, 4, 0);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(84, 25);
            lbl_type.TabIndex = 0;
            lbl_type.Text = "Phân loại";
            // 
            // lbl_note
            // 
            lbl_note.AutoSize = true;
            lbl_note.Location = new Point(120, 239);
            lbl_note.Margin = new Padding(4, 0, 4, 0);
            lbl_note.Name = "lbl_note";
            lbl_note.Size = new Size(51, 25);
            lbl_note.TabIndex = 1;
            lbl_note.Text = "Note";
            // 
            // lbl_taskname
            // 
            lbl_taskname.AutoSize = true;
            lbl_taskname.Location = new Point(120, 91);
            lbl_taskname.Margin = new Padding(4, 0, 4, 0);
            lbl_taskname.Name = "lbl_taskname";
            lbl_taskname.Size = new Size(118, 25);
            lbl_taskname.TabIndex = 0;
            lbl_taskname.Text = "Tên công việc";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(120, 142);
            lbl_date.Margin = new Padding(4, 0, 4, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(85, 25);
            lbl_date.TabIndex = 1;
            lbl_date.Text = "Thời gian";
            // 
            // txt_taskname
            // 
            txt_taskname.BorderStyle = BorderStyle.FixedSingle;
            txt_taskname.Location = new Point(251, 88);
            txt_taskname.Margin = new Padding(4, 4, 4, 4);
            txt_taskname.Name = "txt_taskname";
            txt_taskname.Size = new Size(521, 31);
            txt_taskname.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(251, 239);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(520, 119);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // tc_all
            // 
            tc_all.Controls.Add(All);
            tc_all.Controls.Add(Work);
            tc_all.Controls.Add(Personal);
            tc_all.Controls.Add(NoCatagory);
            tc_all.Location = new Point(86, 395);
            tc_all.Margin = new Padding(4, 4, 4, 4);
            tc_all.Name = "tc_all";
            tc_all.SelectedIndex = 0;
            tc_all.Size = new Size(731, 302);
            tc_all.TabIndex = 4;
            // 
            // All
            // 
            All.Controls.Add(liv_all);
            All.Location = new Point(4, 34);
            All.Margin = new Padding(4, 4, 4, 4);
            All.Name = "All";
            All.Padding = new Padding(4, 4, 4, 4);
            All.Size = new Size(723, 264);
            All.TabIndex = 0;
            All.Text = "All";
            All.UseVisualStyleBackColor = true;
            // 
            // liv_all
            // 
            liv_all.BorderStyle = BorderStyle.FixedSingle;
            liv_all.Columns.AddRange(new ColumnHeader[] { Date, Task, Time, Note, Type, complete });
            liv_all.FullRowSelect = true;
            liv_all.GridLines = true;
            liv_all.Location = new Point(8, 8);
            liv_all.Margin = new Padding(4, 4, 4, 4);
            liv_all.Name = "liv_all";
            liv_all.Size = new Size(705, 245);
            liv_all.TabIndex = 0;
            liv_all.UseCompatibleStateImageBehavior = false;
            liv_all.View = View.Details;
            // 
            // Date
            // 
            Date.Text = "Ngày";
            Date.Width = 80;
            // 
            // Task
            // 
            Task.Text = "Công việc";
            Task.TextAlign = HorizontalAlignment.Center;
            Task.Width = 112;
            // 
            // Time
            // 
            Time.Text = "Thời gian";
            Time.TextAlign = HorizontalAlignment.Center;
            Time.Width = 89;
            // 
            // Note
            // 
            Note.Text = "Note";
            Note.TextAlign = HorizontalAlignment.Center;
            Note.Width = 100;
            // 
            // Type
            // 
            Type.Text = "Phân Loại";
            Type.TextAlign = HorizontalAlignment.Center;
            Type.Width = 85;
            // 
            // complete
            // 
            complete.Text = "Hoàn thành";
            complete.TextAlign = HorizontalAlignment.Center;
            complete.Width = 95;
            // 
            // Work
            // 
            Work.Controls.Add(liv_work);
            Work.Location = new Point(4, 34);
            Work.Margin = new Padding(4, 4, 4, 4);
            Work.Name = "Work";
            Work.Padding = new Padding(4, 4, 4, 4);
            Work.Size = new Size(723, 264);
            Work.TabIndex = 1;
            Work.Text = "Work";
            Work.UseVisualStyleBackColor = true;
            // 
            // liv_work
            // 
            liv_work.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            liv_work.Location = new Point(8, 8);
            liv_work.Margin = new Padding(4, 4, 4, 4);
            liv_work.Name = "liv_work";
            liv_work.Size = new Size(705, 245);
            liv_work.TabIndex = 1;
            liv_work.UseCompatibleStateImageBehavior = false;
            liv_work.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ngày";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Công việc";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời gian";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Note";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phân Loại";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Hoàn thành";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 95;
            // 
            // Personal
            // 
            Personal.Controls.Add(liv_personal);
            Personal.Location = new Point(4, 34);
            Personal.Margin = new Padding(4, 4, 4, 4);
            Personal.Name = "Personal";
            Personal.Padding = new Padding(4, 4, 4, 4);
            Personal.Size = new Size(723, 264);
            Personal.TabIndex = 2;
            Personal.Text = "Personal";
            Personal.UseVisualStyleBackColor = true;
            // 
            // liv_personal
            // 
            liv_personal.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            liv_personal.Location = new Point(8, 8);
            liv_personal.Margin = new Padding(4, 4, 4, 4);
            liv_personal.Name = "liv_personal";
            liv_personal.Size = new Size(705, 245);
            liv_personal.TabIndex = 1;
            liv_personal.UseCompatibleStateImageBehavior = false;
            liv_personal.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ngày";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Công việc";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Thời gian";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 89;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Note";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Phân Loại";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 85;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Hoàn thành";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 95;
            // 
            // NoCatagory
            // 
            NoCatagory.Controls.Add(liv_nocatagory);
            NoCatagory.Location = new Point(4, 34);
            NoCatagory.Margin = new Padding(4, 4, 4, 4);
            NoCatagory.Name = "NoCatagory";
            NoCatagory.Padding = new Padding(4, 4, 4, 4);
            NoCatagory.Size = new Size(723, 264);
            NoCatagory.TabIndex = 3;
            NoCatagory.Text = "No catagory";
            NoCatagory.UseVisualStyleBackColor = true;
            // 
            // liv_nocatagory
            // 
            liv_nocatagory.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18 });
            liv_nocatagory.Location = new Point(8, 8);
            liv_nocatagory.Margin = new Padding(4, 4, 4, 4);
            liv_nocatagory.Name = "liv_nocatagory";
            liv_nocatagory.Size = new Size(705, 245);
            liv_nocatagory.TabIndex = 1;
            liv_nocatagory.UseCompatibleStateImageBehavior = false;
            liv_nocatagory.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Ngày";
            columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Công việc";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 112;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Thời gian";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 89;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Note";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Phân Loại";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 85;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Hoàn thành";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            columnHeader18.Width = 95;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(86, 714);
            btn_add.Margin = new Padding(4, 4, 4, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(118, 36);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(251, 714);
            btn_delete.Margin = new Padding(4, 4, 4, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(118, 36);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_fix
            // 
            btn_fix.Location = new Point(401, 714);
            btn_fix.Margin = new Padding(4, 4, 4, 4);
            btn_fix.Name = "btn_fix";
            btn_fix.Size = new Size(118, 36);
            btn_fix.TabIndex = 5;
            btn_fix.Text = "Sửa";
            btn_fix.UseVisualStyleBackColor = true;
            // 
            // btn_detail
            // 
            btn_detail.Location = new Point(550, 714);
            btn_detail.Margin = new Padding(4, 4, 4, 4);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(118, 36);
            btn_detail.TabIndex = 5;
            btn_detail.Text = "Chi tiết";
            btn_detail.UseVisualStyleBackColor = true;
            // 
            // btn_savefile
            // 
            btn_savefile.Location = new Point(700, 714);
            btn_savefile.Margin = new Padding(4, 4, 4, 4);
            btn_savefile.Name = "btn_savefile";
            btn_savefile.Size = new Size(118, 36);
            btn_savefile.TabIndex = 5;
            btn_savefile.Text = "Lưu file";
            btn_savefile.UseVisualStyleBackColor = true;
            // 
            // cbbox_type
            // 
            cbbox_type.FormattingEnabled = true;
            cbbox_type.Location = new Point(251, 184);
            cbbox_type.Margin = new Padding(4, 4, 4, 4);
            cbbox_type.Name = "cbbox_type";
            cbbox_type.Size = new Size(172, 33);
            cbbox_type.TabIndex = 6;
            // 
            // cbbox_repeatation
            // 
            cbbox_repeatation.FormattingEnabled = true;
            cbbox_repeatation.Location = new Point(511, 184);
            cbbox_repeatation.Margin = new Padding(4, 4, 4, 4);
            cbbox_repeatation.Name = "cbbox_repeatation";
            cbbox_repeatation.Size = new Size(166, 33);
            cbbox_repeatation.TabIndex = 6;
            cbbox_repeatation.SelectedIndexChanged += cbbox_repeatation_SelectedIndexChanged;
            // 
            // txt_repeat
            // 
            txt_repeat.BorderStyle = BorderStyle.FixedSingle;
            txt_repeat.Enabled = false;
            txt_repeat.Location = new Point(686, 184);
            txt_repeat.Margin = new Padding(4, 4, 4, 4);
            txt_repeat.Name = "txt_repeat";
            txt_repeat.Size = new Size(86, 31);
            txt_repeat.TabIndex = 7;
            // 
            // lbl_repeat
            // 
            lbl_repeat.AutoSize = true;
            lbl_repeat.Location = new Point(441, 188);
            lbl_repeat.Margin = new Padding(4, 0, 4, 0);
            lbl_repeat.Name = "lbl_repeat";
            lbl_repeat.Size = new Size(66, 25);
            lbl_repeat.TabIndex = 8;
            lbl_repeat.Text = "Lặp lại:";
            // 
            // pic_calender
            // 
            pic_calender.Image = Properties.Resources.Picture1;
            pic_calender.Location = new Point(251, 138);
            pic_calender.Margin = new Padding(4, 4, 4, 4);
            pic_calender.Name = "pic_calender";
            pic_calender.Size = new Size(45, 39);
            pic_calender.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_calender.TabIndex = 9;
            pic_calender.TabStop = false;
            pic_calender.Click += pic_calender_Click;
            // 
            // lbl_table
            // 
            lbl_table.AutoSize = true;
            lbl_table.Location = new Point(86, 366);
            lbl_table.Margin = new Padding(4, 0, 4, 0);
            lbl_table.Name = "lbl_table";
            lbl_table.Size = new Size(174, 25);
            lbl_table.TabIndex = 1;
            lbl_table.Text = "Danh sách công việc";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 142);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 31);
            textBox1.TabIndex = 10;
            // 
            // cbbox_hours
            // 
            cbbox_hours.FormattingEnabled = true;
            cbbox_hours.Location = new Point(588, 142);
            cbbox_hours.Margin = new Padding(4, 4, 4, 4);
            cbbox_hours.Name = "cbbox_hours";
            cbbox_hours.Size = new Size(90, 33);
            cbbox_hours.TabIndex = 11;
            cbbox_hours.Text = "Giờ";
            // 
            // cbbox_minutes
            // 
            cbbox_minutes.FormattingEnabled = true;
            cbbox_minutes.Location = new Point(686, 141);
            cbbox_minutes.Margin = new Padding(4, 4, 4, 4);
            cbbox_minutes.Name = "cbbox_minutes";
            cbbox_minutes.Size = new Size(85, 33);
            cbbox_minutes.TabIndex = 11;
            cbbox_minutes.Text = "Phút";
            // 
            // MainTaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(871, 765);
            Controls.Add(cbbox_minutes);
            Controls.Add(cbbox_hours);
            Controls.Add(textBox1);
            Controls.Add(pic_calender);
            Controls.Add(lbl_repeat);
            Controls.Add(txt_repeat);
            Controls.Add(cbbox_repeatation);
            Controls.Add(cbbox_type);
            Controls.Add(btn_fix);
            Controls.Add(btn_savefile);
            Controls.Add(btn_detail);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(tc_all);
            Controls.Add(richTextBox1);
            Controls.Add(txt_taskname);
            Controls.Add(lbl_date);
            Controls.Add(lbl_table);
            Controls.Add(lbl_note);
            Controls.Add(lbl_taskname);
            Controls.Add(lbl_type);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainTaskForm";
            Text = "Main task";
            Load += MainTaskForm_Load;
            tc_all.ResumeLayout(false);
            All.ResumeLayout(false);
            Work.ResumeLayout(false);
            Personal.ResumeLayout(false);
            NoCatagory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_calender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_type;
        private Label lbl_note;
        private Label lbl_taskname;
        private Label lbl_date;
        private TextBox txt_taskname;
        private RichTextBox richTextBox1;
        private TabControl tc_all;
        private TabPage All;
        private TabPage Work;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_fix;
        private Button btn_detail;
        private Button btn_savefile;
        private TabPage Personal;
        private TabPage NoCatagory;
        private ComboBox cbbox_type;
        private ComboBox cbbox_repeatation;
        private TextBox txt_repeat;
        private Label lbl_repeat;
        private PictureBox pic_calender;
        private ListView liv_all;
        private ColumnHeader Date;
        private ColumnHeader Task;
        private ColumnHeader Time;
        private ColumnHeader Note;
        private ColumnHeader Type;
        private ColumnHeader complete;
        private Label lbl_table;
        private ListView liv_work;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView liv_personal;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView liv_nocatagory;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private TextBox textBox1;
        private ComboBox cbbox_hours;
        private ComboBox cbbox_minutes;
    }
}

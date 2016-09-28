namespace MultiLearn.Dashboard.UI
{
    partial class StatisticsViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._games_tabs = new System.Windows.Forms.TabControl();
            this._games_math_tab = new System.Windows.Forms.TabPage();
            this._math_viewby_tabs = new System.Windows.Forms.TabControl();
            this._math_viewby_class_tab = new System.Windows.Forms.TabPage();
            this._math_class_type_chart = new System.Windows.Forms.GroupBox();
            this._math_class_problemtype_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._math_class_accuracy_group = new System.Windows.Forms.GroupBox();
            this._math_class_min_accuracy_person = new System.Windows.Forms.Label();
            this._math_class_min_accuracy_value = new System.Windows.Forms.Label();
            this._math_class_min_accuracy_label = new System.Windows.Forms.Label();
            this._math_class_max_accuracy_person = new System.Windows.Forms.Label();
            this._math_class_max_accuracy_value = new System.Windows.Forms.Label();
            this._math_class_max_accuracy_label = new System.Windows.Forms.Label();
            this._math_chart_accuracy_value = new System.Windows.Forms.Label();
            this._math_class_accuracy_label = new System.Windows.Forms.Label();
            this._math_class_time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._math_class_classes_list = new System.Windows.Forms.ListBox();
            this._math_viewby_student_tab = new System.Windows.Forms.TabPage();
            this._math_viewby_problemtype_tab = new System.Windows.Forms.TabPage();
            this._games_spelling_tab = new System.Windows.Forms.TabPage();
            this._spelling_viewby_tabs = new System.Windows.Forms.TabControl();
            this._spelling_word_tab = new System.Windows.Forms.TabPage();
            this._spelling_word_filter_label = new System.Windows.Forms.Label();
            this._spelling_word_filter_textbox = new System.Windows.Forms.TextBox();
            this._spelling_word_accuracy = new System.Windows.Forms.GroupBox();
            this._spelling_word_accuracy_value = new System.Windows.Forms.Label();
            this._spelling_word_accuracy_label = new System.Windows.Forms.Label();
            this._spelling_words_time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._spelling_words_list = new System.Windows.Forms.ListBox();
            this._spelling_class_tab = new System.Windows.Forms.TabPage();
            this._spelling_student_tab = new System.Windows.Forms.TabPage();
            this._games_multiplechoice_tab = new System.Windows.Forms.TabPage();
            this._spelling_word_letters = new System.Windows.Forms.GroupBox();
            this._spelling_word_letters_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._spelling_word_letters_label = new System.Windows.Forms.Label();
            this._spelling_word_letters_combo = new System.Windows.Forms.ComboBox();
            this._spelling_word_letters_pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._games_tabs.SuspendLayout();
            this._games_math_tab.SuspendLayout();
            this._math_viewby_tabs.SuspendLayout();
            this._math_viewby_class_tab.SuspendLayout();
            this._math_class_type_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._math_class_problemtype_chart)).BeginInit();
            this._math_class_accuracy_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._math_class_time_chart)).BeginInit();
            this._games_spelling_tab.SuspendLayout();
            this._spelling_viewby_tabs.SuspendLayout();
            this._spelling_word_tab.SuspendLayout();
            this._spelling_word_accuracy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_words_time_chart)).BeginInit();
            this._spelling_word_letters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_word_letters_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_word_letters_pie)).BeginInit();
            this.SuspendLayout();
            // 
            // _games_tabs
            // 
            this._games_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._games_tabs.Controls.Add(this._games_math_tab);
            this._games_tabs.Controls.Add(this._games_spelling_tab);
            this._games_tabs.Controls.Add(this._games_multiplechoice_tab);
            this._games_tabs.Location = new System.Drawing.Point(12, 12);
            this._games_tabs.Name = "_games_tabs";
            this._games_tabs.SelectedIndex = 0;
            this._games_tabs.Size = new System.Drawing.Size(902, 480);
            this._games_tabs.TabIndex = 0;
            // 
            // _games_math_tab
            // 
            this._games_math_tab.Controls.Add(this._math_viewby_tabs);
            this._games_math_tab.Location = new System.Drawing.Point(4, 22);
            this._games_math_tab.Name = "_games_math_tab";
            this._games_math_tab.Padding = new System.Windows.Forms.Padding(3);
            this._games_math_tab.Size = new System.Drawing.Size(894, 454);
            this._games_math_tab.TabIndex = 0;
            this._games_math_tab.Text = "Math";
            this._games_math_tab.UseVisualStyleBackColor = true;
            // 
            // _math_viewby_tabs
            // 
            this._math_viewby_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._math_viewby_tabs.Controls.Add(this._math_viewby_class_tab);
            this._math_viewby_tabs.Controls.Add(this._math_viewby_student_tab);
            this._math_viewby_tabs.Controls.Add(this._math_viewby_problemtype_tab);
            this._math_viewby_tabs.Location = new System.Drawing.Point(6, 6);
            this._math_viewby_tabs.Name = "_math_viewby_tabs";
            this._math_viewby_tabs.SelectedIndex = 0;
            this._math_viewby_tabs.Size = new System.Drawing.Size(882, 442);
            this._math_viewby_tabs.TabIndex = 0;
            this._math_viewby_tabs.TabIndexChanged += new System.EventHandler(this._math_viewby_tabs_TabIndexChanged);
            // 
            // _math_viewby_class_tab
            // 
            this._math_viewby_class_tab.Controls.Add(this._math_class_type_chart);
            this._math_viewby_class_tab.Controls.Add(this._math_class_accuracy_group);
            this._math_viewby_class_tab.Controls.Add(this._math_class_classes_list);
            this._math_viewby_class_tab.Location = new System.Drawing.Point(4, 22);
            this._math_viewby_class_tab.Name = "_math_viewby_class_tab";
            this._math_viewby_class_tab.Padding = new System.Windows.Forms.Padding(3);
            this._math_viewby_class_tab.Size = new System.Drawing.Size(874, 416);
            this._math_viewby_class_tab.TabIndex = 0;
            this._math_viewby_class_tab.Text = "By Class";
            this._math_viewby_class_tab.UseVisualStyleBackColor = true;
            // 
            // _math_class_type_chart
            // 
            this._math_class_type_chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._math_class_type_chart.Controls.Add(this._math_class_problemtype_chart);
            this._math_class_type_chart.Location = new System.Drawing.Point(487, 6);
            this._math_class_type_chart.Name = "_math_class_type_chart";
            this._math_class_type_chart.Size = new System.Drawing.Size(381, 404);
            this._math_class_type_chart.TabIndex = 3;
            this._math_class_type_chart.TabStop = false;
            this._math_class_type_chart.Text = "Problem Types";
            // 
            // _math_class_problemtype_chart
            // 
            this._math_class_problemtype_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.Name = "ChartArea1";
            this._math_class_problemtype_chart.ChartAreas.Add(chartArea13);
            this._math_class_problemtype_chart.Location = new System.Drawing.Point(6, 19);
            this._math_class_problemtype_chart.Name = "_math_class_problemtype_chart";
            this._math_class_problemtype_chart.Size = new System.Drawing.Size(369, 379);
            this._math_class_problemtype_chart.TabIndex = 0;
            this._math_class_problemtype_chart.Text = "chart1";
            // 
            // _math_class_accuracy_group
            // 
            this._math_class_accuracy_group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._math_class_accuracy_group.Controls.Add(this._math_class_min_accuracy_person);
            this._math_class_accuracy_group.Controls.Add(this._math_class_min_accuracy_value);
            this._math_class_accuracy_group.Controls.Add(this._math_class_min_accuracy_label);
            this._math_class_accuracy_group.Controls.Add(this._math_class_max_accuracy_person);
            this._math_class_accuracy_group.Controls.Add(this._math_class_max_accuracy_value);
            this._math_class_accuracy_group.Controls.Add(this._math_class_max_accuracy_label);
            this._math_class_accuracy_group.Controls.Add(this._math_chart_accuracy_value);
            this._math_class_accuracy_group.Controls.Add(this._math_class_accuracy_label);
            this._math_class_accuracy_group.Controls.Add(this._math_class_time_chart);
            this._math_class_accuracy_group.Location = new System.Drawing.Point(188, 6);
            this._math_class_accuracy_group.Name = "_math_class_accuracy_group";
            this._math_class_accuracy_group.Size = new System.Drawing.Size(293, 404);
            this._math_class_accuracy_group.TabIndex = 2;
            this._math_class_accuracy_group.TabStop = false;
            this._math_class_accuracy_group.Text = "Accuracy";
            // 
            // _math_class_min_accuracy_person
            // 
            this._math_class_min_accuracy_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_min_accuracy_person.AutoSize = true;
            this._math_class_min_accuracy_person.Location = new System.Drawing.Point(139, 332);
            this._math_class_min_accuracy_person.Name = "_math_class_min_accuracy_person";
            this._math_class_min_accuracy_person.Size = new System.Drawing.Size(47, 13);
            this._math_class_min_accuracy_person.TabIndex = 7;
            this._math_class_min_accuracy_person.Text = "(Asdf jkl)";
            // 
            // _math_class_min_accuracy_value
            // 
            this._math_class_min_accuracy_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_min_accuracy_value.AutoSize = true;
            this._math_class_min_accuracy_value.Location = new System.Drawing.Point(139, 319);
            this._math_class_min_accuracy_value.Name = "_math_class_min_accuracy_value";
            this._math_class_min_accuracy_value.Size = new System.Drawing.Size(33, 13);
            this._math_class_min_accuracy_value.TabIndex = 6;
            this._math_class_min_accuracy_value.Text = "100%";
            // 
            // _math_class_min_accuracy_label
            // 
            this._math_class_min_accuracy_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_min_accuracy_label.AutoSize = true;
            this._math_class_min_accuracy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._math_class_min_accuracy_label.Location = new System.Drawing.Point(17, 319);
            this._math_class_min_accuracy_label.Name = "_math_class_min_accuracy_label";
            this._math_class_min_accuracy_label.Size = new System.Drawing.Size(104, 13);
            this._math_class_min_accuracy_label.TabIndex = 5;
            this._math_class_min_accuracy_label.Text = "Lowest Accuracy";
            // 
            // _math_class_max_accuracy_person
            // 
            this._math_class_max_accuracy_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_max_accuracy_person.AutoSize = true;
            this._math_class_max_accuracy_person.Location = new System.Drawing.Point(139, 300);
            this._math_class_max_accuracy_person.Name = "_math_class_max_accuracy_person";
            this._math_class_max_accuracy_person.Size = new System.Drawing.Size(47, 13);
            this._math_class_max_accuracy_person.TabIndex = 4;
            this._math_class_max_accuracy_person.Text = "(Asdf jkl)";
            // 
            // _math_class_max_accuracy_value
            // 
            this._math_class_max_accuracy_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_max_accuracy_value.AutoSize = true;
            this._math_class_max_accuracy_value.Location = new System.Drawing.Point(139, 287);
            this._math_class_max_accuracy_value.Name = "_math_class_max_accuracy_value";
            this._math_class_max_accuracy_value.Size = new System.Drawing.Size(33, 13);
            this._math_class_max_accuracy_value.TabIndex = 3;
            this._math_class_max_accuracy_value.Text = "100%";
            // 
            // _math_class_max_accuracy_label
            // 
            this._math_class_max_accuracy_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_max_accuracy_label.AutoSize = true;
            this._math_class_max_accuracy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._math_class_max_accuracy_label.Location = new System.Drawing.Point(17, 287);
            this._math_class_max_accuracy_label.Name = "_math_class_max_accuracy_label";
            this._math_class_max_accuracy_label.Size = new System.Drawing.Size(86, 13);
            this._math_class_max_accuracy_label.TabIndex = 0;
            this._math_class_max_accuracy_label.Text = "Top Accuracy";
            // 
            // _math_chart_accuracy_value
            // 
            this._math_chart_accuracy_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_chart_accuracy_value.AutoSize = true;
            this._math_chart_accuracy_value.Location = new System.Drawing.Point(138, 231);
            this._math_chart_accuracy_value.Name = "_math_chart_accuracy_value";
            this._math_chart_accuracy_value.Size = new System.Drawing.Size(27, 13);
            this._math_chart_accuracy_value.TabIndex = 2;
            this._math_chart_accuracy_value.Text = "10%";
            // 
            // _math_class_accuracy_label
            // 
            this._math_class_accuracy_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_accuracy_label.AutoSize = true;
            this._math_class_accuracy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._math_class_accuracy_label.Location = new System.Drawing.Point(16, 231);
            this._math_class_accuracy_label.Name = "_math_class_accuracy_label";
            this._math_class_accuracy_label.Size = new System.Drawing.Size(105, 13);
            this._math_class_accuracy_label.TabIndex = 1;
            this._math_class_accuracy_label.Text = "Current Accuracy";
            // 
            // _math_class_time_chart
            // 
            this._math_class_time_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea14.Name = "ChartArea1";
            this._math_class_time_chart.ChartAreas.Add(chartArea14);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this._math_class_time_chart.Legends.Add(legend6);
            this._math_class_time_chart.Location = new System.Drawing.Point(6, 33);
            this._math_class_time_chart.Name = "_math_class_time_chart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this._math_class_time_chart.Series.Add(series11);
            this._math_class_time_chart.Size = new System.Drawing.Size(281, 161);
            this._math_class_time_chart.TabIndex = 1;
            this._math_class_time_chart.Text = "chart1";
            // 
            // _math_class_classes_list
            // 
            this._math_class_classes_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._math_class_classes_list.FormattingEnabled = true;
            this._math_class_classes_list.Location = new System.Drawing.Point(6, 6);
            this._math_class_classes_list.Name = "_math_class_classes_list";
            this._math_class_classes_list.Size = new System.Drawing.Size(176, 407);
            this._math_class_classes_list.TabIndex = 0;
            this._math_class_classes_list.SelectedIndexChanged += new System.EventHandler(this._math_class_classes_list_SelectedIndexChanged);
            // 
            // _math_viewby_student_tab
            // 
            this._math_viewby_student_tab.Location = new System.Drawing.Point(4, 22);
            this._math_viewby_student_tab.Name = "_math_viewby_student_tab";
            this._math_viewby_student_tab.Padding = new System.Windows.Forms.Padding(3);
            this._math_viewby_student_tab.Size = new System.Drawing.Size(874, 416);
            this._math_viewby_student_tab.TabIndex = 1;
            this._math_viewby_student_tab.Text = "By Student";
            this._math_viewby_student_tab.UseVisualStyleBackColor = true;
            // 
            // _math_viewby_problemtype_tab
            // 
            this._math_viewby_problemtype_tab.Location = new System.Drawing.Point(4, 22);
            this._math_viewby_problemtype_tab.Name = "_math_viewby_problemtype_tab";
            this._math_viewby_problemtype_tab.Padding = new System.Windows.Forms.Padding(3);
            this._math_viewby_problemtype_tab.Size = new System.Drawing.Size(874, 416);
            this._math_viewby_problemtype_tab.TabIndex = 2;
            this._math_viewby_problemtype_tab.Text = "By Problem Type";
            this._math_viewby_problemtype_tab.UseVisualStyleBackColor = true;
            // 
            // _games_spelling_tab
            // 
            this._games_spelling_tab.Controls.Add(this._spelling_viewby_tabs);
            this._games_spelling_tab.Location = new System.Drawing.Point(4, 22);
            this._games_spelling_tab.Name = "_games_spelling_tab";
            this._games_spelling_tab.Padding = new System.Windows.Forms.Padding(3);
            this._games_spelling_tab.Size = new System.Drawing.Size(894, 454);
            this._games_spelling_tab.TabIndex = 1;
            this._games_spelling_tab.Text = "Spelling";
            this._games_spelling_tab.UseVisualStyleBackColor = true;
            // 
            // _spelling_viewby_tabs
            // 
            this._spelling_viewby_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._spelling_viewby_tabs.Controls.Add(this._spelling_word_tab);
            this._spelling_viewby_tabs.Controls.Add(this._spelling_class_tab);
            this._spelling_viewby_tabs.Controls.Add(this._spelling_student_tab);
            this._spelling_viewby_tabs.Location = new System.Drawing.Point(6, 6);
            this._spelling_viewby_tabs.Name = "_spelling_viewby_tabs";
            this._spelling_viewby_tabs.SelectedIndex = 0;
            this._spelling_viewby_tabs.Size = new System.Drawing.Size(882, 442);
            this._spelling_viewby_tabs.TabIndex = 0;
            this._spelling_viewby_tabs.TabIndexChanged += new System.EventHandler(this._spelling_tabs_TabIndexChanged);
            // 
            // _spelling_word_tab
            // 
            this._spelling_word_tab.Controls.Add(this._spelling_word_letters);
            this._spelling_word_tab.Controls.Add(this._spelling_word_filter_label);
            this._spelling_word_tab.Controls.Add(this._spelling_word_filter_textbox);
            this._spelling_word_tab.Controls.Add(this._spelling_word_accuracy);
            this._spelling_word_tab.Controls.Add(this._spelling_words_list);
            this._spelling_word_tab.Location = new System.Drawing.Point(4, 22);
            this._spelling_word_tab.Name = "_spelling_word_tab";
            this._spelling_word_tab.Padding = new System.Windows.Forms.Padding(3);
            this._spelling_word_tab.Size = new System.Drawing.Size(874, 416);
            this._spelling_word_tab.TabIndex = 0;
            this._spelling_word_tab.Text = "By Word";
            this._spelling_word_tab.UseVisualStyleBackColor = true;
            // 
            // _spelling_word_filter_label
            // 
            this._spelling_word_filter_label.AutoSize = true;
            this._spelling_word_filter_label.Location = new System.Drawing.Point(6, 9);
            this._spelling_word_filter_label.Name = "_spelling_word_filter_label";
            this._spelling_word_filter_label.Size = new System.Drawing.Size(29, 13);
            this._spelling_word_filter_label.TabIndex = 3;
            this._spelling_word_filter_label.Text = "Filter";
            // 
            // _spelling_word_filter_textbox
            // 
            this._spelling_word_filter_textbox.Location = new System.Drawing.Point(38, 6);
            this._spelling_word_filter_textbox.Name = "_spelling_word_filter_textbox";
            this._spelling_word_filter_textbox.Size = new System.Drawing.Size(144, 20);
            this._spelling_word_filter_textbox.TabIndex = 2;
            this._spelling_word_filter_textbox.TextChanged += new System.EventHandler(this._spelling_word_filter_textbox_TextChanged);
            // 
            // _spelling_word_accuracy
            // 
            this._spelling_word_accuracy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._spelling_word_accuracy.Controls.Add(this._spelling_word_accuracy_value);
            this._spelling_word_accuracy.Controls.Add(this._spelling_word_accuracy_label);
            this._spelling_word_accuracy.Controls.Add(this._spelling_words_time_chart);
            this._spelling_word_accuracy.Location = new System.Drawing.Point(188, 6);
            this._spelling_word_accuracy.Name = "_spelling_word_accuracy";
            this._spelling_word_accuracy.Size = new System.Drawing.Size(311, 404);
            this._spelling_word_accuracy.TabIndex = 1;
            this._spelling_word_accuracy.TabStop = false;
            this._spelling_word_accuracy.Text = "Error Rate";
            // 
            // _spelling_word_accuracy_value
            // 
            this._spelling_word_accuracy_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._spelling_word_accuracy_value.AutoSize = true;
            this._spelling_word_accuracy_value.Location = new System.Drawing.Point(142, 347);
            this._spelling_word_accuracy_value.Name = "_spelling_word_accuracy_value";
            this._spelling_word_accuracy_value.Size = new System.Drawing.Size(53, 13);
            this._spelling_word_accuracy_value.TabIndex = 2;
            this._spelling_word_accuracy_value.Text = "10 / word";
            // 
            // _spelling_word_accuracy_label
            // 
            this._spelling_word_accuracy_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._spelling_word_accuracy_label.AutoSize = true;
            this._spelling_word_accuracy_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._spelling_word_accuracy_label.Location = new System.Drawing.Point(21, 347);
            this._spelling_word_accuracy_label.Name = "_spelling_word_accuracy_label";
            this._spelling_word_accuracy_label.Size = new System.Drawing.Size(110, 13);
            this._spelling_word_accuracy_label.TabIndex = 1;
            this._spelling_word_accuracy_label.Text = "Current Error Rate";
            // 
            // _spelling_words_time_chart
            // 
            this._spelling_words_time_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.Name = "ChartArea1";
            this._spelling_words_time_chart.ChartAreas.Add(chartArea15);
            this._spelling_words_time_chart.Location = new System.Drawing.Point(6, 19);
            this._spelling_words_time_chart.Name = "_spelling_words_time_chart";
            series12.ChartArea = "ChartArea1";
            series12.Name = "Series1";
            this._spelling_words_time_chart.Series.Add(series12);
            this._spelling_words_time_chart.Size = new System.Drawing.Size(299, 291);
            this._spelling_words_time_chart.TabIndex = 0;
            this._spelling_words_time_chart.Text = "chart1";
            // 
            // _spelling_words_list
            // 
            this._spelling_words_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._spelling_words_list.FormattingEnabled = true;
            this._spelling_words_list.Location = new System.Drawing.Point(6, 32);
            this._spelling_words_list.Name = "_spelling_words_list";
            this._spelling_words_list.Size = new System.Drawing.Size(176, 381);
            this._spelling_words_list.TabIndex = 0;
            this._spelling_words_list.SelectedIndexChanged += new System.EventHandler(this._spelling_words_list_SelectedIndexChanged);
            // 
            // _spelling_class_tab
            // 
            this._spelling_class_tab.Location = new System.Drawing.Point(4, 22);
            this._spelling_class_tab.Name = "_spelling_class_tab";
            this._spelling_class_tab.Padding = new System.Windows.Forms.Padding(3);
            this._spelling_class_tab.Size = new System.Drawing.Size(874, 416);
            this._spelling_class_tab.TabIndex = 1;
            this._spelling_class_tab.Text = "By Class";
            this._spelling_class_tab.UseVisualStyleBackColor = true;
            // 
            // _spelling_student_tab
            // 
            this._spelling_student_tab.Location = new System.Drawing.Point(4, 22);
            this._spelling_student_tab.Name = "_spelling_student_tab";
            this._spelling_student_tab.Padding = new System.Windows.Forms.Padding(3);
            this._spelling_student_tab.Size = new System.Drawing.Size(874, 416);
            this._spelling_student_tab.TabIndex = 2;
            this._spelling_student_tab.Text = "By Student";
            this._spelling_student_tab.UseVisualStyleBackColor = true;
            // 
            // _games_multiplechoice_tab
            // 
            this._games_multiplechoice_tab.Location = new System.Drawing.Point(4, 22);
            this._games_multiplechoice_tab.Name = "_games_multiplechoice_tab";
            this._games_multiplechoice_tab.Padding = new System.Windows.Forms.Padding(3);
            this._games_multiplechoice_tab.Size = new System.Drawing.Size(894, 454);
            this._games_multiplechoice_tab.TabIndex = 2;
            this._games_multiplechoice_tab.Text = "Multiple Choice";
            this._games_multiplechoice_tab.UseVisualStyleBackColor = true;
            // 
            // _spelling_word_letters
            // 
            this._spelling_word_letters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._spelling_word_letters.Controls.Add(this._spelling_word_letters_pie);
            this._spelling_word_letters.Controls.Add(this._spelling_word_letters_combo);
            this._spelling_word_letters.Controls.Add(this._spelling_word_letters_label);
            this._spelling_word_letters.Controls.Add(this._spelling_word_letters_chart);
            this._spelling_word_letters.Location = new System.Drawing.Point(505, 9);
            this._spelling_word_letters.Name = "_spelling_word_letters";
            this._spelling_word_letters.Size = new System.Drawing.Size(363, 401);
            this._spelling_word_letters.TabIndex = 1;
            this._spelling_word_letters.TabStop = false;
            this._spelling_word_letters.Text = "Errors by Letter";
            // 
            // _spelling_word_letters_chart
            // 
            this._spelling_word_letters_chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea12.Name = "ChartArea1";
            this._spelling_word_letters_chart.ChartAreas.Add(chartArea12);
            this._spelling_word_letters_chart.Location = new System.Drawing.Point(6, 16);
            this._spelling_word_letters_chart.Name = "_spelling_word_letters_chart";
            series10.ChartArea = "ChartArea1";
            series10.Name = "Series1";
            this._spelling_word_letters_chart.Series.Add(series10);
            this._spelling_word_letters_chart.Size = new System.Drawing.Size(351, 189);
            this._spelling_word_letters_chart.TabIndex = 0;
            this._spelling_word_letters_chart.Text = "chart1";
            // 
            // _spelling_word_letters_label
            // 
            this._spelling_word_letters_label.AutoSize = true;
            this._spelling_word_letters_label.Location = new System.Drawing.Point(6, 214);
            this._spelling_word_letters_label.Name = "_spelling_word_letters_label";
            this._spelling_word_letters_label.Size = new System.Drawing.Size(39, 13);
            this._spelling_word_letters_label.TabIndex = 1;
            this._spelling_word_letters_label.Text = "Letters";
            // 
            // _spelling_word_letters_combo
            // 
            this._spelling_word_letters_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._spelling_word_letters_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._spelling_word_letters_combo.FormattingEnabled = true;
            this._spelling_word_letters_combo.Location = new System.Drawing.Point(51, 211);
            this._spelling_word_letters_combo.Name = "_spelling_word_letters_combo";
            this._spelling_word_letters_combo.Size = new System.Drawing.Size(306, 21);
            this._spelling_word_letters_combo.TabIndex = 2;
            this._spelling_word_letters_combo.SelectedIndexChanged += new System.EventHandler(this._spelling_word_letters_combo_SelectedIndexChanged);
            // 
            // _spelling_word_letters_pie
            // 
            this._spelling_word_letters_pie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.Name = "ChartArea1";
            this._spelling_word_letters_pie.ChartAreas.Add(chartArea11);
            legend5.Name = "Legend1";
            this._spelling_word_letters_pie.Legends.Add(legend5);
            this._spelling_word_letters_pie.Location = new System.Drawing.Point(6, 238);
            this._spelling_word_letters_pie.Name = "_spelling_word_letters_pie";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this._spelling_word_letters_pie.Series.Add(series9);
            this._spelling_word_letters_pie.Size = new System.Drawing.Size(351, 157);
            this._spelling_word_letters_pie.TabIndex = 3;
            this._spelling_word_letters_pie.Text = "chart1";
            // 
            // StatisticsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 504);
            this.Controls.Add(this._games_tabs);
            this.Name = "StatisticsViewer";
            this.Text = "Statistics";
            this._games_tabs.ResumeLayout(false);
            this._games_math_tab.ResumeLayout(false);
            this._math_viewby_tabs.ResumeLayout(false);
            this._math_viewby_class_tab.ResumeLayout(false);
            this._math_class_type_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._math_class_problemtype_chart)).EndInit();
            this._math_class_accuracy_group.ResumeLayout(false);
            this._math_class_accuracy_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._math_class_time_chart)).EndInit();
            this._games_spelling_tab.ResumeLayout(false);
            this._spelling_viewby_tabs.ResumeLayout(false);
            this._spelling_word_tab.ResumeLayout(false);
            this._spelling_word_tab.PerformLayout();
            this._spelling_word_accuracy.ResumeLayout(false);
            this._spelling_word_accuracy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_words_time_chart)).EndInit();
            this._spelling_word_letters.ResumeLayout(false);
            this._spelling_word_letters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_word_letters_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spelling_word_letters_pie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _games_tabs;
        private System.Windows.Forms.TabPage _games_math_tab;
        private System.Windows.Forms.TabControl _math_viewby_tabs;
        private System.Windows.Forms.TabPage _math_viewby_class_tab;
        private System.Windows.Forms.TabPage _math_viewby_student_tab;
        private System.Windows.Forms.TabPage _games_spelling_tab;
        private System.Windows.Forms.TabPage _games_multiplechoice_tab;
        private System.Windows.Forms.TabPage _math_viewby_problemtype_tab;
        private System.Windows.Forms.ListBox _math_class_classes_list;
        private System.Windows.Forms.DataVisualization.Charting.Chart _math_class_time_chart;
        private System.Windows.Forms.GroupBox _math_class_accuracy_group;
        private System.Windows.Forms.GroupBox _math_class_type_chart;
        private System.Windows.Forms.Label _math_chart_accuracy_value;
        private System.Windows.Forms.Label _math_class_accuracy_label;
        private System.Windows.Forms.Label _math_class_min_accuracy_person;
        private System.Windows.Forms.Label _math_class_min_accuracy_value;
        private System.Windows.Forms.Label _math_class_min_accuracy_label;
        private System.Windows.Forms.Label _math_class_max_accuracy_person;
        private System.Windows.Forms.Label _math_class_max_accuracy_value;
        private System.Windows.Forms.Label _math_class_max_accuracy_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart _math_class_problemtype_chart;
        private System.Windows.Forms.TabControl _spelling_viewby_tabs;
        private System.Windows.Forms.TabPage _spelling_word_tab;
        private System.Windows.Forms.ListBox _spelling_words_list;
        private System.Windows.Forms.TabPage _spelling_class_tab;
        private System.Windows.Forms.GroupBox _spelling_word_accuracy;
        private System.Windows.Forms.TabPage _spelling_student_tab;
        private System.Windows.Forms.Label _spelling_word_filter_label;
        private System.Windows.Forms.TextBox _spelling_word_filter_textbox;
        private System.Windows.Forms.Label _spelling_word_accuracy_value;
        private System.Windows.Forms.Label _spelling_word_accuracy_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart _spelling_words_time_chart;
        private System.Windows.Forms.GroupBox _spelling_word_letters;
        private System.Windows.Forms.DataVisualization.Charting.Chart _spelling_word_letters_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart _spelling_word_letters_pie;
        private System.Windows.Forms.ComboBox _spelling_word_letters_combo;
        private System.Windows.Forms.Label _spelling_word_letters_label;

    }
}
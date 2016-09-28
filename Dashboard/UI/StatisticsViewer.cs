using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MultiLearn.Data.Log;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiLearn.Dashboard.UI
{
    public partial class StatisticsViewer : Form
    {
        private SqliteLog _log;
        private UserClass[] _classes;
        private LogUser[] _users;
        private MultiMathQuestion[] _mathQuestions;
        private MultiSpellQuestion[] _spellingQuestions;
        private string[] _words;

        private BindingSource _spelling_words_list_binder;

        public StatisticsViewer()
        {
            this._log = new SqliteLog();

            // get most reusable data
            this._classes = (from c in this._log.UserClassSet
                             select c).ToArray();
            this._users = (from u in this._log.LogUserSet
                              select u).ToArray();

            this._mathQuestions = (from q in this._log.MultiMathQuestionSet
                                   select q).ToArray();

            this._spellingQuestions = (from q in this._log.MultiSpellQuestionSet
                                       select q).ToArray();

            this._words = (from q in this._log.MultiSpellQuestionSet
                           group q by q.word
                               into qByWord
                               select qByWord.Key).ToArray();

            InitializeComponent();

            this._spelling_words_list_binder = new BindingSource();
            this._spelling_words_list_binder.DataSource = this._words;
            this._spelling_words_list.DataSource = this._spelling_words_list_binder;

            this.UpdateMathClass();
            this.UpdateSpellingWords();
        }

        private void _math_viewby_tabs_TabIndexChanged(object sender, EventArgs e)
        {
            switch (this._math_viewby_tabs.SelectedIndex)
            {
                // Game math; Viewby class
                case 0:
                    this.UpdateMathClass();
                    break;
            }
        }

        private void _spelling_tabs_TabIndexChanged(object sender, EventArgs e)
        {
            switch (this._spelling_viewby_tabs.TabIndex)
            {
                case 0:
                    this.UpdateSpellingWords();
                    break;
            }
        }

        private void _math_class_classes_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateMathClass();
        }

        private void UpdateMathClass()
        {
            this._math_class_classes_list.DataSource = this._classes;
            this._math_class_classes_list.DisplayMember = "name";

            var mathQuestions = from q in this._mathQuestions
                                join u in this._users on q.user_id equals u.uid
                                where u.class_id == ((UserClass)this._math_class_classes_list.SelectedItem).id
                                select q;

            var accuracy = from q in mathQuestions
                           group q by q.start.Date
                               into qByDate
                               orderby qByDate.Key ascending
                               select new { Date = qByDate.Key, Accuracy = qByDate.Sum(question => (question.correct ?? false) ? 1 : 0) / ((double)qByDate.Count()) * 100 };
            
            BindingSource binder = new BindingSource();
            binder.DataSource = accuracy;

            this.DataBindChart(this._math_class_time_chart, SeriesChartType.Spline, binder, "Date", "Accuracy");

            if (accuracy.Count() == 0)
                this._math_chart_accuracy_value.Text = "N/A";
            else
                this._math_chart_accuracy_value.Text = string.Format("{0}%", accuracy.Last().Accuracy);

            var accuracies = from q in mathQuestions
                             group q by q.user_id
                                 into qByDate
                                 orderby qByDate.Sum(question => (question.correct ?? false) ? 1 : 0) / ((double)qByDate.Count()) ascending
                                 select new { Uid = qByDate.Key, Accuracy = qByDate.Sum(question => (question.correct ?? false) ? 1 : 0) / ((double)qByDate.Count()) * 100 };

            if (accuracies.Count() == 0)
            {
                this._math_class_max_accuracy_value.Text =
                this._math_class_max_accuracy_person.Text =
                this._math_class_min_accuracy_value.Text =
                this._math_class_min_accuracy_person.Text = "N/A";
            }
            else
            {
                this._math_class_max_accuracy_value.Text = string.Format("{0}%", accuracies.Last().Accuracy);
                this._math_class_max_accuracy_person.Text = this._users.First(u => u.uid == accuracies.Last().Uid).name;
                this._math_class_min_accuracy_value.Text = string.Format("{0}%", accuracies.First().Accuracy);
                this._math_class_min_accuracy_person.Text = this._users.First(u => u.uid == accuracies.First().Uid).name;
            }

            var subjects = from q in mathQuestions
                           group q by q.operand
                               into qByOperand
                               select new { Operand = qByOperand.Key, Accuracy = qByOperand.Sum(question => (question.correct ?? false) ? 1 : 0) / ((double)qByOperand.Count()) * 100 };
            
            BindingSource binder2 = new BindingSource();
            binder2.DataSource = subjects;

            this.DataBindChart(this._math_class_problemtype_chart, SeriesChartType.Bar, binder2, "Operand", "Accuracy");
        }

        private void UpdateSpellingWords()
        {
            string word = this._spelling_words_list.Text;
            var spellingQuestions = from q in this._spellingQuestions
                                    where q.word == word
                                    select q;

            var errorRateByDate = from q in this._spellingQuestions
                                  where q.word == word
                                  group q by q.start.Date
                                      into qByDate
                                      select new { Date = qByDate.Key, ErrorRate = qByDate.Sum(question => question.mistakes) / qByDate.Count() };
            BindingSource binder = new BindingSource();
            binder.DataSource = errorRateByDate;

            this.DataBindChart(this._spelling_words_time_chart, SeriesChartType.Spline, binder, "Date", "ErrorRate");

            if (errorRateByDate.Count() == 0)
            {
                this._spelling_word_accuracy_value.Text = "N/A";
            }
            else
            {
                var recentErrorRates = errorRateByDate.Where(e => e.Date > (DateTime.Now - TimeSpan.FromDays(14)));
                this._spelling_word_accuracy_value.Text = recentErrorRates.Average(e => e.ErrorRate).ToString();
            }

            var mistakes = from m in this._log.MultiSpellMistakeSet
                           where m.word == word
                           select m;

            List<KeyValuePair<string, int>> mistakeCountByLetter = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < word.Length; i++)
                mistakeCountByLetter.Add(new KeyValuePair<string, int>(word[i].ToString(), mistakes.Count(m => (m.index == i))));
            BindingSource binder2 = new BindingSource();
            binder2.DataSource = mistakeCountByLetter;

            this.DataBindChart(this._spelling_word_letters_chart, SeriesChartType.Bar, binder2, "Key", "Value");

            this._spelling_word_letters_combo.DataSource = word.ToCharArray();
            this.UpdateSpellingWordsLetters();
        }

        private void _spelling_word_filter_textbox_TextChanged(object sender, EventArgs e)
        {
            string currentSelect = this._spelling_words_list.Text;
            if (!string.IsNullOrEmpty(this._spelling_word_filter_textbox.Text))
                this._spelling_words_list_binder.DataSource = this._words.Where(word => word.Contains(this._spelling_word_filter_textbox.Text.ToLower()));
            else
                this._spelling_words_list_binder.DataSource = this._words;

            this._spelling_words_list_binder.ResetBindings(false);
            if (this._spelling_words_list.Items.Contains(currentSelect))
                this._spelling_words_list.SelectedItem = currentSelect;
            else
                this._spelling_words_list.SelectedIndex = 0;
        }

        private void _spelling_words_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSpellingWords();
        }

        private void _spelling_word_letters_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSpellingWordsLetters();
        }

        private void UpdateSpellingWordsLetters()
        {
            var mistakes = from m in this._log.MultiSpellMistakeSet
                           where (m.word == this._spelling_words_list.Text) && (m.index == this._spelling_word_letters_combo.SelectedIndex)
                           group m by m.attempt
                               into mByAttempt
                               select new { Letter = mByAttempt.Key, Count = mByAttempt.Count() };
            BindingSource binder = new BindingSource();
            binder.DataSource = mistakes;

            this.DataBindChart(this._spelling_word_letters_pie, SeriesChartType.Pie, binder, "Letter", "Count");
        }

        private void DataBindChart(Chart chart, SeriesChartType type, BindingSource binder, string xAxisValueName, string yAxisValueNames)
        {
            chart.Series.Clear();
            chart.Series.Add("data");
            chart.Series["data"].ChartType = type;
            chart.DataSource = binder;
            chart.Series["data"].XValueMember = xAxisValueName;
            chart.Series["data"].YValueMembers = yAxisValueNames;
        }
    }
}

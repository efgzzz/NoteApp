using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения объектов заметок.
        /// </summary>
        private Project _project;

        public MainForm()
        {
            _project = new Project();
            InitializeComponent();          
        }

        /// <summary>
        /// Обновить список заметок.
        /// </summary>
        private void UpdateListBox()
        {
            NoteListBox.Items.Clear();
            foreach (Note note in _project.Notes)
            {
                NoteListBox.Items.Add(note.Title);
            }
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void AddNote()
        {
            Random random = new Random();
            Note note = new Note();
            note.Title = random.Next().ToString();
            note.Text = random.Next().ToString();
            _project.Notes.Add(note);
        }

        /// <summary>
        /// Удалить заметку.
        /// </summary>
        /// <param name="index">Индекс заметки.</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {NoteListBox.SelectedItem.ToString()}?",
                "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {     
                _project.Notes.RemoveAt(index);
                NoteListBox.SelectedItem = null;
            }
            else return;
        }

        /// <summary>
        /// Обновить поле описания заметки.
        /// </summary>
        /// <param name="index">Индекс заметки.</param>
        private void UpdateSelectedNote(int index)
        {
            if (NoteListBox.SelectedItem == null)
            {
                ClearSelectedNote();
                return;
            }
                NoteText.Text = _project.Notes[index].Text;
                NoteName.Text = _project.Notes[index].Title;
                CreationDatePicker.Value = _project.Notes[index].CreateTime;
                ModifedDatePicker.Value = _project.Notes[index].UpdateTime;
                CategoryNameLabel.Text = _project.Notes[index].Category.ToString();
        }

        /// <summary>
        /// Очистить поле описания заметки.
        /// </summary>
        private void ClearSelectedNote()
        {
            NoteText.Text = string.Empty;
            NoteName.Text = string.Empty;
            CreationDatePicker.Value = DateTime.Now;
            ModifedDatePicker.Value = DateTime.Now;
            CategoryNameLabel.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик нажатия кнопки добавления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик изменения выбранной заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedNote(NoteListBox.SelectedIndex);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "About".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Обработчик добавления заметки из меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик нажатия кнопки удаления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote(NoteListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик удаления заметки из меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(NoteListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Выход из приложения через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Close();
        }

        /// <summary>
        /// Обработчик закрытия приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit?",
    "", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

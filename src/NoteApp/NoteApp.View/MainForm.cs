using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreatedStaticLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm newForm = new NoteForm();
            newForm.Show();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifedStaticLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}

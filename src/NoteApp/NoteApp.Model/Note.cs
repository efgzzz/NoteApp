using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Заметка.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Максимальная длина названия.
        /// </summary>
        private int _noteTitleLengthLimit = 50;

        /// <summary>
        /// Стандартное название.
        /// </summary>
        private string _defaultTitle = "Без Названия";

        /// <summary>
        /// Стандартный текст.
        /// </summary>
        private string _defaultText = " ";

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        private DateTime _createTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата обновления.
        /// </summary>
        private DateTime _updateTime { get; set; }

        /// <summary>
        /// Геттер и сеттер названия.
        /// </summary>
        public string Title
        {
            get { return _title; }

            set
            {
                if (value.Length > _noteTitleLengthLimit)
                {
                    throw new ArgumentException();
                }
                if (value == string.Empty)
                {
                    _title = _defaultTitle;
                }

                _title = value;
                _updateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Геттер и сеттер текста.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                _updateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Копирования объекта, интерфейс ICloneable.
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            Note note = new Note();
            note.Title = this.Title;
            note.Text = this.Text;
            note._category = this._category;
            note._createTime = this._createTime;
            note._updateTime = this._updateTime;
            return note;
        }
    }
}

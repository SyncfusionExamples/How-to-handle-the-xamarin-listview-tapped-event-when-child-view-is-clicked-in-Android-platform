using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HandleTappedEvent
{
    public class BookInfo : INotifyPropertyChanged
    {
        #region Fields

        private string bookName;
        private string bookDesc;

        #endregion

        #region Constructor

        public BookInfo()
        {

        }

        #endregion

        #region Properties

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }


        public int bookname
        {
            get;
            set;
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public bool switchVisible;
        public bool SwitchVisible
        {
            get { return switchVisible; }
            set
            {
                switchVisible = value;
                OnPropertyChanged("SwitchVisible");
            }
        }

        public bool indicatorVisible;


        public bool IndicatorVisible
        {
            get { return indicatorVisible; }
            set
            {
                indicatorVisible = value;
                OnPropertyChanged("IndicatorVisible");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}

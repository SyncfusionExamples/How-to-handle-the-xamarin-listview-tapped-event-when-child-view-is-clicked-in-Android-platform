using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HandleTappedEvent
{
    public class BookInfoRepository : INotifyPropertyChanged
    {
        private ObservableCollection<BookInfo> bookInfo;
        private ObservableCollection<BookInfo> newBookInfo;
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties

        public ObservableCollection<BookInfo> BookInfo
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }
        public ObservableCollection<BookInfo> NewBookInfo
        {
            get { return newBookInfo; }
            set { this.newBookInfo = value; }
        }

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public ICommand TapCommand { get; set; }
        public ICommand GestureCommand { get; set; }
        public ICommand ButtonCommand { get; set; }

        #endregion

        #region Constructor

        public BookInfoRepository()
        {
            GenerateBookInfo();
            //GenerateNewBookInfo();
            TapCommand = new Command(tappedcommand);
            GestureCommand = new Command(gestureCommand);
            ButtonCommand = new Command(buttonCommand);
        }

        private void buttonCommand(object obj)
        {
            App.Current.MainPage.DisplayAlert("OOPS", "Button clicked", "OK");
        }

        private void gestureCommand(object obj)
        {
            App.Current.MainPage.DisplayAlert("OOPS", "Grid Tapped", "OK");
        }

        private void tappedcommand(object obj)
        {
            App.Current.MainPage.DisplayAlert("OOPS", "List tapped", "OK");
        }

        #endregion

        #region Properties

        private void GenerateNewBookInfo()
        {
            NewBookInfo = new ObservableCollection<BookInfo>();
            NewBookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning", IndicatorVisible = false, SwitchVisible = true });
            NewBookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm", IndicatorVisible = false, SwitchVisible = true });
            NewBookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions", IndicatorVisible = false, SwitchVisible = true });
        }

        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm" });
            bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" });
            bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            bookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "It is provides a useful overview of the Android application lifecycle" });
            bookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" });
            bookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly" });
            bookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development" });
            bookInfo.Add(new BookInfo() { BookName = "Agile Software Development", BookDescription = "Learning new development processes can be difficult" });
            bookInfo.Add(new BookInfo() { BookName = "Assembly Language", BookDescription = "Assembly language is as close to writing machine code" });
            bookInfo.Add(new BookInfo() { BookName = "Cryptography in .NET", BookDescription = "Cryptography is used throughout software to protect all kinds of information" });
            bookInfo.Add(new BookInfo() { BookName = "Entity Framework Code First", BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode" });
            bookInfo.Add(new BookInfo() { BookName = "Localization for .NET", BookDescription = "Learn to write applications that support different languages and cultures" });
        }

        #endregion
    }
}

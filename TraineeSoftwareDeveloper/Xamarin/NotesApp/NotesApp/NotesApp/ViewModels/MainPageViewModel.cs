using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace NotesApp.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            AllNotes = new ObservableCollection<string>();

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);
                TheNote = string.Empty;
            });

            EraseCommand = new Command(() =>
            {
                TheNote = string.Empty;
                AllNotes.Clear();
            });

            SelectedNoteChangedCommand = new Command(async () =>
            {
                var detailVM = new DetailPageViewModel(SelectedNote);
                var detailPage = new DetailPage
                {
                    BindingContext = detailVM
                };

                await Application.Current.MainPage.Navigation.PushModalAsync(detailPage);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string theNote;
        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote)); // Let the View know that the property has changed...
                PropertyChanged?.Invoke(this, args); // Let the ViewModel know that the property has changed...
            }
        }

        public ObservableCollection<string> AllNotes { get; set; }

        private string selectedNote;
        public string SelectedNote
        {
            get => selectedNote;
            set
            {
                selectedNote = value;
                var args = new PropertyChangedEventArgs(nameof(SelectedNote)); // Let the View know that the property has changed...
                PropertyChanged?.Invoke(this, args); // Let the ViewModel know that the property has changed...
            }
        }

        public Command SelectedNoteChangedCommand { get; }
        public Command SaveCommand { get; set; }
        public Command EraseCommand { get; }
    }
}

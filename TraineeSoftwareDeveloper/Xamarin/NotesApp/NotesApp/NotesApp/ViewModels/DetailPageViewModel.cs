using System.ComponentModel;
using Xamarin.Forms;

namespace NotesApp.ViewModels
{
    class DetailPageViewModel : INotifyPropertyChanged
    {
        public DetailPageViewModel() { }
        public DetailPageViewModel(string note)
        {
            NoteText = note;
            DismissPageCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string noteText;
        public string NoteText
        {
            get => noteText;
            set
            {
                noteText = value;
                var args = new PropertyChangedEventArgs(nameof(NoteText));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command DismissPageCommand { get; }
    }
}

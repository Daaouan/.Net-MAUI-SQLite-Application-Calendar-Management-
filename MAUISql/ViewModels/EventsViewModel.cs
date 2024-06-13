using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MAUISql.Models;
using MAUISql.Data;
using Microsoft.Maui.Controls;

namespace MAUISql.ViewModels
{
    public class EventsViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseContext _context;

        public ObservableCollection<Event> Events { get; set; }
        public Event OperatingEvent { get; set; }
        public ICommand SaveEventCommand { get; }
        public ICommand SetOperatingEventCommand { get; }
        public ICommand DeleteEventCommand { get; }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        private string _busyText;
        public string BusyText
        {
            get => _busyText;
            set
            {
                _busyText = value;
                OnPropertyChanged();
            }
        }

        public EventsViewModel(DatabaseContext context)
        {
            _context = context;
            Events = new ObservableCollection<Event>();
            OperatingEvent = new Event();

            SaveEventCommand = new Command(async () => await SaveEvent());
            SetOperatingEventCommand = new Command<Event>(SetOperatingEvent);
            DeleteEventCommand = new Command<int>(async (id) => await DeleteEvent(id));

            LoadEvents();
        }

        public async void LoadEvents()
        {
            IsBusy = true;
            BusyText = "Loading Events...";
            OnPropertyChanged(nameof(IsBusy));
            OnPropertyChanged(nameof(BusyText));

            var events = await _context.GetAllEventsAsync();
            Events.Clear();
            foreach (var evt in events)
            {
                Events.Add(evt);
            }

            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        private void SetOperatingEvent(Event evt)
        {
            OperatingEvent = evt ?? new Event();
            OnPropertyChanged(nameof(OperatingEvent));
        }

        private async Task SaveEvent()
        {
            if (OperatingEvent.Id == 0)
                await _context.AddEventAsync(OperatingEvent);
            else
                await _context.UpdateEventAsync(OperatingEvent);

            LoadEvents();
            OperatingEvent = new Event();
            OnPropertyChanged(nameof(OperatingEvent));
        }

        private async Task DeleteEvent(int id)
        {
            var evt = await _context.GetEventByIdAsync(id);
            if (evt != null)
                await _context.DeleteEventAsync(evt);

            LoadEvents();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal async Task LoadEventsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

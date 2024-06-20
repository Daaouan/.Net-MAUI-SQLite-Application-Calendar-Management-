using System;
using System.Windows.Input;
using Calendar.Models;
using Calendar.Data;
using CommunityToolkit.Maui.Views;
using Plugin.Maui.Calendar.Models;

namespace Calendar
{
    public partial class AddEventPopup : Popup
    {
        private EventDatabase _eventDatabase;

        public AddEventPopup(EventCollection events, EventDatabase eventDatabase)
        {
            InitializeComponent();
            Events = events;
            _eventDatabase = eventDatabase;
            BindingContext = this;
        }

        public EventCollection Events { get; set; }

        public ICommand SaveEventCommand => new Command(async () =>
        {
            var newEvent = new EventModel
            {
                Name = NameEntry.Text,
                Description = DescriptionEntry.Text,
                Date = DatePicker.Date
            };

            await _eventDatabase.SaveEventAsync(newEvent);

            Events[DatePicker.Date] = new List<EventModel> { newEvent };
        });
    }
}
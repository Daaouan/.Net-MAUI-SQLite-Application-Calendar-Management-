using Calendar.Models;
using SQLite;

namespace Calendar.Data
{
    public class EventDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public EventDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<EventModel>().Wait();
        }

        public Task<List<EventModel>> GetEventsAsync()
        {
            return _database.Table<EventModel>().ToListAsync();
        }

        public Task<EventModel> GetEventAsync(int id)
        {
            return _database.Table<EventModel>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveEventAsync(EventModel eventModel)
        {
            if (eventModel.ID != 0)
            {
                return _database.UpdateAsync(eventModel);
            }
            else
            {
                return _database.InsertAsync(eventModel);
            }
        }

        public Task<int> DeleteEventAsync(EventModel eventModel)
        {
            return _database.DeleteAsync(eventModel);
        }
    }
}
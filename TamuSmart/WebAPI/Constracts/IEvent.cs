using WebAPI.Models;

namespace WebAPI.Constracts
{
    public interface IEvent : ICrud<Event>
    {
        IEnumerable<Event> GetEventsByName(string eventName);
        IEnumerable<Event> GetEventsByDate(string eventDate);
        IEnumerable<Event> GetEventsByLocation(string eventLocation);
    }
}

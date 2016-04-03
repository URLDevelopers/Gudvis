using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gudvis_final
{
    class EventConnection
    {
        string baseAddress = "http://aydurlapi.azurewebsites.net/api/event/";
        APIConnection api = new APIConnection();

        //Get all users on the database without any filter. You should not use this method for anything but pure administrative purposes.
        public List<Event> getAllEvents()
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress).Result;
                });
                task.Start();
                task.Wait();
                List<Event> users = JsonConvert.DeserializeObject<List<Event>>(json);
                return users;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get a user by his username. Returns null if the user does not exist.
        public Event getEventById(string eventID)
        {
            var json = "";
            try
            {
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "byID/" + eventID).Result;
                });
                task.Start();
                task.Wait();
                Event user = JsonConvert.DeserializeObject<Event>(json);
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Event> getEventsByLocation(string location)
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "byLocation/" + location).Result;
                });
                task.Start();
                task.Wait();
                List<Event> events = JsonConvert.DeserializeObject<List<Event>>(json);
                return events;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Event insertNewEvent(Event newEvent)
        {
            try
            {
                string jsonUser = serializeEvent(newEvent);
                string jsonResponse = "";
                Task task = new Task(() =>
                {
                    jsonResponse = api.POSTRequest(baseAddress, jsonUser).Result;
                });
                task.Start();
                task.Wait();
                Event user = JsonConvert.DeserializeObject<Event>(jsonResponse);
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string serializeEvent(Event nevent)
        {
            return JsonConvert.SerializeObject(nevent);
        }
    }
}

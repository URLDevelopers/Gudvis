using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gudvis_final
{
    public class UserConnection
    {
        //Manage users in the database

        string baseAddress = "http://aydurlapi.azurewebsites.net/api/user/";
        APIConnection api = new APIConnection();

        //Get all users on the database without any filter. You should not use this method for anything but pure administrative purposes.
        public List<User> getAllUsers()
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress).Result;
                });
                task.Start();
                task.Wait();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get a user by his username. Returns null if the user does not exist.
        public User getUserByUsername(string username)
        {
            var json = "";
            try
            {
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "byUser/" + username).Result;
                });
                task.Start();
                task.Wait();
                User user = JsonConvert.DeserializeObject<User>(json);
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public User getUserByFBId(string fbID)
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "byFBID/" + fbID).Result;
                });
                task.Start();
                task.Wait();
                User user = JsonConvert.DeserializeObject<User>(json);
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public User insertNewUser(User newUser)
        {
            try
            {
                string jsonUser = serializeUser(newUser);
                string jsonResponse = "";
                Task task = new Task(() =>
                {
                    jsonResponse = api.POSTRequest(baseAddress, jsonUser).Result;
                });
                task.Start();
                task.Wait();
                User user = JsonConvert.DeserializeObject<User>(jsonResponse);
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string serializeUser(User user)
        {
            return JsonConvert.SerializeObject(user);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gudvis_final
{
    class LevelConnection
    {
        string baseAddress = "http://aydurlapi.azurewebsites.net/api/level/";
        APIConnection api = new APIConnection();

        //Get all users on the database without any filter. You should not use this method for anything but pure administrative purposes.
        public List<Level> getAllLevels()
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress).Result;
                });
                task.Start();
                task.Wait();
                List<Level> levels = JsonConvert.DeserializeObject<List<Level>>(json);
                return levels;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get a user by his username. Returns null if the user does not exist.
        public Level getLevel(int levelNumber)
        {
            var json = "";
            try
            {
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + levelNumber.ToString()).Result;
                });
                task.Start();
                task.Wait();
                Level level  = JsonConvert.DeserializeObject<Level>(json);
                return level;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Level insertNewLevel(Level newLevel)
        {
            try
            {
                string jsonUser = serializeLevel(newLevel);
                string jsonResponse = "";
                Task task = new Task(() =>
                {
                    jsonResponse = api.POSTRequest(baseAddress, jsonUser).Result;
                });
                task.Start();
                task.Wait();
                Level level = JsonConvert.DeserializeObject<Level>(jsonResponse);
                return level;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string serializeLevel(Level level)
        {
            return JsonConvert.SerializeObject(level);
        }
    }
}

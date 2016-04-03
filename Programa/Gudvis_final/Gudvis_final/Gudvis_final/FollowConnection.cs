using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gudvis_final
{
    class FollowConnection
    {
        string baseAddress = "http://aydurlapi.azurewebsites.net/api/follow/";
        APIConnection api = new APIConnection();

        //Get all users on the database without any filter. You should not use this method for anything but pure administrative purposes.
        public List<Follow> getAllFollows()
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress).Result;
                });
                task.Start();
                task.Wait();
                List<Follow> follows = JsonConvert.DeserializeObject<List<Follow>>(json);
                return follows;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get a list of users that follow this username. Returns null if the user does not exist.
        public List<User> getAllFollowers(string username)
        {
            var json = "";
            try
            {
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "followers/" + username).Result;
                });
                task.Start();
                task.Wait();
                List<User> followers = JsonConvert.DeserializeObject<List<User>>(json);
                return followers;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get a list of users that are followed by this username. Returns null if the user does not exist.
        public List<User> getAllFollowing(string username)
        {
            var json = "";
            try
            {
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + "following/" + username).Result;
                });
                task.Start();
                task.Wait();
                List<User> followers = JsonConvert.DeserializeObject<List<User>>(json);
                return followers;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Return the follow relation by id. The id is composed by the follower's username, pipe, the followed's username.
        //For example, if user1 is following user2, the id would be "user1|user2" (user1 follows user2 / user2 is followed by user1)
        //You can use this to know if a user is following another user. If you get null it means that user is not following the second user
        public Follow getFollowByID(string follower, string followed)
        {
            try
            {
                var json = "";
                Task task = new Task(() => {
                    json = api.GETRequest(baseAddress + follower + "/" + followed).Result;
                });
                task.Start();
                task.Wait();
                Follow follow = JsonConvert.DeserializeObject<Follow>(json);
                return follow;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Create a new follow relation. If user1 follows user2, you should send ("user1", "user2") as params
        public Follow insertNewFollow(string username_Follower, string username_Followed)
        {
            try
            {
                Follow newFollow = new Follow();
                newFollow.followID = username_Follower + "|" + username_Followed;
                newFollow.user_follower = username_Follower;
                newFollow.user_followed = username_Followed;
                newFollow.pending = false;
                string jsonUser = serializeFollow(newFollow);
                string jsonResponse = "";
                Task task = new Task(() =>
                {
                    jsonResponse = api.POSTRequest(baseAddress, jsonUser).Result;
                });
                task.Start();
                task.Wait();
                Follow follow = JsonConvert.DeserializeObject<Follow>(jsonResponse);
                return follow;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string serializeFollow(Follow follow)
        {
            return JsonConvert.SerializeObject(follow);
        }
    }
}

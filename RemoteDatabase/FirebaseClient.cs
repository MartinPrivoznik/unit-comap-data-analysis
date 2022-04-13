using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Configuration;
using System.Threading.Tasks;
using UnIT_ComAp.Models;

namespace UnIT_ComAp.RemoteDatabase
{
    public class FirebaseClient
    {
        IFirebaseClient _firebaseClient;

        

        public FirebaseClient()
        {
            //Temporarilly hard coded xd
            IFirebaseConfig config = new FirebaseConfig()
            {
                BasePath = "https://unit-comap-db-default-rtdb.europe-west1.firebasedatabase.app/",
                AuthSecret = "2XndXVfoN2PG7jl5i9OfTdMBCJLRW0Wt4v4WUigK"
            };
            
            _firebaseClient = new FireSharp.FirebaseClient(config);

            if (_firebaseClient == null)
                throw new System.Exception("Firebase was not loaded correctly");
        }

        public async Task Insert<T>(T item)
        {
            if(item is Weather)
            {
                await _firebaseClient.PushAsync("Weathers", item);
            }
        }
    }
}

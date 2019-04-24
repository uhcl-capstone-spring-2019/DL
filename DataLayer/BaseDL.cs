using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.DataLayer
{
    public class BaseDL
    {

        protected IFirebaseClient _client;

        public BaseDL()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "br707FFFnL6ppBu1Myo9T28Bknfa8u0xE9fPrYuo",
                BasePath = "https://arfloodsimulator.firebaseio.com/"
            };
            _client = new FirebaseClient(config);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionDB.Interfaces
{
    public class IdbConnect
    {
        interface Idbconnection
        {
            bool Connect();
            bool Disconnect();

            bool Execute(string Query, Dictionary<string, object> Params, bool IsStoredP = false );

            bool GetExecute(string Query, Dictionary<string, object> Params, bool IsStoredP = false);

        }
    }
}

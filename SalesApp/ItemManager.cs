using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class ItemManager
    {
        public static string GetItemName(string id)
        {
            // TODO replace this with database lookup
            switch (id)
            {
                case "0":
                    return "Meds";
                case "1":
                    return "Drugs";
                case "2":
                    return "Bugs";
                default:
                    return "Unknown";
            }
        }

        public static float GetItemPrice(string id)
        {
            // TODO replace this with database lookup
            switch (id)
            {
                case "0":
                    return 0.1f;
                case "1":
                    return 1000f;
                case "2":
                    return 4.5f;
                default:
                    return 0.0f;
            }
        }
    }
}

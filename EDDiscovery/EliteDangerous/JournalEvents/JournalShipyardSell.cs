﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    
  public class JournalShipyardSell : JournalEntry
    {
        //When Written: when selling a ship stored in the shipyard
        //Parameters:
        //•	ShipType: type of ship being sold
        //•	SellShipID
        //•	ShipPrice: sale price
        //•	System: (if ship is in another system) name of system
        public JournalShipyardSell(JObject evt, EDJournalReader reader) : base(evt, JournalTypeEnum.ShipyardSell, reader)
        {
            ShipType = evt.Value<string>("ShipType");
            SellShipId = evt.Value<int>("SellShipID");
            ShipPrice = evt.Value<int>("ShipPrice");
            System = evt.Value<string>("System");
        }
        public string ShipType { get; set; }
        public int SellShipId { get; set; }
        public int ShipPrice { get; set; }
        public string System { get; set; }

    }
}
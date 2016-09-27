﻿using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: when leaving a power
    //Parameters:
    //•	Power
    public class JournalPowerplayLeave : JournalEntry
    {
        public JournalPowerplayLeave(JObject evt) : base(evt, JournalTypeEnum.PowerplayLeave)
        {
            Power = Tools.GetStringDef(evt["Power"]);

        }
        public string Power { get; set; }

    }
}

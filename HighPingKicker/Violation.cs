﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPingKicker {
    internal class Violation {
        public string SteamId { get; set; }
        public string Name { get; set; }
        public int PingFailures { get; set; }
        public int TimesKicked { get; set; }

        public Violation(string steamId, string name) {
            SteamId = steamId;
            Name = name;
            PingFailures = 0;
            TimesKicked = 0;
        }
    }
}

﻿namespace HighPingKicker {
    public class Configuration {
        public int MaxPingAllowed { get; set; } = 200;
        public int FailureThresholdBeforeKick { get; set; } = 2;
        public int AllowedKicksBeforeBan { get; set; } = 2;
        public int HoursBannedAfterKickWarnings { get; set; } = 24;

        public override string ToString() {
            return $"MaxPingAllowed: {MaxPingAllowed}\nFailureThresholdBeforeKick: {FailureThresholdBeforeKick}\nAllowedKicksBeforeBan: {AllowedKicksBeforeBan}\nHoursBannedAfterKickWarnings: {HoursBannedAfterKickWarnings}";
        }
    }
}
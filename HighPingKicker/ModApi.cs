﻿namespace HighPingKicker {
    public class ModApi : IModApi {
        public void InitMod(Mod _modInstance) {
            Service.Load();
            ModEvents.SavePlayerData.RegisterHandler(Service.CheckPing);
        }
    }
}

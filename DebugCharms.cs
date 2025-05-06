using Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DebugCharms {
    public class DebugCharms: Mod {
        new public string GetName() => "DebugCharms";
        public override string GetVersion() => "1.0.0.0";
        internal static DebugCharms instance { get; private set; }

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects) {
            if(instance == null)
                instance = this;
            if(AppDomain.CurrentDomain.GetAssemblies().Select(x => x.GetName().Name).Contains("DebugMod")) {
                AddStuffToDebug();
            }
        }

        private void AddStuffToDebug() {
            DebugMod.DebugMod.AddToKeyBindList(typeof(KeyBinds));
        }
    }
}
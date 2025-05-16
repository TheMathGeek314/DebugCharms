using DebugMod;

namespace DebugCharms {
    public static class KeyBinds {
        //Revert unbreakable charms to fragile
        [BindableMethod(name = "Toggle Unbreakable Heart", category = "Fragile Charms")]
        public static void toggleFHeart() {
            if(PlayerData.instance.fragileHealth_unbreakable) {
                PlayerData.instance.fragileHealth_unbreakable = false;
                Console.AddLine("Unbreakable Heart made fragile");
            }
            else {
                PlayerData.instance.fragileHealth_unbreakable = true;
                PlayerData.instance.brokenCharm_23 = false;
                Console.AddLine("Fragile Heart made unbreakable");
            }
        }

        [BindableMethod(name = "Toggle Unbreakable Greed", category = "Fragile Charms")]
        public static void toggleFGreed() {
            if(PlayerData.instance.fragileGreed_unbreakable) {
                PlayerData.instance.fragileGreed_unbreakable = false;
                Console.AddLine("Unbreakable Greed made fragile");
            }
            else {
                PlayerData.instance.fragileGreed_unbreakable = true;
                PlayerData.instance.brokenCharm_24 = false;
                Console.AddLine("Fragile Greed made unbreakable");
            }
        }

        [BindableMethod(name = "Toggle Unbreakable Strength", category = "Fragile Charms")]
        public static void toggleFStrength() {
            if(PlayerData.instance.fragileStrength_unbreakable) {
                PlayerData.instance.fragileStrength_unbreakable = false;
                Console.AddLine("Unbreakable Strength made fragile");
            }
            else {
                PlayerData.instance.fragileStrength_unbreakable = true;
                PlayerData.instance.brokenCharm_25 = false;
                Console.AddLine("Fragile Strength made unbreakable");
            }
        }

        //break fragile charms
        [BindableMethod(name = "Break Fragile Heart", category = "Fragile Charms")]
        public static void breakFHeart() {
            PlayerData.instance.fragileHealth_unbreakable = false;
            PlayerData.instance.brokenCharm_23 = true;
            Console.AddLine("Fragile Heart broken");
        }

        [BindableMethod(name = "Break Fragile Greed", category = "Fragile Charms")]
        public static void breakFGreed() {
            PlayerData.instance.fragileGreed_unbreakable = false;
            PlayerData.instance.brokenCharm_24 = true;
            Console.AddLine("Fragile Greed broken");
        }

        [BindableMethod(name = "Break Fragile Strength", category = "Fragile Charms")]
        public static void breakFStrength() {
            PlayerData.instance.fragileStrength_unbreakable = false;
            PlayerData.instance.brokenCharm_25 = true;
            Console.AddLine("Fragile Strength broken");
        }

        //Give individual charms
        [BindableMethod(name = "Give Wayward Compass", category = "Give Charms 1")]
        public static void giveCharmCompass() {
            addCharmGeneric(2, "Wayward Compass");
        }

        [BindableMethod(name = "Give Gathering Swarm", category = "Give Charms 1")]
        public static void giveCharmSwarm() {
            addCharmGeneric(1, "Gathering Swarm");
        }

        [BindableMethod(name = "Give Stalwart Shell", category = "Give Charms 1")]
        public static void giveCharmStalwart() {
            addCharmGeneric(4, "Stalwart Shell");
        }

        [BindableMethod(name = "Give Soul Catcher", category = "Give Charms 1")]
        public static void giveCharmCatcher() {
            addCharmGeneric(20, "Soul Catcher");
        }

        [BindableMethod(name = "Give Shaman Stone", category = "Give Charms 1")]
        public static void giveCharmShaman() {
            addCharmGeneric(19, "Shaman Stone");
        }

        [BindableMethod(name = "Give Soul Eater", category = "Give Charms 1")]
        public static void giveCharmEater() {
            addCharmGeneric(21, "Soul Eater");
        }

        [BindableMethod(name = "Give Dashmaster", category = "Give Charms 1")]
        public static void giveCharmDashmaster() {
            addCharmGeneric(31, "Dashmaster");
        }

        [BindableMethod(name = "Give Sprintmaster", category = "Give Charms 1")]
        public static void giveCharmSprintmaster() {
            addCharmGeneric(37, "Sprintmaster");
        }

        [BindableMethod(name = "Give Grubsong", category = "Give Charms 1")]
        public static void giveCharmGrubsong() {
            addCharmGeneric(3, "Grubsong");
        }

        [BindableMethod(name = "Give Grubberfly's Elegy", category = "Give Charms 1")]
        public static void giveCharmElegy() {
            addCharmGeneric(35, "Grubberfly's Elegy");
        }

        [BindableMethod(name = "Give Fragile Heart", category = "Give Charms 2")]
        public static void giveCharmFHeart() {
            string fragile = PlayerData.instance.fragileHealth_unbreakable ? "Unbreakable" : "Fragile";
            addCharmGeneric(23, $"{fragile} Heart");
        }

        [BindableMethod(name = "Give Fragile Greed", category = "Give Charms 2")]
        public static void giveCharmFGreed() {
            string fragile = PlayerData.instance.fragileGreed_unbreakable ? "Unbreakable" : "Fragile";
            addCharmGeneric(24, $"{fragile} Greed");
        }

        [BindableMethod(name = "Give Fragile Strength", category = "Give Charms 2")]
        public static void giveCharmFStrength() {
            string fragile = PlayerData.instance.fragileStrength_unbreakable ? "Unbreakable" : "Fragile";
            addCharmGeneric(25, $"{fragile} Strength");
        }

        [BindableMethod(name = "Give Spell Twister", category = "Give Charms 2")]
        public static void giveCharmTwister() {
            addCharmGeneric(33, "Spell Twister");
        }

        [BindableMethod(name = "Give Steady Body", category = "Give Charms 2")]
        public static void giveCharmSBody() {
            addCharmGeneric(14, "Steady Body");
        }

        [BindableMethod(name = "Give Heavy Blow", category = "Give Charms 2")]
        public static void giveCharmHBlow() {
            addCharmGeneric(15, "Heavy Blow");
        }

        [BindableMethod(name = "Give Quick Slash", category = "Give Charms 2")]
        public static void giveCharmQSlash() {
            addCharmGeneric(32, "Quick Slash");
        }

        [BindableMethod(name = "Give Longnail", category = "Give Charms 2")]
        public static void giveCharmLongnail() {
            addCharmGeneric(18, "Longnail");
        }

        [BindableMethod(name = "Give Mark of Pride", category = "Give Charms 2")]
        public static void giveCharmMop() {
            addCharmGeneric(13, "Mark of Pride");
        }

        [BindableMethod(name = "Give Fury of the Fallen", category = "Give Charms 2")]
        public static void giveCharmFury() {
            addCharmGeneric(6, "Fury of the Fallen");
        }

        [BindableMethod(name = "Give Thorns of Agony", category = "Give Charms 3")]
        public static void giveCharmThorns() {
            addCharmGeneric(12, "Thorns of Agony");
        }

        [BindableMethod(name = "Give Baldur Shell", category = "Give Charms 3")]
        public static void giveCharmBaldur() {
            addCharmGeneric(5, "Baldur Shell");
        }

        [BindableMethod(name = "Give Flukenest", category = "Give Charms 3")]
        public static void giveCharmFlukenest() {
            addCharmGeneric(11, "Flukenest");
        }

        [BindableMethod(name = "Give Defender's Crest", category = "Give Charms 3")]
        public static void giveCharmDCrest() {
            addCharmGeneric(10, "Defender's Crest");
        }

        [BindableMethod(name = "Give Glowing Womb", category = "Give Charms 3")]
        public static void giveCharmWomb() {
            addCharmGeneric(22, "Glowing Womb");
        }

        [BindableMethod(name = "Give Quick Focus", category = "Give Charms 3")]
        public static void giveCharmQFocus() {
            addCharmGeneric(7, "Quick Focus");
        }

        [BindableMethod(name = "Give Deep Focus", category = "Give Charms 3")]
        public static void giveCharmDFocus() {
            addCharmGeneric(34, "Deep Focus");
        }

        [BindableMethod(name = "Give Lifeblood Heart", category = "Give Charms 3")]
        public static void giveCharmLHeart() {
            addCharmGeneric(8, "Lifeblood Heart");
        }

        [BindableMethod(name = "Give Lifeblood Core", category = "Give Charms 3")]
        public static void giveCharmLCore() {
            addCharmGeneric(9, "Lifeblood Core");
        }

        [BindableMethod(name = "Give Joni's Blessing", category = "Give Charms 3")]
        public static void giveCharmJoni() {
            addCharmGeneric(27, "Joni's Blessing");
        }

        [BindableMethod(name = "Give Hiveblood", category = "Give Charms 4")]
        public static void giveCharmHive() {
            addCharmGeneric(29, "Hiveblood");
        }

        [BindableMethod(name = "Give Spore Shroom", category = "Give Charms 4")]
        public static void giveCharmSpore() {
            addCharmGeneric(17, "Spore Shroom");
        }

        [BindableMethod(name = "Give Sharp Shadow", category = "Give Charms 4")]
        public static void giveCharmSShadow() {
            addCharmGeneric(16, "Sharp Shadow");
        }

        [BindableMethod(name = "Give Shape of Unn", category = "Give Charms 4")]
        public static void giveCharmUnn() {
            addCharmGeneric(28, "Shape of Unn");
        }

        [BindableMethod(name = "Give Nailmaster's Glory", category = "Give Charms 4")]
        public static void giveCharmNMG() {
            addCharmGeneric(26, "Nailmaster's Glory");
        }

        [BindableMethod(name = "Give Weaversong", category = "Give Charms 4")]
        public static void giveCharmWeavers() {
            addCharmGeneric(39, "Weaversong");
        }

        [BindableMethod(name = "Give Dream Wielder", category = "Give Charms 4")]
        public static void giveCharmWielder() {
            addCharmGeneric(30, "Dream Wielder");
        }

        [BindableMethod(name = "Give Dreamshield", category = "Give Charms 4")]
        public static void giveCharmDShield() {
            addCharmGeneric(38, "Dreamshield");
        }

        [BindableMethod(name = "Give Grimmchild", category = "Give Charms 4")]
        public static void giveCharmGrimm() {
            addCharmGeneric(40, "Grimmchild");
        }

        [BindableMethod(name = "Give Kingsoul", category = "Give Charms 4")]
        public static void giveCharmKingsoul() {
            PlayerData.instance.royalCharmState = 3;
            PlayerData.instance.gotShadeCharm = false;
            PlayerData.instance.charmCost_36 = 5;
            addCharmGeneric(36, "Kingsoul");
        }

        //Remove individual charms
        [BindableMethod(name = "Remove Wayward Compass", category = "Remove Charms 1")]
        public static void takeCharmCompass() {
            removeCharmGeneric(2, "Wayward Compass");
        }

        [BindableMethod(name = "Remove Gathering Swarm", category = "Remove Charms 1")]
        public static void takeCharmSwarm() {
            removeCharmGeneric(1, "Gathering Swarm");
        }

        [BindableMethod(name = "Remove Stalwart Shell", category = "Remove Charms 1")]
        public static void takeCharmStalwart() {
            removeCharmGeneric(4, "Stalwart Shell");
        }

        [BindableMethod(name = "Remove Soul Catcher", category = "Remove Charms 1")]
        public static void takeCharmCatcher() {
            removeCharmGeneric(20, "Soul Catcher");
        }

        [BindableMethod(name = "Remove Shaman Stone", category = "Remove Charms 1")]
        public static void takeCharmShaman() {
            removeCharmGeneric(19, "Shaman Stone");
        }

        [BindableMethod(name = "Remove Soul Eater", category = "Remove Charms 1")]
        public static void takeCharmEater() {
            removeCharmGeneric(21, "Soul Eater");
        }

        [BindableMethod(name = "Remove Dashmaster", category = "Remove Charms 1")]
        public static void takeCharmDashmaster() {
            removeCharmGeneric(31, "Dashmaster");
        }

        [BindableMethod(name = "Remove Sprintmaster", category = "Remove Charms 1")]
        public static void takeCharmSprintmaster() {
            removeCharmGeneric(37, "Sprintmaster");
        }

        [BindableMethod(name = "Remove Grubsong", category = "Remove Charms 1")]
        public static void takeCharmGrubsong() {
            removeCharmGeneric(3, "Grubsong");
        }

        [BindableMethod(name = "Remove Grubberfly's Elegy", category = "Remove Charms 1")]
        public static void takeCharmElegy() {
            removeCharmGeneric(35, "Grubberfly's Elegy");
        }

        [BindableMethod(name = "Remove Fragile Heart", category = "Remove Charms 2")]
        public static void takeCharmFHeart() {
            string fragile = PlayerData.instance.fragileHealth_unbreakable ? "Unbreakable" : "Fragile";
            removeCharmGeneric(23, $"{fragile} Heart");
        }

        [BindableMethod(name = "Remove Fragile Greed", category = "Remove Charms 2")]
        public static void takeCharmFGreed() {
            string fragile = PlayerData.instance.fragileGreed_unbreakable ? "Unbreakable" : "Fragile";
            removeCharmGeneric(24, $"{fragile} Greed");
        }

        [BindableMethod(name = "Remove Fragile Strength", category = "Remove Charms 2")]
        public static void takeCharmFStrength() {
            string fragile = PlayerData.instance.fragileStrength_unbreakable ? "Unbreakable" : "Fragile";
            removeCharmGeneric(25, $"{fragile} Strength");
        }

        [BindableMethod(name = "Remove Spell Twister", category = "Remove Charms 2")]
        public static void takeCharmTwister() {
            removeCharmGeneric(33, "Spell Twister");
        }

        [BindableMethod(name = "Remove Steady Body", category = "Remove Charms 2")]
        public static void takeCharmSBody() {
            removeCharmGeneric(14, "Steady Body");
        }

        [BindableMethod(name = "Remove Heavy Blow", category = "Remove Charms 2")]
        public static void takeCharmHBlow() {
            removeCharmGeneric(15, "Heavy Blow");
        }

        [BindableMethod(name = "Remove Quick Slash", category = "Remove Charms 2")]
        public static void takeCharmQSlash() {
            removeCharmGeneric(32, "Quick Slash");
        }

        [BindableMethod(name = "Remove Longnail", category = "Remove Charms 2")]
        public static void takeCharmLongnail() {
            removeCharmGeneric(18, "Longnail");
        }

        [BindableMethod(name = "Remove Mark of Pride", category = "Remove Charms 2")]
        public static void takeCharmMop() {
            removeCharmGeneric(13, "Mark of Pride");
        }

        [BindableMethod(name = "Remove Fury of the Fallen", category = "Remove Charms 2")]
        public static void takeCharmFury() {
            removeCharmGeneric(6, "Fury of the Fallen");
        }

        [BindableMethod(name = "Remove Thorns of Agony", category = "Remove Charms 3")]
        public static void takeCharmThorns() {
            removeCharmGeneric(12, "Thorns of Agony");
        }

        [BindableMethod(name = "Remove Baldur Shell", category = "Remove Charms 3")]
        public static void takeCharmBaldur() {
            removeCharmGeneric(5, "Baldur Shell");
        }

        [BindableMethod(name = "Remove Flukenest", category = "Remove Charms 3")]
        public static void takeCharmFlukenest() {
            removeCharmGeneric(11, "Flukenest");
        }

        [BindableMethod(name = "Remove Defender's Crest", category = "Remove Charms 3")]
        public static void takeCharmDCrest() {
            removeCharmGeneric(10, "Defender's Crest");
        }

        [BindableMethod(name = "Remove Glowing Womb", category = "Remove Charms 3")]
        public static void takeCharmWomb() {
            removeCharmGeneric(22, "Glowing Womb");
        }

        [BindableMethod(name = "Remove Quick Focus", category = "Remove Charms 3")]
        public static void takeCharmQFocus() {
            removeCharmGeneric(7, "Quick Focus");
        }

        [BindableMethod(name = "Remove Deep Focus", category = "Remove Charms 3")]
        public static void takeCharmDFocus() {
            removeCharmGeneric(34, "Deep Focus");
        }

        [BindableMethod(name = "Remove Lifeblood Heart", category = "Remove Charms 3")]
        public static void takeCharmLHeart() {
            removeCharmGeneric(8, "Lifeblood Heart");
        }

        [BindableMethod(name = "Remove Lifeblood Core", category = "Remove Charms 3")]
        public static void takeCharmLCore() {
            removeCharmGeneric(9, "Lifeblood Core");
        }

        [BindableMethod(name = "Remove Joni's Blessing", category = "Remove Charms 3")]
        public static void takeCharmJoni() {
            removeCharmGeneric(27, "Joni's Blessing");
        }

        [BindableMethod(name = "Remove Hiveblood", category = "Remove Charms 4")]
        public static void takeCharmHive() {
            removeCharmGeneric(29, "Hiveblood");
        }

        [BindableMethod(name = "Remove Spore Shroom", category = "Remove Charms 4")]
        public static void takeCharmSpore() {
            removeCharmGeneric(17, "Spore Shroom");
        }

        [BindableMethod(name = "Remove Sharp Shadow", category = "Remove Charms 4")]
        public static void takeCharmSShadow() {
            removeCharmGeneric(16, "Sharp Shadow");
        }

        [BindableMethod(name = "Remove Shape of Unn", category = "Remove Charms 4")]
        public static void takeCharmUnn() {
            removeCharmGeneric(28, "Shape of Unn");
        }

        [BindableMethod(name = "Remove Nailmaster's Glory", category = "Remove Charms 4")]
        public static void takeCharmNMG() {
            removeCharmGeneric(26, "Nailmaster's Glory");
        }

        [BindableMethod(name = "Remove Weaversong", category = "Remove Charms 4")]
        public static void takeCharmWeavers() {
            removeCharmGeneric(39, "Weaversong");
        }

        [BindableMethod(name = "Remove Dream Wielder", category = "Remove Charms 4")]
        public static void takeCharmWielder() {
            removeCharmGeneric(30, "Dream Wielder");
        }

        [BindableMethod(name = "Remove Dreamshield", category = "Remove Charms 4")]
        public static void takeCharmDShield() {
            removeCharmGeneric(38, "Dreamshield");
        }

        [BindableMethod(name = "Remove Grimmchild", category = "Remove Charms 4")]
        public static void takeCharmGrimm() {
            removeCharmGeneric(40, "Grimmchild");
        }

        [BindableMethod(name = "Remove Kingsoul", category = "Remove Charms 4")]
        public static void takeCharmKingsoul() {
            string royal = PlayerData.instance.royalCharmState == 4 ? "Void Heart" : "Kingsoul";
            removeCharmGeneric(36, royal);
            PlayerData.instance.royalCharmState = 0;
            PlayerData.instance.gotShadeCharm = false;
        }

        private static void addCharmGeneric(int id, string name) {
            PlayerData.instance.SetBoolInternal("gotCharm_" + id, true);
            PlayerData.instance.hasCharm = true;
            PlayerData.instance.charmsOwned++;
            Console.AddLine($"Added {name} to inventory");
            updateCharmEffects();
        }

        private static void removeCharmGeneric(int id, string name) {
            PlayerData.instance.SetBoolInternal("gotCharm_" + id, false);
            PlayerData.instance.charmsOwned--;
            if(PlayerData.instance.GetBoolInternal("equippedCharm_" + id)) {
                PlayerData.instance.SetBoolInternal("equippedCharm_" + id, false);
                PlayerData.instance.equippedCharms.Remove(id);
            }
            Console.AddLine($"Removed {name} from inventory");
            updateCharmEffects();
        }

        private static void updateCharmEffects() {
            PlayMakerFSM.BroadcastEvent("CHARM INDICATOR CHECK");
            PlayMakerFSM.BroadcastEvent("CHARM EQUIP CHECK");
        }
    }
}
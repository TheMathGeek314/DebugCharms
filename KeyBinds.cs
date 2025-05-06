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
            PlayerData.instance.gotCharm_2 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Wayward Compass to inventory");
        }

        [BindableMethod(name = "Give Gathering Swarm", category = "Give Charms 1")]
        public static void giveCharmSwarm() {
            PlayerData.instance.gotCharm_1 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Gathering Swarm to inventory");
        }

        [BindableMethod(name = "Give Stalwart Shell", category = "Give Charms 1")]
        public static void giveCharmStalwart() {
            PlayerData.instance.gotCharm_4 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Stalwart Shell to inventory");
        }

        [BindableMethod(name = "Give Soul Catcher", category = "Give Charms 1")]
        public static void giveCharmCatcher() {
            PlayerData.instance.gotCharm_20 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Soul Catcher to inventory");
        }

        [BindableMethod(name = "Give Shaman Stone", category = "Give Charms 1")]
        public static void giveCharmShaman() {
            PlayerData.instance.gotCharm_19 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Shaman Stone to inventory");
        }

        [BindableMethod(name = "Give Soul Eater", category = "Give Charms 1")]
        public static void giveCharmEater() {
            PlayerData.instance.gotCharm_21 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Soul Eater to inventory");
        }

        [BindableMethod(name = "Give Dashmaster", category = "Give Charms 1")]
        public static void giveCharmDashmaster() {
            PlayerData.instance.gotCharm_31 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Dashmaster to inventory");
        }

        [BindableMethod(name = "Give Sprintmaster", category = "Give Charms 1")]
        public static void giveCharmSprintmaster() {
            PlayerData.instance.gotCharm_37 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Sprintmaster to inventory");
        }

        [BindableMethod(name = "Give Grubsong", category = "Give Charms 1")]
        public static void giveCharmGrubsong() {
            PlayerData.instance.gotCharm_3 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Grubsong to inventory");
        }

        [BindableMethod(name = "Give Grubberfly's Elegy", category = "Give Charms 1")]
        public static void giveCharmElegy() {
            PlayerData.instance.gotCharm_35 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Grubberfly's Elegy to inventory");
        }

        [BindableMethod(name = "Give Fragile Heart", category = "Give Charms 2")]
        public static void giveCharmFHeart() {
            PlayerData.instance.gotCharm_23 = true;
            string fragile = PlayerData.instance.fragileHealth_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Added {fragile} Heart to inventory");
        }

        [BindableMethod(name = "Give Fragile Greed", category = "Give Charms 2")]
        public static void giveCharmFGreed() {
            PlayerData.instance.gotCharm_24 = true;
            string fragile = PlayerData.instance.fragileGreed_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Added {fragile} Greed to inventory");
        }

        [BindableMethod(name = "Give Fragile Strength", category = "Give Charms 2")]
        public static void giveCharmFStrength() {
            PlayerData.instance.gotCharm_25 = true;
            string fragile = PlayerData.instance.fragileStrength_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Added {fragile} Strength to inventory");
        }

        [BindableMethod(name = "Give Spell Twister", category = "Give Charms 2")]
        public static void giveCharmTwister() {
            PlayerData.instance.gotCharm_33 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Spell Twister to inventory");
        }

        [BindableMethod(name = "Give Steady Body", category = "Give Charms 2")]
        public static void giveCharmSBody() {
            PlayerData.instance.gotCharm_14 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Steady Body to inventory");
        }

        [BindableMethod(name = "Give Heavy Blow", category = "Give Charms 2")]
        public static void giveCharmHBlow() {
            PlayerData.instance.gotCharm_15 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Heavy Blow to inventory");
        }

        [BindableMethod(name = "Give Quick Slash", category = "Give Charms 2")]
        public static void giveCharmQSlash() {
            PlayerData.instance.gotCharm_32 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Quick Slash to inventory");
        }

        [BindableMethod(name = "Give Longnail", category = "Give Charms 2")]
        public static void giveCharmLongnail() {
            PlayerData.instance.gotCharm_18 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Longnail to inventory");
        }

        [BindableMethod(name = "Give Mark of Pride", category = "Give Charms 2")]
        public static void giveCharmMop() {
            PlayerData.instance.gotCharm_13 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Mark of Pride to inventory");
        }

        [BindableMethod(name = "Give Fury of the Fallen", category = "Give Charms 2")]
        public static void giveCharmFury() {
            PlayerData.instance.gotCharm_6 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Fury of the Fallen to inventory");
        }

        [BindableMethod(name = "Give Thorns of Agony", category = "Give Charms 3")]
        public static void giveCharmThorns() {
            PlayerData.instance.gotCharm_12 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Thorns of Agony to inventory");
        }

        [BindableMethod(name = "Give Baldur Shell", category = "Give Charms 3")]
        public static void giveCharmBaldur() {
            PlayerData.instance.gotCharm_5 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Baldur Shell to inventory");
        }

        [BindableMethod(name = "Give Flukenest", category = "Give Charms 3")]
        public static void giveCharmFlukenest() {
            PlayerData.instance.gotCharm_11 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Flukenest to inventory");
        }

        [BindableMethod(name = "Give Defender's Crest", category = "Give Charms 3")]
        public static void giveCharmDCrest() {
            PlayerData.instance.gotCharm_10 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Defender's Crest to inventory");
        }

        [BindableMethod(name = "Give Glowing Womb", category = "Give Charms 3")]
        public static void giveCharmWomb() {
            PlayerData.instance.gotCharm_22 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Glowing Womb to inventory");
        }

        [BindableMethod(name = "Give Quick Focus", category = "Give Charms 3")]
        public static void giveCharmQFocus() {
            PlayerData.instance.gotCharm_7 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Quick Focus to inventory");
        }

        [BindableMethod(name = "Give Deep Focus", category = "Give Charms 3")]
        public static void giveCharmDFocus() {
            PlayerData.instance.gotCharm_34 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Deep Focus to inventory");
        }

        [BindableMethod(name = "Give Lifeblood Heart", category = "Give Charms 3")]
        public static void giveCharmLHeart() {
            PlayerData.instance.gotCharm_8 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Lifeblood Heart to inventory");
        }

        [BindableMethod(name = "Give Lifeblood Core", category = "Give Charms 3")]
        public static void giveCharmLCore() {
            PlayerData.instance.gotCharm_9 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Lifeblood Core to inventory");
        }

        [BindableMethod(name = "Give Joni's Blessing", category = "Give Charms 3")]
        public static void giveCharmJoni() {
            PlayerData.instance.gotCharm_27 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Joni's Blessing to inventory");
        }

        [BindableMethod(name = "Give Hiveblood", category = "Give Charms 4")]
        public static void giveCharmHive() {
            PlayerData.instance.gotCharm_29 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Hiveblood to inventory");
        }

        [BindableMethod(name = "Give Spore Shroom", category = "Give Charms 4")]
        public static void giveCharmSpore() {
            PlayerData.instance.gotCharm_17 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Spore Shroom to inventory");
        }

        [BindableMethod(name = "Give Sharp Shadow", category = "Give Charms 4")]
        public static void giveCharmSShadow() {
            PlayerData.instance.gotCharm_16 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Sharp Shadow to inventory");
        }

        [BindableMethod(name = "Give Shape of Unn", category = "Give Charms 4")]
        public static void giveCharmUnn() {
            PlayerData.instance.gotCharm_28 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Shape of Unn to inventory");
        }

        [BindableMethod(name = "Give Nailmaster's Glory", category = "Give Charms 4")]
        public static void giveCharmNMG() {
            PlayerData.instance.gotCharm_26 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Nailmaster's Glory to inventory");
        }

        [BindableMethod(name = "Give Weaversong", category = "Give Charms 4")]
        public static void giveCharmWeavers() {
            PlayerData.instance.gotCharm_39 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Weaversong to inventory");
        }

        [BindableMethod(name = "Give Dream Wielder", category = "Give Charms 4")]
        public static void giveCharmWielder() {
            PlayerData.instance.gotCharm_30 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Dream Wielder to inventory");
        }

        [BindableMethod(name = "Give Dreamshield", category = "Give Charms 4")]
        public static void giveCharmDShield() {
            PlayerData.instance.gotCharm_38 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Dreamshield to inventory");
        }

        [BindableMethod(name = "Give Grimmchild", category = "Give Charms 4")]
        public static void giveCharmGrimm() {
            PlayerData.instance.gotCharm_40 = true;
            PlayerData.instance.CountCharms();
            Console.AddLine("Added Grimmchild to inventory");
        }

        [BindableMethod(name = "Give Kingsoul", category = "Give Charms 4")]
        public static void giveCharmKingsoul() {
            PlayerData.instance.gotCharm_36 = true;
            if(PlayerData.instance.royalCharmState == 0) {
                PlayerData.instance.royalCharmState = 3;
            }
            string royal = PlayerData.instance.royalCharmState == 4 ? "Void Heart" : "Kingsoul";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Added {royal} to inventory");
        }

        //Remove individual charms
        [BindableMethod(name = "Remove Wayward Compass", category = "Remove Charms 1")]
        public static void takeCharmCompass() {
            PlayerData.instance.gotCharm_2 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Wayward Compass from inventory");
        }

        [BindableMethod(name = "Remove Gathering Swarm", category = "Remove Charms 1")]
        public static void takeCharmSwarm() {
            PlayerData.instance.gotCharm_1 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Gathering Swarm from inventory");
        }

        [BindableMethod(name = "Remove Stalwart Shell", category = "Remove Charms 1")]
        public static void takeCharmStalwart() {
            PlayerData.instance.gotCharm_4 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Stalwart Shell from inventory");
        }

        [BindableMethod(name = "Remove Soul Catcher", category = "Remove Charms 1")]
        public static void takeCharmCatcher() {
            PlayerData.instance.gotCharm_20 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Soul Catcher from inventory");
        }

        [BindableMethod(name = "Remove Shaman Stone", category = "Remove Charms 1")]
        public static void takeCharmShaman() {
            PlayerData.instance.gotCharm_19 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Shaman Stone from inventory");
        }

        [BindableMethod(name = "Remove Soul Eater", category = "Remove Charms 1")]
        public static void takeCharmEater() {
            PlayerData.instance.gotCharm_21 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Soul Eater from inventory");
        }

        [BindableMethod(name = "Remove Dashmaster", category = "Remove Charms 1")]
        public static void takeCharmDashmaster() {
            PlayerData.instance.gotCharm_31 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Dashmaster from inventory");
        }

        [BindableMethod(name = "Remove Sprintmaster", category = "Remove Charms 1")]
        public static void takeCharmSprintmaster() {
            PlayerData.instance.gotCharm_37 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Sprintmaster from inventory");
        }

        [BindableMethod(name = "Remove Grubsong", category = "Remove Charms 1")]
        public static void takeCharmGrubsong() {
            PlayerData.instance.gotCharm_3 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Grubsong from inventory");
        }

        [BindableMethod(name = "Remove Grubberfly's Elegy", category = "Remove Charms 1")]
        public static void takeCharmElegy() {
            PlayerData.instance.gotCharm_35 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Grubberfly's Elegy from inventory");
        }

        [BindableMethod(name = "Remove Fragile Heart", category = "Remove Charms 2")]
        public static void takeCharmFHeart() {
            PlayerData.instance.gotCharm_23 = false;
            string fragile = PlayerData.instance.fragileHealth_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Removed {fragile} Heart from inventory");
        }

        [BindableMethod(name = "Remove Fragile Greed", category = "Remove Charms 2")]
        public static void takeCharmFGreed() {
            PlayerData.instance.gotCharm_24 = false;
            string fragile = PlayerData.instance.fragileGreed_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Removed {fragile} Greed from inventory");
        }

        [BindableMethod(name = "Remove Fragile Strength", category = "Remove Charms 2")]
        public static void takeCharmFStrength() {
            PlayerData.instance.gotCharm_25 = false;
            string fragile = PlayerData.instance.fragileStrength_unbreakable ? "Unbreakable" : "Fragile";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Removed {fragile} Strength from inventory");
        }

        [BindableMethod(name = "Remove Spell Twister", category = "Remove Charms 2")]
        public static void takeCharmTwister() {
            PlayerData.instance.gotCharm_33 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Spell Twister from inventory");
        }

        [BindableMethod(name = "Remove Steady Body", category = "Remove Charms 2")]
        public static void takeCharmSBody() {
            PlayerData.instance.gotCharm_14 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Steady Body from inventory");
        }

        [BindableMethod(name = "Remove Heavy Blow", category = "Remove Charms 2")]
        public static void takeCharmHBlow() {
            PlayerData.instance.gotCharm_15 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Heavy Blow from inventory");
        }

        [BindableMethod(name = "Remove Quick Slash", category = "Remove Charms 2")]
        public static void takeCharmQSlash() {
            PlayerData.instance.gotCharm_32 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Quick Slash from inventory");
        }

        [BindableMethod(name = "Remove Longnail", category = "Remove Charms 2")]
        public static void takeCharmLongnail() {
            PlayerData.instance.gotCharm_18 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Longnail from inventory");
        }

        [BindableMethod(name = "Remove Mark of Pride", category = "Remove Charms 2")]
        public static void takeCharmMop() {
            PlayerData.instance.gotCharm_13 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Mark of Pride from inventory");
        }

        [BindableMethod(name = "Remove Fury of the Fallen", category = "Remove Charms 2")]
        public static void takeCharmFury() {
            PlayerData.instance.gotCharm_6 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Fury of the Fallen from inventory");
        }

        [BindableMethod(name = "Remove Thorns of Agony", category = "Remove Charms 3")]
        public static void takeCharmThorns() {
            PlayerData.instance.gotCharm_12 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Thorns of Agony from inventory");
        }

        [BindableMethod(name = "Remove Baldur Shell", category = "Remove Charms 3")]
        public static void takeCharmBaldur() {
            PlayerData.instance.gotCharm_5 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Baldur Shell from inventory");
        }

        [BindableMethod(name = "Remove Flukenest", category = "Remove Charms 3")]
        public static void takeCharmFlukenest() {
            PlayerData.instance.gotCharm_11 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Flukenest from inventory");
        }

        [BindableMethod(name = "Remove Defender's Crest", category = "Remove Charms 3")]
        public static void takeCharmDCrest() {
            PlayerData.instance.gotCharm_10 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Defender's Crest from inventory");
        }

        [BindableMethod(name = "Remove Glowing Womb", category = "Remove Charms 3")]
        public static void takeCharmWomb() {
            PlayerData.instance.gotCharm_22 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Glowing Womb from inventory");
        }

        [BindableMethod(name = "Remove Quick Focus", category = "Remove Charms 3")]
        public static void takeCharmQFocus() {
            PlayerData.instance.gotCharm_7 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Quick Focus from inventory");
        }

        [BindableMethod(name = "Remove Deep Focus", category = "Remove Charms 3")]
        public static void takeCharmDFocus() {
            PlayerData.instance.gotCharm_34 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Deep Focus from inventory");
        }

        [BindableMethod(name = "Remove Lifeblood Heart", category = "Remove Charms 3")]
        public static void takeCharmLHeart() {
            PlayerData.instance.gotCharm_8 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Lifeblood Heart from inventory");
        }

        [BindableMethod(name = "Remove Lifeblood Core", category = "Remove Charms 3")]
        public static void takeCharmLCore() {
            PlayerData.instance.gotCharm_9 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Lifeblood Core from inventory");
        }

        [BindableMethod(name = "Remove Joni's Blessing", category = "Remove Charms 3")]
        public static void takeCharmJoni() {
            PlayerData.instance.gotCharm_27 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Joni's Blessing from inventory");
        }

        [BindableMethod(name = "Remove Hiveblood", category = "Remove Charms 4")]
        public static void takeCharmHive() {
            PlayerData.instance.gotCharm_29 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Hiveblood from inventory");
        }

        [BindableMethod(name = "Remove Spore Shroom", category = "Remove Charms 4")]
        public static void takeCharmSpore() {
            PlayerData.instance.gotCharm_17 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Spore Shroom from inventory");
        }

        [BindableMethod(name = "Remove Sharp Shadow", category = "Remove Charms 4")]
        public static void takeCharmSShadow() {
            PlayerData.instance.gotCharm_16 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Sharp Shadow from inventory");
        }

        [BindableMethod(name = "Remove Shape of Unn", category = "Remove Charms 4")]
        public static void takeCharmUnn() {
            PlayerData.instance.gotCharm_28 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Shape of Unn from inventory");
        }

        [BindableMethod(name = "Remove Nailmaster's Glory", category = "Remove Charms 4")]
        public static void takeCharmNMG() {
            PlayerData.instance.gotCharm_26 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Nailmaster's Glory from inventory");
        }

        [BindableMethod(name = "Remove Weaversong", category = "Remove Charms 4")]
        public static void takeCharmWeavers() {
            PlayerData.instance.gotCharm_39 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Weaversong from inventory");
        }

        [BindableMethod(name = "Remove Dream Wielder", category = "Remove Charms 4")]
        public static void takeCharmWielder() {
            PlayerData.instance.gotCharm_30 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Dream Wielder from inventory");
        }

        [BindableMethod(name = "Remove Dreamshield", category = "Remove Charms 4")]
        public static void takeCharmDShield() {
            PlayerData.instance.gotCharm_38 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Dreamshield from inventory");
        }

        [BindableMethod(name = "Remove Grimmchild", category = "Remove Charms 4")]
        public static void takeCharmGrimm() {
            PlayerData.instance.gotCharm_40 = false;
            PlayerData.instance.CountCharms();
            Console.AddLine("Removed Grimmchild from inventory");
        }

        [BindableMethod(name = "Remove Kingsoul", category = "Remove Charms 4")]
        public static void takeCharmKingsoul() {
            PlayerData.instance.gotCharm_36 = false;
            string royal = PlayerData.instance.royalCharmState == 4 ? "Void Heart" : "Kingsoul";
            PlayerData.instance.CountCharms();
            Console.AddLine($"Removed {royal} from inventory");
        }
    }
}
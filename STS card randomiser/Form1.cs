using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS_card_randomiser
{
    public partial class Form1 : Form
    {
        //add all cards to their respective arrays
        readonly string[] CommonICards =
            {
                "Anger", "Body Slam", 
                "Clash", "Cleave", 
                "Clothesline", "Headbutt", 
                "Heavy Blade", "Iron Wave", 
                "Perfected Strike", "Pommel Strike", 
                "Sword Boomerang", "Thunderclap", 
                "Twin Strike", "Wild Strike", 
                "Armaments", "Flex", 
                "Havoc", "Shrug It Off", 
                "True Grit", "Warcry"
            };


        readonly string[] CommonSCards =
            {
                "Bane", "Dagger Spray", 
                "Dagger Throw", "Flying Knee", 
                "Poisoned Stab", "Quick Slash", 
                "Slice", "Sneaky Strike", 
                "Sucker Punch", "Acrobatics", 
                "Backflip", "Blade Dance", 
                "Cloak and Dagger", "Deadly Poison", 
                "Deflect", "Dodge and Roll", 
                "Outmaneuver", "Piercing Wail", 
                "Prepared"
            };

        readonly string[] CommonDCards =
            {
                "Ball Lightning", "Barrage", 
                "Beam Cell", "Claw", 
                "Cold Snap", "Compile Driver", 
                "Go for the Eyes", "Rebound", 
                "Streamline", "Sweeping Beam", 
                "Charge Battery", "Coolheaded", 
                "Hologram", "Leap", 
                "Recursion", "Stack", 
                "Steam Barrier", "TURBO",
            };

        readonly string[] CommonWCards =
            {
                "Bowling Bash", "Consecrate", 
                "Crush Joints", "Cut Through Fate", 
                "Empty Fist", "Flurry of Blows", 
                "Flying Sleeves", "Follow-Up", 
                "Just Lucky", "Sash Whip", 
                "Crescendo", "Empty Body", 
                "Evaluate", "Halt", 
                "Pressure Points", "Prostrate", 
                "Protect", "Third Eye", 
                "Tranquility",
            };

        readonly string[] UncommonICards =
            {
                "Blood for Blood", "Carnage", 
                "Dropkick", "Hemokinesis", 
                "Pummel", "Rampage", 
                "Reckless Charge", "Searing Blow", 
                "Sever Soul", "Uppercut", 
                "Whirlwind", "Battle Trance", 
                "Bloodletting", "Burning Pact", 
                "Disarm", "Dual Wield", 
                "Entrench", "Flame Barrier", 
                "Ghostly Armor", "Infernal Blade", 
                "Intimidate", "Power Through", 
                "Rage", "Second Wind", 
                "Seeing Red", "Sentinel", 
                "Shockwave", "Spot Weakness", 
                "Combust", "Dark Embrace", 
                "Evolve", "Feel No Pain", 
                "Fire Breathing", "Inflame", 
                "Metallicize", "Rupture",
            };

        readonly string[] UncommonSCards =
            {
                "All-Out Attack", "Backstab", 
                "Choke", "Dash", 
                "Endless Agony", "Eviscerate", 
                "Finisher", "Flechettes", 
                "Heel Hook", "Masterful Stab", 
                "Predator", "Riddle with Holes", 
                "Skewer", "Blur", 
                "Bouncing Flask", "Calculated Gamble", 
                "Catalyst", "Concentrate", 
                "Crippling Cloud", "Distraction", 
                "Escape Plan", "Expertise", 
                "Leg Sweep", "Reflex", 
                "Setup", "Tactician", 
                "Terror", "Accuracy", 
                "Caltrops", "Footwork", 
                "Infinite Blades", "Noxious Fumes", 
                "Well-Laid Plans",
            };

        readonly string[] UncommonDCards =
            {
                "Blizzard", "Bullseye", 
                "Doom and Gloom", "FTL", 
                "Melter", "Rip and Tear", 
                "Scrape", "Sunder", 
                "Aggregate", "Auto-Shields", 
                "Boot Sequence", "Chaos", 
                "Chill", "Consume", 
                "Darkness", "Double Energy", 
                "Equilibrium", "Force Field",
                "Fusion", "Genetic Algorithm", 
                "Glacier", "Overclock",
                "Recycle", "Reinforced Body", 
                "Reprogram", "Skim", 
                "Tempest", "White Noise", 
                "Capacitor", "Defragment", 
                "Heatsinks", "Hello World", 
                "Loop", "Self Repair", 
                "Static Discharge", "Storm",
            };

        readonly string[] UncommonWCards =
            {
                "Carve Reality", "Conclude", 
                "Fear No Evil", "Reach Heaven", 
                "Sands of Time", "Signature Move", 
                "Talk to the Hand", "Tantrum", 
                "Wallop", "Weave", 
                "Wheel Kick", "Windmill Strike", 
                "Collect", "Deceive Reality",
                "Empty Mind", "Foreign Influence", 
                "Indignation", "Inner Peace", 
                "Meditate", "Perseverance", 
                "Pray", "Sanctity", 
                "Simmering Fury", "Swivel",
                "Wave of the Hand", "Worship",
                "Wreath of Flame", "Battle Hymn",
                "Fasting", "Foresight",
                "Like Water", "Mental Fortress", 
                "Nirvana", "Rushdown",
                "Study",
            };

        readonly string[] UncommonCCards =
            {
                "Dramatic Entrance", "Flash of Steel", 
                "Mind Blast", "Swift Strike", 
                "Bandage Up", "Blind", 
                "Dark Shackles", "Deep Breath", 
                "Discovery", "Enlightenment", 
                "Finesse", "Forethought", 
                "Good Instincts", "Impatience", 
                "Jack of All Trades", "Madness", 
                "Panacea", "Panic Button", 
                "Purity", "Trip",
            };

        readonly string[] RareICards =
            {
                "Bludgeon", "Feed", 
                "Fiend Fire", "Immolate", 
                "Reaper", "Double Tap", 
                "Exhume", "Impervious", 
                "Limit Break", "Offering", 
                "Barricade", "Berserk", 
                "Brutality", "Corruption", 
                "Demon Form", "Juggernaut",
            };

        readonly string[] RareSCards =
            {
                "Die Die Die", "Glass Knife", 
                "Grand Finale", "Unload", 
                "Adrenaline", "Alchemize", 
                "Bullet Time", "Burst", 
                "Corpse Explosion", "Doppelganger", 
                "Malaise", "Nightmare", 
                "Phantasmal Killer", "Storm of Steel",
                "A Thousand Cuts", "After Image",
                "Envenom", "Tools of the Trade", 
                "Wraith Form",
            };

        readonly string[] RareDCards =
            {
                "All for One", "Core Surge", 
                "Hyperbeam", "Meteor Strike", 
                "Thunder Strike", "Amplify", 
                "Fission", "Multi-Cast", 
                "Rainbow", "Reboot", 
                "Seek", "Biased Cognition",
                "Buffer", "Creative AI",
                "Echo Form", "Electrodynamics", 
                "Machine Learning",
            };

        readonly string[] RareWCards =
            {
                "Brilliance", "Lesson Learned", 
                "Ragnarok", "Alpha", 
                "Blasphemy", "Conjure Blade", 
                "Deus Ex Machina", "Judgment", 
                "Omniscience", "Scrawl", 
                "Spirit Shield", "Vault", 
                "Wish", "Deva Form",
                "Devotion", "Establishment", 
                "Master Reality",
            };

        readonly string[] RareCCards =
            {
                "Hand of Greed", "Apotheosis", 
                "Chrysalis", "Master of Strategy", 
                "Metamorphosis", "Secret Technique", 
                "Secret Weapon", "The Bomb", 
                "Thinking Ahead", "Transmutation", 
                "Violence", "Magnetism", 
                "Mayhem", "Panache", 
                "Sadistic Nature",
            };

        readonly string[] SCurseCards =
            {
                "Ascender's Bane", "Clumsy", 
                "Curse of the Bell", "Decay", 
                "Doubt", "Injury", 
                "Necronomicurse", "Normality", 
                "Pain", "Parasite", 
                "Pride", "Regret", 
                "Shame", "Writhe"
            };
        readonly string[] StatusCards =
            {
                "Burn", "Dazed", 
                "Slimed", "Void", 
                "Wound"
            };

        // Creates a Random object  
        static Random rand = new Random();
        // Creates lists of different card rarities to be filled in when the set button is clicked
        List<string> CommonCards = new List<string>();
        List<string> UncommonCards = new List<string>();
        List<string> RareCards = new List<string>();
        List<string> CurseCards = new List<string>();
        List<string> dicechoice = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            // Generate a random index less than the size of the array.
            int index = rand.Next(dicechoice.Count);
            //MessageBox.Show(dicechoice[index]);
            if (dicechoice[index] == "CommonCards")
            {
                // Generate a random index less than the size of the array.
                int index1 = rand.Next(CommonCards.Count);
                // Display outcome to user
                label1.Text = CommonCards[index1];
                label2.Text = "Common";
            }
            else if (dicechoice[index] == "UncommonCards")
            {
                // Generate a random index less than the size of the array.
                int index1 = rand.Next(UncommonCards.Count);
                // Display outcome to user
                label1.Text = UncommonCards[index1];
                label2.Text = "Uncommon";
            }
            else if (dicechoice[index] == "RareCards")
            {
                // Generate a random index less than the size of the array.
                int index1 = rand.Next(RareCards.Count);
                // Display outcome to user
                label1.Text = RareCards[index1];
                label2.Text = "Rare";
            }
            else if (dicechoice[index] == "CurseCards")
            {
                // Generate a random index less than the size of the array.
                int index1 = rand.Next(CurseCards.Count);
                // Display outcome to user
                label1.Text = CurseCards[index1];
                label2.Text = "Curse";
            }
            else if (dicechoice[index] == "Skip")
            {
                
                // Display outcome to user
                label1.Text = "";
                label2.Text = "Skip";
            }
            else 
            {
                MessageBox.Show("Some error occured");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            CommonCards.Clear();
            UncommonCards.Clear();
            RareCards.Clear();
            CurseCards.Clear();
            dicechoice.Clear();

            dicechoice.Add("CommonCards");
            dicechoice.Add("UncommonCards");
            dicechoice.Add("RareCards");
            dicechoice.Add("Skip");

            if (checkBoxIC.Checked == true)
            {
                foreach (string s in CommonICards)
                    CommonCards.Add(s);
                foreach (string s in UncommonICards)
                    UncommonCards.Add(s);
                foreach (string s in RareICards)
                    RareCards.Add(s);
            }
            else { }
            if (checkBoxSilent.Checked == true)
            {
                foreach (string s in CommonSCards)
                    CommonCards.Add(s);
                foreach (string s in UncommonSCards)
                    UncommonCards.Add(s);
                foreach (string s in RareSCards)
                    RareCards.Add(s);
            }
            else { }
            if (checkBoxDefect.Checked == true)
            {
                foreach (string s in CommonDCards)
                    CommonCards.Add(s);
                foreach (string s in UncommonDCards)
                    UncommonCards.Add(s);
                foreach (string s in RareDCards)
                    RareCards.Add(s);
            }
            else { }
            if (checkBoxWatcher.Checked == true)
            {
                foreach (string s in CommonWCards)
                    CommonCards.Add(s);
                foreach (string s in UncommonWCards)
                    UncommonCards.Add(s);
                foreach (string s in RareWCards)
                    RareCards.Add(s);
            }
            else { }
            if (checkBoxColourless.Checked == true)
            {
                foreach (string s in UncommonCCards)
                    UncommonCards.Add(s);
                foreach (string s in RareCCards)
                    RareCards.Add(s);
            }
            else { }
            if (checkBoxCurses.Checked == true)
            {
                dicechoice.Add("CurseCards");
                foreach (string s in SCurseCards)
                    CurseCards.Add(s);
            }
            else { }
            if (checkBoxStatuses.Checked == true)
            {
                if (checkBoxCurses.Checked == false)
                    { dicechoice.Add("CurseCards"); }
                else { }
                foreach (string s in StatusCards)
                    CurseCards.Add(s);
            }
            else { }
        }
    }
}

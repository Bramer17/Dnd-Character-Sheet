using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //********************************
        //Title:D&d character 
        //Author:Payton Bramer
        //Date:4/22/2019
        //********************************

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();

        }

        static void DisplayMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string menuChoice;
            bool exiting = false;
            string Class = null;           
            string Background = null;
            string Race = null;
            string Alignment = null;
            int HitPoint = 0;
            string EquipmentPack = null;
           

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("1) Races");
                Console.WriteLine("2) Classes");
                Console.WriteLine("3) Alignment");
                Console.WriteLine("4) Background");
                Console.WriteLine("5) Equipment");        
                Console.WriteLine("6) Character Sheet");
                Console.WriteLine("E) Exit");
                Console.WriteLine();
                Console.WriteLine("Enter Menu Choice");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Dragonborn();
                        Dwarf();
                        Elf();
                        Gnome();
                        HalfElf();
                        HalfOrc();
                        Halfling();
                        Tiefling();
                        Race = ChooseRace();                       
                        break;
                    case "2":
                        Barbarian();
                        Bard();
                        Cleric();
                        Druid();
                        Fighter();
                        Monk();
                        Paladin();
                        Ranger();
                        Rogue();
                        Sorcerer();
                        Warlock();
                        Wizard();
                        Class = ChooseClass();
                        break;
                    case "3":
                        Alignment = ChooseAlignment();
                        break;
                    case "4":
                        Acolyte();
                        Criminal();
                        FolkHero();
                        Noble();
                        Sage();
                        Soldier();
                        Background = ChooseBackground();
                        break;
                    case "5":
                        EquipmentPack=Equipment(Class);
                        break;                   
                    case "6":
                        CharacterSheet(Class,Background, Race, Alignment, HitPoint, EquipmentPack);
                        break;
                    case "E":
                    case "e":
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            }
        }

        /// <summary>
        /// Describe races abilities
        /// </summary>
        static void Dragonborn()
        {
            DisplayHeader("Races");
            Console.WriteLine();           
            Console.WriteLine("DragonBorn");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Strength score increases by 2, and your Charisma score increases by 1.");           
            Console.WriteLine("Age: Young dragonborn grow quickly.They walk hours after hatching, attain the size and development of");
            Console.WriteLine("a 10 - year - old human child by the age of 3, and reach Adulthood by 15.They live to be around 80.");            
            Console.WriteLine("Alignment: Dragonborn tend to extremes, making a conscious choice for one side or the other in the");
            Console.WriteLine("cosmic war between good and evil. Most dragonborn are good, but those who side with evil can be");
            Console.WriteLine("terrible villains.");           
            Console.WriteLine("Size: Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging");
            Console.WriteLine("almost 250 pounds. Your size is Medium.");           
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");            
            Console.WriteLine("Breath Weapon: You can use your action to exhale destructive energy. Your Draconic ancestry determines");
            Console.WriteLine("the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the");
            Console.WriteLine("area of the exhalation must make a saving throw, the type of which is determined by your Draconic ancestry.");
            Console.WriteLine("The DC for this saving throw equals 8 + your Constitution modifier + your Proficiency Bonus. A creature");
            Console.WriteLine("takes 2d6 damage on a failed save, and half as   much damage on a successful one.The damage increases to");
            Console.WriteLine("3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use");
            Console.WriteLine("it again until you complete a short or Long Rest.");            
            Console.WriteLine("Damage Resistance: You have Resistance to the damage type associated with your Draconic ancestry.");            
            Console.WriteLine("Languages: You can speak, read, and write Common and Draconic.Draconic is thought to be one of the oldest");
            Console.WriteLine(" Languages and is often used in the study of magic.The language sounds harsh to most other creatures and");
            Console.WriteLine("includes numerous hard consonants and sibilants.");
            Console.WriteLine();
            DisplayContinuePrompt();

        }

        static void Dwarf()
        {
            Console.Clear();
            DisplayHeader("Dwarf");
            Console.WriteLine();
            Console.WriteLine("Age: Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50.");
            Console.WriteLine(" On average, they live about 350 years.");            
            Console.WriteLine("Alignment: Most Dwarves are lawful, believing firmly in the benefits of a well - ordered society.They tend toward");
            Console.WriteLine("good as well, with a strong sense of Fair Play and a belief that everyone deserves to share in the benefits");
            Console.WriteLine("of a just order.");            
            Console.WriteLine("Size: Dwarves stand between 4 and 5 feet tall and average about 150 pounds.Your size is Medium.");            
            Console.WriteLine("Speed: Your base walking speed is 25 feet.Your speed is not reduced by wearing Heavy Armor.");          
            Console.WriteLine("Darkvision: Accustomed to life Underground, you have superior vision in dark and dim Conditions.You can see in ");
            Console.WriteLine("dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light.You can’t discern");
            Console.WriteLine("color in Darkness, only shades of gray.");           
            Console.WriteLine("Dwarven Resilience: You have advantage on Saving Throws against poison, and you have Resistance against poison damage.");
            Console.WriteLine("Dwarven Combat Training: You have proficiency with the Battleaxe, Handaxe, Light Hammer, and Warhammer.");           
            Console.WriteLine("Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or");
            Console.WriteLine("mason’s tools.");            
            Console.WriteLine("Stonecunning: Whenever you make an Intelligence(History) check related to the Origin of stonework, you are considered");            
            Console.WriteLine(" proficient in the History skill and add double your Proficiency Bonus to the check, instead of your normal Proficiency Bonus.");            
            Console.WriteLine("Languages: You can speak, read, and write Common and Dwarvish.Dwarvish is full of hard consonants and guttural sounds,");
            Console.WriteLine("and those characteristics spill over into whatever other language a dwarf might speak.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Elf()
        {
            Console.Clear();
            DisplayHeader("Elf");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Dexterity score increases by 2.");
            Console.WriteLine("Age: Although elves reach physical maturity at about the same age as humans, the elven understanding of Adulthood");
            Console.WriteLine("goes beyond physical growth to encompass worldly experience.An elf typically claims Adulthood and an adult name");
            Console.WriteLine("around the age of 100 and can live to be 750 years old.");
            Console.WriteLine("Alignment: Elves love freedom, variety, and self - expression, so they lean strongly toward the gentler aspects");
            Console.WriteLine("of chaos.They value and protect others’ freedom as well as their own, and they are more often good than not.");
            Console.WriteLine("Size: Elves range from under 5 to over 6 feet tall and have slender builds.Your size is Medium.");
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");
            Console.WriteLine("Darkvision: Accustomed to twilit forests and the night sky, you have superior vision in dark and dim Conditions.");
            Console.WriteLine("You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light.");
            Console.WriteLine("You can’t discern color in Darkness, only shades of gray.");
            Console.WriteLine("Keen Senses: You have proficiency in the Perception skill.");
            Console.WriteLine("Fey Ancestry: You have advantage on Saving Throws against being Charmed, and magic can’t put you to sleep.");
            Console.WriteLine("Trance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day.");
            Console.WriteLine("(The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are");
            Console.WriteLine("actually mental exercises that have become reflexive through years of practice. After Resting in this way, you gain ");
            Console.WriteLine("the same benefit that a human does from 8 hours of sleep.");
            Console.WriteLine("Languages: You can speak, read, and write Common and Elvish.Elvish is fluid, with subtle intonations and intricate");
            Console.WriteLine("grammar.");
            Console.WriteLine("Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their");
            Console.WriteLine("language");
            Console.WriteLine("so they can add Elvish ballads to their repertoires.");
            Console.WriteLine();
            DisplayContinuePrompt();
            Console.Clear();
            DisplayHeader("Subrace");
            Console.WriteLine();
            Console.WriteLine("High Elf");
            Console.WriteLine();
            Console.WriteLine("As a High Elf, you have a Keen Mind and a mastery of at least the basics of magic.In many fantasy gaming worlds,");
            Console.WriteLine("there are two kinds of high elves.One type is haughty and reclusive, believing themselves to be superior to non - elves");
            Console.WriteLine("and even other elves.The other type is more Common and more friendly, and often encountered among humans and other races");
            Console.WriteLine("Ability Score Increase: Your Intelligence score increases by 1.");
            Console.WriteLine("Elf Weapon Training⁠: You have proficiency with the Longsword, Shortsword, Shortbow, and Longbow.");
            Console.WriteLine("Cantrip: You know one cantrip of your choice from the Wizard spell list.Intelligence is your Spellcasting ability for it");
            Console.WriteLine("Extra Language⁠: You can speak, read, and write one extra language of your choice.");
            Console.WriteLine();
           DisplayContinuePrompt();
        }

        static void Gnome()
        {
            Console.Clear();
            DisplayHeader("Gnome");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Intelligence score increases by 2.");
            Console.WriteLine("Age: Gnomes mature at the same rate humans do, and most are expected to settle down into an adult life by");
            Console.WriteLine("around age 40.They can live 350 to almost 500 years.");
            Console.WriteLine("Alignment: Gnomes are most often good.Those who tend toward law are sages, engineers, researchers, scholars,");
            Console.WriteLine("investigators, or inventors. Those who tend toward chaos are minstrels, tricksters, wanderers, or fanciful");
            Console.WriteLine("jewelers.Gnomes are good - hearted, and even the tricksters among them are more playful than vicious.");
            Console.WriteLine("Size: Gnomes are between 3 and 4 feet tall and average about 40 pounds.Your size is Small.");
            Console.WriteLine("Speed: Your base walking speed is 25 feet.");
            Console.WriteLine("Darkvision: Accustomed to life Underground, you have superior vision in dark and dim Conditions. You can see");
            Console.WriteLine("in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light.You can’t");
            Console.WriteLine("discern color in Darkness, only shades of gray.");
            Console.WriteLine("Gnome Cunning: You have advantage on all Intelligence, Wisdom, and Charisma Saving Throws against magic.");
            Console.WriteLine("Languages: You can speak, read, and write Common and Gnomish.The Gnomish language, which uses the Dwarvish script,");
            Console.WriteLine("is renowned for its technical treatises and its catalogs of knowledge about the natural world.");
            Console.WriteLine();
            DisplayContinuePrompt();
            Console.Clear();
            DisplayHeader("Subrace");
            Console.WriteLine();
            Console.WriteLine("Rock Gnome");
            Console.WriteLine("As a Rock Gnome, you have a natural inventiveness and hardiness beyond that of other Gnomes.");
            Console.WriteLine("Ability Score Increase: Your Constitution score increases by 1.");
            Console.WriteLine("Artificer’s Lore: Whenever you make an Intelligence(History) check related to Magic Items, alchemical Objects,");
            Console.WriteLine("or technological devices, you can add twice your Proficiency Bonus, instead of any Proficiency Bonus you normally apply.");
            Console.WriteLine("Tinker: You have proficiency with artisan’s tools(tinker’s tools).Using those tools, you can spend 1 hour and");
            Console.WriteLine("10 gp worth of materials to construct a Tiny clockwork device(AC 5, 1 hp).The device ceases to function after 24");
            Console.WriteLine("hours(unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it;");
            Console.WriteLine("at that time, you can reclaim the materials used to create it.You can have up to three such devices active at a time.");
            Console.WriteLine("When you create a device, choose one of the following options:");
            Console.WriteLine("Clockwork Toy: This toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or Soldier.");
            Console.WriteLine("When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction.");
            Console.WriteLine("It makes noises as appropriate to the creature it represents.");
            Console.WriteLine("Fire Starter: The device produces a miniature flame, which you can use to light a Candle, torch, or campfire.");
            Console.WriteLine("Using the device requires your action.");
            Console.WriteLine("Music Box: When opened, this music box plays a single song at a moderate volume. The box stops playing when");
            Console.WriteLine("it reaches the song’s end or when it is closed.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void HalfElf()
        {
            Console.Clear();
            DisplayHeader("Half-Elf");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Charisma score increases by 2, and two other Ability Scores of your choice increase by 1.");
            Console.WriteLine("Age: Half - elves mature at the same rate humans do and reach Adulthood around the age of 20.They live much longer");
            Console.WriteLine("than humans, however, often exceeding 180 years.");
            Console.WriteLine("Alignment: Half - elves share the chaotic bent of their elven heritage. They value both personal freedom and creative");
            Console.WriteLine("expression, demonstrating neither love of leaders nor desire for followers.They chafe at rules, resent others’ demands,");
            Console.WriteLine("and sometimes prove unreliable, or at least unpredictable.");
            Console.WriteLine("Size: Half - elves are about the same size as humans, ranging from 5 to 6 feet tall.Your size is Medium.");
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");
            Console.WriteLine("Darkvision: Thanks to your elf blood, you have superior vision in dark and dim Conditions.You can see in dim light");
            Console.WriteLine("within 60 feet of you as if it were bright light, and in Darkness as if it were dim light.You can’t discern color");
            Console.WriteLine("in Darkness, only shades of gray.");
            Console.WriteLine("Fey Ancestry: You have advantage on Saving Throws against being Charmed, and magic can’t put you to sleep.");
            Console.WriteLine("Skill Versatility: You gain proficiency in two Skills of your choice.");
            Console.WriteLine("Languages: You can speak, read, and write Common, Elvish, and one extra language of your choice.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void HalfOrc()
        {
            Console.Clear();
            DisplayHeader("Half-Orc");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Strength score increases by 2, and your Constitution score increases by 1.");
            Console.WriteLine("Age: Half - Orcs mature a little faster than humans, reaching Adulthood around age 14.They age noticeably faster");
            Console.WriteLine("and rarely live longer than 75 years.");
            Console.WriteLine("Alignment: Half - Orcs inherit a tendency toward chaos from their orc Parents and are not strongly inclined toward");
            Console.WriteLine("good.Half - Orcs raised among orcs and willing to live out their lives among them are usually evil.");
            Console.WriteLine("Size: Half - Orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall.");
            Console.WriteLine("Your size is Medium.");
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");
            Console.WriteLine("Darkvision: Thanks to your orc blood, you have superior vision in dark and dim Conditions.You can see in dim light");
            Console.WriteLine("within 60 feet of you as if it were bright light, and in Darkness as if it were dim light.You can’t discern color in");
            Console.WriteLine("Darkness, only shades of gray.");
            Console.WriteLine("Menacing: You gain proficiency in the Intimidation skill.");
            Console.WriteLine("Relentless Endurance: When you are reduced to 0 Hit Points but not killed outright, you can drop to 1 hit point");
            Console.WriteLine("instead.You can’t use this feature again until you finish a Long Rest.");
            Console.WriteLine("Savage Attacks: When you score a critical hit with a melee weapon Attack, you can roll one of the weapon’s damage");
            Console.WriteLine("dice one additional time and add it to the extra damage of the critical hit.");
            Console.WriteLine("Languages: You can speak, read, and write Common and Orc.Orc is a harsh, grating language with hard consonants.");
            Console.WriteLine("It has no script of its own but is written in the Dwarvish script.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Halfling()
        {
            Console.Clear();
            DisplayHeader("Halfling");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Dexterity score increases by 2.");
            Console.WriteLine("Age: A halfling reaches Adulthood at the age of 20 and generally lives into the middle of his or her second century.");
            Console.WriteLine("Alignment: Most Halflings are lawful good.As a rule, they are good - hearted and kind, hate to see others in pain,");
            Console.WriteLine("and have no tolerance for oppression.They are also very orderly and traditional, leaning heavily on the support of");
            Console.WriteLine("their community and the comfort of their old ways.");
            Console.WriteLine("Size: Halflings average about 3 feet tall and weigh about 40 pounds.Your size is Small.");
            Console.WriteLine("Speed: Your base walking speed is 25 feet.");
            Console.WriteLine("Lucky: When you roll a 1 on The D20 for an Attack roll, ability check, or saving throw, you can reroll the die and");
            Console.WriteLine("must use the new roll.");
            Console.WriteLine("Brave: You have advantage on Saving Throws against being Frightened.");
            Console.WriteLine("Halfling Nimbleness: You can move through the space of any creature that is of a size larger than yours.");
            Console.WriteLine("Languages: You can speak, read, and write Common and Halfling.The Halfling language isn’t Secret, but Halflings are");
            Console.WriteLine("loath to share it with others.They write very little, so they don’t have a rich body of literature.Their oral tradition,");
            Console.WriteLine("however, is very strong. Almost all Halflings speak Common to converse with the people in whose lands they dwell or ");
            Console.WriteLine("through which they are traveling.");
            Console.WriteLine();
            DisplayContinuePrompt();
            Console.Clear();
            DisplayHeader("Subrace");
            Console.WriteLine();
            Console.WriteLine("Lightfoot");
            Console.WriteLine("As a Lightfoot Halfling, you can easily hide from notice, even using other people as cover.You’re inclined to be affable");
            Console.WriteLine("and get along well with others.Lightfoots are more prone to wanderlust than other Halflings, and often dwell alongside");
            Console.WriteLine("other races or take up a nomadic life.");
            Console.WriteLine("Ability Score Increase: Your Charisma score increases by 1.");
            Console.WriteLine("Naturally Stealthy: You can attempt to hide even when you are obscured only by a creature that is at least one size");
            Console.WriteLine("larger than you.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Tiefling()
        {
            Console.Clear();
            DisplayHeader("Tiefling");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Intelligence score increases by 1, and your Charisma score increases by 2.");
            Console.WriteLine("Age: Tieflings mature at the same rate as humans but live a few years longer.");
            Console.WriteLine("Alignment: Tieflings might not have an innate tendency toward evil, but many of them end up there.");
            Console.WriteLine("Evil or not, an independent Nature inclines many tieflings toward a chaotic Alignment.");
            Console.WriteLine("Size: Tieflings are about the same size and build as humans.Your size is Medium.");
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");
            Console.WriteLine("Darkvision: Thanks to your Infernal heritage, you have superior vision in dark and dim Conditions.");
            Console.WriteLine("You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were");
            Console.WriteLine("dim light.You can’t discern color in Darkness, only shades of gray.");
            Console.WriteLine("Hellish Resistance: You have Resistance to fire damage.");
            Console.WriteLine("Infernal Legacy. You know the Thaumaturgy cantrip.When you reach 3rd level, you can cast the Hellish");
            Console.WriteLine("Rebuke spell as a 2nd - level spell once with this trait and regain the ability to do so when you finish");
            Console.WriteLine("a Long Rest. When you reach 5th level, you can cast the Darkness spell once with this trait and regain the");
            Console.WriteLine("ability to do so when you finish a Long Rest. Charisma is your Spellcasting ability for these Spells.");
            Console.WriteLine("Languages: You can speak, read, and write Common and Infernal.");
            Console.WriteLine();
            DisplayContinuePrompt();

        }

        static void Human()
        {
            Console.Clear();
            DisplayHeader("Human");
            Console.WriteLine();
            Console.WriteLine("Ability Score Increase: Your Ability Scores each increase by 1.");
            Console.WriteLine("Age: Humans reach Adulthood in their late teens and live less than a century.");
            Console.WriteLine("Alignment: Humans tend toward no particular Alignment.The best and the worst are found among them.");
            Console.WriteLine("Size: Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall.");
            Console.WriteLine("Regardless of your position in that range, your size is Medium.");
            Console.WriteLine("Speed: Your base walking speed is 30 feet.");
            Console.WriteLine("Languages: You can speak, read, and write Common and one extra language of your choice.");
            Console.WriteLine("Humans typically learn the Languages of other peoples they deal with, including obscure dialects.");
            Console.WriteLine("They are fond of sprinkling their Speech with words borrowed from other tongues: Orc curses, Elvish");
            Console.WriteLine("musical expressions, Dwarvish military phrases, and so on.");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static string ChooseRace()
        {
            string Race = null;
            Console.Clear();
            bool exiting = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("The races are: Dragonborn,Dwarf, Elf, High Elf, Gnome, Rock Gnome, Half Elf, Half Orc, Halfling,Lightfoot, Human,");
                Console.WriteLine("Tiefling");
                Console.WriteLine();
                Console.Write("Choose a Race:");
                Race = Console.ReadLine();           
                switch (Race)
                {
                    case "Dragonborn":
                        exiting = true;
                        break;
                    case "Dwarf":
                        exiting = true;
                        break;
                    case "Elf":
                        exiting = true;
                        break;
                    case "High Elf":
                        exiting = true;
                        break;
                    case "Gnome":
                        exiting = true;
                        break;
                    case "Rock Gnome":
                        exiting = true;
                        break;
                    case "Half Elf":
                        exiting = true;
                        break;
                    case "Half Orc":
                        exiting = true;
                        break;
                    case "Halfling":
                        exiting = true;
                        break;
                    case "Lightfoot":
                        exiting = true;
                        break;
                    case "Human":
                        exiting = true;
                        break;
                    case "Tiefling":
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine("Please give a valid race");
                        exiting = false;
                        break;
                }

            } while (!exiting);

            DisplayContinuePrompt();
            return Race;
        }

        static void Barbarian()
        {
            DisplayHeader("Barbarian");
            Console.WriteLine("Hit Dice 1d12");
            Console.WriteLine("Armors:Light armor, medium armor, shields");
            Console.WriteLine("Weapons Proficiency: Simple weapons, martial weapons");
            Console.WriteLine("Saving Throws:Strength, Constitution");
            Console.WriteLine("Skills: 2 from Athletics, Animal Handling, Intimidation, Nature, Perception, Survival");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Bard()
        {
            DisplayHeader("Bard");
            Console.WriteLine("Hit Dice: 1d8");
            Console.WriteLine("Armors Proficiency: Light armor");
            Console.WriteLine("Weapons Proficiency: Simple weapons, hand crossbow, longsword, shortsword, rapier");
            Console.WriteLine("Tools get 3 musical instruments");
            Console.WriteLine("Saving Throws: Dexterity, Charisma");
            Console.WriteLine("Skills: 3 from Acrobatics, Arcana, Athletics, Stealth, Animal Handling, Sleight of Hand, History,");
            Console.WriteLine("Intimidation, Insight, Investigation, Medicine, Nature, Perception, Persuasion, Religion,");
            Console.WriteLine("Performance,");
            Console.WriteLine("Survival, Deception");
            Console.WriteLine();
            DisplayContinuePrompt();

        }

        static void Cleric()
        {
            DisplayHeader("Cleric");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d8");
            Console.WriteLine("Armors proficiency: Light armor, medium armor, shields");
            Console.WriteLine("Weapon profocoency: Simple weapons");
            Console.WriteLine("Saving Throws: Wisdom, Charisma");
            Console.WriteLine("Skills: 2 from History, Insight, Medicine, Persuasion, Religion");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Druid()
        {
            DisplayHeader("Druid");
            Console.WriteLine();
            Console.WriteLine("Hit dice: 1d8");
            Console.WriteLine("Armors proficiency:Light armor, medium armor, shields");
            Console.WriteLine("Weapons proficiency: Club, dagger, dart, javelin, mace, quarterstaff, scimitar, sickle, sling, spear");
            Console.WriteLine("Tools:Herbalism kit");
            Console.WriteLine("Saving Throws: Intelligence, Wisdom");
            Console.WriteLine("Skills: 2 from Arcana, Animal Handling, Insight, Medicine, Nature, Perception, Religion, Survival");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Fighter()
        {
            DisplayHeader("Fighter");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d10");
            Console.WriteLine("Armors proficiency: All armor, shields");
            Console.WriteLine("Weapon proficiencies: Simple weapons, martial weapons");
            Console.WriteLine("Saving Throws: Strength, Constitution");
            Console.WriteLine("Skills: 2 from Acrobatics, Athletics, Animal Handling, History, Intimidation, Insight, Perception, Survival");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Monk()
        {
            DisplayHeader("Monk");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d8");
            Console.WriteLine("Weapon proficiencies: Simple weapons, shortsword");
            Console.WriteLine("Tools:Artisan's tools");
            Console.WriteLine("Saving Throws: Strength, Dexterity");
            Console.WriteLine("Skills: 2 from Acrobatics, Athletics, Stealth, History, Insight, Religion");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Paladin()
        {
            DisplayHeader("Paladin");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d10");
            Console.WriteLine("Armor proficiencies: All armor, shields");
            Console.WriteLine("Weapon proficiencies: Simple weapons, martial weapons");
            Console.WriteLine("Saving Throws:Wisdom, Charisma");
            Console.WriteLine("Skills: 2 from Athletics, Intimidation, Insight, Medicine, Persuasion, Religion");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Ranger()
        {
            DisplayHeader("Ranger");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d10");
            Console.WriteLine("Armor proficiencies:Light armor, medium armor, shields");
            Console.WriteLine("Weapon proficiencies: Simple weapons, martial weapons");
            Console.WriteLine("Saving Throws: Strength, Dexterity");
            Console.WriteLine("Skill:2 from Athletics, Stealth, Animal Handling, Insight, Investigation, Nature, Perception, Survival");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Rogue()
        {
            DisplayHeader("Rogue");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d8");
            Console.WriteLine("Armor proficiencies:Light armor");
            Console.WriteLine("Weapon proficiencies:Simple weapons, hand crossbow, shortsword, longsword, rapier, shortbow");
            Console.WriteLine("Tools:Thieves' tools");
            Console.WriteLine("Saving Throws: Dexterity, Intelligence");
            Console.WriteLine("Skills: 4 from Acrobatics, Athletics, Stealth, Sleight of Hand, Intimidation, Insight,");
            Console.WriteLine("Investigation, Perception, Persuasion, Performance, Deception");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Sorcerer()
        {
            DisplayHeader("Sorcerer");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d6");
            Console.WriteLine("Weapon proficiencies:Dagger, dart, sling, quarterstaff, light Crossbow");
            Console.WriteLine("Saving Throws: Constitution, Charisma");
            Console.WriteLine("Skills: 2 from Arcana, Intimidation, Insight, Persuasion, Religion, Deception");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Warlock()
        {
            DisplayHeader("Warlock");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d8");
            Console.WriteLine("Armor proficiencies: Light armor");
            Console.WriteLine("Weapon proficiencies: Simple weapons");
            Console.WriteLine("Saving Throws:Wisdom, Charisma");
            Console.WriteLine("Skills: 2 from Arcana, History, Intimidation, Investigation, Nature, Religion, Deception");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Wizard()
        {
            DisplayHeader("Wizard");
            Console.WriteLine();
            Console.WriteLine("Hit Dice: 1d6");
            Console.WriteLine("Weapon proficiencies:Dagger, dart, sling, quarterstaff, light Crossbow");
            Console.WriteLine("Saving Throws:Intelligence, Wisdom");
            Console.WriteLine("Skills: 2 from Arcana, History, Insight, Investigation, Medicine, Religion");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static string ChooseClass()
        {
            string Class;
            Console.Clear();
            bool exiting = true;

            do
            {
                Console.WriteLine("The classes are: Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rogue,");
                Console.WriteLine("Sorcerer, Warlock, Wizard");
                 Console.Write("Choose a Class:");
                 Class = Console.ReadLine();
                switch (Class)
                {
                    case "Barbarian":
                        exiting = true;
                        break;
                    case "Bard":
                        exiting = true;
                        break;
                    case "Cleric":
                        exiting = true;
                        break;
                    case "Druid":
                        exiting = true;
                        break;
                    case "Fighter":
                        exiting = true;
                        break;
                    case "Monk":
                        exiting = true; ;
                        break;
                    case "Paladin":
                        exiting = true;
                        break;
                    case "Ranger":
                        exiting = true;
                        break;
                    case "Rogue":
                        exiting = true;
                        break;
                    case "Sorcerer":
                        exiting = true;
                        break;
                    case "Warlock":
                        exiting = true;
                        break;
                    case "Wizard":
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine("Please give a valid Class");
                        Console.WriteLine();
                        exiting = false;
                        break;
                }

            } while (!exiting);

            DisplayContinuePrompt();
            return Class;
        }

        static void Acolyte()
        {
            DisplayHeader("Acolyte");
            Console.WriteLine("Skill Proficiencies: Insight, Religion");
            Console.WriteLine("Languages: 2");
            Console.WriteLine("Feature.Shelter of the Faithful");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Criminal()
        {
            DisplayHeader("Criminal");
            Console.WriteLine("Skill Proficiencies:Deception, Stealth");
            Console.WriteLine("Tool Proficiencies:Gaming set, thieves' tools");
            Console.WriteLine("Feature.Criminal Contact");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void FolkHero()
        {
            DisplayHeader("Folk Hero");
            Console.WriteLine("Skill Proficiencies:Animal Handling, Survival");
            Console.WriteLine("Tool Proficiencies:Artisan's tools, vehicles (land)");
            Console.WriteLine("Feature: Rustic Hospitality");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Noble()
        {
            DisplayHeader("Noble");
            Console.WriteLine("Skill Proficiencies: History, Persuasion");
            Console.WriteLine("Languages: 1");
            Console.WriteLine("Tool Proficiencies:Gaming set");
            Console.WriteLine("Feature: Position of Privilege");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Sage()
        {
            DisplayHeader("Sage");
            Console.WriteLine("Skill Proficiencies: Arcana, History");
            Console.WriteLine("Languages: 2");
            Console.WriteLine("Feature:Researcher");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static void Soldier()
        {
            DisplayHeader("Soldier");
            Console.WriteLine("Skill Proficiencies: Athletics, Intimidation");
            Console.WriteLine("Tool Proficiencies:Gaming set, vehicles(land)");
            Console.WriteLine("Feature.Military Rank");
            Console.WriteLine();
            DisplayContinuePrompt();
        }

        static string ChooseBackground()
        {
            string Background;
            Console.Clear();
            bool exiting = true;
            do
            {
                Console.WriteLine("The backgrounds are: Acolyte, Criminal, FolkHero, Noble, Sage, and Soldier");
                Console.Write("Choose a Background:");
                Background = Console.ReadLine();                
                switch (Background)
                {
                    case "Acolyte":
                        exiting = true;
                        break;
                    case "Criminal":
                        exiting = true;
                        break;
                    case "FolkHero":
                        exiting = true;
                        break;
                    case "Noble":
                        exiting = true;
                        break;
                    case "Sage":
                        exiting = true;
                        break;
                    case "Soldier":
                        exiting = true; ;
                        break;                 
                    default:
                        Console.WriteLine("Please give a valid Background");
                        Console.WriteLine();
                        exiting = false;
                        break;
                }

            } while (!exiting);

            DisplayContinuePrompt();
            return Background;

        }

        static string ChooseAlignment()
        {
            string Alignment;
            bool exiting = true;

            DisplayHeader("Alignment");

            do
            {
                Console.WriteLine("Lawful good, Neutral good, Chaotic good, Lawful neutral, Neutral, Chaotic neutral");
                Console.WriteLine("Lawful evil, Neutral evil, Chaotic evil");
                Console.Write("Choose an Alignment:");
                 Alignment = Console.ReadLine();
                switch (Alignment)
                {
                    case "Lawful good":
                        exiting = true;
                        break;
                    case "Neutral good":
                        exiting = true;
                        break;
                    case "Chaotic good":
                        exiting = true;
                        break;
                    case "Lawful neutral":
                        exiting = true;
                        break;
                    case "Neutral":
                        exiting = true;
                        break;
                    case "Chaotic neutral":
                        exiting = true;
                        break;
                    case "Lawful evil":
                        exiting = true;
                        break;
                    case "Neutral evil":
                        exiting = true;
                        break;
                    case "Chaotic evil":
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine("Please choose one of the allignments above");
                        exiting = false;
                        break;
                }
            } while (!exiting);
            
           
            return Alignment;
        }

        static int AbilityScores()
        {
            Random rnd = new Random();
            int Strength = rnd.Next(4, 18);
            int Dexterity = rnd.Next(4, 18);
            int Constitution = rnd.Next(4, 18);
            int Intelligence = rnd.Next(4, 18);
            int Wisdom = rnd.Next(4, 18);
            int Charisma = rnd.Next(4, 18);
            Console.WriteLine($"Strength:{Strength}");
            Console.WriteLine($"Dexterity:{Dexterity}");
            Console.WriteLine($"Constitution:{Constitution}");
            Console.WriteLine($"Intelligence:{Intelligence}");
            Console.WriteLine($"Wisdom:{Wisdom}");
            Console.WriteLine($"Charisma:{Charisma}");
            
            return Constitution;
        }

        static int ModifierScore(int Constitution)
        {
            int Modifier = 0;

            if (Constitution== 4 || Constitution== 5)
            {
                Modifier = -3;               
            }
            else if (Constitution== 6 || Constitution == 7)
            {
                Modifier = -2;                
            }
            else if (Constitution == 8 || Constitution == 9)
            {
                Modifier = -1;               
            }
            else if (Constitution == 10 || Constitution ==11)
            {
                Modifier = 0;                
            }
            else if (Constitution == 12 || Constitution == 13)
            {
                Modifier = 1;
                
            }
            else if (Constitution == 14 || Constitution == 15)
            {
                Modifier = 2;                
            }
            else if (Constitution == 16 || Constitution == 17)
            {
                Modifier = 3;               
            }
            else if (Constitution == 18)
            {
                Modifier = 4;                
            }          
           

            return Modifier;             
        }

        static int HitPoints(string Class, int Modifier)
        {
            Random rnd = new Random();
            int Point;
            int HitPoint = 0;
            if (Class=="Barbarian")
            {
                Point = rnd.Next(1, 12);
                HitPoint = Point + Modifier;                
                Console.WriteLine($"Total Hitpoints:{HitPoint}");
            }
            else if (Class=="Fighter"|| Class=="Paladin" || Class=="Ranger")
            {
                Point = rnd.Next(1, 10);
                HitPoint = Point + Modifier;
                Console.WriteLine($"Hitpoints:{HitPoint}");
            }
            else if (Class=="Bard" || Class=="Cleric" || Class=="Druid" || Class=="Monk" || Class=="Warlock" || Class=="Rogue")
            {
                Point = rnd.Next(1, 8);
                HitPoint = Point + Modifier;
                Console.WriteLine($"Hitpoints:{HitPoint}");
            }
            else if (Class=="Sorcerer" || Class=="Wizard")
            {
                Point = rnd.Next(1, 6);
                HitPoint = Point + Modifier;
                Console.WriteLine($"Hitpoints:{HitPoint}");
            }
            else
            {
                Console.WriteLine("Please go back and pick a race and class");
            }            
            
            return HitPoint;
        }

        static string Equipment(string Class)
        {
            string EquipmentPack = null;

            Console.Clear();
            DisplayHeader("Equipment");
            switch (Class)
            {
                case "Barbarian":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has a greataxe, two handaxes, four javelins, and an explorers pack");
                    Console.WriteLine("B has a melee weapon, a simple weapon, four javelin, and an explorers pack");
                    Console.WriteLine("Would you Like Pack A or B");
                    EquipmentPack = Console.ReadLine();                   
                    break;
                case "Bard":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has a rapier, a diplomats pack, a lute, leather armor, and a dagger");
                    Console.WriteLine("B has a longsword, an entertainers pack, a musical instrument, Leather armor, and a dagger");
                    Console.WriteLine("Would you Like Pack A or B");
                    EquipmentPack = Console.ReadLine();                    
                    break;
                case "Cleric":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: a mace, scale mail, a light crossbow with 20 bolts, a priests pack, a shield, and a holy symbol");
                    Console.WriteLine("B has: a warhammer, leather armor, a simple weapon,an explorers pack, a shield, and a holy symbol");
                    Console.WriteLine("Would you Like Pack A or B");
                    EquipmentPack = Console.ReadLine();                    
                    break;
                case "Druid":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: a wooden shield, a scimitar, leather armor, an explorers pack, and a druidic focus");
                    Console.WriteLine("B has: a simple weapon, a simple melee weapon,leather armor, an explorers pack, and a druidic focus");
                    Console.WriteLine("Would you Like Pack A or B");
                    EquipmentPack = Console.ReadLine();                    
                    break;
                case "Fighter":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A Has: chain mail, a martial weapon and shield, light crossbow with 20 bolts, and dungeoneers pack");
                    Console.WriteLine("B has: leather armor, longbow with 20 arrows, two martial weapons, two handaxes, and an explorers pack");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();                  
                    break;
                case "Monk":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: shortsword, dungeoneers pack, 10 darts");
                    Console.WriteLine("B has: simple weapon, explorer's pack, 10 darts");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;
                case "Paladin":                    
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: a martial weapon and shield, five javelin, a priests pack, chain mail, and holy symbol");
                    Console.WriteLine("B has: two martial weapons, simple weapon, explorers pack, chain mail, and holy symbol");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();                   
                    break;
                case "Ranger":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: scale mail, two shortswords, a dungeoneers pack, a longbow, quiver, and 20 arrows");
                    Console.WriteLine("B has: leather armor, two simple melee weapons, explorers pack, a longbow, quiver, and 20 arrows");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;
                case "Rogue":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: Rapier, shortbow, quiver, 20 arrows, burglars pack, leather armor, two daggers, thieves tools");
                    Console.WriteLine("B has: two shortsword, dungeoneers pack,  leather armor, two daggers, thieves tools");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;
                case "Sorcerer":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has:light crossbow, 20 bolts, component pouch, duneoneers pack, and two daggers");
                    Console.WriteLine("B has: a simple weapon, arcane focus, explorers pack, and two daggers");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;
                case "Warlock":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: light crossbow, 20 bolts, component pouch, scholars pack, leather armor, simple weapon, and two daggers.");
                    Console.WriteLine("B has: two simple weapon, arcane focus, dungeoneer's pack, leather armor, and two daggers");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;
                case "Wizard":
                    Console.WriteLine("You get to pick between equipment Pack A or Equipment Pack B");
                    Console.WriteLine("A has: quarterstaff, component pouch, scholars pack, and a spellbook");
                    Console.WriteLine("B has: dagger, arcane focus, explorers pouch, and a spellbook");
                    Console.WriteLine("Would you Like Pack A or B ?");
                    EquipmentPack = Console.ReadLine();
                    break;                    
                default:
                    Console.WriteLine("Please go back and pick a race and class");
                    break;
            }
            DisplayContinuePrompt();
            return EquipmentPack;
        }

        static void CharacterSheet(string Class, string Background, string Race, string Alignment, int HitPoint, string EquipmentPack)
        {
            int Constitution = 0;
            int Modifier;
            
            Console.Clear();
            DisplayHeader("Character Sheet");
            Console.WriteLine($"Race:{Race}");           
            Console.WriteLine($"Class:{Class}");           
            Console.WriteLine($"Alignment:{Alignment}");                  
            Console.WriteLine($"Background:{Background}");
            Console.WriteLine();
            Console.WriteLine("Ability Scores");
            Constitution = AbilityScores();
            Console.WriteLine();
            Modifier = ModifierScore(Constitution);
            HitPoint = HitPoints(Class, Modifier);            
            Console.WriteLine();
            Console.WriteLine("Equipment:");
            switch (Class)
            {
                case "Barbarian":
                    if (EquipmentPack=="A")
                    {
                        Console.Write("You have a greataxe, two handaxes, four javelins, and an explorers pack");
                        
                    }
                    else if (EquipmentPack=="B")
                    {
                        Console.Write("You have a melee weapon, a simple weapon, four javelin, and an explorers pack");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Bard":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a rapier, a diplomats pack, a lute, leather armor, and a dagger");                        
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a longsword, an entertainers pack, a musical instrument, Leather armor, and a dagger");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Cleric":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a mace, scale mail, a light crossbow with 20 bolts, a priests pack, a shield, and a holy symbol");                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a warhammer, leather armor, a simple weapon,an explorers pack, a shield, and a holy symbol");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Druid":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a wooden shield, a scimitar, leather armor, an explorers pack, and a druidic focus");                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a simple weapon, a simple melee weapon,leather armor, an explorers pack, and a druidic focus");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Fighter":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have chain mail, a martial weapon and shield, light crossbow with 20 bolts, and dungeoneers pack");
                        
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have leather armor, longbow with 20 arrows, two martial weapons, two handaxes, and an explorers pack");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Monk":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a shortsword, dungeoneers pack, 10 darts");

                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a simple weapon, explorer's pack, 10 darts");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Paladin":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a martial weapon and shield, five javelin, a priests pack, chain mail, and holy symbol");                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have two martial weapons, simple weapon, explorers pack, chain mail, and holy symbol");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Ranger":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have scale mail, two shortswords, a dungeoneers pack, a longbow, quiver, and 20 arrows");                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have leather armor, two simple melee weapons, explorers pack, a longbow, quiver, and 20 arrows");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Rogue":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a Rapier, shortbow, quiver, 20 arrows, burglars pack, leather armor, two daggers, thieves tools");                        
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have two shortswords, dungeoneers pack,  leather armor, two daggers, thieves tools");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Sorcerer":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a light crossbow, 20 bolts, component pouch, duneoneers pack, and two daggers");                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a simple weapon, arcane focus, explorers pack, and two daggers");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Warlock":
                    if (EquipmentPack == "A")
                    {
                        Console.Write("You have a light crossbow, 20 bolts, component pouch, scholars pack, leather armor, simple weapon, and two daggers.");                      
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have two simple weapon, arcane focus, dungeoneer's pack, leather armor, and two daggers");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                case "Wizard":
                    if (EquipmentPack == "A")
                    {
                        Console.WriteLine("You have a quarterstaff, component pouch, scholars pack, and a spellbook");
                       
                    }
                    else if (EquipmentPack == "B")
                    {
                        Console.Write("You have a dagger, arcane focus, explorers pouch, and a spellbook");
                    }
                    else
                    {
                        Console.Write("Please go back and pick a valid Equipment Pack");
                    }
                    break;
                default:
                   
                    break;
                    
            }
            DisplayContinuePrompt();
        }
       
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to my D&d character sheet creator");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank You for using our application"); // makes it appear over more
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        static void DisplayHeader(string headerText)
        {
            //
            //display header
            //

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t" + headerText);
            Console.WriteLine();

        }


    }
}
    


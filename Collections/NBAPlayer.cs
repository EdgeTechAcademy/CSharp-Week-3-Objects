﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Collections
{
    class NBAPlayer
    {
        private string name;
        private string team;
        private decimal salary;
        private string position;
        private float gamesPlayed;
        private float minutes;
        private float fieldGoalsMade;
        private float fieldGoalsAttempted;
        private float threePtsMade;
        private float threePointsAttempted;
        private float freeThrowsMade;
        private float freeThrowAttemped;
        private float turnovers;
        private float personalFouls;
        private float offensiveRebounds;
        private float defensiveRebounds;
        private float rebounds;
        private float assists;
        private float steals;
        private float blocks;
        private float points;

        public string Name { get => name; set => name = value; }
        public string Team { get => team; set => team = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public float GamesPlayed { get => gamesPlayed; set => gamesPlayed = value; }
        public float Minutes { get => minutes; set => minutes = value; }
        public float FieldGoalsMade { get => fieldGoalsMade; set => fieldGoalsMade = value; }
        public float FieldGoalsAttempted { get => fieldGoalsAttempted; set => fieldGoalsAttempted = value; }
        public float ThreePtsMade { get => threePtsMade; set => threePtsMade = value; }
        public float ThreePointsAttempted { get => threePointsAttempted; set => threePointsAttempted = value; }
        public float FreeThrowsMade { get => freeThrowsMade; set => freeThrowsMade = value; }
        public float FreeThrowAttemped { get => freeThrowAttemped; set => freeThrowAttemped = value; }
        public float Turnovers { get => turnovers; set => turnovers = value; }
        public float PersonalFouls { get => personalFouls; set => personalFouls = value; }
        public float OffensiveRebounds { get => offensiveRebounds; set => offensiveRebounds = value; }
        public float DefensiveRebounds { get => defensiveRebounds; set => defensiveRebounds = value; }
        public float Rebounds { get => rebounds; set => rebounds = value; }
        public float Assists { get => assists; set => assists = value; }
        public float Steals { get => steals; set => steals = value; }
        public float Blocks { get => blocks; set => blocks = value; }
        public float Points { get => points; set => points = value; }
        //  Player	Team
        //  Salary	Position	GamesPlayed	MinutesPerGame	FGMade	FGAttempts	3PMade	3pAttempts	FTMade	FTAttempts	Turnovers	Fouls	OffensiveRebounds	DefensiveRebounds	Rebounds	Assists	Steals	Blocks	Points

        public NBAPlayer(string name, string team,  decimal salary, string position,
                        float gamesPlayed,  float minutes,              float fieldGoalsMade,    float fieldGoalsAttempted, 
                        float threePtsMade, float threePointsAttempted, float freeThrowsMade,    float freeThrowAttemped,
                        float turnovers,    float personalFouls,        float offensiveRebounds, float defensiveRebounds,
                        float rebounds,     float assists,              float steals,            float blocks, 
                        float points)
        {
            this.Name = name;
            this.team = team;
            this.Salary = salary;
            this.Position = position;
            this.gamesPlayed = gamesPlayed;
            this.minutes = minutes;
            this.fieldGoalsMade = fieldGoalsMade;
            this.fieldGoalsAttempted = fieldGoalsAttempted;
            this.threePtsMade = threePtsMade;
            this.threePointsAttempted = threePointsAttempted;
            this.freeThrowsMade = freeThrowsMade;
            this.freeThrowAttemped = freeThrowAttemped;
            this.turnovers = turnovers;
            this.personalFouls = personalFouls;
            this.offensiveRebounds = offensiveRebounds;
            this.defensiveRebounds = defensiveRebounds;
            this.rebounds = rebounds;
            this.assists = assists;
            this.steals = steals;
            this.blocks = blocks;
            this.points = points;
        }

        public override string ToString()
        {
            return $"{Name} plays for {Team} at {Position} for {Salary:C}";
        }

        /**
         *      LoadRecords 
         *          Reads a csv file
         *          parses the lines on comma
         *          creates an NBAPlayer with the fields
         *          adds the player to the List
         *          returns list to the calling application
         *
         */
        public static List<NBAPlayer> LoadRecords()
        {
            String fileName = @"C:\Projects\csv\Players.csv";

            List<NBAPlayer> players = new List<NBAPlayer>();    //  list of all NBA players
            StreamReader textIn = null;                         //  this is file read
            string line = "";
            try
            {
                textIn = new StreamReader(fileName);            //  open the file for reading
                textIn.ReadLine();                              //  read and throw away the header line
                while ((line = textIn.ReadLine()) != null)      //  read each line from the file
                {
                    string[] prop = line.Split(",");            //  split the data fields apart

                    //  create the NBA Player
                    NBAPlayer player = new NBAPlayer(prop[1], prop[2], decimal.Parse(prop[3]), prop[4],
                        float.Parse(prop[5]), float.Parse(prop[6]), float.Parse(prop[7]), float.Parse(prop[8]),
                        float.Parse(prop[9]), float.Parse(prop[10]), float.Parse(prop[11]), float.Parse(prop[12]),
                        float.Parse(prop[13]), float.Parse(prop[14]), float.Parse(prop[15]), float.Parse(prop[16]), 
                        float.Parse(prop[17]), float.Parse(prop[18]), float.Parse(prop[19]), float.Parse(prop[20]),
                        float.Parse(prop[21]));
                    players.Add(player);                        //  add player to the list of players
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file: " + fileName);
                Console.WriteLine("\t"+line);
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }
            return players;
        }
    }
}
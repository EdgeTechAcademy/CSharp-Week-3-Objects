using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> paxList = Passenger.LoadPassengers();

            List<Passenger> survivor = paxList.FindAll(p => p.Survivor);
            HashSet<string> classes = new HashSet<string>();
            HashSet<string> roles = new HashSet<string>();

            //  classes and roles are Sets so this will code will produce a unique set of these attributes
            //  classes = paxList.Select(p => p.PaxClass).ToHashSet();
            foreach (var pax in paxList)
            {
                classes.Add(pax.PaxClass);
                roles.Add(pax.Role);
            }
            //  same but using Linq code
            //  classes = paxList.Select(p => p.PaxClass).ToHashSet();
            //  roles = paxList.Select(p => p.Role).ToHashSet();

            //  display the unique roles of passengers
            foreach (var role in roles)
            {
                Console.WriteLine(role);
            }
            //  same but using some Linq code
            //  roles.ToList().ForEach(r => Console.WriteLine(r));

            List<NBAPlayer> players = NBAPlayer.LoadRecords();
            List<NBAPlayer> phxSuns = players.FindAll(p => p.Team.Equals("PHX"));
            foreach (var player in phxSuns)
            {
                Console.WriteLine(player);
            }
            //  same but using Linq
            //  phxSuns.ForEach(p => Console.WriteLine(p));
 
            /*      
                               LINQ and Collection methods

            List<Passenger> passengers = Passenger.LoadPassengers();
            var survivors = passengers.FindAll(p => p.Survivor);
            https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netcore-3.1
                Add         AddRange    Clear       Contains    ConvertAll  Exists
                Find        FindAll     FindIndex   FindLast    FindLastIndex
                ForEach     GetRange    IndexOf     Insert      InsertRange
                LastIndexOf Remove      RemoveAll   RemoveAt    RemoveRange
                Reverse     Sort        ToArray     TrimExcess  TrueForAll

                https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=netcore-3.1
                Any         All         Average     Contains    Count
                Distinct    ElementAt   Empty       Except      First
                GroupBy     Interesct   Join        Last        Max Min
                OrderBy(Desc)           Prepend     Range       Repeat
                Reverse     Select      SelectMany  Single      Skip
                SkipLast    SkipWhile   Sum         Take        TakeLast
                TakeWhile   ThenBy      Union       Where       Zip
                ToArray     ToDictionary  ToHashSet ToList      ToLookUp
                */

        }
    }
}

﻿using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using Test.Model;

namespace Test.Services
{
    public class DataService
    {
        private ObservableCollection<Event> events;
        private ObservableCollection<Account> accounts;
        private ObservableCollection<Group> groups;
        public ObservableCollection<Event> Events
        {
            get { return events; }
            set { events = value; }
        }

        public ObservableCollection<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public ObservableCollection<Group> Groups
        {
            get { return groups; }
            set { groups = value; }
        }

        public DataService()
        {
            events = new ObservableCollection<Event>()
            {
                new Event
                {
                    Name="Rebel Friday",
                    MainHost="Rebel Nightclub",
                    Description="A shit club located in a fucked location with kinda cool lights and shit. REBEL is a truly distinctive " +
                    "and transformative event complex, offering guests a unique and unparalleled experience. The versatile event space functions " +
                    "as a state-of-the-art live concert venue as well as a turn-key corporate event facility.",
                    Image="pic2.png",
                    Nineteen_Plus="19+",
                    Event_Type="Club",
                    Date="Friday, June 5th",
                    People="2,367",
                    Friends="4",
                    City="Toronto",
                    Address="11 Polson St",
                    Price="$30-$60",
                    Time="9PM-3AM",
                
                },

                new Event
                {
                    Name="Madison Avenue Pub",
                    Description="A multi-level student bar with an hour long wait time to get in. Not worth it.",
                    Image="pic1.png",
                    Nineteen_Plus="19+",
                    Event_Type="Bar",
                    Date="Monday, June 11th",
                    People="100",
                    Friends="6"
                },

                new Event
                {
                    Name="Jazz at the Rex",
                    Description="",
                    Image="therex.png",
                    Nineteen_Plus="All Ages",
                    Event_Type="Music",
                    Date="Friday, July 21st",
                    People="80",
                    Friends="2"
                },
                new Event
                {
                    Name="Xaver's Party",
                    Description="Best party host in the east end of toronto... (dj set)",
                    Image="pic3.png",
                    Nineteen_Plus="All Ages",
                    Event_Type="Party",
                    Date="Saturday, June 26th",
                    People="50",
                    Friends="2"
                },

                new Event
                {
                    Name="Lost and Found",
                    Description="Found it",
                    Image="lostandfound.png",
                    Nineteen_Plus="19+",
                    Event_Type="Club",
                    Date="Thursday, June 30th",
                    People="150",
                    Friends="0"
                },

                new Event
                {
                    Name="Barrett's Party",
                    Description="Free Tattoos, bring your own skateboard",
                    Image="barrettparty.png",
                    Nineteen_Plus="19+",
                    Event_Type="Party",
                    Date="Sunday, July 5th",
                    People="1",
                    Friends="1"
                },

                new Event
                {
                    Name="Future at Cabana",
                    Description="Come see your favourite autotune crackhead pop bottles",
                    Image="cabana.png",
                    Nineteen_Plus="19+",
                    Event_Type="Bar",
                    Date="Monday, June 13th",
                    People="400",
                    Friends="30"
                }
            };

            accounts = new ObservableCollection<Account>()
            {
                new Account
                {
                    Name="Lucas Worrell",
                    BImage="lucasworrell",
                    Friends="4,095",
                    Gallery= new List<string> {"frog", "jay", "map", "pic2", "pic1" },
                    Interests= new List<string> {"Club", "Gaming", "Security", "Workout", "Drugs"}
                },

                new Account
                {
                    Name="Barrett MacFarlane",
                    Image="barrett.png",
                    BImage="barrettbackground",
                    Friends="1"
                },

                new Account
                {
                    Name="Angel",
                    Image = "angel.png",
                    Friends="587"
                },

                new Account
                {
                    Name="Caleb Lenkorn",
                    Image = "caleb.png",
                    Friends="2,524"
                }, 

                new Account
                {
                    Name="Xaver Kwol",
                    Image = "xaver.png",
                    Friends="420"
                },

                new Account
                {
                    Name="Oliver van Rossem",
                    Image = "oliver.png",
                    Friends="234,954"
                }, 

                new Account
                {
                    Name="Frog the Dog",
                    Image = "frog.png",
                    Friends="5,023,489"
                }, 

                new Account
                {
                    Name="Sam Doulis"
                }, 

                new Account
                {
                    Name="Hayden STM",
                    Image = "hayden.png"
                }, 

                new Account
                {
                    Name="Otzi",
                    Image = "otzi.png"
                },

                new Account
                {
                    Name="Fidel Castro",
                    Image = "fidel.png"
                },

                new Account
                {
                    Name="Jay Clyke",
                    Image = "jay.png"
                }, 

                new Account
                {
                    Name="Hazbulla", 
                    Image="hazbulla.png"
                },

                new Account
                {
                    Name="Draymond Green",
                    Image="draymond.png"
                }

            };
            groups = new ObservableCollection<Group>()
            {
                new Group
                {
                    Name="Trappin Snow on Christmas",
                    People= new List<Account> { accounts[0], accounts[1] },
                    Image="trappin"
                },

                new Group
                {
                    Name="Power Rangers",
                    People= new List<Account> { accounts[0], accounts[1], accounts[2], accounts[3],accounts[4], accounts[5]},
                    Image="powerrangers"
                },

                new Group
                {
                    Name="Free Pac and Big From Cuba",
                    People= new List<Account> { accounts[6], accounts[3], accounts[8], accounts[7]},
                    Image="freepac"
                },

                new Group
                {
                    Name="Le babyyyy fan club",
                    People= new List<Account> { accounts[2], accounts[5]},
                    Image="lebaby"
                }         
                                 
            };
        }

        public ObservableCollection<Event> GetDisplayedItems(int count)
        {
            return new ObservableCollection<Event>(events.Take(count));
        }

        internal static IEnumerable GetSearchResults(string text)
        {
            throw new NotImplementedException();
        }
    }
} 

﻿using System.Collections.Generic;
using Commander.Data;
using Microsoft.VisualBasic.FileIO;

namespace Commander.Models
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command{Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & chopping board"},
                new Command{Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }
    }
}
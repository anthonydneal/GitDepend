﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitDepend.Commands;
using NUnit.Framework;

namespace GitDepend.UnitTests.Commands
{
    [TestFixture]
    public class CommandParserTests : TestFixtureBase
    {
        [Test]
        public void GetCommand_ShouldReturn_InitCommand_WhenInitVerbIsSpecified()
        {
            string[] args = { "init" };
            var instance = new CommandParser();

            var command = instance.GetCommand(args);

            Assert.IsTrue(command is InitCommand, "Invalid Command");
        }

        [Test]
        public void GetCommand_ShouldReturn_ShowConfigCommand_WhenCloneVerbIsSpecified()
        {
            string[] args = { "config" };
            var instance = new CommandParser();

            var command = instance.GetCommand(args);

            Assert.IsTrue(command is ShowConfigCommand, "Invalid Command");
        }

        [Test]
        public void GetCommand_ShouldReturn_CloneCommand_WhenCloneVerbIsSpecified()
        {
            string[] args = { "clone" };
            var instance = new CommandParser();

            var command = instance.GetCommand(args);

            Assert.IsTrue(command is CloneCommand, "Invalid Command");
        }

        [Test]
        public void GetCommand_ShouldReturn_UpdateCommand_WhenUpdateVerbIsSpecified()
        {
            string[] args = { "update" };
            var instance = new CommandParser();

            var command = instance.GetCommand(args);

            Assert.IsTrue(command is UpdateCommand, "Invalid Command");
        }
    }
}
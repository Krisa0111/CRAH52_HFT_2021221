using CRAH52_HFT_2021221.Logic;
using CRAH52_HFT_2021221.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.Test
{
    [TestFixture]
    class GuestLogicTest
    {
        IGuestsLogic guestsLogic;
        public void Setup()
        {
            Mock<IGuestsLogic> mockrepo = new Mock<IGuestsLogic>();
        }
        [Test]
        public void CheckCreate()
        {

        }
        public void CheckYoungestPersonOnEvent(Events events)
        {

        }
    }
}

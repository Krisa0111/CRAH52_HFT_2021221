using CRAH52_HFT_2021221.Logic;
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
    class EventsLogicTest
    {
        IEventsLogic eventsLogic;
        public void Setup()
        {
            Mock<IEventsLogic> mockrepo = new Mock<IEventsLogic>();   
        }
        [Test]
        public void CheckCreate()
        {

        }
        public void CheckTheMostPopularEvent()
        {

        }
        public void CheckMostExpensiveEvents()
        {

        }
        
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRAH52_HFT_2021221.Logic;
using Moq;
using CRAH52_HFT_2021221.Repository;

namespace CRAH52_HFT_2021221.Test
{
    [TestFixture]
    class ClubsLogicTest
    {
        IClubsLogic clubsLogic;
        public void Setup()
        {
            Mock<IClubsRepository> mockrepo = new Mock<IClubsRepository>();

        }



        [Test]
        public void CheckTheMostPopularCLub()
        {

        }
        public void CheckClubsThatHeldEventsInTheSummer()
        {

        }
        public void CheckCreate()
        {

        }
    }
}

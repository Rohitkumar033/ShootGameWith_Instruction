using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShootGameWith_Instruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootGameWith_Instruction.Tests
{
    [TestClass()]
    public class PlateformTests
    {
        [TestMethod()]
        public void secndFireTest()
        {
            Plateform frm = new Plateform();
            frm.firstFire();
            frm.secndFire();
            Assert.Fail();
        }
    }
}
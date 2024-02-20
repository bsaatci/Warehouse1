using BarcodedInventory;
using BarcodedInventoryTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BarcodedInventory.Tests
{
    [TestClass()]
    public class MainFormTest
    {
        private DataContextMock? _context;
        [TestInitialize]
        public void Init()
        {
            _context = new DataContextMock();
        }

        [TestMethod()]
        public void Dispose_Box_Fails_When_Box_DoesNotExist_With_Given_Barcode()
        {
            var mainForm = new MainForm();
            mainForm.DisposeBoxes(_context, mainForm.GetListOfBoxes(_context, new []{"xyz11"}));
            Assert.AreEqual(mainForm.listBoxMessages.Items[0], "xyz11 cannot be found!");
        }

        [TestMethod()]
        public void DisposeBoxesTest()
        {
            var mainForm = new MainForm();
            mainForm.DisposeBoxes(_context, mainForm.GetListOfBoxes(_context, new []{"abc10", "abc12"}));
            Assert.AreEqual(mainForm.listBoxMessages.Items[0], "BC1 is taken.");
            Assert.AreEqual(mainForm.listBoxMessages.Items[1], "BC3 is taken.");

        }
    }

}


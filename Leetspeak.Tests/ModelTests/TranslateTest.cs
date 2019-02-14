using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class TranslateTest
  {
    [TestMethod]
    public void IsLetterE_True()
    {
      Translate test = new Translate();
      Assert.AreEqual("3a7", test.translateString("eat"));
    }

  }
}

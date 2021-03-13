using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod(displayName:"Shoul Validate Gravatar Extension")]
        [DataRow(null, false)]
        [DataRow("",false)]
        [DataRow(" ",false)]
        [DataRow("a@a",false)]
        [DataRow("a@ricardo.com",false)]        
        [DataRow("ricardo.sribeiro@outlook.com",false)]
        public void TestMethod1(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/64cc168cKcoR2YCKpmVKwTmcYp115bHjtDFYN6";

            Assert.AreEqual((email.ToGravatar()==result),status);
        }
    }
}



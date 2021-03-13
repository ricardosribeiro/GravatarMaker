using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod(displayName: "Should Validate Gravatar Extension")]
        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("a@ricardo.com", 200, false)]
        [DataRow("ricardo.sribeiro@outlook.com", null, true)]
        [DataRow("ricardo.sribeiro@outlook.com", 200, true)]
        public void TestMethod1(string email, int? size, bool status)
        {

            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var expected = $"https://www.gravatar.com/avatar/64cc168024507d9b541245b42f2f1b36?s={imageSize}";
            var result = email.ToGravatar(size ?? 80);
            Assert.AreEqual((result == expected), status);
        }
    }
}



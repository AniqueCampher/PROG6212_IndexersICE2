using prjIndexersICE2;

namespace TestBooks
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestUpdatedPrice()
        {
            Books books = new Books(100, 1, "It Ends With Us", "Colleen Hoover");
            books["price"] = 120; 
            Assert.AreEqual(books["price"], 120);
        }

        [TestMethod]
        public void TestUpdatedTitle()
        {
            Books books = new Books(150, 2, "King of Envy", "Ana Haung");
            books[2] = "King of Greed";
            Assert.AreEqual(books[2], "King of Greed");
        }

        [TestMethod]
        public void TestUpdatedISBN()
        {
            Books books = new Books(200, 3, "Shatter Me", "Tahereh Mafi");
            books[1] = 14;
            Assert.AreEqual(books[1], 14);
        }

        [TestMethod]
        public void TestUpdatedAuthorPass()
        {
            Books books = new Books(250, 4, "Watch Me", "Tahereh Mafi");
            Assert.AreEqual(books["author"], "Tahereh Mafi"); 
        }

        [TestMethod]
        public void TestUpdatedAuthorFail()
        {
            Books books = new Books(1, 4, "Watch Me", "Tahereh Mafi");
            Assert.AreNotEqual(books["author"], "Shakespeare");
        }
    }
}

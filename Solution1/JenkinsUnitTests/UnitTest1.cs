namespace JenkinsUnitTests
{
   using JenkinsConsoleApp;
   // https://www.youtube.com/watch?v=uC7vajbnZS4

   [TestClass]
   public class UnitTest1
   {
      private const string Expected = "Hellow world from Terry";

      [TestMethod]
      public void TestMethod1()
      {
         using (var sw= new StringWriter())
         {
            // Sets the System.Console.Out property to target the StringWriter
            string[] args = new[] {"Hi"}; 
            Console.SetOut(sw);
            Program.Main(args);
            var result = sw.ToString().Trim();
            Assert.IsTrue(string.Equals(Expected, result));
         }
      }
   }
}
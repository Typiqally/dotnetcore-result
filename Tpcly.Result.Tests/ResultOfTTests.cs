using NUnit.Framework;

namespace Tpcly.Result.Tests
{
    [TestFixture]
    public class ResultOfTTests
    {
        [Test]
        public void When_ConstructDefaultResult_Then_Value_ShouldBe_Null()
        {
            // Arrange
            // Act
            var result = new Result<string>();
            
            // Assert
            Assert.AreEqual(null, result.Value);
        }

        [Test]
        public void Given_Value_When_Construct_Then_Value_ShouldBe_EqualToData()
        {
            // Arrange
            const string expected = "example";
            
            // Act
            var result = new Result<string>(expected);
            
            // Assert
            Assert.AreEqual(expected, result.Value);
        }
        
        [Test]
        public void When_Construct_And_OverrideSuccessfulWithTrue_Then_Result_ShouldBe_Successful()
        {
            // Arrange
            // Act
            var result = new Result<string>(default, true);
            
            // Assert
            Assert.AreEqual(null, result.Value);
            Assert.IsTrue(result.IsSuccessful);
        }
        
        [Test]
        public void When_Construct_And_OverrideSuccessfulWithFalse_Then_Result_ShouldNotBe_Successful()
        {
            // Arrange
            // Act
            var result = new Result<string>(default, false);
            
            // Assert
            Assert.AreEqual(null, result.Value);
            Assert.IsFalse(result.IsSuccessful);
        }
        
        [Test]
        public void Given_Value_When_Construct_And_OverrideSuccessfulWithTrue_Then_Result_ShouldBe_Successful()
        {
            // Arrange
            const string expected = "example";

            // Act
            var result = new Result<string>(expected, true);
            
            // Assert
            Assert.AreEqual(expected, result.Value);
            Assert.IsTrue(result.IsSuccessful);
        }
        
        [Test]
        public void Given_Value_When_Construct_And_OverrideSuccessfulWithFalse_Then_Result_ShouldNotBe_Successful()
        {
            // Arrange
            const string expected = "example";

            // Act
            var result = new Result<string>(expected, false);
            
            // Assert
            Assert.AreEqual(expected, result.Value);
            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
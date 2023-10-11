using NUnit.Framework;

namespace Tpcly.Result.Tests
{
    [TestFixture]
    public class ResultTests
    {
        [Test]
        public void When_ConstructDefaultResult_Then_Value_ShouldBe_Null()
        {
            // Arrange
            // Act
            var result = new Result();

            // Assert
            Assert.AreEqual(null, result.Value);
        }

        [Test]
        public void Given_Value_When_Construct_Then_Value_ShouldBe_EqualToData()
        {
            // Arrange
            const string expected = "example";

            // Act
            var result = new Result(expected);

            // Assert
            Assert.AreEqual(expected, result.Value);
        }

        [Test]
        public void When_Construct_And_OverrideSuccessfulWithTrue_Then_Result_ShouldBe_Successful()
        {
            // Arrange
            // Act
            var result = new Result(default, true);

            // Assert
            Assert.AreEqual(null, result.Value);
            Assert.IsTrue(result.IsSuccessful);
        }

        [Test]
        public void When_Construct_And_OverrideSuccessfulWithFalse_Then_Result_ShouldNotBe_Successful()
        {
            // Arrange
            // Act
            var result = new Result(default, false);

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
            var result = new Result(expected, true);

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
            var result = new Result(expected, false);

            // Assert
            Assert.AreEqual(expected, result.Value);
            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
using NUnit.Framework;

namespace Tpcly.Result.Tests
{
    [TestFixture]
    public class ResultOfTWithErrorOfTTests
    {
        [Test]
        public void When_Construct_Then_ValueAndSuccessAndError_ShouldBe_Null()
        {
            // Arrange
            // Act
            var result = new Result<string, int?>();

            // Assert
            Assert.IsNull(result.Value);
            Assert.IsNull(result.Success);
            Assert.IsNull(result.Error);
        }

        [Test]
        public void Given_Success_When_Construct_Then_Success_ShouldBe_EqualToValueAndSuccess_And_Error_ShouldBe_Null()
        {
            // Arrange
            const string expected = "example";

            // Act
            var result = new Result<string, int?>(expected);

            // Assert
            Assert.AreEqual(expected, result.Value);
            Assert.AreEqual(expected, result.Success);
            Assert.IsNull(result.Error);
        }

        [Test]
        public void Given_Error_When_Construct_Then_Success_ShouldBe_Null_And_Error_ShouldBe_EqualToValueAndError()
        {
            // Arrange
            const int expected = 1;

            // Act
            var result = new Result<string, int?>(expected);

            // Assert
            Assert.IsNull(result.Success);
            Assert.AreEqual(expected, result.Value);
            Assert.AreEqual(expected, result.Error);
        }

        [Test]
        public void Given_Success_When_Construct_Then_Result_ShouldBe_Successful()
        {
            // Arrange
            const string expected = "example";

            // Act
            var result = new Result<string, int?>(expected);

            // Assert
            Assert.IsTrue(result.IsSuccessful);
        }

        [Test]
        public void Given_Error_When_Construct_Then_Result_ShouldNotBe_Successful()
        {
            // Arrange
            const int expected = 1;

            // Act
            var result = new Result<string, int?>(expected);

            // Assert
            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
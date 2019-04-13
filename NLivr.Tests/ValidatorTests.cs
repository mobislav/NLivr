using System;
using Xunit;

namespace NLivr.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void Validator_Create_ThrowExceptionIfRulesEmpty()
        {
           Assert.Throws<ArgumentNullException>(()=>Validator.Create(null));
        }

        [Fact]
        public void Validator_Create_ThrowExceptionIfRulesNotJsonString()
        {
            Assert.Throws<ArgumentException>(() => Validator.Create("test"));
        }

        [Fact]
        public void Validator_Create_ReturnValidator()
        {
           Assert.NotNull( Validator.Create("{}"));
        }
    }
}

using DataStructureDemo.DSService;
using Xunit;

namespace DataStructureDemo.Test
{
    public class DataStructureTest
    {
        private readonly DataStructure ds;

        public DataStructureTest()
        {
            ds = new DataStructure();
        }

        [Theory, MemberData(nameof(LongestString_Return_Longest_String_ShouldPass_Data))]
        public void LongestString_Return_Longest_String_ShouldPass(string input, string expect)
        {
            // Act
            var actual = ds.LongestString(input);

            // Assert
            Assert.Equal(expect, actual);
        }

        public static TheoryData<string, string> LongestString_Return_Longest_String_ShouldPass_Data()
        {
            return new TheoryData<string, string>
            {
                { "Hello John", "Hello" },
                { "Hi John and Mandy", "Mandy" }
            };
        }
    }
}

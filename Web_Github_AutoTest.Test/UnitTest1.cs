namespace Web_Github_AutoTest.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test1(int arg)
        {
            var hoge = arg * arg;
            Assert.Equal(Math.Pow(arg, 2), hoge);
        }

        [Fact]
        public void FailureTest()
        {
            var hoge = 1;
            Assert.Equal(1, hoge);
        }
    }
}

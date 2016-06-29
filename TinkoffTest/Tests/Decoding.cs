using TinkoffTest.Services;
using Xunit;

namespace TinkoffTest.Tests
{
    public class Decoding
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private int baseType = 62;
        private int testNumber = 1234567890;

        [Fact()]
        public void DecodeData()
        {
            int number = 0;
            var encodeService = new EncodeService();
            var encodedNumber = encodeService.Encode(testNumber);

            for (int i = 0, len = encodedNumber.Length; i < len; i++)
            {
                number = number * baseType + alphabet.IndexOf(encodedNumber[(i)]);
            }

            Assert.Equal(testNumber, number);
        }
    }
}
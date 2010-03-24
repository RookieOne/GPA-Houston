using NUnit.Framework;

namespace GpaHouston.Data.Tests
{
    public static class AssertExtensions
    {
        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBe<T>(this T actual, T expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBeTrue(this bool b)
        {
            Assert.IsTrue(b);
        }

        public static void ShouldNotBeNull(this object o)
        {
            Assert.IsNotNull(o);
        }
    }
}
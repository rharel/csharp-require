using NUnit.Framework;
using System;

namespace rharel.Debug.Tests
{
    [TestFixture]
    public sealed class RequireTest
    {
        private sealed class CustomException: Exception
        {
            public CustomException(): this("custom exception message") {}
            public CustomException(string message): base(message) { }
        }

        [Test]
        public void Test_IsNull()
        {
            Assert.Throws<CustomException>(
                () => Require.IsNull<CustomException>(this)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNull(this)
            );

            Assert.DoesNotThrow(
                () => Require.IsNull<CustomException>(null)
            );
            Assert.DoesNotThrow(
                () => Require.IsNull(null)
            );
        }
        [Test]
        public void Test_IsNotNull()
        {
            Assert.Throws<CustomException>(
                () => Require.IsNotNull<CustomException>(null)
            );
            Assert.Throws<ArgumentNullException>(
                () => Require.IsNotNull(null)
            );

            Assert.DoesNotThrow(
                () => Require.IsNotNull<CustomException>(this)
            );
            Assert.DoesNotThrow(
                () => Require.IsNotNull(this)
            );
        }

        [Test]
        public void Test_IsEmpty()
        {
            Assert.Throws<CustomException>(
                () => Require.IsEmpty<CustomException>("non empty string")
            );
            Assert.Throws<CustomException>(
                () => Require.IsEmpty<CustomException>(" ")
            );
            Assert.Throws<CustomException>(
                () => Require.IsEmpty<CustomException>(null)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsEmpty("non empty string")
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsEmpty(" ")
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsEmpty(null)
            );

            Assert.DoesNotThrow(
                () => Require.IsEmpty<CustomException>(string.Empty)
            );
            Assert.DoesNotThrow(
                () => Require.IsEmpty(string.Empty)
            );
        }
        [Test]
        public void Test_IsNotEmpty()
        {
            Assert.Throws<CustomException>(
                () => Require.IsNotEmpty<CustomException>(string.Empty)
            );
            Assert.Throws<CustomException>(
                () => Require.IsNotEmpty<CustomException>(null)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNotEmpty(string.Empty)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNotEmpty(null)
            );

            Assert.DoesNotThrow(
                () => Require.IsNotEmpty<CustomException>("non empty string")
            );
            Assert.DoesNotThrow(
                () => Require.IsNotEmpty<CustomException>(" ")
            );
            Assert.DoesNotThrow(
                () => Require.IsNotEmpty("non empty string")
            );
            Assert.DoesNotThrow(
                () => Require.IsNotEmpty(" ")
            );
        }

        [Test]
        public void Test_IsBlank()
        {
            Assert.Throws<CustomException>(
                () => Require.IsBlank<CustomException>("non empty string")
            );
            Assert.Throws<CustomException>(
                () => Require.IsBlank<CustomException>(null)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsBlank("non empty string")
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsBlank(null)
            );

            Assert.DoesNotThrow(
                () => Require.IsBlank<CustomException>(string.Empty)
            );
            Assert.DoesNotThrow(
                () => Require.IsBlank<CustomException>(" ")
            );
            Assert.DoesNotThrow(
                () => Require.IsBlank(string.Empty)
            );
            Assert.DoesNotThrow(
                () => Require.IsBlank(" ")
            );
        }
        [Test]
        public void Test_IsNotBlank()
        {
            Assert.Throws<CustomException>(
                () => Require.IsNotBlank<CustomException>(" ")
            );
            Assert.Throws<CustomException>(
                () => Require.IsNotBlank<CustomException>(string.Empty)
            );
            Assert.Throws<CustomException>(
                () => Require.IsNotBlank<CustomException>(null)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNotBlank(" ")
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNotBlank(string.Empty)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsNotBlank(null)
            );

            Assert.DoesNotThrow(
                () => Require.IsNotBlank<CustomException>("non empty string")
            );
            Assert.DoesNotThrow(
                () => Require.IsNotBlank("non empty string")
            );
        }

        [Test]
        public void Test_IsTrue()
        {
            Assert.Throws<CustomException>(
                () => Require.IsTrue<CustomException>(false)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsTrue(false)
            );

            Assert.DoesNotThrow(
                () => Require.IsTrue<CustomException>(true)
            );
            Assert.DoesNotThrow(
                () => Require.IsTrue(true)
            );
        }
        [Test]
        public void Test_IsFalse()
        {
            Assert.Throws<CustomException>(
                () => Require.IsFalse<CustomException>(true)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsFalse(true)
            );

            Assert.DoesNotThrow(
                () => Require.IsFalse<CustomException>(false)
            );
            Assert.DoesNotThrow(
                () => Require.IsFalse(false)
            );
        }

        [Test]
        public void Test_AreEqual()
        {
            Assert.Throws<CustomException>(
                () => Require.AreEqual<CustomException>(1, 2)
            );
            Assert.Throws<ArgumentException>(
                () => Require.AreEqual(1, 2)
            );

            Assert.DoesNotThrow(
                () => Require.AreEqual<CustomException>(1, 1)
            );
            Assert.DoesNotThrow(
                () => Require.AreEqual(1, 1)
            );
        }
        [Test]
        public void Test_AreNotEqual()
        {
            Assert.Throws<CustomException>(
                () => Require.AreNotEqual<CustomException>(1, 1)
            );
            Assert.Throws<ArgumentException>(
                () => Require.AreNotEqual(1, 1)
            );

            Assert.DoesNotThrow(
                () => Require.AreNotEqual<CustomException>(1, 2)
            );
            Assert.DoesNotThrow(
                () => Require.AreNotEqual(1, 2)
            );
        }

        [Test]
        public void Test_AreSame()
        {
            var a = new object();
            var b = new object();

            Assert.Throws<CustomException>(
                () => Require.AreSame<CustomException>(a, b)
            );
            Assert.Throws<ArgumentException>(
                () => Require.AreSame(a, b)
            );

            Assert.DoesNotThrow(
                () => Require.AreSame<CustomException>(a, a)
            );
            Assert.DoesNotThrow(
                () => Require.AreSame(a, a)
            );
        }
        [Test]
        public void Test_AreNotSame()
        {
            var a = new object();
            var b = new object();

            Assert.Throws<CustomException>(
                () => Require.AreNotSame<CustomException>(a, a)
            );
            Assert.Throws<ArgumentException>(
                () => Require.AreNotSame(a, a)
            );

            Assert.DoesNotThrow(
                () => Require.AreNotSame<CustomException>(a, b)
            );
            Assert.DoesNotThrow(
                () => Require.AreNotSame(a, b)
            );
        }

        [Test]
        public void Test_IsLessThan()
        {
            Assert.Throws<CustomException>(
                () => Require.IsLessThan<int, CustomException>(1, 1)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsLessThan(1, 1)
            );
            Assert.Throws<CustomException>(
                () => Require.IsLessThan<int, CustomException>(2, 1)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsLessThan(2, 1)
            );

            Assert.DoesNotThrow(
                () => Require.IsLessThan<int, CustomException>(1, 2)
            );
            Assert.DoesNotThrow(
                () => Require.IsLessThan(1, 2)
            );
        }
        [Test]
        public void Test_IsGreaterThan()
        {
            Assert.Throws<CustomException>(
                () => Require.IsGreaterThan<int, CustomException>(1, 1)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsGreaterThan(1, 1)
            );
            Assert.Throws<CustomException>
            (
                () => Require.IsGreaterThan<int, CustomException>(1, 2)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsGreaterThan(1, 2)
            );

            Assert.DoesNotThrow(
                () => Require.IsGreaterThan<int, CustomException>(2, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsGreaterThan(2, 1)
            );
        }
        [Test]
        public void Test_IsAtMost()
        {
            Assert.Throws<CustomException>(
                () => Require.IsAtMost<int, CustomException>(2, 1)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsAtMost(2, 1)
            );

            Assert.DoesNotThrow(
                () => Require.IsAtMost<int, CustomException>(1, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtMost(1, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtMost<int, CustomException>(1, 2)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtMost(1, 2)
            );
        }
        [Test]
        public void Test_IsAtLeast()
        {
            Assert.Throws<CustomException>(
                () => Require.IsAtLeast<int, CustomException>(1, 2)
            );
            Assert.Throws<ArgumentException>(
                () => Require.IsAtLeast(1, 2)
            );

            Assert.DoesNotThrow(
                () => Require.IsAtLeast<int, CustomException>(1, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtLeast(1, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtLeast<int, CustomException>(2, 1)
            );
            Assert.DoesNotThrow(
                () => Require.IsAtLeast(2, 1)
            );
        }
    }
}

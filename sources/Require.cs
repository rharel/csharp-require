using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace rharel.Debug
{
    /// <summary>
    /// A collection of assertion methods for debugging purposes.
    /// </summary>
    public static class Require
    {
        /// <summary>
        /// Asserts the specified object is null.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_object">The object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNull<TException>(object some_object,
                                              string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected null but was {some_object}.";
            }
            Assert<TException>(some_object == null, message);
        }
        /// <summary>
        /// Asserts the specified object is null.
        /// </summary>
        /// <param name="some_object">The object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNull(object some_object, string message = null)
        {
            IsNull<ArgumentException>(some_object, message);
        }

        /// <summary>
        /// Asserts the specified object is not null.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_object">The object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotNull<TException>(object some_object,
                                                 string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Unexpected null.";
            }
            Assert<TException>(some_object != null, message);
        }
        /// <summary>
        /// Asserts the specified object is not the null object.
        /// </summary>
        /// <param name="some_object">The object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentNullException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotNull(object some_object, string message = null)
        {
            IsNotNull<ArgumentNullException>(some_object, message);
        }

        /// <summary>
        /// Asserts the specified is string is empty.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsEmpty<TException>(string some_string,
                                               string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected empty string but was {some_string}.";
            }

            IsNotNull<TException>(some_string, message);
            Assert<TException>(some_string.Length == 0, message);
        }
        /// <summary>
        /// Asserts the specified is string is empty.
        /// </summary>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsEmpty(string some_string, string message = null)
        {
            IsEmpty<ArgumentException>(some_string, message);
        }

        /// <summary>
        /// Asserts the specified string is not null or empty. 
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotEmpty<TException>(string some_string,
                                                  string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected non-empty string but was {some_string}.";
            }

            IsNotNull<TException>(some_string, message);
            Assert<TException>(some_string.Length > 0, message);
        }
        /// <summary>
        /// Asserts the specified string is not null or empty. 
        /// </summary>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotEmpty(string some_string, 
                                      string message = null)
        {
            IsNotEmpty<ArgumentException>(some_string, message);
        }

        /// <summary>
        /// Asserts the specified string is blank.
        /// 
        /// A blank string is one containing whitespace characters exclusively.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsBlank<TException>(string some_string,
                                               string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected blank string but was {some_string}.";
            }

            IsNotNull<TException>(some_string, message);
            Assert<TException>(some_string.Trim().Length == 0, message);
        }
        /// <summary>
        /// Asserts the specified string is blank.
        /// 
        /// A blank string is one containing whitespace characters exclusively.
        /// </summary>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsBlank(string some_string, string message = null)
        {
            IsBlank<ArgumentException>(some_string, message);
        }

        /// <summary>
        /// Asserts the specified string is not null or blank.
        /// 
        /// A blank string is one containing whitespace characters exclusively.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotBlank<TException>(string some_string,
                                                  string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected non-blank string.";
            }

            IsNotNull<TException>(some_string, message);
            Assert<TException>(some_string.Trim().Length > 0, message);
        }
        /// <summary>
        /// Asserts the specified string is not null or blank.
        /// 
        /// A blank string is one containing whitespace characters exclusively.
        /// </summary>
        /// <param name="some_string">The string to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsNotBlank(string some_string, 
                                      string message = null)
        {
            IsNotBlank<ArgumentException>(some_string, message);
        }

        /// <summary>
        /// Asserts the specified value is true.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsTrue<TException>(bool value,
                                              string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected true but was false.";
            }
            Assert<TException>(value == true, message);
        }
        /// <summary>
        /// Asserts the specified value is true.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool value, string message = null)
        {
            IsTrue<ArgumentException>(value, message);
        }

        /// <summary>
        /// Asserts the specified value is false.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsFalse<TException>(bool value,
                                               string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected false but was true.";
            }
            Assert<TException>(value == false, message);
        }
        /// <summary>
        /// Asserts the specified value is false.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool value, string message = null)
        {
            IsFalse<ArgumentException>(value, message);
        }

        /// <summary>
        /// Asserts the specified objects are equal.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreEqual<TException>(object a, object b,
                                                string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to equal {b}.";
            }
            Assert<TException>(Equals(a, b), message);
        }
        /// <summary>
        /// Asserts the specified objects are equal.
        /// </summary>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreEqual(object a, object b, string message = null)
        {
            AreEqual<ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts the specified objects are not equal.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreNotEqual<TException>(object a, object b,
                                                   string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to not equal {b}.";
            }
            Assert<TException>(!Equals(a, b), message);
        }
        /// <summary>
        /// Asserts the specified objects are not equal.
        /// </summary>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreNotEqual(object a, object b, 
                                       string message = null)
        {
            AreNotEqual<ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts the specified objects are the same.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreSame<TException>(object a, object b,
                                               string message = null
        )
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to reference-equal {b}.";
            }
            Assert<TException>(ReferenceEquals(a, b), message);
        }
        /// <summary>
        /// Asserts the specified objects are the same.
        /// </summary>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreSame(object a, object b, string message = null)
        {
            AreSame<ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts the specified objects are not the same.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreNotSame<TException>(object a, object b,
                                                  string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to not reference-equal {b}.";
            }
            Assert<TException>(!ReferenceEquals(a, b), message);
        }
        /// <summary>
        /// Asserts the specified objects are not the same.
        /// </summary>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void AreNotSame(object a, object b, 
                                      string message = null)
        {
            AreNotSame<ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts one object is strictly less than another.
        /// </summary>
        /// <typeparam name="TObject">
        /// The type of the tested objects.
        /// </typeparam>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsLessThan<TObject, TException>(
            TObject a,
            TObject b,
            string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to be less than {b}.";
            }
            int comparison_status = Comparer<TObject>.Default.Compare(a, b);
            Assert<TException>(comparison_status < 0, message);
        }
        /// <summary>
        /// Asserts one object is strictly less than another.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the tested objects.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsLessThan<T>(T a, T b, string message = null)
        {
            IsLessThan<T, ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts one object is strictly greater than another.
        /// </summary>
        /// <typeparam name="TObject">
        /// The type of the tested objects.
        /// </typeparam>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsGreaterThan<TObject, TException>(   
            TObject a,
            TObject b,
            string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to be greater than {b}.";
            }
            int comparison_status = Comparer<TObject>.Default.Compare(a, b);
            Assert<TException>(comparison_status > 0, message);
        }
        /// <summary>
        /// Asserts one object is strictly less than another.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the tested objects.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsGreaterThan<T>(T a, T b, string message = null)
        {
            IsGreaterThan<T, ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts one object is less than or equal to another.
        /// </summary>
        /// <typeparam name="TObject">
        /// The type of the tested objects.
        /// </typeparam>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsAtMost<TObject, TException>(
            TObject a,
            TObject b,
            string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to be at most {b}.";
            }
            int comparison_status = Comparer<TObject>.Default.Compare(a, b);
            Assert<TException>(comparison_status <= 0, message);
        }
        /// <summary>
        /// Asserts one object is less than or equal to another.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the tested objects.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsAtMost<T>(T a, T b, string message = null)
        {
            IsAtMost<T, ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts one object is greater than or equal to another.
        /// </summary>
        /// <typeparam name="TObject">
        /// The type of the tested objects.
        /// </typeparam>
        /// /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsAtLeast<TObject, TException>(
            TObject a,
            TObject b,
            string message = null)
            where TException: Exception, new()
        {
            if (message == null)
            {
                message = $"Expected {a} to be at least {b}.";
            }
            int comparison_status = Comparer<TObject>.Default.Compare(a, b);
            Assert<TException>(comparison_status >= 0, message);
        }
        /// <summary>
        /// Asserts one object is greater than or equal to another.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the tested objects.
        /// </typeparam>
        /// <param name="a">The first object to test.</param>
        /// <param name="b">The second object to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="ArgumentException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        public static void IsAtLeast<T>(T a, T b, string message = null)
        {
            IsAtLeast<T, ArgumentException>(a, b, message);
        }

        /// <summary>
        /// Asserts the specified value is true.
        /// </summary>
        /// <typeparam name="TException">
        /// The type of the exception to throw in case of failure.
        /// </typeparam>
        /// <param name="value">The value to test.</param>
        /// <param name="message">A message in case of failure.</param>
        /// <exception cref="TException">
        /// When the assertion fails.
        /// </exception>
        [Conditional("DEBUG")]
        private static void Assert<TException>(
            bool value,
            string message = "Failed assertion.")
            where TException: Exception, new()
        {
            if (!value)
            {
                throw Activator.CreateInstance(typeof(TException), message) 
                as TException;
            }
        }
    }
}

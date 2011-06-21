using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NUnit.Should
{
	public static class NUnitExtensions
	{
		public static void ShouldBeTrue(this bool actual)
		{
			Assert.IsTrue(actual);
		}

		public static void ShouldBeFalse(this bool actual)
		{
			Assert.IsFalse(actual);
		}

		public static void ShouldNotBeNull<T>(this T actual)
		{
			Assert.IsNotNull(actual);
		}

		public static void ShouldBeNull<T>(this T actual)
		{
			Assert.IsNull(actual);
		}

		public static void ShouldBeGreaterThan<T>(this T actual, T expected) where T : IComparable
		{
			Assert.Greater(expected, actual);
		}

		public static void ShouldBe<T>(this T actual, T expected)
		{
			Assert.AreEqual(expected, actual);
		}

		public static void ShouldBeSameAs<T>(this T actual, T expected)
		{
			Assert.AreSame(expected, actual);
		}

		public static void ShouldContain<T>(this IEnumerable<T> collection, T item)
		{
			Assert.Contains(item, collection.ToList());
		}

		public static void ShouldNotContain<T>(this IEnumerable<T> collection, T item)
		{
			Assert.IsFalse(collection.Contains(item));
		}

		public static void ShouldBeOfType<T>(this object expected)
		{
			Assert.IsTrue(expected.GetType() == typeof(T));
		}
	}
}

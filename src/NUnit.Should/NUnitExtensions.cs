using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NUnit.Should
{
	public static class NUnitExtensions
	{
		public static void ShouldBeTrue(this bool expected)
		{
			Assert.IsTrue(expected);
		}

		public static void ShouldBeFalse(this bool expected)
		{
			Assert.IsFalse(expected);
		}

		public static void ShouldNotBeNull<T>(this T expected)
		{
			Assert.IsNotNull(expected);
		}

		public static void ShouldBeNull<T>(this T expected)
		{
			Assert.IsNull(expected);
		}

		public static void ShouldBeGreaterThan<T>(this T expected, T actual) where T : IComparable
		{
			Assert.Greater(expected, actual);
		}

		public static void ShouldBe<T>(this T expected, T actual)
		{
			Assert.AreEqual(expected, actual);
		}

		public static void ShouldBeSameAs<T>(this T expected, T actual)
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

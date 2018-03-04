using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Feature
{
	[TestClass]
	public class YieldTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			foreach (var num in GetNumber())
			{
				Console.WriteLine(num);
			}
		}


		private static IEnumerable<int> GetNumber()
		{
			yield return 10;  // 첫번째 루프에서 리턴되는 값
			yield return 20;  // 두번째 루프에서 리턴되는 값
			yield return 30;  // 세번째 루프에서 리턴되는 값
		}

	}
}

﻿//
// GitTests.cs
//
// Author:
//       Manish Sinha <manish.sinha@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using NUnit.Framework;

namespace UserInterfaceTests
{
	[TestFixture]
	[Category ("Git")]
	public class GitTests : CreateBuildTemplatesTestBase
	{
		[Test]
		public void TestGitSSHClone ()
		{
			TestClone ("git@github.com:mono/monkeywrench.git");
		}

		[Test]
		public void TestGitHTTPSClone ()
		{
			TestClone ("https://github.com/mono/monkeywrench.git");
		}

		void TestClone (string url)
		{
			var checkoutFolder = VCSUtils.CheckoutOrClone (url, TakeScreenShot);
			FoldersToClean.Add (checkoutFolder);
			Assert.DoesNotThrow (() => Ide.WaitForSolutionLoaded (TakeScreenShot));
			Assert.DoesNotThrow (() => Ide.WaitForPackageUpdate());
			TakeScreenShot ("Packages-Updated");
		}
	}
}

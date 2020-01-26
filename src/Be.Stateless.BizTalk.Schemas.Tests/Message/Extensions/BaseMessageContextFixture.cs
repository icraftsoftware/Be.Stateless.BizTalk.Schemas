#region Copyright & License

// Copyright © 2012 - 2020 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using Be.Stateless.BizTalk.ContextProperties;
using FluentAssertions;
using Microsoft.BizTalk.Message.Interop;
using Moq;
using Xunit;

namespace Be.Stateless.BizTalk.Message.Extensions
{
	public class BaseMessageContextFixture
	{
		[Fact]
		public void ReadBoolean()
		{
			var messageContextMock = new Mock<IBaseMessageContext>();

			messageContextMock.Setup(c => c.Read(BtsProperties.AckRequired.Name, BtsProperties.AckRequired.Namespace)).Returns(null);
			messageContextMock.Object.GetProperty(BtsProperties.AckRequired).Should().BeNull();

			messageContextMock.Setup(c => c.Read(BtsProperties.AckRequired.Name, BtsProperties.AckRequired.Namespace)).Returns("true");
			messageContextMock.Object.GetProperty(BtsProperties.AckRequired).Should().BeTrue();

			messageContextMock.Setup(c => c.Read(BtsProperties.AckRequired.Name, BtsProperties.AckRequired.Namespace)).Returns("True");
			messageContextMock.Object.GetProperty(BtsProperties.AckRequired).Should().BeTrue();
		}

		[Fact]
		public void ReadDateTime()
		{
			var messageContextMock = new Mock<IBaseMessageContext>();

			messageContextMock.Setup(c => c.Read(FileProperties.FileCreationTime.Name, FileProperties.FileCreationTime.Namespace)).Returns(null);
			messageContextMock.Object.GetProperty(FileProperties.FileCreationTime).Should().BeNull();

			messageContextMock.Setup(c => c.Read(FileProperties.FileCreationTime.Name, FileProperties.FileCreationTime.Namespace)).Returns("2012-12-01");
			messageContextMock.Object.GetProperty(FileProperties.FileCreationTime).Should().Be(new DateTime(2012, 12, 1));

			messageContextMock.Setup(c => c.Read(FileProperties.FileCreationTime.Name, FileProperties.FileCreationTime.Namespace)).Returns("2017-09-15T10:19:06");
			messageContextMock.Object.GetProperty(FileProperties.FileCreationTime).Should().Be(new DateTime(2017, 9, 15, 10, 19, 6));
		}

		[Fact]
		public void ReadInteger()
		{
			var messageContextMock = new Mock<IBaseMessageContext>();

			messageContextMock.Setup(c => c.Read(BtsProperties.RetryCount.Name, BtsProperties.RetryCount.Namespace)).Returns(null);
			messageContextMock.Object.GetProperty(BtsProperties.RetryCount).Should().BeNull();

			messageContextMock.Setup(c => c.Read(BtsProperties.RetryCount.Name, BtsProperties.RetryCount.Namespace)).Returns("2");
			messageContextMock.Object.GetProperty(BtsProperties.RetryCount).Should().Be(2);
		}
	}
}

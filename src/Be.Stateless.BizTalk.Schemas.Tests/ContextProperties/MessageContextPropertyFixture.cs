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
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using FluentAssertions;
using Microsoft.XLANGs.BaseTypes;
using Xunit;

namespace Be.Stateless.BizTalk.ContextProperties
{
	public class MessageContextPropertyFixture
	{
		[Fact]
		[SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
		public void MessageContextPropertyEnforcesStrongTyping()
		{
			Action act = () => new MessageContextProperty<DummyProperty, string>();
			act.Should().NotThrow();
		}

		[Fact]
		[SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
		public void MessageContextPropertyThrowsWhenSchemaDeclaredPropertyTypeIsNotRespected()
		{
			Action act = () => new MessageContextProperty<DummyProperty, int>();
			act.Should().Throw<TypeInitializationException>()
				.WithInnerExceptionExactly<ArgumentException>()
				.WithMessage("Message context property 'DummyProperty' is of type 'String' but MessageContextProperty<DummyProperty, Int32> declares it of type 'Int32'.");
		}

		private class DummyProperty : MessageContextPropertyBase
		{
			#region Base Class Member Overrides

			public override XmlQualifiedName Name => _qualifiedName;

			public override Type Type => typeof(string);

			#endregion

			private static readonly XmlQualifiedName _qualifiedName = new XmlQualifiedName(@"DummyProperty", @"urn:schemas.stateless.be:biztalk:properties:dummy:2012:04");
		}
	}
}

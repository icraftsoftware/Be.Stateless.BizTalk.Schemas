#region Copyright & License

// Copyright © 2012 - 2021 François Chabot
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

using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using Be.Stateless.BizTalk.Message;
using Be.Stateless.BizTalk.Schemas.Xml;
using Be.Stateless.IO.Extensions;
using Be.Stateless.Resources;
using BTF2Schemas;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace Be.Stateless.BizTalk.Unit.Schema
{
	public class SchemaFixtureFixture
	{
		[Fact]
		public void LaxValidation()
		{
			Invoking(
					() => new EnvelopeSchemaFixture().ValidateInstanceDocument(
						ResourceManager.Load(Assembly.GetExecutingAssembly(), "Be.Stateless.BizTalk.Resources.Envelope.xml"),
						XmlSchemaContentProcessing.Lax))
				.Should().NotThrow();
		}

		[Fact]
		public void StrictValidation()
		{
			Invoking(
					() => new EnvelopeSchemaFixture().ValidateInstanceDocument(
						ResourceManager.Load(Assembly.GetExecutingAssembly(), "Be.Stateless.BizTalk.Resources.Envelope.xml"),
						XmlSchemaContentProcessing.Strict))
				.Should().Throw<XmlSchemaValidationException>().WithMessage("Warning: Could not find schema information for the element 'nested'.");
		}

		[Fact]
		public void ValidatingInvalidXmlDocumentThrows()
		{
			var instance = MessageBodyFactory.Create<btf2_services_header>();
			Invoking(() => new DocumentSchemaFixture().ValidateInstanceDocument(instance))
				.Should().Throw<XmlSchemaValidationException>()
				.WithMessage(
					"Error: The 'http://schemas.biztalk.org/btf-2-0/services:sendBy' element is invalid - The value '' is invalid according to its datatype 'http://www.w3.org/2001/XMLSchema:dateTime'*");
		}

		[Fact]
		public void ValidatingInvalidXmlFileThrows()
		{
			var tempFileName = Path.GetTempFileName();
			var instance = MessageBodyFactory.Create<btf2_services_header>();
			instance.Save(tempFileName);
			Invoking(() => new DocumentSchemaFixture().ValidateInstanceDocument(tempFileName))
				.Should().Throw<XmlSchemaValidationException>()
				.WithMessage(
					"Error: The 'http://schemas.biztalk.org/btf-2-0/services:sendBy' element is invalid - The value '' is invalid according to its datatype 'http://www.w3.org/2001/XMLSchema:dateTime'*");
		}

		[Fact]
		public void ValidatingValidXmlDoesNotThrow()
		{
			var instance = MessageBodyFactory.Create<btf2_services_header>(
				ResourceManager.Load(Assembly.GetExecutingAssembly(), "Be.Stateless.BizTalk.Resources.Message.xml", s => s.ReadToEnd()));
			Invoking(() => new DocumentSchemaFixture().ValidateInstanceDocument(instance))
				.Should().NotThrow();
		}

		private class EnvelopeSchemaFixture : SchemaFixture<Envelope>
		{
			public new void ValidateInstanceDocument(System.IO.Stream stream, XmlSchemaContentProcessing contentProcessing)
			{
				base.ValidateInstanceDocument(stream, contentProcessing);
			}
		}

		private class DocumentSchemaFixture : SchemaFixture<btf2_services_header>
		{
			public new void ValidateInstanceDocument(string filepath)
			{
				base.ValidateInstanceDocument(filepath);
			}

			public new void ValidateInstanceDocument(XmlDocument document)
			{
				base.ValidateInstanceDocument(document);
			}
		}
	}
}

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

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Be.Stateless.BizTalk.Schema;

namespace Be.Stateless.BizTalk.Extensions
{
	public static class SchemaAssemblyExtensions
	{
		[SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Public API.")]
		public static IEnumerable<Type> GetSchemaRoots(this Assembly assembly)
		{
			return assembly.GetTypes().Where(t => t.IsSchemaRoot());
		}

		public static IEnumerable<Tuple<Type, string>> GetUnpromotableMessageTypes(this Assembly assembly)
		{
			return assembly.GetSchemaRoots()
				.Where(t => !t.IsPromotableMessageType())
				.Select(t => Tuple.Create(t, SchemaMetadata.For(t).MessageType));
		}

		public static IEnumerable<Type> GetUnpromotableSchemaStrongNames(this Assembly assembly)
		{
			return assembly.GetSchemaRoots().Where(t => !t.IsPromotableSchemaStrongName());
		}
	}
}

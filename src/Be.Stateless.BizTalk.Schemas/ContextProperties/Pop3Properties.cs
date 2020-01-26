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

using System.Diagnostics.CodeAnalysis;
using POP3;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global")]
	public static class Pop3Properties
	{
		public static readonly MessageContextProperty<Date, string> Date
			= new MessageContextProperty<Date, string>();

		public static readonly MessageContextProperty<From, string> From
			= new MessageContextProperty<From, string>();

		public static readonly MessageContextProperty<Subject, string> Subject
			= new MessageContextProperty<Subject, string>();
	}
}

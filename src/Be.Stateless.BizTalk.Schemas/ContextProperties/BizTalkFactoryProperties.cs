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
using Be.Stateless.BizTalk.Schemas.BizTalkFactory;

namespace Be.Stateless.BizTalk.ContextProperties
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	public static class BizTalkFactoryProperties
	{
		public static readonly MessageContextProperty<ContextBuilderTypeName, string> ContextBuilderTypeName
			= new MessageContextProperty<ContextBuilderTypeName, string>();

		public static readonly MessageContextProperty<CorrelationId, string> CorrelationId
			= new MessageContextProperty<CorrelationId, string>();

		/// <summary>
		/// To be used when one application has to be connected to several distinct sets of interacting parties and cannot leak
		/// messages from one set of parties into another. In concrete terms, to be used in pub/sub of messages in order to keep
		/// them strictly insulated within an individual set of such interacting parties.
		/// </summary>
		public static readonly MessageContextProperty<EnvironmentTag, string> EnvironmentTag
			= new MessageContextProperty<EnvironmentTag, string>();

		public static readonly MessageContextProperty<MapTypeName, string> MapTypeName
			= new MessageContextProperty<MapTypeName, string>();

		public static readonly MessageContextProperty<MessageBodyStreamFactoryTypeName, string> MessageBodyStreamFactoryTypeName
			= new MessageContextProperty<MessageBodyStreamFactoryTypeName, string>();

		public static readonly MessageContextProperty<MessageType, string> MessageType
			= new MessageContextProperty<MessageType, string>();

		public static readonly MessageContextProperty<OutboundTransportLocation, string> OutboundTransportLocation
			= new MessageContextProperty<OutboundTransportLocation, string>();

		/// <summary>
		/// Name of the intended receiver of the current message.
		/// </summary>
		public static readonly MessageContextProperty<ReceiverName, string> ReceiverName
			= new MessageContextProperty<ReceiverName, string>();

		/// <summary>
		/// Name of the initiating sender of the current message.
		/// </summary>
		public static readonly MessageContextProperty<SenderName, string> SenderName
			= new MessageContextProperty<SenderName, string>();

		public static readonly MessageContextProperty<XmlTranslations, string> XmlTranslations
			= new MessageContextProperty<XmlTranslations, string>();
	}
}

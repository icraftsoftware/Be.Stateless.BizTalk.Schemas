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
using Be.Stateless.BizTalk.Message.Extensions;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.XLANGs.BaseTypes;

namespace Be.Stateless.BizTalk.ContextProperties.Extensions
{
	/// <summary>
	/// Fluent-syntax <see cref="IBaseMessage"/> and <see cref="IBaseMessageContext"/> helpers for <see
	/// cref="BizTalkFactoryProperties"/> context properties.
	/// </summary>
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	public static class BizTalkFactoryPropertiesExtensions
	{
		public static IBaseMessage SetCorrelationId(this IBaseMessage message, string correlationId)
		{
			message.SetProperty(BizTalkFactoryProperties.CorrelationId, correlationId);
			return message;
		}

		public static IBaseMessageContext SetCorrelationId(this IBaseMessageContext context, string correlationId)
		{
			context.SetProperty(BizTalkFactoryProperties.CorrelationId, correlationId);
			return context;
		}

		public static IBaseMessage PromoteCorrelationId(this IBaseMessage message, string correlationId)
		{
			message.Promote(BizTalkFactoryProperties.CorrelationId, correlationId);
			return message;
		}

		public static IBaseMessageContext PromoteCorrelationId(this IBaseMessageContext context, string correlationId)
		{
			context.Promote(BizTalkFactoryProperties.CorrelationId, correlationId);
			return context;
		}

		public static IBaseMessage SetEnvironmentTag(this IBaseMessage message, string environmentTag)
		{
			message.SetProperty(BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return message;
		}

		public static IBaseMessageContext SetEnvironmentTag(this IBaseMessageContext context, string environmentTag)
		{
			context.SetProperty(BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return context;
		}

		public static IBaseMessage PromoteEnvironmentTag(this IBaseMessage message, string environmentTag)
		{
			message.Promote(BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return message;
		}

		public static IBaseMessageContext PromoteEnvironmentTag(this IBaseMessageContext context, string environmentTag)
		{
			context.Promote(BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return context;
		}

		public static IBaseMessage SetMap<T>(this IBaseMessage message) where T : TransformBase
		{
			message.SetProperty(BizTalkFactoryProperties.MapTypeName, typeof(T).AssemblyQualifiedName);
			return message;
		}

		public static IBaseMessageContext SetMap<T>(this IBaseMessageContext context) where T : TransformBase
		{
			context.SetProperty(BizTalkFactoryProperties.MapTypeName, typeof(T).AssemblyQualifiedName);
			return context;
		}

		public static IBaseMessage SetOutboundTransportLocation(this IBaseMessage message, string outboundTransportLocation)
		{
			message.SetProperty(BizTalkFactoryProperties.OutboundTransportLocation, outboundTransportLocation);
			return message;
		}

		public static IBaseMessageContext SetOutboundTransportLocation(this IBaseMessageContext context, string outboundTransportLocation)
		{
			context.SetProperty(BizTalkFactoryProperties.OutboundTransportLocation, outboundTransportLocation);
			return context;
		}

		public static IBaseMessage SetReceiverName(this IBaseMessage message, string receiverName)
		{
			message.SetProperty(BizTalkFactoryProperties.ReceiverName, receiverName);
			return message;
		}

		public static IBaseMessageContext SetReceiverName(this IBaseMessageContext context, string receiverName)
		{
			context.SetProperty(BizTalkFactoryProperties.ReceiverName, receiverName);
			return context;
		}

		public static IBaseMessage PromoteReceiverName(this IBaseMessage message, string receiverName)
		{
			message.Promote(BizTalkFactoryProperties.ReceiverName, receiverName);
			return message;
		}

		public static IBaseMessageContext PromoteReceiverName(this IBaseMessageContext context, string receiverName)
		{
			context.Promote(BizTalkFactoryProperties.ReceiverName, receiverName);
			return context;
		}

		public static IBaseMessage SetSenderName(this IBaseMessage message, string senderName)
		{
			message.SetProperty(BizTalkFactoryProperties.SenderName, senderName);
			return message;
		}

		public static IBaseMessageContext SetSenderName(this IBaseMessageContext context, string senderName)
		{
			context.SetProperty(BizTalkFactoryProperties.SenderName, senderName);
			return context;
		}

		public static IBaseMessage PromoteSenderName(this IBaseMessage message, string senderName)
		{
			message.Promote(BizTalkFactoryProperties.SenderName, senderName);
			return message;
		}

		public static IBaseMessageContext PromoteSenderName(this IBaseMessageContext context, string senderName)
		{
			context.Promote(BizTalkFactoryProperties.SenderName, senderName);
			return context;
		}
	}
}

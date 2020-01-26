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

using System.Diagnostics.CodeAnalysis;
using Be.Stateless.BizTalk.Message.Extensions;
using Microsoft.BizTalk.Message.Interop;

namespace Be.Stateless.BizTalk.ContextProperties.Extensions
{
	/// <summary>
	/// Fluent-syntax <see cref="IBaseMessage"/> and <see cref="IBaseMessageContext"/> helpers for <see
	/// cref="Subscribable.BizTalkFactoryProperties"/> context properties.
	/// </summary>
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
	[SuppressMessage("ReSharper", "UnusedType.Global", Justification = "Public API.")]
	public static class BizTalkFactorySubscribablePropertiesExtensions
	{
		public static IBaseMessage SetCorrelationId(this IBaseMessage message, string correlationId)
		{
			message.SetProperty(Subscribable.BizTalkFactoryProperties.CorrelationId, correlationId);
			return message;
		}

		public static IBaseMessageContext SetCorrelationId(this IBaseMessageContext context, string correlationId)
		{
			context.SetProperty(Subscribable.BizTalkFactoryProperties.CorrelationId, correlationId);
			return context;
		}

		public static IBaseMessage PromoteCorrelationId(this IBaseMessage message, string correlationId)
		{
			message.Promote(Subscribable.BizTalkFactoryProperties.CorrelationId, correlationId);
			return message;
		}

		public static IBaseMessageContext PromoteCorrelationId(this IBaseMessageContext context, string correlationId)
		{
			context.Promote(Subscribable.BizTalkFactoryProperties.CorrelationId, correlationId);
			return context;
		}

		public static IBaseMessage SetEnvironmentTag(this IBaseMessage message, string environmentTag)
		{
			message.SetProperty(Subscribable.BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return message;
		}

		public static IBaseMessageContext SetEnvironmentTag(this IBaseMessageContext context, string environmentTag)
		{
			context.SetProperty(Subscribable.BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return context;
		}

		public static IBaseMessage PromoteEnvironmentTag(this IBaseMessage message, string environmentTag)
		{
			message.Promote(Subscribable.BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return message;
		}

		public static IBaseMessageContext PromoteEnvironmentTag(this IBaseMessageContext context, string environmentTag)
		{
			context.Promote(Subscribable.BizTalkFactoryProperties.EnvironmentTag, environmentTag);
			return context;
		}

		public static IBaseMessage SetReceiverName(this IBaseMessage message, string receiverName)
		{
			message.SetProperty(Subscribable.BizTalkFactoryProperties.ReceiverName, receiverName);
			return message;
		}

		public static IBaseMessageContext SetReceiverName(this IBaseMessageContext context, string receiverName)
		{
			context.SetProperty(Subscribable.BizTalkFactoryProperties.ReceiverName, receiverName);
			return context;
		}

		public static IBaseMessage PromoteReceiverName(this IBaseMessage message, string receiverName)
		{
			message.Promote(Subscribable.BizTalkFactoryProperties.ReceiverName, receiverName);
			return message;
		}

		public static IBaseMessageContext PromoteReceiverName(this IBaseMessageContext context, string receiverName)
		{
			context.Promote(Subscribable.BizTalkFactoryProperties.ReceiverName, receiverName);
			return context;
		}

		public static IBaseMessage SetSenderName(this IBaseMessage message, string senderName)
		{
			message.SetProperty(Subscribable.BizTalkFactoryProperties.SenderName, senderName);
			return message;
		}

		public static IBaseMessageContext SetSenderName(this IBaseMessageContext context, string senderName)
		{
			context.SetProperty(Subscribable.BizTalkFactoryProperties.SenderName, senderName);
			return context;
		}

		public static IBaseMessage PromoteSenderName(this IBaseMessage message, string senderName)
		{
			message.Promote(Subscribable.BizTalkFactoryProperties.SenderName, senderName);
			return message;
		}

		public static IBaseMessageContext PromoteSenderName(this IBaseMessageContext context, string senderName)
		{
			context.Promote(Subscribable.BizTalkFactoryProperties.SenderName, senderName);
			return context;
		}
	}
}

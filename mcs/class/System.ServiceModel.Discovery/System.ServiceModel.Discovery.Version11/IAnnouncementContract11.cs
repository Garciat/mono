//
// Author: Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2010 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Discovery;

namespace System.ServiceModel.Discovery.Version11
{
	[ServiceContract (Name = "Client", Namespace = MessageContracts11.NS)]
	internal interface IAnnouncementContract11
	{
		[OperationContract (Name = "Hello", Action = MessageContracts11.HelloAction, IsOneWay = true, AsyncPattern = true)]
		IAsyncResult BeginOnlineAnnouncement (MessageContracts11.OnlineAnnouncement message, AsyncCallback callback, object state);

		void EndOnlineAnnouncement (IAsyncResult result);

		[OperationContract (Name = "Bye", Action = MessageContracts11.ByeAction, IsOneWay = true, AsyncPattern = true)]
		IAsyncResult BeginOfflineAnnouncement (MessageContracts11.OfflineAnnouncement message, AsyncCallback callback, object state);

		void EndOfflineAnnouncement (IAsyncResult result);
	}
}

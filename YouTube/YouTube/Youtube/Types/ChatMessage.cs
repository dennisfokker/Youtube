﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Youtube.Types
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class ChatMessage
	{
		public virtual int MessageID
		{
			get;
			private set;
		}

		public virtual string Content
		{
			get;
			private set;
		}

		public virtual Channel Author
		{
			get;
			set;
		}

	}
}


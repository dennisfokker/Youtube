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

	public class Video
	{
		public virtual int VideoID
		{
			get;
			private set;
		}

		public virtual string Title
		{
			get;
			private set;
		}

		public virtual int Views
		{
			get;
			private set;
		}

		public virtual string Description
		{
			get;
			private set;
		}

		public virtual DateTime UploadDate
		{
			get;
			private set;
		}

		public virtual int UpVotes
		{
			get;
			private set;
		}

		public virtual int DownVotes
		{
			get;
			private set;
		}

		public virtual string VideoLink
		{
			get;
			private set;
		}

		public virtual IEnumerable<Comment> Comments
		{
			get;
			set;
		}

		public virtual Channel Creator
		{
			get;
			set;
		}

		public virtual void EditDescription(string description)
		{
			throw new System.NotImplementedException();
		}

		public virtual void AddDownVote()
		{
			throw new System.NotImplementedException();
		}

		public virtual void RemoveDownVote()
		{
			throw new System.NotImplementedException();
		}

		public virtual void EditTitle(string title)
		{
			throw new System.NotImplementedException();
		}

		public virtual void AddUpVote()
		{
			throw new System.NotImplementedException();
		}

		public virtual void RemoveUpVote()
		{
			throw new System.NotImplementedException();
		}

		public virtual void AddView()
		{
			throw new System.NotImplementedException();
		}

		public virtual void AddComment(Comment comment)
		{
			throw new System.NotImplementedException();
		}

	}
}


// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data containing which users presence has changed
	/// </summary>
	public struct PresenceChangedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Client-specified data passed into <see cref="PresenceInterface.AddNotifyOnPresenceChanged" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Epic Account ID of the local user who is being informed for PresenceUserId's presence change
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Account ID of the user who had their presence changed
		/// </summary>
		public EpicAccountId PresenceUserId { get; set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ref PresenceChangedCallbackInfoInternal other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			PresenceUserId = other.PresenceUserId;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PresenceChangedCallbackInfo>, ISettable<PresenceChangedCallbackInfo>, System.IDisposable
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_PresenceUserId;

		public object ClientData
		{
			get
			{
				object value;
				Helper.Get(m_ClientData, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ClientData);
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public EpicAccountId PresenceUserId
		{
			get
			{
				EpicAccountId value;
				Helper.Get(m_PresenceUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_PresenceUserId);
			}
		}

		public void Set(ref PresenceChangedCallbackInfo other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			PresenceUserId = other.PresenceUserId;
		}

		public void Set(ref PresenceChangedCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				PresenceUserId = other.Value.PresenceUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_PresenceUserId);
		}

		public void Get(out PresenceChangedCallbackInfo output)
		{
			output = new PresenceChangedCallbackInfo();
			output.Set(ref this);
		}
	}
}
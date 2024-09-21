// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about who would like to receive a packet.
	/// </summary>
	public struct GetNextReceivedPacketSizeOptions
	{
		/// <summary>
		/// The Product User ID of the local user who is receiving the packet
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// An optional channel to request the data for. If <see langword="null" />, we're retrieving the size of the next packet on any channel.
		/// </summary>
		public byte? RequestedChannel { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable<GetNextReceivedPacketSizeOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RequestedChannel;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public byte? RequestedChannel
		{
			set
			{
				Helper.Set(value, ref m_RequestedChannel);
			}
		}

		public void Set(ref GetNextReceivedPacketSizeOptions other)
		{
			m_ApiVersion = P2PInterface.GetnextreceivedpacketsizeApiLatest;
			LocalUserId = other.LocalUserId;
			RequestedChannel = other.RequestedChannel;
		}

		public void Set(ref GetNextReceivedPacketSizeOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = P2PInterface.GetnextreceivedpacketsizeApiLatest;
				LocalUserId = other.Value.LocalUserId;
				RequestedChannel = other.Value.RequestedChannel;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RequestedChannel);
		}
	}
}
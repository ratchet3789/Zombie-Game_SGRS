// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.UpdateLobby" /> function.
	/// </summary>
	public struct UpdateLobbyOptions
	{
		/// <summary>
		/// Builder handle
		/// </summary>
		public LobbyModification LobbyModificationHandle { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateLobbyOptionsInternal : ISettable<UpdateLobbyOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LobbyModificationHandle;

		public LobbyModification LobbyModificationHandle
		{
			set
			{
				Helper.Set(value, ref m_LobbyModificationHandle);
			}
		}

		public void Set(ref UpdateLobbyOptions other)
		{
			m_ApiVersion = LobbyInterface.UpdatelobbyApiLatest;
			LobbyModificationHandle = other.LobbyModificationHandle;
		}

		public void Set(ref UpdateLobbyOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = LobbyInterface.UpdatelobbyApiLatest;
				LobbyModificationHandle = other.Value.LobbyModificationHandle;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LobbyModificationHandle);
		}
	}
}
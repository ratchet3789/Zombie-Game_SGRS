// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

#if DEBUG
	#define EOS_DEBUG
#endif

#if UNITY_EDITOR
	#define EOS_EDITOR
#endif

#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_PS4 || UNITY_XBOXONE || UNITY_SWITCH || UNITY_IOS || UNITY_ANDROID
	#define EOS_UNITY
#endif

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN || PLATFORM_64BITS || PLATFORM_32BITS
	#if UNITY_EDITOR_WIN || UNITY_64 || PLATFORM_64BITS
		#define EOS_PLATFORM_WINDOWS_64
	#else
		#define EOS_PLATFORM_WINDOWS_32
	#endif

#elif UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
	#define EOS_PLATFORM_OSX

#elif UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
	#define EOS_PLATFORM_LINUX

#elif UNITY_PS4
	#define EOS_PLATFORM_PS4

#elif UNITY_XBOXONE
	#define EOS_PLATFORM_XBOXONE

#elif UNITY_SWITCH
	#define EOS_PLATFORM_SWITCH

#elif UNITY_IOS || __IOS__
	#define EOS_PLATFORM_IOS

#elif UNITY_ANDROID || __ANDROID__
	#define EOS_PLATFORM_ANDROID

#endif

#if EOS_EDITOR
	#define EOS_DYNAMIC_BINDINGS
#endif

#if EOS_DYNAMIC_BINDINGS
	#if EOS_PLATFORM_WINDOWS_32
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE3
	#elif EOS_PLATFORM_OSX
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE2
	#else
		#define EOS_DYNAMIC_BINDINGS_NAME_TYPE1
	#endif
#endif

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices
{
	public static partial class AndroidBindings
	{
#if EOS_DYNAMIC_BINDINGS_NAME_TYPE1
		private const string EOS_InitializeName = "EOS_Initialize";
#endif

#if EOS_DYNAMIC_BINDINGS_NAME_TYPE2
		private const string EOS_InitializeName = "_EOS_Initialize";
#endif

#if EOS_DYNAMIC_BINDINGS_NAME_TYPE3
		private const string EOS_InitializeName = "_EOS_Initialize@4";
#endif

#if EOS_DYNAMIC_BINDINGS
		/// <summary>
		/// Hooks the dynamic SDK API bindings. EOS_DYNAMIC_BINDINGS or EOS_EDITOR must be set.
		/// </summary>
		/// <param name="libraryHandle">The library handle to find functions in. The type is platform dependent, but would typically be <see cref="System.IntPtr"/>.</param>
		/// <param name="getFunctionPointer">A delegate that gets a function pointer using the given library handle and function name.</param>
		public static void Hook<TLibraryHandle>(TLibraryHandle libraryHandle, Func<TLibraryHandle, string, IntPtr> getFunctionPointer)
		{
			System.IntPtr functionPointer;

			functionPointer = getFunctionPointer(libraryHandle, EOS_InitializeName);
			if (functionPointer == System.IntPtr.Zero) throw new DynamicBindingException(EOS_InitializeName);
			EOS_Initialize = (EOS_InitializeDelegate)Marshal.GetDelegateForFunctionPointer(functionPointer, typeof(EOS_InitializeDelegate));
		}
#endif

#if EOS_DYNAMIC_BINDINGS
		/// <summary>
		/// Unhooks the dynamic SDK API bindings. EOS_DYNAMIC_BINDINGS or EOS_EDITOR must be set.
		/// </summary>
		public static void Unhook()
		{
			EOS_Initialize = null;
		}
#endif

#if EOS_DYNAMIC_BINDINGS
		[UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
		internal delegate Result EOS_InitializeDelegate(ref Platform.AndroidInitializeOptionsInternal options);
		internal static EOS_InitializeDelegate EOS_Initialize;
#endif

#if !EOS_DYNAMIC_BINDINGS
		[DllImport(Config.LibraryName)]
		internal static extern Result EOS_Initialize(ref Platform.AndroidInitializeOptionsInternal options);
#endif
	}
}
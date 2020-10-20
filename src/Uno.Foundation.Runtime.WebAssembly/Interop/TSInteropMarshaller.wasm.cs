﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Uno.Extensions;
using Uno.Foundation;

namespace Uno.Foundation.Interop
{
	public static unsafe class TSInteropMarshaller 
	{
		[DllImport("*")]
		private static unsafe extern int printf(byte* str, byte* unused);

		private static readonly Lazy<ILogger> _logger = new Lazy<ILogger>(() => typeof(TSInteropMarshaller).Log());

		public const UnmanagedType LPUTF8Str = (UnmanagedType)48;

		/// <summary>
		/// Prints the actual offsets of the structures present in <see cref="WindowManagerInterop"/> for debugging purposes.
		/// </summary>
		internal static void GenerateTSMarshallingLayouts()
		{
			// Uncomment this to troubshoot this field offsets.
			//
			// Console.WriteLine("Generating layouts");
			// foreach (var p in typeof(WindowManagerInterop).GetNestedTypes(System.Reflection.BindingFlags.NonPublic).Where(t => t.IsValueType))
			// {
			// 		var sb = new StringBuilder();
			   
			// 		Console.WriteLine($"class {p.Name}:");
			   
			// 		foreach (var field in p.GetFields())
			// 		{
			// 			var fieldOffset = Marshal.OffsetOf(p, field.Name);
			// 			Console.WriteLine($"\t{field.Name} : {fieldOffset}");
			// 		}
			// }
		}
		public struct TwoByteStr
		{
			public byte first;
			public byte second;
		}
		private static unsafe void PrintString(string s)
		{
			int length = s.Length;
			fixed (char* curChar = s)
			{
				for (int i = 0; i < length; i++)
				{
					TwoByteStr curCharStr = new TwoByteStr();
					curCharStr.first = (byte)(*(curChar + i));
					printf((byte*)&curCharStr, null);
				}
			}
		}
		public static void PrintLine(string s)
		{
			PrintString(s);
			PrintString("\n");
		}

		public static void InvokeJS<TParam>(
			string methodName,
			TParam paramStruct,
			[System.Runtime.CompilerServices.CallerMemberName] string memberName = null
		)
		{
			if (_logger.Value.IsEnabled(LogLevel.Debug))
			{
				_logger.Value.LogDebug($"InvokeJS for {memberName}/{typeof(TParam)}");
			}

			PrintLine("methodName:" + methodName);
			PrintLine("type:" + typeof(TParam).Name);
			PrintLine("size:" + MarshalSizeOf<TParam>.Size.ToString());
			var pParms = Marshal.AllocHGlobal(MarshalSizeOf<TParam>.Size);

			Marshal.StructureToPtr(paramStruct, pParms, false);
			PrintLine(pParms.ToInt32().ToString());
			WebAssemblyRuntime.InvokeJSUnmarshalled(methodName, pParms, out var exception);

			Marshal.DestroyStructure(pParms, typeof(TParam));
			Marshal.FreeHGlobal(pParms);

			if (exception != null)
			{
				if (_logger.Value.IsEnabled(LogLevel.Error))
				{
					_logger.Value.LogError($"Failed InvokeJS for {memberName}/{typeof(TParam)}: {exception}");
				}

				throw exception;
			}
		}

		public static TRet InvokeJS<TParam, TRet>(
			string methodName,
			TParam paramStruct,
			[System.Runtime.CompilerServices.CallerMemberName] string memberName = null
		)
		{
			if (_logger.Value.IsEnabled(LogLevel.Debug))
			{
				_logger.Value.LogDebug($"InvokeJS for {memberName}/{typeof(TParam)}/{typeof(TRet)}");
			}

			var pParms = Marshal.AllocHGlobal(MarshalSizeOf<TParam>.Size);
			var pReturnValue = Marshal.AllocHGlobal(MarshalSizeOf<TRet>.Size);

			TRet returnValue = default;

			try
			{
				Marshal.StructureToPtr(paramStruct, pParms, false);
				Marshal.StructureToPtr(returnValue, pReturnValue, false);

				var ret = WebAssemblyRuntime.InvokeJSUnmarshalled(methodName, pParms, pReturnValue);

				returnValue = (TRet)Marshal.PtrToStructure(pReturnValue, typeof(TRet));
				return returnValue;
			}
			catch (Exception e)
			{
				if (_logger.Value.IsEnabled(LogLevel.Error))
				{
					_logger.Value.LogDebug($"Failed InvokeJS for {memberName}/{typeof(TParam)}: {e}");
				}
				throw;
			}
			finally
			{
				Marshal.DestroyStructure(pParms, typeof(TParam));
				Marshal.FreeHGlobal(pParms);

				Marshal.DestroyStructure(pReturnValue, typeof(TRet));
				Marshal.FreeHGlobal(pReturnValue);
			}
		}

		private class MarshalSizeOf<T>
		{
			internal static readonly int Size = Marshal.SizeOf(typeof(T));
		}
	}
}

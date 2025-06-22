using BinarySerializerLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Base
{
    public static class RandomHandler
    {
        private static Random _Rnd = new();

        public static int GetNextCollectionSize(int maxCollectionSize = 100, int minCollectionSize = 0) => (_Rnd.Next() % (maxCollectionSize - minCollectionSize)) + minCollectionSize;

        #region NotNullable

        public static bool GetNextBool() => (bool)((GetNextUInt8() % 2) == 1);

        public static char GetNextChar() => (char)((GetNextUInt8() % 0x5F) + 0x20);

        public static string GetNextString(int maxStringSize = 100, int minCollectionSize = 0)
        {
            IEnumerable<char> _GetStringSymbols()
            {
                var isEmpty = GetNextBool();

                if (isEmpty)
                {
                    yield break;
                }

                foreach (var index in Enumerable.Range(0, GetNextCollectionSize(maxStringSize, minCollectionSize)))
                {
                    yield return GetNextChar();
                }
            }

            return new string(_GetStringSymbols().ToArray());
        }

        public static float GetNextFloat() => (float)_Rnd.NextDouble();

        public static double GetNextDouble() => (double)_Rnd.NextDouble();

        public static byte GetNextUInt8(int bitSize = 8) => (byte)((ulong)_Rnd.NextInt64() & ByteVectorHandler.GetMask(bitSize));

        public static sbyte GetNextInt8(int bitSize = 8) => (sbyte)(ByteVectorHandler.GetIntFromUInt((UInt64)_Rnd.NextInt64(), bitSize));

        public static UInt16 GetNextUInt16(int bitSize = 16) => (UInt16)((ulong)_Rnd.NextInt64() & ByteVectorHandler.GetMask(bitSize));

        public static Int16 GetNextInt16(int bitSize = 16) => (Int16)(ByteVectorHandler.GetIntFromUInt((UInt64)_Rnd.NextInt64(), bitSize));

        public static UInt32 GetNextUInt32(int bitSize = 32) => (UInt32)((ulong)_Rnd.NextInt64() & ByteVectorHandler.GetMask(bitSize));

        public static Int32 GetNextInt32(int bitSize = 32) => (Int32)(ByteVectorHandler.GetIntFromUInt((UInt64)_Rnd.NextInt64(), bitSize));

        public static UInt64 GetNextUInt64(int bitSize = 64) => (UInt64)((ulong)_Rnd.NextInt64() & ByteVectorHandler.GetMask(bitSize));

        public static Int64 GetNextInt64(int bitSize = 64) => (Int64)(ByteVectorHandler.GetIntFromUInt((UInt64)_Rnd.NextInt64(), bitSize));

        #endregion

        #region Nullable

        public static bool? GetNextBoolNullable () => GetNextBool() ? null : (bool?)GetNextBool();

        public static char? GetNextCharNullable() => GetNextBool() ? null : (char?)GetNextChar();

        public static string? GetNextStringNullable(int maxStringSize = 100, int minCollectionSize = 0) => GetNextBool() ? null : (string?)GetNextString(maxStringSize, minCollectionSize);

        public static float? GetNextFloatNullable() => GetNextBool() ? null : (float?)GetNextFloat();

        public static double? GetNextDoubleNullable() => GetNextBool() ? null : (double?)GetNextDouble();

        public static byte? GetNextUInt8Nullable(int bitSize = 8) => GetNextBool() ? null : (byte?)GetNextUInt8(bitSize);

        public static sbyte? GetNextInt8Nullable(int bitSize = 8) => GetNextBool() ? null : (sbyte?)GetNextInt8(bitSize);

        public static UInt16? GetNextUInt16Nullable(int bitSize = 16) => GetNextBool() ? null : (UInt16?)GetNextUInt16(bitSize);

        public static Int16? GetNextInt16Nullable(int bitSize = 16) => GetNextBool() ? null : (Int16?)GetNextInt16(bitSize);

        public static UInt32? GetNextUInt32Nullable(int bitSize = 32) => GetNextBool() ? null : (UInt32?)GetNextUInt32(bitSize);

        public static Int32? GetNextInt32Nullable(int bitSize = 32) => GetNextBool() ? null : (Int32?)GetNextInt32(bitSize);

        public static UInt64? GetNextUInt64Nullable(int bitSize = 64) => GetNextBool() ? null : (UInt64?)GetNextUInt64(bitSize);

        public static Int64? GetNextInt64Nullable(int bitSize = 64) => GetNextBool() ? null : (Int64?)GetNextInt64(bitSize);

        #endregion
    }
}

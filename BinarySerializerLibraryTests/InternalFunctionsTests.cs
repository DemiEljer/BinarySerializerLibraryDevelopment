using BinarySerializerLibrary.Attributes;
using BinarySerializerLibrary.BinaryDataHandlers;
using BinarySerializerLibrary.Enums;
using BinarySerializerLibrary.Exceptions;
using BinarySerializerLibrary.ObjectSerializationRecipes;
using BinarySerializerLibrary.Serializers;

namespace BinarySerializerLibraryTests;

[TestClass]
public class InternalFunctionsTests
{
    [TestMethod]
    public void TestCollectionSizeSerialization()
    {
        void _TestCollectionSizeValue(int collectionSize)
        {
            BinaryArrayBuilder ab = new();

            ComplexBaseTypeSerializer.SerializeCollectionSize
            (
                new BinaryTypeBoolAttribute(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.NoAlignment)
                , collectionSize
                , ab
            );

            BinaryArrayReader ar = new(ab.GetByteArray());

            var resultCollectionSize = ComplexBaseTypeSerializer.DeserializeCollectionSize
            (
                new BinaryTypeBoolAttribute(BinarySerializerLibrary.Enums.BinaryAlignmentTypeEnum.NoAlignment)
                , ar
            );

            Assert.AreEqual(collectionSize, resultCollectionSize);
        }

        _TestCollectionSizeValue(0);
        _TestCollectionSizeValue(0x3F);
        _TestCollectionSizeValue(0x40);
        _TestCollectionSizeValue(0x1524);
        _TestCollectionSizeValue(0x3FFF);
        _TestCollectionSizeValue(0x4000);
        _TestCollectionSizeValue(0x314565);
        _TestCollectionSizeValue(0x3FFFFF);
        _TestCollectionSizeValue(0x400000);
        _TestCollectionSizeValue(0x12FDCA43);
        _TestCollectionSizeValue(0x3FFFFFFF);
        Assert.ThrowsException<CollectionSizeIsTooLargeException>(() => _TestCollectionSizeValue(0x40000000));
    }

    [TestMethod]
    public void TestTypeVerification()
    {
        Type[] typesCollection = new Type[]
        {
            typeof(bool)                    // 0   
            , typeof(char)                  // 1
            , typeof(float)                 // 2
            , typeof(double)                // 3
            , typeof(byte)                  // 4
            , typeof(UInt16)                // 5
            , typeof(UInt32)                // 6
            , typeof(UInt64)                // 7
            , typeof(UInt128)               // 8
            , typeof(sbyte)                 // 9
            , typeof(Int16)                 // 10
            , typeof(Int32)                 // 11
            , typeof(Int64)                 // 12
            , typeof(Int128)                // 13
            
            , typeof(bool?)                 // 14
            , typeof(char?)                 // 15
            , typeof(float?)                // 16
            , typeof(double?)               // 17
            , typeof(byte?)                 // 18
            , typeof(UInt16?)               // 19
            , typeof(UInt32?)               // 20
            , typeof(UInt64?)               // 21
            , typeof(UInt128?)              // 22
            , typeof(sbyte?)                // 23
            , typeof(Int16?)                // 24
            , typeof(Int32?)                // 25
            , typeof(Int64?)                // 26
            , typeof(Int128)                // 27

            , typeof(object)                // 28
            , typeof(string)                // 29

            , typeof(bool[])                // 30
            , typeof(char[])                // 31
            , typeof(float[])               // 32
            , typeof(double[])              // 33
            , typeof(byte[])                // 34
            , typeof(UInt16[])              // 35
            , typeof(UInt32[])              // 36
            , typeof(UInt64[])              // 37
            , typeof(UInt128[])             // 38
            , typeof(sbyte[])               // 39
            , typeof(Int16[])               // 40
            , typeof(Int32[])               // 41
            , typeof(Int64[])               // 42
            , typeof(Int128[])              // 43

            , typeof(bool?[])               // 44
            , typeof(char?[])               // 45
            , typeof(float?[])              // 46
            , typeof(double?[])             // 47
            , typeof(byte?[])               // 48
            , typeof(UInt16?[])             // 49
            , typeof(UInt32?[])             // 50
            , typeof(UInt64?[])             // 51
            , typeof(UInt128?[])            // 52
            , typeof(sbyte?[])              // 53
            , typeof(Int16?[])              // 54
            , typeof(Int32?[])              // 55
            , typeof(Int64?[])              // 56
            , typeof(Int128[])              // 57

            , typeof(object[])              // 58
            , typeof(string[])              // 59

            , typeof(List<bool>)            // 60   
            , typeof(List<char>)            // 61
            , typeof(List<float>)           // 62
            , typeof(List<double>)          // 63
            , typeof(List<byte>)            // 64
            , typeof(List<UInt16>)          // 65
            , typeof(List<UInt32>)          // 66
            , typeof(List<UInt64>)          // 67
            , typeof(List<UInt128>)         // 68
            , typeof(List<sbyte>)           // 69
            , typeof(List<Int16>)           // 70
            , typeof(List<Int32>)           // 71
            , typeof(List<Int64>)           // 72
            , typeof(List<Int128>)          // 73
            
            , typeof(List<bool?>)           // 74
            , typeof(List<char?>)           // 75
            , typeof(List<float?>)          // 76
            , typeof(List<double?>)         // 77
            , typeof(List<byte?>)           // 78
            , typeof(List<UInt16?>)         // 79
            , typeof(List<UInt32?>)         // 80
            , typeof(List<UInt64?>)         // 81
            , typeof(List<UInt128?>)        // 82
            , typeof(List<sbyte?>)          // 83
            , typeof(List<Int16?>)          // 84
            , typeof(List<Int32?>)          // 85
            , typeof(List<Int64?>)          // 86
            , typeof(List<Int128>)          // 87

            , typeof(List<object>)          // 88
            , typeof(List<string>)          // 89
        };

        ObjectTypeVerificationHandler verificationHandler = new();

        void _VerifyAttribute(BinaryTypeBaseAttribute attribute, int[] suitableTypesIndexes)
        {
            foreach (var index in Enumerable.Range(0, typesCollection.Length))
            {
                if (suitableTypesIndexes.Contains(index))
                {
                    Assert.IsTrue(verificationHandler.VerifyPropertyType(typesCollection[index], attribute), $"{attribute} : {typesCollection[index]}");
                }
                else
                {
                    Assert.IsFalse(verificationHandler.VerifyPropertyType(typesCollection[index], attribute), $"{attribute} : {typesCollection[index]}");
                }
            }
        }

        // Bool
        {
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 0 });
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 0, 14 });
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 30 });
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 30, 44 });
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 60 });
            _VerifyAttribute(new BinaryTypeBoolAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 60, 74 });
        }
        // Char
        {
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 1 });
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 1, 15 });
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 31 });
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 31, 45 });
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 61 });
            _VerifyAttribute(new BinaryTypeCharAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 61, 75 });
        }
        // Float
        {

            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 2 });
            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 2, 16 });
            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 32 });
            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 32, 46 });
            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 62 });
            _VerifyAttribute(new BinaryTypeFloatAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 62, 76 });
        }
        // Double
        {
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 3 });
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 3, 17 });
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 33 });
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 33, 47 });
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 63 });
            _VerifyAttribute(new BinaryTypeDoubleAttribute(BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 63, 77 });
        }
        // Object
        {
            _VerifyAttribute(new BinaryTypeObjectAttribute(BinaryArgumentTypeEnum.Single), new int[] { 28 });
            _VerifyAttribute(new BinaryTypeObjectAttribute(BinaryArgumentTypeEnum.Array), new int[] { 58 });
            _VerifyAttribute(new BinaryTypeObjectAttribute(BinaryArgumentTypeEnum.List), new int[] { 88 });
        }
        // String
        {
            _VerifyAttribute(new BinaryTypeStringAttribute(BinaryArgumentTypeEnum.Single), new int[] { 29 });
            _VerifyAttribute(new BinaryTypeStringAttribute(BinaryArgumentTypeEnum.Array), new int[] { 59 });
            _VerifyAttribute(new BinaryTypeStringAttribute(BinaryArgumentTypeEnum.List), new int[] { 89 });
        }
        // UInt
        {
            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 4, 5, 6, 7 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 5, 6, 7 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 6, 7 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 7 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { });

            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 4, 5, 6, 7, 18, 19, 20, 21 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 5, 6, 7, 19, 20, 21 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 6, 7, 20, 21 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 7, 21 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { });

            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 34, 35, 36, 37 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 35, 36, 37 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 36, 37 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 37 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { });

            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 34, 35, 36, 37, 48, 49, 50, 51 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 35, 36, 37, 49, 50, 51 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 36, 37, 50, 51 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 37, 51 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { });

            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 64, 65, 66, 67 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 65, 66, 67 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 66, 67 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 67 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { });

            _VerifyAttribute(new BinaryTypeUIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 64, 65, 66, 67, 78, 79, 80, 81 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 65, 66, 67, 79, 80, 81 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 66, 67, 80, 81 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 67, 81 });
            _VerifyAttribute(new BinaryTypeUIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { });
        }
        // Int
        {
            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 9, 10, 11, 12 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 10, 11, 12 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 11, 12 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { 12 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Single), new int[] { });

            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 9, 10, 11, 12, 23, 24, 25, 26 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 10, 11, 12, 24, 25, 26 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 11, 12, 25, 26 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { 12, 26 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Single), new int[] { });

            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 39, 40, 41, 42 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 40, 41, 42 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 41, 42 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { 42 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.Array), new int[] { });

            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 39, 40, 41, 42, 53, 54, 55, 56 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 40, 41, 42, 54, 55, 56 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 41, 42, 55, 56 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { 42, 56 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.Array), new int[] { });

            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 69, 70, 71, 72 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 70, 71, 72 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 71, 72 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { 72 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.NotNullable, BinaryArgumentTypeEnum.List), new int[] { });

            _VerifyAttribute(new BinaryTypeIntAttribute(8, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 69, 70, 71, 72, 83, 84, 85, 86 });
            _VerifyAttribute(new BinaryTypeIntAttribute(16, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 70, 71, 72, 84, 85, 86 });
            _VerifyAttribute(new BinaryTypeIntAttribute(32, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 71, 72, 85, 86 });
            _VerifyAttribute(new BinaryTypeIntAttribute(64, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { 72, 86 });
            _VerifyAttribute(new BinaryTypeIntAttribute(128, BinaryNullableTypeEnum.Nullable, BinaryArgumentTypeEnum.List), new int[] { });
        }
    }
}

using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Models
{
    using TestModelLevel1Type1 = TestModelLevel1<int, string, bool, byte, double, float>;
    using TestModelLevel1Type2 = TestModelLevel1<float, string, short, int, double, char>;
    using TestModelLevel1Type3 = TestModelLevel1<ushort, bool, sbyte, UInt64, byte, bool>;

    [BinarySerializableObject]
    public class TestModelLevel2
    {
        [BinaryTypeObject]
        public TestModelLevel1Type1? SubModel1 { get; set; } = TestModelLevel1Type1.Create();

        [BinaryTypeObject]
        public TestModelLevel1Type2? SubModel2 { get; set; } = TestModelLevel1Type2.Create();

        [BinaryTypeObject]
        public TestModelLevel1Type3? SubModel3 { get; set; } = TestModelLevel1Type3.Create();

        static TestModelLevel2()
        {
            TestModelLevel1Type1.CreateElementSingleType1 = () => RandomHandler.GetNextInt32();
            TestModelLevel1Type1.CreateElementSingleType2 = () => RandomHandler.GetNextString();
            TestModelLevel1Type1.CreateElementArrayType1 = () => RandomHandler.GetNextBool();
            TestModelLevel1Type1.CreateElementArrayType2 = () => RandomHandler.GetNextUInt8();
            TestModelLevel1Type1.CreateElementListType1 = () => RandomHandler.GetNextDouble();
            TestModelLevel1Type1.CreateElementListType2 = () => RandomHandler.GetNextFloat();

            TestModelLevel1Type2.CreateElementSingleType1 = () => RandomHandler.GetNextFloat();
            TestModelLevel1Type2.CreateElementSingleType2 = () => RandomHandler.GetNextString();
            TestModelLevel1Type2.CreateElementArrayType1 = () => RandomHandler.GetNextInt16();
            TestModelLevel1Type2.CreateElementArrayType2 = () => RandomHandler.GetNextInt32();
            TestModelLevel1Type2.CreateElementListType1 = () => RandomHandler.GetNextDouble();
            TestModelLevel1Type2.CreateElementListType2 = () => RandomHandler.GetNextChar();

            TestModelLevel1Type3.CreateElementSingleType1 = () => RandomHandler.GetNextUInt16();
            TestModelLevel1Type3.CreateElementSingleType2 = () => RandomHandler.GetNextBool();
            TestModelLevel1Type3.CreateElementArrayType1 = () => RandomHandler.GetNextInt8();
            TestModelLevel1Type3.CreateElementArrayType2 = () => RandomHandler.GetNextUInt64();
            TestModelLevel1Type3.CreateElementListType1 = () => RandomHandler.GetNextUInt8();
            TestModelLevel1Type3.CreateElementListType2 = () => RandomHandler.GetNextBool();
        }
    }
}

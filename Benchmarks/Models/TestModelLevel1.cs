using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Models
{
    [BinarySerializableObject]
    public class TestModelLevel1<SingleType1, SingleType2, ArrayType1, ArrayType2, ListType1, ListType2>
    {
        [BinaryTypeAuto()]
        public SingleType1? Property1 { get; set; }
        [BinaryTypeAuto()]
        public SingleType2? Property2 { get; set; }
        [BinaryTypeAuto()]
        public ArrayType1?[]? ArrayProperty1 { get; set; }
        [BinaryTypeAuto()]
        public ArrayType2?[]? ArrayProperty2 { get; set; }
        [BinaryTypeAuto()]
        public List<ListType1?>? ListProperty1 { get; set; }
        [BinaryTypeAuto()]
        public List<ListType2?>? ListProperty2 { get; set; }

        public static Func<SingleType1>? CreateElementSingleType1;
        public static Func<SingleType2>? CreateElementSingleType2;
        public static Func<ArrayType1>? CreateElementArrayType1;
        public static Func<ArrayType2>? CreateElementArrayType2;
        public static Func<ListType1>? CreateElementListType1;
        public static Func<ListType2>? CreateElementListType2;

        public static TestModelLevel1<SingleType1, SingleType2, ArrayType1, ArrayType2, ListType1, ListType2> Create()
        {
            TestModelLevel1<SingleType1, SingleType2, ArrayType1, ArrayType2, ListType1, ListType2> resultModel = new();

            if (CreateElementSingleType1 is not null)
            {
                resultModel.Property1 = CreateElementSingleType1.Invoke();
            }
            if (CreateElementSingleType2 is not null)
            {
                resultModel.Property2 = CreateElementSingleType2.Invoke();
            }
            if (CreateElementArrayType1 is not null)
            {
                resultModel.ArrayProperty1 = Helpers.CreateCollection(() => CreateElementArrayType1()).ToArray();
            }
            if (CreateElementArrayType2 is not null)
            {
                resultModel.ArrayProperty2 = Helpers.CreateCollection(() => CreateElementArrayType2()).ToArray();
            }
            if (CreateElementListType1 is not null)
            {
                resultModel.ListProperty1 = Helpers.CreateCollection(() => CreateElementListType1()).ToList();
            }
            if (CreateElementListType2 is not null)
            {
                resultModel.ListProperty2 = Helpers.CreateCollection(() => CreateElementListType2()).ToList();
            }

            return resultModel;
        }
    }
}

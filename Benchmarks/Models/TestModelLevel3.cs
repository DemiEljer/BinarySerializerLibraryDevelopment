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
    public class TestModelLevel3
    {
        [BinaryTypeObject]
        public TestModelLevel2? SubModel1 { get; set; } = new();

        [BinaryTypeObject]
        public TestModelLevel2? SubModel2 { get; set; } = new();

        [BinaryTypeObject]
        public TestModelLevel2? SubModel3 { get; set; } = new();
    }
}

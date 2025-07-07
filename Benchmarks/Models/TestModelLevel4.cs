using BinarySerializerLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Models
{
    [BinarySerializableObject]
    public class TestModelLevel4
    {
        [BinaryTypeObject]
        public TestModelLevel3? SubModel1 { get; set; } = new();

        [BinaryTypeObject]
        public TestModelLevel3? SubModel2 { get; set; } = new();

        [BinaryTypeObject]
        public TestModelLevel3? SubModel3 { get; set; } = new();
    }
}

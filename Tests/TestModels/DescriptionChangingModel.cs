using BinarySerializerLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestModels
{
    [BinarySerializableObject]
    public class DescriptionChangingModel
    {
        [BinaryTypeAuto]
        public int Field1 { get; set; }

        [BinaryTypeAuto]
        public string? Field2 { get; set; }

        [BinaryTypeAuto]
        public double[]? Field3 { get; set; }
    }
}

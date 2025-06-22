using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.IncorrectModels
{
    public class ModelWithoutAttribute
    {
        [BinaryTypeBool()]
        public bool Value { get; set; } = RandomHandler.GetNextBool();
    }
}

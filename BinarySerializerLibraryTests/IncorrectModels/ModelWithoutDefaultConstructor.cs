using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.IncorrectModels
{
    [BinarySerializableObject]
    public class ModelWithoutDefaultConstructor
    {
        [BinaryTypeBool()]
        public bool Value { get; set; } = RandomHandler.GetNextBool();

        public ModelWithoutDefaultConstructor(int someArgument)
        {

        }
    }
}

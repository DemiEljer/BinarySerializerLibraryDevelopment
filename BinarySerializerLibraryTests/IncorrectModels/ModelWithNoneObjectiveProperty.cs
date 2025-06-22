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
    public class ModelWithNoneObjectiveProperty
    {
        [BinaryTypeObject()]
        public (bool, int) Value { get; set; } = (RandomHandler.GetNextBool(), RandomHandler.GetNextInt32());
    }
}

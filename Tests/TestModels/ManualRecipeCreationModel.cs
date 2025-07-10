using BinarySerializerLibrary.Attributes;
using BinarySerializerLibraryTests.Base;
using BinarySerializerLibraryTests.CorrectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestModels
{
    [BinarySerializableObject]
    public class ManualRecipeCreationModel
    {
        public int Field1 { get; set; }

        public string? Field2 { get; set; }

        public double[]? Field3 { get; set; }

        public ManualRecipeCreationModel()
        {
            Field1 = RandomHandler.GetNextInt32(12);
            Field2 = RandomHandler.GetNextString();
            Field3 = Helpers.CreateCollection(() => RandomHandler.GetNextDouble()).ToArray();
        }

        public void AssetEqual(ManualRecipeCreationModel? anotherModel)
        {
            Assert.IsNotNull(anotherModel);

            Assert.AreEqual(Field1, anotherModel.Field1);
            Assert.AreEqual(Field2, anotherModel.Field2);
            Helpers.CheckCollectionsEquality(Field3, anotherModel.Field3);
        }
    }
}

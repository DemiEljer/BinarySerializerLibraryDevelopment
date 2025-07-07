using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Interfaces
{
    public interface IObjectiveBasePropertyModel<Type>
        where Type : class
    {
        #region Atomic

        public Type ValueNotNull { get; set; }

        public Type? ValueNull { get; set; }

        public Type ValueNotNullAlignment { get; set; }

        public Type? ValueNullAlignment { get; set; }

        #endregion Atomic

        #region Array

        public Type[]? NullArray { get; set; }

        public Type[]? EmptyArray { get; set; }

        public Type?[]? Array { get; set; }

        public Type[]? NullArrayAlignment { get; set; }

        public Type[]? EmptyArrayAlignment { get; set; }

        public Type?[]? ArrayAlignment { get; set; }

        #endregion Array

        #region List

        public List<Type>? NullList { get; set; }

        public List<Type>? EmptyList { get; set; }

        public List<Type?>? List { get; set; }

        public List<Type>? NullListAlignment { get; set; }

        public List<Type>? EmptyListAlignment { get; set; }

        public List<Type?>? ListAlignment { get; set; }

        #endregion List
    }
}

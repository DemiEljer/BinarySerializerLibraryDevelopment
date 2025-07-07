using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Interfaces
{
    public interface IBasePropertyModel<Type>
        where Type : struct
    {
        #region Atomic

        public Type Value { get; set; }

        public Type? ValueNotNull { get; set; }

        public Type? ValueNull { get; set; }

        public Type ValueAlignment { get; set; }

        public Type? ValueNotNullAlignment { get; set; }

        public Type? ValueNullAlignment { get; set; }

        #endregion Atomic

        #region Array

        public Type[]? NullArray { get; set; }

        public Type[]? EmptyArray { get; set; }

        public Type[]? Array { get; set; }

        public Type?[]? NullableArray { get; set; }

        public Type[]? NullArrayAlignment { get; set; }

        public Type[]? EmptyArrayAlignment { get; set; }

        public Type[]? ArrayAlignment { get; set; }

        public Type?[]? NullableArrayAlignment { get; set; }

        #endregion Array

        #region List

        public List<Type>? NullList { get; set; }

        public List<Type>? EmptyList { get; set; }

        public List<Type>? List { get; set; }

        public List<Type?>? NullableList { get; set; }

        public List<Type>? NullListAlignment { get; set; }

        public List<Type>? EmptyListAlignment { get; set; }

        public List<Type>? ListAlignment { get; set; }

        public List<Type?>? NullableListAlignment { get; set; }

        #endregion List
    }
}

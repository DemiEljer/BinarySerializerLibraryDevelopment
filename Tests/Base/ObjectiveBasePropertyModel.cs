using BinarySerializerLibraryTests.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Base
{
    public abstract class ObjectiveBasePropertyModel<Type>
        where Type : class
    {
        #region Atomic

        protected Type _ValueNotNull { get; set; }

        protected Type? _ValueNull { get; set; } = null;

        protected Type _ValueNotNullAlignment { get; set; }

        protected Type? _ValueNullAlignment { get; set; } = null;

        #endregion Atomic

        #region Array

        protected Type[]? _NullArray { get; set; } = null;

        protected Type[]? _EmptyArray { get; set; } = Array.Empty<Type>();

        protected Type?[]? _Array { get; set; }

        protected Type[]? _NullArrayAlignment { get; set; } = null;

        protected Type[]? _EmptyArrayAlignment { get; set; } = Array.Empty<Type>();

        protected Type?[]? _ArrayAlignment { get; set; }

        #endregion Array

        #region List

        protected List<Type>? _NullList { get; set; } = null;

        protected List<Type>? _EmptyList { get; set; } = new();

        protected List<Type?>? _List { get; set; }

        protected List<Type>? _NullListAlignment { get; set; } = null;

        protected List<Type>? _EmptyListAlignment { get; set; } = new();

        protected List<Type?>? _ListAlignment { get; set; }

        #endregion List

        public ObjectiveBasePropertyModel()
        {
            // Atomic
            {
                _ValueNotNull = _GetRandomValue();
                _ValueNotNullAlignment = _GetRandomValue();
            }

            // Array
            {
                _Array = Helpers.CreateCollection(() => _GetRandomValue()).ToArray();
                _ArrayAlignment = Helpers.CreateCollection(() => _GetRandomValue()).ToArray();
            }

            // List
            {
                _List = Helpers.CreateCollection(() => _GetRandomValue()).ToList();
                _ListAlignment = Helpers.CreateCollection(() => _GetRandomValue()).ToList();
            }
        }

        protected abstract Type _GetRandomValue();

        protected abstract Type? _GetRandomNullableValue();

        public virtual void AssetEqual(ObjectiveBasePropertyModel<Type>? anotherModel)
        {
            Assert.IsNotNull(anotherModel);
            // Atomic
            {
                Helpers.CheckIfNotNull(_ValueNotNull, anotherModel._ValueNotNull);
                Helpers.CheckIfNull(_ValueNull, anotherModel._ValueNull);

                Helpers.CheckIfNotNull(_ValueNotNullAlignment, anotherModel._ValueNotNullAlignment);
                Helpers.CheckIfNull(_ValueNullAlignment, anotherModel._ValueNullAlignment);
            }

            // Array
            {
                Helpers.CheckIfNull(_NullArray, anotherModel._NullArray);
                Helpers.CheckIfEmptyCollections(_EmptyArray, anotherModel._EmptyArray);
                Helpers.CheckCollectionsEquality(_Array, anotherModel._Array);

                Helpers.CheckIfNull(_NullArrayAlignment, anotherModel._NullArrayAlignment);
                Helpers.CheckIfEmptyCollections(_EmptyArrayAlignment, anotherModel._EmptyArrayAlignment);
                Helpers.CheckCollectionsEquality(_ArrayAlignment, anotherModel._ArrayAlignment);
            }

            // List
            {
                Helpers.CheckIfNull(_NullList, anotherModel._NullList);
                Helpers.CheckIfEmptyCollections(_EmptyList, anotherModel._EmptyList);
                Helpers.CheckCollectionsEquality(_List, anotherModel._List);

                Helpers.CheckIfNull(_NullListAlignment, anotherModel._NullListAlignment);
                Helpers.CheckIfEmptyCollections(_EmptyListAlignment, anotherModel._EmptyListAlignment);
                Helpers.CheckCollectionsEquality(_ListAlignment, anotherModel._ListAlignment);
            }
        }
    }
}

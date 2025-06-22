using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializerLibraryTests.Base
{
    public static class Helpers
    {
        public static IEnumerable<Type?> CreateCollection<Type>(Func<Type?>? getCollectionElement)
        {
            if (getCollectionElement is null)
            {
                Assert.Fail();
            }

            int collectionSize = RandomHandler.GetNextCollectionSize(100, 10);
            
            foreach (var index in Enumerable.Range(0, collectionSize))
            {
                yield return getCollectionElement.Invoke();
            }
        }

        public static void CheckIfNull<Type>(Type? targetValue, Type? actualValue)
        {
            Assert.IsNull(targetValue);
            Assert.AreEqual(targetValue, actualValue);
        }

        public static void CheckIfNotNull<Type>(Type? targetValue, Type? actualValue)
        {
            Assert.IsNotNull(targetValue);
            Assert.AreEqual(targetValue, actualValue);
        }

        public static void CheckIfNotNull<Type>(Type? targetValue, Type? actualValue, Action<Type?, Type?>? equalityChecker)
        {
            if (equalityChecker is null)
            {
                Assert.Fail();
            }

            Assert.IsNotNull(targetValue);
            Assert.IsNotNull(actualValue);
            equalityChecker.Invoke(targetValue, actualValue);
        }

        public static void CheckIfEmptyCollections<Type>(IEnumerable<Type?>? targetCollection, IEnumerable<Type?>? actualCollection)
        {
            Assert.IsNotNull(targetCollection);
            Assert.IsNotNull(actualCollection);

            int targetCollectionElementsCount = targetCollection.Count();
            Assert.AreEqual(0, targetCollectionElementsCount);
            Assert.AreEqual(targetCollectionElementsCount, actualCollection.Count());
        }

        public static void CheckCollectionsEquality<Type>(IEnumerable<Type?>? targetCollection, IEnumerable<Type?>? actualCollection)
        {
            Assert.IsNotNull(targetCollection);
            Assert.IsNotNull(actualCollection);

            var _targetCollection = targetCollection.ToArray();
            var _actualCollection = actualCollection.ToArray();

            Assert.AreEqual(_targetCollection.Length, _actualCollection.Length);

            foreach (var index in Enumerable.Range(0, _targetCollection.Length))
            {
                Assert.AreEqual(_targetCollection[index], _actualCollection[index]);
            }
        }

        public static void CheckCollectionsEquality<Type>(IEnumerable<Type?>? targetCollection, IEnumerable<Type?>? actualCollection, Action<Type?, Type?>? equalityChecker)
        {
            if (equalityChecker is null)
            {
                Assert.Fail();
            }

            Assert.IsNotNull(targetCollection);
            Assert.IsNotNull(actualCollection);

            var _targetCollection = targetCollection.ToArray();
            var _actualCollection = actualCollection.ToArray();

            Assert.AreEqual(_targetCollection.Length, _actualCollection.Length);

            foreach (var index in Enumerable.Range(0, _targetCollection.Length))
            {
                equalityChecker.Invoke(_targetCollection[index], _actualCollection[index]);
            }
        }

        public static void CheckExceptionHasThrown<ExceptionType>(Action<Action<Exception>> handlerDelegate)
        {
            if (handlerDelegate is null)
            {
                Assert.Fail();
            }

            bool errorHasThrownFlag = false;

            handlerDelegate.Invoke((e) =>
            {
                errorHasThrownFlag = e is ExceptionType;
            });

            Assert.IsTrue(errorHasThrownFlag);
        }

        public static void CheckExceptionHasNotThrown(Action<Action<Exception>> handlerDelegate)
        {
            if (handlerDelegate is null)
            {
                Assert.Fail();
            }

            handlerDelegate.Invoke((e) =>
            {
                Assert.Fail();
            });
        }

        public static void CheckExceptionHasNotThrown(Action handlerDelegate)
        {
            if (handlerDelegate is null)
            {
                Assert.Fail();
            }

            try
            {
                handlerDelegate.Invoke();
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}

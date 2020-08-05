using System;
using Xunit;
using CircularQueue;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1 : IEnumerator
    {
        /// <summary>
        /// test to check if queue is empty or contains any data
        /// </summary>
        [Fact]
        public void EmptyQueueTest()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            //is.Count = 0;
            //_rear + 1 == _front;
            //testData.Count = 0;
            //var actual = testData.Dequeue();
            //var expected = "The buffer is empty";
            Assert.Throws<InvalidOperationException>(() => testData.Dequeue());
        }

        /// <summary>
        /// need to include property of Count to be used by the following test methods
        /// </summary>
        //public int Count { get; }

        

        object IEnumerator.Current => throw new NotImplementedException();

        /// <summary>
        /// test to enqueue items and return the count of items in the queue
        /// </summary>
        [Fact]
        public void EnqueueItem()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item = 5;
            testData.Enqueue(item);
            int actual = testData.Count;
            int expected = 1;
            Assert.Equal(expected, actual);

        }

        /// <summary>
        /// test that enqueues three items, dequeues one item and then counts number of items in the queue 
        /// </summary>
        [Fact]
        public void EnqueueThreeDequeueOneItems()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            testData.Dequeue();
            int actual = testData.Count;
            int expected = 2;
            Assert.Equal(expected, actual);
        }


        /// <summary>
        /// test that enqueues three items and then dequeues the first (FIFO) and returns its value
        /// </summary>
        [Fact]
        public void EnqueueThreeDequeueOneReturnValue()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(16);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            int actual = testData.Dequeue();
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// test to attempt to enqueue full queue and returns false
        /// </summary>
        [Fact]
        public void EnqueueFullBuffer()
        {
            CircularBuffer<int> testData = new CircularBuffer<int>(3);
            int item1 = 6;
            int item2 = 8;
            int item3 = 22;
            int item4 = 13;
            testData.Enqueue(item1);
            testData.Enqueue(item2);
            testData.Enqueue(item3);
            bool actual = testData.Enqueue(item4);
            Assert.False(actual);
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

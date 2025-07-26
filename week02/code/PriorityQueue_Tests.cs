using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test the priority queue with 4 words, 2 containing the same priority
    // Expected Result: Good Bye, Hello, Number, Eyes.
    // Defect(s) Found:
    //  When running this test, I detected an issue with the PriorityQueue. The same was not
    //  removing the values returned.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        var hello = "Hello";
        var goodbye = "Good Bye";
        var number = "Number";
        var eyes = "Eyes";

        string[] expectedResult = { goodbye, hello, number, eyes };

        priorityQueue.Enqueue(hello, 2);
        priorityQueue.Enqueue(goodbye, 2);
        priorityQueue.Enqueue(number, 1);
        priorityQueue.Enqueue(eyes, 20);

        for (int i = 0; i < 4; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    [TestMethod]
    // Scenario: Create 3 fruits with priorities (2 of them with the same), enqueue and dequeue them
    // Expected Result: banana, apple, orange
    // Defect(s) Found:
    //  Because the previous test method helped me identify an issue with the queue, this test case
    //  did not present issues.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        PriorityItem banana = new PriorityItem("banana", 20);
        PriorityItem apple = new PriorityItem("apple", 20);
        PriorityItem orange = new PriorityItem("orange", 10);

        priorityQueue.Enqueue(apple.Value, apple.Priority);
        priorityQueue.Enqueue(banana.Value, banana.Priority);
        priorityQueue.Enqueue(orange.Value, orange.Priority);

        PriorityItem[] expectedResults = { banana, apple, orange };

        for (int i = 0; i < expectedResults.Count(); i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i].Value, value);
        }
    }

    // Add more test cases as needed below.
}
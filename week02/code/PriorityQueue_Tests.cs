using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities: A(2), B(5), C(3). Then dequeue once.
    // Expected Result: B should be returned, as it has the highest priority (5).
    // Defect(s) Found: the for-loop excludes the last element, causing it to skip comparisons with the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Enqueue three items with the same priority: A(4), B(4), and C(2). Dequeue twice.
    // Expected Result: A and B should be dequeued FIFO since they have the same priority.
    // Defect(s) Found: the for-loop excludes the last item, which could break the FIFO if a highsted priority item at the end.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        priorityQueue.Enqueue("A", 4);
        priorityQueue.Enqueue("B", 4);
        priorityQueue.Enqueue("C", 2);

        string result1 = priorityQueue.Dequeue();
        string result2 = priorityQueue.Dequeue();

        Assert.AreEqual("A", result1); //First In, first Out between A and B
        Assert.AreEqual("B", result2);
    }

    // Add more test cases as needed below.
}
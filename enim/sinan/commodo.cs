// Define a maximum time limit (in milliseconds) for the loop execution
int timeLimit = 10000; // 10 seconds

// Capture the start time of the loop
DateTime startTime = DateTime.Now;

// Boolean flag to control the loop execution based on the time limit
bool timeLimitExceeded = false;

while (!timeLimitExceeded)
{
    // Your loop logic here
    // ...

    // Check if the current time has exceeded the start time by the time limit
    if ((DateTime.Now - startTime).TotalMilliseconds > timeLimit)
    {
        // If time limit is exceeded, print a message and break the loop
        Console.WriteLine("Time limit exceeded. Breaking the loop.");
        timeLimitExceeded = true;
    }
}

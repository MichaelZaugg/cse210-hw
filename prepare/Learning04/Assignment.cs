public class Assignment
{
    //attributes for the assignment class, being name and topic
    private string studentName;
    private string topic;

    public Assignment(string studentName, string topic) { //Constructor
        this.studentName = studentName;
        this.topic = topic;
    }

    public string GetStudentName() { //return the studentname since we made it private and we will need to provide it for the other assignments
        return studentName;
    }

    public string GetTopic() { //Same thing here, we are returning the topic for the other assignments
        return topic;
    }

    public string GetSummary() {
        return studentName + " - " + topic;
    }
}
public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) { //Asks for name, topic, and title then passes the name and topic to the base assignment class
    

        this.title = title; //The only variable we need for this class
    }

    public string GetWritingInformation() {
    
        string studentName = GetStudentName(); //the student name is private so we need to call it and make it into a string for this function to reutrn what we need.

        return $"{title} by {studentName}";
    }
}
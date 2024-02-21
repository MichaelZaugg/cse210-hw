public class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic) { //Using the base assignment still for the name and topic. This class will only worry about the secitons and problems
        this.textbookSection = textbookSection;
        this.problems = problems;
    }

    public string GetHomeworkList() { //Returning the variables we have in this class as a string to be printed.
        return $"Section {textbookSection} Problems {problems}";
    }
}
namespace Journal;
using System.IO;
using System.Runtime.InteropServices;

public class FileManager {

    static public void WriteToFile(string filename, string Data) {
        using (StreamWriter outputFile = File.AppendText(filename)){
        // Write the data from the jounral into the filename given.
        outputFile.WriteLine(Data);
        }
    }

    static public void ReadFromFile(string filename, Journal journal){
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            //For each line in the file go through and get the data for the entries
            string[] parts = line.Split("^");

            //Seperate each part of the list
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            //Add the new parts into a new entry and add it to the jounral.
            var entry = new Entry(response, prompt, date);
            journal.AddEntry(entry);
        }
    }
}
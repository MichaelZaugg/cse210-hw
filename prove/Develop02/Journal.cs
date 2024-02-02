namespace Journal;
public class Journal {
    public List<Entry> entries;

    public Journal() {
        entries = new List<Entry>();
    }


    public void AddEntry(Entry entry){
        entries.Add(entry); //Take the data and save it into the entry class
    }
    public void Display() {
        foreach(Entry entry in entries) {
            entry.Display(); //Go through each entry and call the entries display function
        }
    }

    public void Export(string filename) {
        foreach(Entry entry in entries) {
            //Go through each entry and call the filemanager for each one and pass the data to be saved.
            var data = entry.Export();

            FileManager.WriteToFile(filename, data);
        }
    }
}
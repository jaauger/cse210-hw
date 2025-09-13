using System;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = [];
        Boolean check = true;
        do
        {
            try
            {
                lines = File.ReadAllLines(filename);
                check = false;
            }
            catch (FileNotFoundException)
            {
                Console.Write($"File {filename} not found. Please enter file name: ");
                filename = Console.ReadLine();
            }
        } while (check);
                
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[1], parts[2])
            {
                Date = parts[0]
            };
            _entries.Add(entry);
        }
    }
}
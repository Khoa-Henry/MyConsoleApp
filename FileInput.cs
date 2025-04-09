public class FileInput
{
    StreamReader? reader = null;
    private string fileName;

    public FileInput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            reader = new StreamReader(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + "contructor" + " " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("File Open Error: " + "contructor" + " " + e.Message);
        }
    }

    public void FileRead()
    {
        string? line;
        try
        {
            while ((line = reader?.ReadLine()) != null) // Use null-conditional operator
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + "read" + " " + e.Message);
            Console.WriteLine(e.ToString()); // Detailed stack trace
        }
    }

    public string? FileReadLine()
    {
        try
        {
            string? line = reader?.ReadLine(); // Use null-conditional operator
            return line;
        }
        catch (Exception e)
        {
            Console.WriteLine("File Read Error: " + "read line" + " " + e.Message);
            Console.WriteLine(e.ToString()); // Detailed stack trace
            return null;
        }
    }

    public void FileClose()
    {
        if (reader != null)
        {
            try
            {
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("File Close Error: " + "close" + " " + e.Message);
                Console.WriteLine(e.ToString()); // Detailed stack trace
            }
            finally
            {
                reader = null; // Set reader to null after closing
            }
        }
    }
}

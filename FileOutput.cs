public class FileOutput
{
    StreamWriter? writer = null;
    private string fileName;

    public FileOutput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            writer = new StreamWriter(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e.Message);
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            writer?.WriteLine(line + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("File Write Error: " + fileName + " " + e.Message);
        }
    }

    public void FileClose()
    {
        if (writer != null)
        {
            try
            {
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString()); // Detailed stack trace
            }
        }
    }
}

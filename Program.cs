

using System.Collections;

var path = Path.Combine(Environment.CurrentDirectory, "output.txt");
var tempPath = path + ".tmp";

var tempFile = new FileInfo(tempPath);

if (tempFile.Exists)
    tempFile.Delete();

using (var writer = tempFile.CreateText())
{
    foreach (DictionaryEntry entry in Environment.GetEnvironmentVariables())
    {
        writer.WriteLine($"{entry.Key}: {entry.Value}");
    }

    var oldFileInfo = new FileInfo(path);
    if (oldFileInfo.Exists)
        oldFileInfo.Delete();
}

if (args.Length > 0)
{
    File.Move(tempPath, path);
}
else
{
    tempFile.MoveTo(path);
}
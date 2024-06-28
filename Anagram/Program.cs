const string word = "documenting";
const string fileName = "words.txt";

string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

try
{
	StreamReader stream = new(path);
	string line = stream.ReadLine();
	
	if (line != null)
	{
		string[] lineWords = line.Split(' ');

		foreach (string target in lineWords)
		{
            if (IsAnagram(target))
            {
                
            }
        }
	}

	
}
catch (FileNotFoundException)
{
    Console.WriteLine("File not found");
}


static bool IsAnagram(string target)
{
	char[] chars = target.ToCharArray();


}

using System.Text;

internal static class CharacterFrequencyUseCase
{
    internal static int Execute(string filePath, char searchByCharacter)
    {
        const int bufferSize = 1024;

        byte[] buffer = new byte[bufferSize];

        int bytesRead;

        int characterFrequency = 0;

        using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read);

        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            string content = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

            foreach (char character in content)
            {
                if (character == searchByCharacter)
                {
                    characterFrequency++;
                }
            }
        }

        return characterFrequency;
    }
}
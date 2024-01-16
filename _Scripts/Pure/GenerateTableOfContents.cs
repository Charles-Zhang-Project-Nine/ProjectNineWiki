/* Generate Table of Contents
Version: v0.1
Author: Charles Zhang
Initial Date: 2024-01-16

This script generates plain text table of contents to STD OUT to serve as automatic replacement for top-level README for language specific landing page. The contents are saved to git explicitly providing benefit of explicit definitions.

Remark: Current workflow generates most pages, then for WuGong we will manually generate a seperate output, then manually combine them all.
*/

using System.Text;
using System.Text.RegularExpressions;

// Main function
string GenerateToC(string folder)
{
    StringBuilder builder = new();
    foreach (string topicFolder in Directory.EnumerateDirectories(folder)
        .OrderBy(f => f))
    {
        string topic = Path.GetFileName(topicFolder);
        WriteLine($"Parsing {topic}...");
        
        // Skipping icon for now since we don't have it anyway
        builder.AppendLine($"### {topic}\n");

        string topicREADMEFile = Path.Combine(topicFolder, "README.md");
        if (File.Exists(topicREADMEFile))
        {
            string topicREADME = File.ReadAllText(topicREADMEFile).TrimEnd();
            string refinedFormat = Regex.Replace(topicREADME, "^#", "####", RegexOptions.Multiline);
            builder.AppendLine($"{refinedFormat}\n");
        }
        if (Directory.EnumerateFiles(topicFolder).Where(f => Path.GetFileName(f) != "README.md").Count() == 0)
        {
            builder.AppendLine($"No contents available under this topic.\n");
            continue;
        }

        builder.AppendLine("|Entry|Description|Link|");
        builder.AppendLine("|-|-|-|");

        foreach(string file in Directory.EnumerateFiles(topicFolder)
            .Where(f => Path.GetFileName(f) != "README.md")
            .OrderBy(f => f))
        {   
            string entryName = Path.GetFileNameWithoutExtension(file);
            WriteLine($"  Parsing {entryName}");

            string[] contents = File.ReadAllLines(file);
            string description = contents
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Where(l => !l.StartsWith('#')) // Skip headers
                .Where(l => !l.StartsWith('>')) // Skip quotes
                .FirstOrDefault(l => !Regex.IsMatch(l, @"^(.*?): (.*)[^\.]$"));    // First non-meta-data
                // Remark: Current parsing scheme can encounter problems when the description paragraph contains ':', otherwise we require ending the line with a `.`
            
            builder.AppendLine($"|{entryName}|{description ?? "Pending"}|[Link](./{topic}/{entryName.Replace(" ", "%20")})|");  // Relative to language landing page
        }

        builder.AppendLine();
    }
    return builder.ToString().TrimEnd();
}

// Entry
if (Arguments.Length == 0)
{
    Write("Enter folder path: ");
    string inputFolder = ReadLine();
    string toc = GenerateToC(inputFolder);

    Write("Enter output file path: ");
    string outputFile = ReadLine();
    File.WriteAllText(outputFile, toc);
}
else if (Arguments.Length == 2)
{
    string toc = GenerateToC(Arguments.First());
    File.WriteAllText(Arguments.Last(), toc);
}
else if (Arguments.First() == "--help" || Arguments.Length != 2)
    WriteLine("pure GenerateTableOfContents.cs <Folder Path> <Output File>");
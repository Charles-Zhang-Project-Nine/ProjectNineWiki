/* Generate Table of Contents
Version: v0.3
Author: Charles Zhang
Initial Date: 2024-01-16

This script generates plain text table of contents to STD OUT to serve as automatic replacement for top-level README for language specific landing page. The contents are saved to git explicitly providing benefit of explicit definitions.

Remark:
* Current workflow flattens all subtopics under top-level topics.
* The generated ToC can effectively serve as a replacement for P9 Rev1's (part of Legends of NFC) `(Entity) Names Collection.md`.

Changelog:
* v0.1: Basic folder enumeration
* v0.2: Fix topic README display; Automatically flatten sub-topics to top level
* v0.3: Add entry count to topics; Allow README renaming for Topic
*/

using System.Text;
using System.Text.RegularExpressions;

// Main parsing logic
void EnumerateTopic(StringBuilder builder, string topicFolder, string parentPath = "" /*Includes trailing `/`*/)
{
    // Skipping icon for now since we don't have it anyway

    string topic = Path.GetFileName(topicFolder);
    WriteLine($"Parsing {topic}...");

    int directSubItemCount = Directory.EnumerateFiles(topicFolder)
        .Where(f => Path.GetFileName(f) != "README.md").Count(); // Exclude sub-topics and README
    string topicHeader = topic;

    // Get topic description
    string topicREADMEFile = Path.Combine(topicFolder, "README.md");
    if (File.Exists(topicREADMEFile))
    {
        string topicREADME = File.ReadAllText(topicREADMEFile).TrimEnd();
        topicHeader = Regex.Matches(topicREADME, "^# (.*)$", RegexOptions.Multiline).First().Value.TrimStart('#').Trim();
        string refinedFormat = Regex.Replace(topicREADME, "^# (.*)$", string.Empty, RegexOptions.Multiline).Trim(); // Replace the top-level header
        refinedFormat = Regex.Replace(refinedFormat, "^#", "####", RegexOptions.Multiline); // Further indent sections
        builder.AppendLine($"{refinedFormat}\n");
    }

    builder.AppendLine($"### {topicHeader} (x{directSubItemCount})\n");

    // Skip table generation for empty topics
    if (directSubItemCount == 0 && Directory.EnumerateDirectories(topicFolder).Count() == 0)
    {
        builder.AppendLine($"No contents available under this topic.\n");
        return;
    }

    // Generate table of entries
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
        
        if (description == null)
            WriteLine($"  Warning: Potentially incorrect formatting @{entryName}.");

        builder.AppendLine($"|{entryName}|{description ?? "Pending"}|[Link](./{parentPath}{topic}/{entryName.Replace(" ", "%20")})|");  // Relative to language landing page
    }
    builder.AppendLine();

    // Recursively parse subtopics (bring them to top level)
    foreach(string subtopicsFolder in Directory.EnumerateDirectories(topicFolder)
        .OrderBy(f => f))
        EnumerateTopic(builder, subtopicsFolder, $"{parentPath}{topic}/");
}

// Top-level function
string GenerateToC(string folder)
{
    StringBuilder builder = new();
    foreach (string topicFolder in Directory.EnumerateDirectories(folder)
        .OrderBy(f => f))
        EnumerateTopic(builder, topicFolder);
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
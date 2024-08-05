using CommandLine;

namespace SwaggerToFetchGenerator;

[Verb("generate", HelpText = "Generate Fetch APIs in TypeScript.")]
public class GeneratorOption
{
    [Option("file", Group = "swagger-source", Required = false, HelpText = "Swagger JSON file.")]
    public string SwaggerFile { get; set; }

    [Option("url", Group = "swagger-source", Required = false, HelpText = "Url of Swagger JSON file.")]
    public string SwaggerUrl { get; set; }

    [Option("save", Required = true, HelpText = "Directory for saving the final result.")]
    public string SaveTo { get; set; }

    [Option("name", Required = true, HelpText = "Class name.")]
    public string Name { get; set; }

    [Option("config", Default = false, Required = false, HelpText = "Generate Config class.")]
    public bool HasConfig { get; set; }
}
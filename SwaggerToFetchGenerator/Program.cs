using CommandLine;

namespace SwaggerToFetchGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<GeneratorOption>(args)
                .WithParsed(ResultGenerator.GetResult);
        }
    }
}
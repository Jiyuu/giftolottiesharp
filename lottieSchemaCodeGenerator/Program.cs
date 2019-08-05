using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lottieSchemaCodeGenerator
{
    class Program
    {
        static string jsonBasepath;
        static JObject animation;
        static async Task Main(string[] args)
        {
            jsonBasepath = Path.GetFullPath("json");
            var jsonDirs = Directory.GetDirectories(jsonBasepath);
            animation = JObject.Parse(File.ReadAllText("json\\animation.json"));
            animation["definitions"] = new JObject();
            foreach (var dir in jsonDirs)
            {
                readDirectory(dir);
            }
            var json = animation.ToString();

            foreach (JProperty definition in animation["definitions"])
            {
                json = json.Replace(definition.Value["$id"].Value<string>(), $"#/definitions/{definition.Name}");
            }

            File.WriteAllText(@"asdasd.json", json);
            var schema = await JsonSchema.FromFileAsync("asdasd.json");
            var generator = new CSharpGenerator(schema);
            var file = generator.GenerateFile();
            File.WriteAllText("generated.cs", file);
        }

        private static void readDirectory(string dir)
        {
            var files= Directory.GetFiles(dir, "*.json");
            foreach (var file in files)
            {
                getDefinition(file);
            }
            var jsonDirs = Directory.GetDirectories(dir);
            foreach (var dirc in jsonDirs)
            {
                readDirectory(dirc);
            }   
        }

        private static void getDefinition(string file)
        {
            
            JObject o1 = JObject.Parse(File.ReadAllText(file));
            o1["$id"] = "#" + file.Replace(jsonBasepath, "").Replace("\\", "/").Replace(".json","");
            var arr = animation["definitions"].ToArray();
            if (arr.Select(k=>(JProperty) k).Any(k=>k.Name== file.Replace(jsonBasepath, "").Replace("\\", "/").Replace(".json", "").Replace("/","")))
                throw new Exception("duplicate type");

            animation["definitions"][file.Replace(jsonBasepath, "").Replace("\\", "/").Replace(".json", "").Replace("/", "")] = o1;


            //definitions[""]
        }
    }
}

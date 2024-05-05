using System.Security.Claims;
using System.Text;
using Scriban;
using SdkGenerator.Convertor;
using SdkGenerator.Model;
using SdkGenerator.Model.Converter;
using SdkGenerator.Model.Definition;

namespace SdkGenerator.Service;

public class ConverterService(
    DtoDirectory dtoDirectory,
    ConvertorOptions options,
    IEnumerable<IClassConvertor> classConvertors,
    IEnumerable<ITypeConvertor> typeConvertors
)
{
    /// <summary>
    /// Steps:
    ///     1) Clone directory
    ///     2) Create files
    ///     3) Build solution
    /// </summary>
    public void Convert(string language)
    {
        var classConvertor = classConvertors.FirstOrDefault(c => c.TargetLanguage == language);
        if (classConvertor is null) throw new NullReferenceException("No template found for " + language);

        var abc = new Abc(classConvertor, dtoDirectory, options, typeConvertors.Where(t => t.TargetLanguage == language));
        abc.CloneTemplate(language);
        abc.CreateFiles(language);
    }
}

internal class Abc(
    IClassConvertor classConvertor,
    DtoDirectory dtoDirectory,
    ConvertorOptions options,
    IEnumerable<ITypeConvertor> typeConvertors
)
{
    private const string GitKeep = ".gitkeep";

    internal void CloneTemplate(string template)
    {
        const string root = ".";
        var sourcePath = string.Join(Path.DirectorySeparatorChar, root, template);
        var targetPath = string.Join(Path.DirectorySeparatorChar, root, options.OutputDirectory, template);
        Directory.CreateDirectory(targetPath);

        //Now Create all of the directories
        foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
        {
            var newPathUpdated = dirPath.Replace(sourcePath, targetPath);
            //Console.WriteLine("Creating folder: " + newPathUpdated);
            Directory.CreateDirectory(newPathUpdated);
        }

        //Copy all the files & Replaces any files with the same name
        foreach (var newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
        {
            if (newPath.EndsWith(GitKeep)) continue;
            var newPathUpdated = newPath.Replace(sourcePath, targetPath);
            //Console.WriteLine("Creating file: " + newPathUpdated);
            File.Copy(newPath, newPathUpdated, true);
        }
    }

    public void CreateFiles(string language)
    {
        var classTemplate = classConvertor.GetClassTemplate();
        var template = Template.ParseLiquid(classTemplate);
        
        
        var classTemplates = TransformSchema(dtoDirectory.GetAll());
        //    var types = typeConvertors
        //        .Where(t => t.TargetLanguage == language)
        //        .ToDictionary(k => k..FullName!, v => v.ConvertProperty());
        //     foreach (var cc in classTemplates)
        //     {
        //         cc.Properties = cc.Properties.Select(p => new ClassProperty()
        //         {
        //             Name = p.Name,
        //             Type = types.GetValueOrDefault(p.Type, p.Type)
        //         }).ToList();
        //     }

        foreach (var type in classTemplates)
        {
            var result = template.Render(type);
            Console.WriteLine(result);

            var classPath = type.Namespace.Replace('.', Path.DirectorySeparatorChar);
            var folder = string.Join(Path.DirectorySeparatorChar, ".", options.OutputDirectory, language, classPath);
            Directory.CreateDirectory(folder);

            var targetPath = string.Join(Path.DirectorySeparatorChar, folder, type.Class + ".ts");
            //Console.WriteLine("Creating file: " + targetPath);
            using (var fs = File.Create(targetPath))
            {
                // Add some text to file
                var title = new UTF8Encoding(true).GetBytes(result);
                fs.Write(title, 0, title.Length);
            }
        }
    }

    private List<ClassTemplate> TransformSchema(IEnumerable<Schema> schemes)
    {
        return schemes.OfType<ObjectSchema>().Select(s => new ClassTemplate()
        {
            Namespace = s.Namespace,
            Class = s.Name,
            Imports = s.Properties
                .Select(p => ParseNamespace(p.Type))
                .Distinct().OfType<string>()
                .Where(n => n != s.Namespace)
                .ToList(),
            Properties = s.Properties.Select(p =>
            {
                
                return classConvertor.FormatProperty(new ClassProperty
                {
                    Type = ParseType(p.Type),
                    Name = p.Name,
                    Nullable = false
                });
            }).ToList()
        }).Select(classConvertor.PostTransform).ToList();
    }

    private string? ParseNamespace(string fullPath)
    {
        var paths = fullPath.Split('.');
        if (paths.Length == 1) return null;
        return string.Join('.', paths[..^1]);
    }
    
    private string ParseType(string fullPath)
    {
        return fullPath.Split('.')[^1];
    }
}
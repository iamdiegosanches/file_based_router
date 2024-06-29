using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string root = "./approutes/";

app.Map("/{*path}", async context =>
{
    string? pathString = context.Request.Path.Value;
    string[]? parts = pathString?.Split('/');

    string? fileName = parts?.Length > 1 ? parts[1] : null;
    string? content = parts?.Length > 2 ? parts[2] : null;
    
    string fileUrl = Path.Combine(root, "[" + fileName + "]" + ".cs");
    
    // Home
    if (string.IsNullOrEmpty(fileName))
    {
        context.Response.StatusCode = 400;
        string? homeHtml = await ProcessFile("Home", null);
        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync(homeHtml);
        return;
    }
    
    if (!File.Exists(fileUrl))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("File not found");
        return;
    }

    string? resultHtml = await ProcessFile(fileName, content);

    if (resultHtml == null)
    {
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("Content not found.");
        return;
    }

    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(resultHtml);
});

app.Run();

async Task<string?> ProcessFile(string fileName, string? content)
{
    string fileUrl = Path.Combine(root, "[" + fileName + "]" + ".cs");

    string fileContent = await File.ReadAllTextAsync(fileUrl);
    
    var compiler = CSharpCompilation.Create(fileName)
        .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
        .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
        .AddSyntaxTrees(SyntaxFactory.ParseSyntaxTree(fileContent));

    using (var ms = new MemoryStream())
    {
        var result = compiler.Emit(ms);

        if (!result.Success)
        {
            var failures = result.Diagnostics.Where(diagnostic => 
                diagnostic.IsWarningAsError || 
                diagnostic.Severity == DiagnosticSeverity.Error);

            foreach (var diagnostic in failures)
            {
                Console.WriteLine($"{diagnostic.Id}: {diagnostic.GetMessage()}\n");
            }
            return null;
        }

        ms.Seek(0, SeekOrigin.Begin);
        var assembly = Assembly.Load(ms.ToArray());
        
        var type = assembly.GetType("file_based_router.approutes." + "_" + fileName + "_");

        if (type == null)
        {
            Console.WriteLine("Type not found");
            return null;
        }

        var method = type.GetMethod("GetContent");
        if (method == null)
        {
            Console.WriteLine("Method 'GetContent' not found");
            return null;
        }

        if (method.ReturnType == typeof(string))
        {
            // If GetContent returns a string
            string? htmlContent = (string?)method.Invoke(null, null);
            return htmlContent;
        }
        else if (method.ReturnType == typeof(ValueTuple<string?, IDictionary<string, IDictionary<string, string>>?>))
        {
            // If GetContent returns a tuple
            var resultTuple = ((string?, IDictionary<string, IDictionary<string, string>>?))method.Invoke(null, null)!;

            string? htmlContent = resultTuple.Item1;
            var data = resultTuple.Item2;
            
            if (htmlContent == null)
            {
                return null;
            }

            if (data != null)
            {
                htmlContent = ProcessHtml(htmlContent, data, content);

                if (htmlContent == null)
                {
                    return null;
                }
            }

            return htmlContent;
        }
        else
        {
            Console.WriteLine("Invalid return type from GetContent");
            return null;
        }
    }
}

string? ProcessHtml(string? html, IDictionary<string, IDictionary<string, string>> data, string? direct)
{
    if (direct == null || !data.TryGetValue(direct, out var info))
    {
        return null;
    }

    foreach (var detail in info)
    {
        html = html?.Replace($"[:{detail.Key}]", detail.Value);
    }

    return html;
}

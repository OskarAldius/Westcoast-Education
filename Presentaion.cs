using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Westcoast_Education;

public class Presentaion<T>
{

    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static List<T> Read(string path)
    {
        try
        {
            var json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                return JsonSerializer.Deserialize<List<T>>(json, _options)!;
            }
            else
            {
                return [];
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static void Write(string path, List<T> data)
    {
        try
        {
            var json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

}


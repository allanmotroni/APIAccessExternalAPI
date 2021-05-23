using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIAccessExternalAPI.Utils.Extension
{
    public static class JsonExtension
    {
        public static T ToClassOf<T>(this string json) 
        {
            try
            {
                if (!string.IsNullOrEmpty(json))
                    return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {

            }

            return default;
        }

        public static List<T> ToListClassOf<T>(this string json)
        {
            try
            {
                if (!string.IsNullOrEmpty(json))
                    return JsonSerializer.Deserialize<List<T>>(json);
            }
            catch (Exception ex)
            {

            }

            return default;
        }

        public static string ToJson<T>(this T obj)
        {
            try
            {
                if (obj != null)
                    return JsonSerializer.Serialize(obj);
            }
            catch (Exception ex)
            {

            }

            return string.Empty;
        }
    }
}

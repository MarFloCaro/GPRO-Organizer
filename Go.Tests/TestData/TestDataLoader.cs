using System.IO;
using System.Reflection;

namespace go.Tests.TestData
{
    public static class TestDataLoader
    {
        public static string Load(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "go.Tests.TestData." + fileName;

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

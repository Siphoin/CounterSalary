namespace CounterSalary.Core.Services
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class StorageService : ServiceBase
    {
        private readonly string _storageFolderName = "storage";
        private readonly string _storagePath;

        public StorageService()
        {
            _storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _storageFolderName);
        }

        public override void Initialize()
        {
            if (!Directory.Exists(_storagePath))
            {
                Directory.CreateDirectory(_storagePath);
            }
        }

        public async Task<T> Read<T>()
        {
            string entityName = typeof(T).Name;
            string filePath = Path.Combine(_storagePath, $"{entityName}.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл {filePath} не найден.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        public bool Exits<T>()
        {
            string entityName = typeof(T).Name;
            string filePath = Path.Combine(_storagePath, $"{entityName}.json");

            return File.Exists(filePath);
        }

        public async Task Save<T>(T target)
        {
            string entityName = typeof(T).Name;
            string filePath = Path.Combine(_storagePath, $"{entityName}.json");
            string json = JsonConvert.SerializeObject(target, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                await writer.WriteAsync(json);
            }
        }
    }

}

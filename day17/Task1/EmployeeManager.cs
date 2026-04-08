using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace Task1
{
    public class EmployeeManager
    {
        private const string FilePath = "employees.json";

        public List<EmployeeModel> Load()
        {
            if (!File.Exists(FilePath))
                return new List<EmployeeModel>();

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<EmployeeModel>>(json)
                   ?? new List<EmployeeModel>();
        }

        public void Save(IEnumerable<EmployeeModel> employees)
        {
            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}

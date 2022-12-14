using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tracer.Core.Models
{
    public class MethodInfo
    {
        public MethodInfo(string name, string className)
        {
            Name = name;
            ClassName = className;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string ClassName { get; set; }
        public long ExecutionTime { get; set; }
    }
}
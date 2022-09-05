using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracer.Core.Models;
using Tracer.Serialization.Abstractions;

namespace Json
{
    public class JsonTraceResultSerializer : ITraceResultSerializer
    {
        public void Serialize(TraceResult traceResult, Stream to)
        {
            var json = JsonConvert.SerializeObject(traceResult, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            to.Write(Encoding.Default.GetBytes(json));
        }
    }
}
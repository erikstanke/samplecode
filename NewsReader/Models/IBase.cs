using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewsReader.Models
{
    public interface IBase
    {
        int Id { get; set; }
        string By { get; set; }
    }
}

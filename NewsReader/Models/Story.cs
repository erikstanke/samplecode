using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewsReader.Models
{
    public class Story : IBase
    {
        public int Id { get; set; }
        public string By { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}

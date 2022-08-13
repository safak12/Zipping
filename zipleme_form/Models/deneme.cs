using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace zipleme_form.Models
{
    public class deneme
    {
        [JsonProperty(propertyName: "Fullname")]
        public  string Fullname {  get;  set; }
        [JsonProperty(propertyName: "Country")]
        public  string Coutry { get; set; }
        

        public string Tarih { get; set; }
        

        public int id { get; set; }
        
        public string email { get; set; }
    }
}

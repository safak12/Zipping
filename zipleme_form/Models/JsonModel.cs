using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace zipleme_form.Models
{
    public class JsonModel
    {
        
        public   int Evrak_yil { get; set; }
        [JsonProperty(propertyName: "Evrak_ay")]
        public int Evrak_ay { get; set; }
        [JsonProperty(propertyName: "Evrak_hafta")]
        public int Evrak_hafta { get; set; }
        [JsonProperty(propertyName: "Evrak_tip")]
        public int Evrak_tip { get; set; }
        [JsonProperty(propertyName: "Hesap_kod")]
        public string Hesap_kod { get; set; }
        [JsonProperty(propertyName: "Unvan")]
        public string Unvan { get; set; }
        [JsonProperty(propertyName: "CARIIL")]
        public string CARIIL { get; set; }
        [JsonProperty(propertyName: "Malkod")]
        public string Malkod { get; set; }
        [JsonProperty(propertyName: "Malad")]
        public string Malad { get; set; }
        [JsonProperty(propertyName: "Bu_yila_ait_ciro")]
        public decimal Bu_yila_ait_ciro { get; set; }
        [JsonProperty(propertyName: "Bu_aya_ait_ciro")]
        public decimal Bu_aya_ait_ciro { get; set; }
        [JsonProperty(propertyName: "Bu_haftaya_ait_ciro")]

        public decimal Bu_haftaya_ait_ciro { get; set; }
        [JsonProperty(propertyName: "Satis_bolge_adedi")]
        public int Satis_bolge_adedi { get; set; }
        [JsonProperty(propertyName: "Guncel_ciro")]

        public decimal Guncel_ciro { get; set; }
        [JsonProperty(propertyName: "Onceki_ciro")]
        public decimal Onceki_ciro{ get; set; }
        [JsonProperty(propertyName: "Guncel_ciro_iade")]

        public decimal Guncel_ciro_iade { get; set; }
        [JsonProperty(propertyName: "Onceki_ciro_iade")]
        public decimal Onceki_ciro_iade { get; set; }
        [JsonProperty(propertyName: "Guncel_ciro_siparis")]
        public decimal Guncel_ciro_siparis { get; set; }
        [JsonProperty(propertyName: "Guncel_ciro_IRS")]
        public decimal Guncel_ciro_IRS { get; set; }
        [JsonProperty(propertyName: "Onceki_ciro_iade_IRS")]
        public decimal Onceki_ciro_iade_IRS { get; set; }















    }
}

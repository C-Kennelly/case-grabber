using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace case_grabber.Models.CaseStore
{
    [DataContract(Name="Endpoints")]
    public class Endpoints
    {
        [DataMember(Name="cases")]
        private string casesEndpoint {get; set;}
        
        [DataMember(Name="citations")]
        private string citationsEndpoint {get; set;}
        [DataMember(Name="jurisdictions")]
        private string jurisdictionsEndpoint {get; set;}
        [DataMember(Name="courts")]
        private string courtsEndpoint {get; set;}
        [DataMember(Name="volumes")]
        private string volumesEndpoint {get; set;}
        [DataMember(Name="reporters")]
        private string reportersEndpoint {get; set;}
        [DataMember(Name="bulk")]
        private string bulkEndpoint {get; set;}
        [DataMember(Name="ngrams")]
        private string ngramsEndpoint {get; set;}
        public Dictionary<string, string> MakeDictionary() 
        {
            Dictionary<string, string> endpoints = new Dictionary<string, string>();
            endpoints.Add("cases", casesEndpoint);
            endpoints.Add("citations", citationsEndpoint);
            endpoints.Add("jurisdictions", jurisdictionsEndpoint);
            endpoints.Add("courts", courtsEndpoint);
            endpoints.Add("volumes", volumesEndpoint);
            endpoints.Add("reporters", reportersEndpoint);
            endpoints.Add("bulk", bulkEndpoint);
            endpoints.Add("ngrams", ngramsEndpoint);

            return endpoints;
        }
    }
}

/******** Sample response *************
{
    "cases": "https://api.case.law/v1/cases/",
    "citations": "https://api.case.law/v1/citations/",
    "jurisdictions": "https://api.case.law/v1/jurisdictions/",
    "courts": "https://api.case.law/v1/courts/",
    "volumes": "https://api.case.law/v1/volumes/",
    "reporters": "https://api.case.law/v1/reporters/",
    "bulk": "https://api.case.law/v1/bulk/",
    "ngrams": "https://api.case.law/v1/ngrams/"
}
***************/
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PolystreamAssessment.Models.Modeller
{
    //
    // Summary:
    //     Document DTO when creating a document.
    [ExcludeFromCodeCoverage]
    public class CouchDbCreateDocumentResult
    {
        public CouchDbCreateDocumentResult() { }

        //
        // Summary:
        //     Gets or sets a value indicating whether operation was successful.
        [JsonProperty("ok")]
        public bool IsSuccessful { get; set; }
        //
        // Summary:
        //     Gets or sets document id.
        [JsonProperty("id")]
        [MaxLength(256)]
        public string DocumentId { get; set; }
        //
        // Summary:
        //     Gets or sets revision id.
        [JsonProperty("rev")]
        public string RevisionId { get; set; }
    }
}

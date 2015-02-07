using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySampleProject.Models
{
    public class DocumentMetaData
    {
        [Required]
        [Display(Name = "Date Published")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime PubDate { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

    }

    [MetadataType(typeof(DocumentMetaData))]
    public partial class Document
    {
    }
}
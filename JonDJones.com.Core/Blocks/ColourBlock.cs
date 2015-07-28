using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace JonDJones.com.Core.Blocks
{
    [ContentType(DisplayName = "Colour Block",
        GUID = "EB15ECE1-341D-4F3D-887B-315963732790",
        Description = "Colour text")]
    public class ColourBlock : BlockData
    {
        [Display(Name = "Text",
            Description = "Block content",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString Text { get; set; }
    }
}

using EPiServer.Framework.DataAnnotations;
using JonDJones.com.Core.Blocks;
using JonDJones.com.Core.Resources;
using JonDJones.com.Core.ViewModel.Blocks;
using JonDJones.Com.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JonDJones.Com.Controllers.Blocks
{
    public class ColourBlockController : BaseBlockController<ColourBlock>
    {
        public override ActionResult Index(ColourBlock currentBlock)
        {
            var displayTag = GetDisplayOptionTag();
            return PartialView("Index", new ColourBlockViewModel(currentBlock, EpiServerDependencies, displayTag));
        }
    }
}
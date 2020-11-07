﻿using Microsoft.AspNetCore.Components;

namespace Tabler.Components
{
    public partial class Navbar : TablerBaseComponent
    {
        protected string HtmlTag => "aside";

        protected bool isExpanded = true;

        protected override string ClassNames => ClassBuilder
              .Add("navbar navbar-vertical navbar-expand-md navbar-dark")
              .ToString();

        protected void ToogleExpand()
        {
            isExpanded = !isExpanded;
        }
    }

}
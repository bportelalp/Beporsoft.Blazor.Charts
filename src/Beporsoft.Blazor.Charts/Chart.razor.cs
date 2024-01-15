﻿using Beporsoft.Blazor.Charts.Common;
using Beporsoft.Blazor.Charts.Interop;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beporsoft.Blazor.Charts
{
    public partial class Chart : ComponentBase
    {

        #region Injects
        [Inject] ChartJsInterop ChartInterop { get; set; } = null!;
        #endregion

        #region Parameters
        public string ChartId {get; } = Guid.NewGuid().ToString();

        public ConfigBase? Config { get; set; }

        #endregion

        #region Privates
        #endregion

        #region Lifecycle
        
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
               await ChartInterop.RenderChart(this);
            }
        }
        #endregion

        #region Interface
        #endregion

        #region Methods
        #endregion

        #region UI Handlers
        #endregion

    }
}
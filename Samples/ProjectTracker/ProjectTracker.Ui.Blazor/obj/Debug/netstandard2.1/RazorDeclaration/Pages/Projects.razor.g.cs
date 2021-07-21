// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectTracker.Ui.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor;

#line default
#line hidden
#line 9 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\_Imports.razor"
using ProjectTracker.Ui.Blazor.Shared;

#line default
#line hidden
#line 2 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Projects.razor"
using Csla.Blazor;

#line default
#line hidden
#line 3 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Projects.razor"
using Csla.Rules;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 56 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\Projects.razor"
       
  private int itemSelectedForDeletion = -1;

  protected override async Task OnParametersSetAsync()
  {
    await vm.RefreshAsync(() => Csla.DataPortal.FetchAsync<ProjectTracker.Library.ProjectList>());
  }

  private void SelectForDelete(int id)
  {
    itemSelectedForDeletion = id;
  }

  private async void Delete(int id)
  {
    itemSelectedForDeletion = -1;
    vm.Model = null;
    await ProjectTracker.Library.ProjectEdit.DeleteProjectAsync(id);
    await vm.RefreshAsync(() => 
      Csla.DataPortal.FetchAsync<ProjectTracker.Library.ProjectList>());
    StateHasChanged();
  }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ViewModel<ProjectTracker.Library.ProjectList> vm { get; set; }
    }
}
#pragma warning restore 1591

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectedit/{id:int}")]
    public partial class ProjectEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 127 "D:\GitHub\csla\Samples\ProjectTracker\ProjectTracker.Ui.Blazor\Pages\ProjectEdit.razor"
       
  [Parameter]
  public int id { get; set; }

  private SubViewModes viewMode = SubViewModes.Default;
  private ProjectTracker.Library.ProjectResourceEdit selectedResource;
  private List<ProjectTracker.Library.ResourceInfo> _resourceList;

  protected override void OnInitialized()
  {
    vm.Saved += () => NavigationManager.NavigateTo("projects");
    vm.ModelPropertyChanged += async (s, e) => await InvokeAsync(() => StateHasChanged());
  }

  protected override async Task OnParametersSetAsync()
  {
    if (id == 0)
      await vm.RefreshAsync(() => Csla.DataPortal.CreateAsync<ProjectTracker.Library.ProjectEdit>());
    else
      await vm.RefreshAsync(() => Csla.DataPortal.FetchAsync<ProjectTracker.Library.ProjectEdit>(id));
  }

  private async void SelectResource()
  {
    viewMode = SubViewModes.Select;
    _resourceList = (await ProjectTracker.Library.ResourceList.GetResourceListAsync())
                      .Where(r => !vm.Model.Resources.Contains(r.Id)).ToList();
    StateHasChanged();
  }

  private void ShowDefaultView()
  {
    if (selectedResource != null)
      selectedResource.CancelEdit();
    viewMode = SubViewModes.Default;
  }

  private async void AssignRole(int resourceId)
  {
    selectedResource = (await ProjectTracker.Library.ProjectResourceEditCreator.GetProjectResourceEditCreatorAsync(resourceId)).Result;
    selectedResource.BeginEdit();
    viewMode = SubViewModes.Details;
    StateHasChanged();
  }

  private void AddResource()
  {
    selectedResource.ApplyEdit();
    if (!vm.Model.Resources.Contains(selectedResource.ResourceId))
      vm.Model.Resources.Add(selectedResource);
    ShowDefaultView();
  }

  private void EditResource(int resourceId)
  {
    selectedResource = vm.Model.Resources
      .Where(r => r.ResourceId == resourceId).FirstOrDefault();
    if (selectedResource != null)
    {
      selectedResource.BeginEdit();
      viewMode = SubViewModes.Details;
    }
  }

  private void RemoveResource(int resourceId)
  {
    vm.Model.Resources.Remove(resourceId);
  }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Csla.Blazor.ViewModel<ProjectTracker.Library.ProjectEdit> vm { get; set; }
    }
}
#pragma warning restore 1591

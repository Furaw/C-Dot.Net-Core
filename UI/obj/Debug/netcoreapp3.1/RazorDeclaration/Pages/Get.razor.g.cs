#pragma checksum "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a869541d0d75837c66aa97b25ac1825f243628d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 2 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DellUser\source\repos\University\UI\Pages\_Imports.razor"
using UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using BusinessLogicLayer.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using BusinessLogicLayer.Interfaces.services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using System.Net.Http.Formatting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using BusinessLogicLayer.validators;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/api/Group")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/api/Group/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/check2/{page}")]
    public partial class Get : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\DellUser\source\repos\University\UI\Pages\Get.razor"
                

        private List<DataAccessLayer.Entities.Group> groupList = new List<DataAccessLayer.Entities.Group>();


        protected override async Task OnInitializedAsync() => await GetGroups();

        HttpClient httpClient = new HttpClient();

        public int pageNum = 1;
        private async Task GetGroups() => groupList = await httpClient.GetJsonAsync<List<DataAccessLayer.Entities.Group>>("https://localhost:44341/check");
        // DataAccessLayer.Entities.Group group = new DataAccessLayer.Entities.Group();



        private async void DeleteGroup(int id)
        {
            string baseUrl = "https://localhost:44341";
            string endpoint = $"{baseUrl}/api/Group/{id}";

            //await httpClient.SendJsonAsync(HttpMethod.Delete, endpoint,);
            await httpClient.DeleteAsync(endpoint);
        }

        GroupDTO groupDTO { get; set; } = new GroupDTO();


        private async void HandleValidSubmit()
        {



            GroupValidator groupValidator = new GroupValidator();
            if (groupValidator.Validate(groupDTO).IsValid)
            {
                await groupService.AddGroup(groupDTO);

            }



        }



    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEFGroupService groupService { get; set; }
    }
}
#pragma warning restore 1591

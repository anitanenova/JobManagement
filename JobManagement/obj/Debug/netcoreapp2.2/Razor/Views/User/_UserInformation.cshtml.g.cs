#pragma checksum "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee997887f1a49e13a67ae3cadf8e63006f50976e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__UserInformation), @"mvc.1.0.view", @"/Views/User/_UserInformation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/_UserInformation.cshtml", typeof(AspNetCore.Views_User__UserInformation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ani\source\repos\JobManagement\Views\_ViewImports.cshtml"
using JobManagement;

#line default
#line hidden
#line 2 "C:\Users\Ani\source\repos\JobManagement\Views\_ViewImports.cshtml"
using JobManagement.Models;

#line default
#line hidden
#line 1 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
using JobManagement.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee997887f1a49e13a67ae3cadf8e63006f50976e", @"/Views/User/_UserInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101dee5b93eab4feefeb805df539bf9d6ed07c3e", @"/Views/_ViewImports.cshtml")]
    public class Views_User__UserInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobManagement.Models.User.UserInformationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(91, 139, true);
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(231, 20, false);
#line 7 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Name);

#line default
#line hidden
            EndContext();
            BeginContext(251, 147, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(399, 10, false);
#line 12 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(409, 179, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(589, 24, false);
#line 19 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(613, 147, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(761, 14, false);
#line 24 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(775, 179, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(955, 22, false);
#line 31 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(977, 165, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1143, 18, false);
#line 37 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
           Write(Model.NGender.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1161, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 39 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.NGender == null)
                {
                    

#line default
#line hidden
            BeginContext(1255, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 41 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(1286, 203, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n        <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n            <div class=\"col-md-12\">\r\n                <p>");
            EndContext();
            BeginContext(1490, 24, false);
#line 50 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
              Write(AccountResource.BdayDate);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 148, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n            <div class=\"col-md-12\">\r\n");
            EndContext();
#line 55 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.BdayDate != null)
               {

#line default
#line hidden
            BeginContext(1726, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(1750, 40, false);
#line 57 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                  Write(Model.BdayDate.Value.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1790, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 58 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
               }

#line default
#line hidden
            BeginContext(1815, 185, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(2001, 23, false);
#line 65 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2024, 165, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(2190, 19, false);
#line 71 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
           Write(Model.NCountry.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 73 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.NCountry == null)
                {
                    

#line default
#line hidden
            BeginContext(2304, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 75 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(2335, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(2527, 20, false);
#line 84 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Town);

#line default
#line hidden
            EndContext();
            BeginContext(2547, 165, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(2713, 16, false);
#line 90 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
           Write(Model.NTown.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 92 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.NTown == null)
                {
                    

#line default
#line hidden
            BeginContext(2821, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 94 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(2852, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(3044, 25, false);
#line 103 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Education);

#line default
#line hidden
            EndContext();
            BeginContext(3069, 165, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(3235, 21, false);
#line 109 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
           Write(Model.NEducation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3256, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 111 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.NEducation.Name == null)
                {
                    

#line default
#line hidden
            BeginContext(3358, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 113 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(3389, 193, true);
            WriteLiteral("            </p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(3583, 26, false);
#line 123 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Categories);

#line default
#line hidden
            EndContext();
            BeginContext(3609, 148, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-6\">\r\n            <p>\r\n");
            EndContext();
#line 129 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 foreach (var category in Model.Categories)
                {
                    

#line default
#line hidden
            BeginContext(3859, 13, false);
#line 131 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3901, 2, true);
            WriteLiteral(", ");
            EndContext();
#line 132 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                   
                }

#line default
#line hidden
            BeginContext(3931, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 134 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.Categories.Count == 0)
                {
                    

#line default
#line hidden
            BeginContext(4027, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 136 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(4058, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(4250, 20, false);
#line 145 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Type);

#line default
#line hidden
            EndContext();
            BeginContext(4270, 148, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-6\">\r\n            <p>\r\n");
            EndContext();
#line 151 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 foreach (var jobType in Model.JobTypes)
                {
                    

#line default
#line hidden
            BeginContext(4517, 12, false);
#line 153 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                Write(jobType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 2, true);
            WriteLiteral(", ");
            EndContext();
#line 154 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                   
                }

#line default
#line hidden
            BeginContext(4588, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 156 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.JobTypes.Count == 0)
                {
                    

#line default
#line hidden
            BeginContext(4682, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 158 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(4713, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(4905, 22, false);
#line 167 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Skills);

#line default
#line hidden
            EndContext();
            BeginContext(4927, 148, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-6\">\r\n            <p>\r\n");
            EndContext();
#line 173 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 foreach (var skill in Model.Skills)
                {
                    

#line default
#line hidden
            BeginContext(5170, 10, false);
#line 175 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                Write(skill.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5209, 2, true);
            WriteLiteral(", ");
            EndContext();
#line 176 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                   
                }

#line default
#line hidden
            BeginContext(5239, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 178 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.Skills.Count == 0)
                {
                    

#line default
#line hidden
            BeginContext(5331, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 180 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(5362, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(5554, 28, false);
#line 189 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.HealthStatus);

#line default
#line hidden
            EndContext();
            BeginContext(5582, 148, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-6\">\r\n            <p>\r\n");
            EndContext();
#line 195 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 foreach (var healthStatus in Model.HealthStatus)
                {
                    

#line default
#line hidden
            BeginContext(5838, 17, false);
#line 197 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                Write(healthStatus.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5884, 2, true);
            WriteLiteral(", ");
            EndContext();
#line 198 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                   
                }

#line default
#line hidden
            BeginContext(5914, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 200 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                 if (Model.HealthStatus.Count == 0)
                {
                    

#line default
#line hidden
            BeginContext(6012, 3, true);
            WriteLiteral(" - ");
            EndContext();
#line 202 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(6043, 191, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(6235, 25, false);
#line 211 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.TelNumber);

#line default
#line hidden
            EndContext();
            BeginContext(6260, 99, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n");
            EndContext();
#line 215 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
         if (Model.TelеphoneNumber != null)
        {

#line default
#line hidden
            BeginContext(6415, 50, true);
            WriteLiteral("            <div id=\"telephone-number\" data-last=\"");
            EndContext();
            BeginContext(6466, 65, false);
#line 217 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
                                             Write(Model.TelеphoneNumber.Substring(Model.TelеphoneNumber.Length - 4));

#line default
#line hidden
            EndContext();
            BeginContext(6531, 63, true);
            WriteLiteral("\" class=\"col-md-12\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(6595, 68, false);
#line 219 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
               Write(Model.TelеphoneNumber.Substring(0, Model.TelеphoneNumber.Length - 4));

#line default
#line hidden
            EndContext();
            BeginContext(6663, 192, true);
            WriteLiteral("\r\n                    <span id=\"show-more-for-number\" class=\"txt-color-blueLight cursor-pointer\"> виж още</span><span class=\"last-7-numbers\"></span>\r\n                </p>\r\n            </div>\r\n");
            EndContext();
#line 223 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(6891, 112, true);
            WriteLiteral("            <div id=\"telephone-number\"  class=\"col-md-12\">\r\n                <p> - </p>\r\n                </div>\r\n");
            EndContext();
#line 229 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
        }

#line default
#line hidden
            BeginContext(7014, 177, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n<div class=\"col-md-12\">\r\n    <div class=\"col-md-6 col-xs-6 profil-info-left-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(7192, 21, false);
#line 237 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.Email);

#line default
#line hidden
            EndContext();
            BeginContext(7213, 147, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6 col-xs-6 profil-info-right-container\">\r\n        <div class=\"col-md-12\">\r\n            <p>");
            EndContext();
            BeginContext(7361, 11, false);
#line 242 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(7372, 44, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 247 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
 if (Model.AdditionalDescription == null || Model.AdditionalDescription == "<p><br></p>" )
{

#line default
#line hidden
            BeginContext(7511, 56, true);
            WriteLiteral("    <div class=\"col-md-12 empty-div-space-20px\"></div>\r\n");
            EndContext();
#line 250 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(7577, 48, true);
            WriteLiteral(" <div class=\"col-md-12 empty-div-space\"></div>\r\n");
            EndContext();
            BeginContext(7627, 110, true);
            WriteLiteral("    <div class=\"col-md-12 text-align-center\">\r\n        <div class=\"col-md-6 col-md-offset-3\">\r\n            <p>");
            EndContext();
            BeginContext(7738, 37, false);
#line 256 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
          Write(AccountResource.AdditionalDescription);

#line default
#line hidden
            EndContext();
            BeginContext(7775, 95, true);
            WriteLiteral("</p>\r\n            <div class=\"col-md-12 additional-description-container\">\r\n                <p>");
            EndContext();
            BeginContext(7871, 37, false);
#line 258 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
              Write(Html.Raw(Model.AdditionalDescription));

#line default
#line hidden
            EndContext();
            BeginContext(7908, 105, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12 empty-div-space\"></div>\r\n");
            EndContext();
#line 263 "C:\Users\Ani\source\repos\JobManagement\Views\User\_UserInformation.cshtml"
}

#line default
#line hidden
            BeginContext(8016, 197, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<script>\r\n    $(\'#telephone-number\').click(function () {\r\n        $(this).find(\'.last-7-numbers\').text($(this).data(\'last\'));\r\n        $(\'#show-more-for-number\').hide();\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobManagement.Models.User.UserInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
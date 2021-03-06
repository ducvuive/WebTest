#pragma checksum "E:\FileGit\WebTest\Test\Test\Areas\Admin\Views\Home\ManHinh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1730bf6ed2b83ec4323a5231cafe645b075bc206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ManHinh), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ManHinh.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1730bf6ed2b83ec4323a5231cafe645b075bc206", @"/Areas/Admin/Views/Home/ManHinh.cshtml")]
    public class Areas_Admin_Views_Home_ManHinh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\FileGit\WebTest\Test\Test\Areas\Admin\Views\Home\ManHinh.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Page Heading -->
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">

        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">DataTables Example</h6>
        </div>

        <p></p>

        <div class=""container"">

            <div class=""row"">



                <div class=""col-md-12"">
                    <form>

                        <div class=""form-row"">
                            <div class=""form-group col-md-2"">
                                <label for=""inputMonitor"">Mã màn hình</label>
                                <input type=""text"" readonly class=""form-control-plaintext"" id=""staticMonitorCode"" value=""MH001"">
                            </div>

                            <div class=""form-group col-md-2"">
                                <label for=""inputSize"">Kích thước</label>
                                <input type=""text"" class=""form-control"" id=""inputSize"" placehol");
            WriteLiteral(@"der=""14inch"">
                            </div>

                            <div class=""form-group col-md-1"">
                            </div>

                            <div class=""form-group col-md-2"">
                                <label for=""inputResolution"">Độ phân giải</label>
                                <input type=""text"" class=""form-control"" id=""inputResolution"" placeholder=""FHD 1080p"">
                            </div>

                            <div class=""form-group col-md-1"">
                            </div>

                            <div class=""form-group col-md-2"">
                                <label for=""inputRefreshRate"">Tần số quét</label>
                                <input type=""number"" class=""form-control"" id=""inputRefreshRate"" placeholder=""120Hz"">
                            </div>

                        </div>

                        <div class=""form-row"">
                            <div class=""form-check"">
                            ");
            WriteLiteral(@"    <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios1"" value=""option1"" checked>
                                <label class=""form-check-label"" for=""exampleRadios1"">
                                    Có cảm ứng
                                </label>
                            </div>
                            <div class=""form-group col-md-1"">
                            </div>
                            <div class=""form-check"">
                                <input class=""form-check-input"" type=""radio"" name=""exampleRadios"" id=""exampleRadios2"" value=""option2"">
                                <label class=""form-check-label"" for=""exampleRadios2"">
                                    Không có cảm ứng
                                </label>
                            </div>

                        </div>
                        <p></p>

                        <div class=""form-row"">
                            <div class=""form-group col-md-12"">
      ");
            WriteLiteral(@"                          <label for=""exampleFormControlTextarea3"">Công nghệ màn hình</label>
                                <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""3""></textarea>
                            </div>
                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-6""></div>
                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-primary"">Thêm</button>
                            </div>

                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-secondary"">Cập nhật</button>
                            </div>

                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-danger"">Xóa</button>
                            </div>
                   ");
            WriteLiteral(@"     </div>

                    </form>

                </div>


            </div>

        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th width=""15%"">Mã MH</th>
                            <th width=""10%"">Kích thước</th>
                            <th width=""10%"">Phân giải</th>
                            <th width=""10%"">Tần số quét</th>
                            <th width=""10%"">Cảm ứng</th>

                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th width=""15%"">Mã MH</th>
                            <th width=""10%"">Kích thước</th>
                            <th width=""10%"">Phân giải</th>
                            <th width=""10%"">Tần số quét</th>
                    ");
            WriteLiteral(@"        <th width=""10%"">Cảm ứng</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td>MH001</td>
                            <td>14inch</td>
                            <td>1080p</td>
                            <td>120Hz</td>
                            <td>Có</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

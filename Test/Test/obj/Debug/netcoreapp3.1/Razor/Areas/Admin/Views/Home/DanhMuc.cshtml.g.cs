#pragma checksum "E:\FileGit\WebTest\Test\Test\Areas\Admin\Views\Home\DanhMuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3faf1865b883f58170068ffc9decf6f33707df94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_DanhMuc), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/DanhMuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faf1865b883f58170068ffc9decf6f33707df94", @"/Areas/Admin/Views/Home/DanhMuc.cshtml")]
    public class Areas_Admin_Views_Home_DanhMuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\FileGit\WebTest\Test\Test\Areas\Admin\Views\Home\DanhMuc.cshtml"
  
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
                                <label for=""inputBrand"">Danh mục</label>
                                <input type=""text"" class=""form-control"" id=""inputBrand"" placeholder=""Dell"">
                            </div>
                        </div>

                        <div class=""form-row"">
                            <div class=""form-group col-md-1 center"">
                                <button type=""button"" class=""btn btn-primary"">Thêm</button>
                      ");
            WriteLiteral(@"      </div>

                            <div class=""form-group col-md-2 center"">
                                <button type=""button"" class=""btn btn-secondary"">Cập nhật</button>
                            </div>

                            <div class=""form-group col-md-1 center"">
                                <button type=""button"" class=""btn btn-danger"">Xóa</button>
                            </div>
                        </div>
                    </form>
                </div>



            </div>

        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th width=""20%"">Mã danh mục</th>
                            <th width=""60%"">Tên danh mục</th>
                            <th width=""20%"">Số sản phẩm</th>
                        </tr>
                    </t");
            WriteLiteral(@"head>
                    <tfoot>
                        <tr>
                            <th width=""20%"">Mã danh mục</th>
                            <th width=""60%"">Tên danh mục</th>
                            <th width=""20%"">Số sản phẩm</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td>DELL</td>
                            <td>DELL</td>
                            <td>50</td>
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

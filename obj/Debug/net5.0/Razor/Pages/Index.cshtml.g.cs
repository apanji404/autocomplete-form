#pragma checksum "C:\Users\apanj\OneDrive\Dokumen\Dotnet\test_ilcs\simple-form\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c449057eabb4ca3d1714761487020e4b0750f369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(simple_form.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace simple_form.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\apanj\OneDrive\Dokumen\Dotnet\test_ilcs\simple-form\Pages\_ViewImports.cshtml"
using simple_form;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c449057eabb4ca3d1714761487020e4b0750f369", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba97f3eb614dc2b26a61822c0bd444b158224b42", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\apanj\OneDrive\Dokumen\Dotnet\test_ilcs\simple-form\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1>Form Page</h1>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""negara"">Negara:</label>
                <input type=""text"" id=""negara"" name=""negara"" class=""form-control"" />
            </div>
            <div class=""form-group col-md-6"">
                <label for=""pelabuhan"">Pelabuhan:</label>
                <input type=""text"" id=""pelabuhan"" name=""pelabuhan"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""barang"">Barang:</label>
                <input type=""text"" id=""barang"" name=""barang"" class=""form-control"" />
            </div>
            <div class=""form-group col-md-6"">
                <label for=""harga"">Harga:</label>
                <input type=""text"" id=""harga"" name=""harga"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
           ");
            WriteLiteral(@" <label for=""deskripsi"">Deskripsi Barang:</label>
            <textarea id=""deskripsi"" name=""deskripsi"" disabled class=""form-control"" rows=""4""></textarea>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""totalBeaMasuk"">Total Bea Masuk (%):</label>
                <input type=""text"" id=""totalBeaMasuk"" disabled name=""totalBeaMasuk"" class=""form-control"" />
            </div>
            <div class=""form-group col-md-6"">
                <label for=""hxt"">Harga x Tarif:</label>
                <input type=""text"" id=""hxt"" name=""hxt"" disabled class=""form-control"" />
            </div>
        </div>
        <b>APInya tidak bisa diakses ^.^</b>
</div>


<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script>
    // Negara
    $(document).ready(function () {
        $('#negara').autocomplete({
            source: function (request, response) {
                if (request.term.length >= 3) {
              ");
            WriteLiteral(@"      $.ajax({
                        url: 'https://insw-dev.ilcs.co.id/n/negara?ur_negara=' + request.term,
                        type: ""GET"",
                        dataType: 'json',
                        success: function (data) {
                            response(data);
                        }
                    });
                }
            },
            minLength: 3 // Menentukan panjang karakter minimum sebelum permintaan API dikirim
        });
    });

    // Pelabuhan
    $(document).ready(function () {
        $('#pelabuhan').autocomplete({
            source: function (request, response) {
                if (request.term.length >= 3) {
                    $.ajax({
                        url: 'https://insw-dev.ilcs.co.id/n/pelabuhan?'+'kd_negara='+$('#negara').attr(""data-id"")+""&ur_pelabuhan="" + request.term,
                        type: ""GET"",
                        dataType: 'json',
                        success: function (data) {
                    ");
            WriteLiteral(@"        response(data);
                        }
                    });
                }
            },
            minLength: 3 // Menentukan panjang karakter minimum sebelum permintaan API dikirim
        });
    });

    // Deskripsi Barang
    $(document).ready(function () {
        $('#barang').on('input', function () {
            var value = $(this).val();
            if (value) {
                $.ajax({
                    url: ""https://insw-dev.ilcs.co.id/n/barang?"",
                    type: ""GET"",
                    data: { hs_code: value },
                    dataType: ""json"",
                    success: function (data) {
                        $(""#deskripsi"").text(data.data[0].sub_header + data.data[0].uraian_id)
                    },
                    error: function (xhr, status, error) {
                        $(""#deskripsi"").text("""")
                    }
                });
            }
        });
    });

    // tarif bea masuk
    $(document).re");
            WriteLiteral(@"ady(function () {
        $('#barang').on('input', function () {
            var value = $(this).val();
            if (value) {
                $.ajax({
                    url: ""https://insw-dev.ilcs.co.id/n/tarif?"",
                    type: ""GET"",
                    data: { hs_code: value },
                    dataType: ""json"",
                    success: function (data) {
                        $(""#totalBeaMasuk"").val(data.data[0].bm)
                    },
                    error: function (xhr, status, error) {
                        $(""#totalBeaMasuk"").val(0)
                    }
                });
            }
        });
    });

    // harga * tarif bea masuk
    $(document).ready(function () {
        $(""#harga"").on('input', function () {
            $(""#hxt"").val(($(""#harga"").val() * $(""#totalBeaMasuk"").val()) / 100)                   
        })
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

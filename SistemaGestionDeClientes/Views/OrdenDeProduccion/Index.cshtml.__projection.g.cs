//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_OrdenDeProduccion_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_OrdenDeProduccion_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
      
    ViewBag.Title = "Orden de Produccion";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }
    

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
    if (role == "Admin")
{
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Crear Nueva Orden", "Create", "OrdenDeProduccion", new { @class = "btn" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
        
}

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Numero);


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Estado);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.FechaDeInicio);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.FechaDeFin);


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.CantidadDePrimera);


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.CantidadPorHermanado);


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.CodigoColor);


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.Sku);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayNameFor(model => model.IdLinea);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
            foreach (var item in Model)
        {
            

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Numero);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Estado);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.FechaDeInicio);


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.FechaDeFin);


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CantidadDePrimera);


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CantidadPorHermanado);


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CodigoColor);


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Sku);


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.IdLinea);


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = ;


#line default
#line "Details", new { id = item.Numero }, new { @class = "btn" }) hidden

#line 26 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
90C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                    if ((role == "Admin") || (role == "SuperLinea"))
                    {
                        Html.ActionLink("Editar", "Edit", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("Eliminar", "Delete", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("AsignarOp", "AddUserToOp", new { id = item.Numero }, new { @class = "btn" });
                    }

#line default
#line hidden

#line 27 "C:\Users\user\AppData27ocal\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                 
        }

#line default
#line hidden

#line 28 "C:\Users\user\AppData28ocal\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Volver al Inicio", "Index", "Home", null, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {

});

}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_OrdenDeProduccion_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_OrdenDeProduccion_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
      
    ViewBag.Title = "Orden de Produccion";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
if (    role == "Admin")
{
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Crear Nueva Orden", "Create", "OrdenDeProduccion", new { @class = "btn" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
        
}

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.Numero);


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.Estado);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.FechaDeInicio);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.FechaDeFin);


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.CantidadDePrimera);


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.CantidadPorHermanado);


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.CodigoColor);


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.Sku);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               = Html.DisplayNameFor(model => model.IdLinea);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                ach (var item in Model)
        {
            

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.Numero);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.Estado);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.FechaDeInicio);


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.FechaDeFin);


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.CantidadDePrimera);


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.CantidadPorHermanado);


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.CodigoColor);


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.Sku);


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 For(modelItem => item.IdLinea);


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                 ink("Detalles", "Details", new { id = item.Numero }, new { @class = "btn" });


#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                      n") || (role == "SuperLinea"))
                    {
                        Html.ActionLink("Editar", "Edit", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("Eliminar", "Delete", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("AsignarOp", "AddUserToOp", new { id = item.Numero }, new { @class = "btn" });
                    }

#line default
#line hidden

#line 27 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                                   e default
#line hidden

#line 28 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o    = Html.ActionLink("Volver al Inicio", "Index", "Home", null, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {

});

}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
  
    ViewBag.Title = "Orden de Produccion";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
if (role == "Admin")
{
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Crear Nueva Orden", "Create", "OrdenDeProduccion", new { @class = "btn" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
        
}

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Numero);


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Estado);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FechaDeInicio);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FechaDeFin);


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CantidadDePrimera);


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CantidadPorHermanado);


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CodigoColor);


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Sku);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.IdLinea);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
        foreach (var item in Model)
        {
            

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Numero);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Estado);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.FechaDeInicio);


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.FechaDeFin);


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CantidadDePrimera);


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CantidadPorHermanado);


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.CodigoColor);


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.Sku);


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.DisplayFor(modelItem => item.IdLinea);


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
               __o = Html.ActionLink("Detalles", "Details", new { id = item.Numero }, new { @class = "btn" });


#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                    if ((role == "Admin") || (role == "SuperLinea"))
                    {
                        Html.ActionLink("Editar", "Edit", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("Eliminar", "Delete", new { id = item.Numero }, new { @class = "btn" });
                        Html.ActionLink("AsignarOp", "AddUserToOp", new { id = item.Numero }, new { @class = "btn" });
                    }

#line default
#line hidden

#line 27 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                 
        }

#line default
#line hidden

#line 28 "C:\Users\user\AppData\Local\Temp\0150840264C97A451A6728042AFB7BFD459D\2\ControlDeCalzado.git\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o = Html.ActionLink("Volver al Inicio", "Index", "Home", null, new { @class = "btn" });


#line default
#line hidden
DefineSection("Scripts", () => {

});

}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_OrdenDeProduccion_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_OrdenDeProduccion_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
      
    ViewBag.Title = "Orden de Produccion";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }
    

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
    if(role == "SuperLinea"){
    

#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Crear Nueva Orden", "Create", "OrdenDeProduccion",new { @class = "btn" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
        
    }

#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Numero);


#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Estado);


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FechaDeInicio);


#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FechaDeFin);


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CantidadDePrimera);


#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CantidadPorHermanado);


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.CodigoColor);


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Sku);


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.IdLinea);


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
    foreach (var item in Model)
    {
        

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Numero);


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Estado);


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.FechaDeInicio);


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.FechaDeFin);


#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.CantidadDePrimera);


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.CantidadPorHermanado);


#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.CodigoColor);


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.Sku);


#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.DisplayFor(modelItem => item.IdLinea);


#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
           __o = Html.ActionLink("Detalles", "Details", new { id = item.Numero }, new { @class = "btn" });


#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
                if ((role == "Admin") || (role == "SuperLinea"))
                {
                    Html.ActionLink("Editar", "Edit", new { id = item.Numero }, new { @class = "btn" });
                    Html.ActionLink("Eliminar", "Delete", new { id = item.Numero }, new { @class = "btn" });
                    Html.ActionLink("AsignarOp", "AddUserToOp", new { id = item.Numero }, new { @class = "btn" });
                }

#line default
#line hidden

#line 27 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
             
    }

#line default
#line hidden

#line 28 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\OrdenDeProduccion\Index.cshtml"
   __o = Html.ActionLink("Volver al Inicio", "Index", "Home", null , new{ @class = "btn" } );


#line default
#line hidden
}
}
}

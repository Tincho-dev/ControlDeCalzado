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

public class _Page_Views_Home_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = Common.CurrentUser.Get.Name;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                   
        

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = role;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                           
    }
    else
    {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                              
        

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                        
        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                __o = Url.Action("Login", "Account");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            
    }

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
	{
		if (role == "Admin")
		{
			

#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Color");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
			

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Modelo");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

		}
		if (role == "Admin" || role == "SuperLinea")
		{
			

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
		}

		

#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\2ABE7DD7AD111644CF213A58CDC32B2090C5\3\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              

		
	}

#line default
#line hidden
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

public class _Page_Views_Home_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = Common.CurrentUser.Get.Name;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                  
        

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = role;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                           
    }
    else
    {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                              
        

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                        
        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                __o = Url.Action("Login", "Account");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            
    }

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
	{
		if (role == "Admin")
		{
			

#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Color");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
			

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Modelo");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

		}
		if (role == "Admin" || role == "SuperLinea")
		{
			

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
		}

		

#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\131B2E59C3713A23A87F597EB723B29CDDF0\4\ControlDeCalzado\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              

		
	}

#line default
#line hidden
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

public class _Page_Views_Home_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Home_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = Common.CurrentUser.Get.Name;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                  
        

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = role;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                           
    }
    else
    {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                              
        

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                        
        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                __o = Url.Action("Login", "Account");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            
    }

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
	{
		if (role == "Admin")
		{
			

#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Color");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
			

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Modelo");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

		}
		if (role == "Admin" || role == "SuperLinea")
		{
			

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  

			

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
		}

		

#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\7364B903DD7CF22CD54A4BCD870E7B320D19\2\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              

		
	}

#line default
#line hidden
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

#line 1 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = Common.CurrentUser.Get.Name;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                  
        

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = role;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                           
    }
    else
    {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                              
        

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                        
        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                __o = Url.Action("Login", "Account");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            
    }

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        if (role == "Admin")
        {
            

#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Color");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Modelo");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                       
        }
        else if (role == "SuperCalidad")
        {
            

#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
        }
        else if (role == "SuperLinea")
        {
        

#line default
#line hidden

#line 27 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 28 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 29 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 30 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 31 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 32 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 33 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 34 "C:\Users\user\AppData\Local\Temp\318FFC68ABFF20CD581E07E8FF0578B3B1EA\2\ControlDeCalzado.git.augusto.cesar.paz\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
     }
   }

#line default
#line hidden
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

#line 1 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Inicio";
    var role = string.Empty;
    if (Request.IsAuthenticated)
    {
        role = Services.UserService.GetRole(Common.CurrentUser.Get.UserId).Role;
    }


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        

#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = Common.CurrentUser.Get.Name;


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                  
        

#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            __o = role;


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                           
    }
    else
    {
        

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                              
        

#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                                        
        

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                __o = Url.Action("Login", "Account");


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
            
    }

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
    if (Request.IsAuthenticated)
    {
        if (role == "Admin")
        {
            

#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Color");


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Modelo");


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 19 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 20 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 21 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 22 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 23 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
            

#line default
#line hidden

#line 24 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                       
        }
        else if (role == "SuperCalidad")
        {
            

#line default
#line hidden

#line 25 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                                   __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 26 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                  
        }
        else if (role == "SuperLinea")
        {
        

#line default
#line hidden

#line 27 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "LineaDeProduccion");


#line default
#line hidden

#line 28 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 29 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "Defecto");


#line default
#line hidden

#line 30 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 31 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "OrdenDeProduccion");


#line default
#line hidden

#line 32 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
        

#line default
#line hidden

#line 33 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
                               __o = Url.Action("Index", "Turno");


#line default
#line hidden

#line 34 "C:\Users\user\AppData\Local\Temp\4E41871F206EC196E1D0BB11BA318030115B\3\ControlDeCalzado.git.augusto.cesar\SistemaGestionDeClientes\Views\Home\Index.cshtml"
              
     }
   }

#line default
#line hidden
}
}
}
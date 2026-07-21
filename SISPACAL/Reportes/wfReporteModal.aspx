<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfReporteModal.aspx.vb" Inherits="Reportes_wfReporteModal" %>
<%@ Register TagPrefix="uc1" TagName="ucReporte" Src="~/controles/ucReporte.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: white" >
    <form id="form1" runat="server">
    <div>
        <uc1:ucReporte id="ucReporte1" runat="server"></uc1:ucReporte>
    </div>
    </form>
</body>
</html>

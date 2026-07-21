<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfReporteModalCatorcena.aspx.vb" Inherits="Reportes_wfReporteModalCatorcena" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteCatorcena" Src="~/controles/ucReporteCatorcena.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: white">
    <form id="form1" runat="server">
    <div>
        <uc1:ucReporteCatorcena id="ucReporteCatorcena1" runat="server"></uc1:ucReporteCatorcena>
    </div>
    </form>
</body>
</html>

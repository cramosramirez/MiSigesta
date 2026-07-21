<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfReporteFinancieroModal.aspx.vb" Inherits="Financiero_wfReporteFinancieroModal" %>
<%@ Register TagPrefix="uc1" TagName="ucReporteFinanciero" Src="~/controlesFinanciero/ucReporteFinanciero.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="background: white" >
    <form id="form1" runat="server">
    <div>
        <uc1:ucReporteFinanciero id="ucReporteFinanciero1" runat="server"></uc1:ucReporteFinanciero>
    </div>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfReportePlanCosechaModal.aspx.vb" Inherits="Reportes_wfReportePlanCosechaModal" %>
<%@ Register TagPrefix="uc1" TagName="ucReportePlanCosecha" Src="~/controlesCenso/ucReportePlanCosecha.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="background: white" >
    <form id="form1" runat="server">
    <div>
        <uc1:ucReportePlanCosecha id="ucReportePlanCosecha1" runat="server"></uc1:ucReportePlanCosecha>
    </div>
    </form>
</body>
</html>

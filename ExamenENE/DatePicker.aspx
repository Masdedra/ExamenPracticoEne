<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatePicker.aspx.cs" Inherits="ExamenENE.DatePicker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <h1>Date Picker</h1>
            <div class="row">
                <div class="col text-center">
                    <input type="date" id="start" runat="server" value="2021-01-26" min="2018-01-01" max="2022-12-31" />

                    <input type="date" id="end" runat="server" value="2022-01-26" min="2018-01-01" max="2022-12-31" />

                    <asp:Button ID="Btn" Text="Submit" class="btn btn-default" OnClick="Btn_Click" runat="server" />
                </div>
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col-auto">
                <asp:GridView ID="table" runat="server" class="table table-responsive"></asp:GridView>
            </div>
        </div>

    </form>
</body>
</html>

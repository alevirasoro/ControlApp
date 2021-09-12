<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ControldeGastos.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <div>
        <script type="text/javascript">
              var sal = "<% =sal %>";
        </script>
    </div>
    <div>
        <p><%= sal %></p>
    </div>

    <div>
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Fecha") %></td>
                    <td><%# Eval("Titulo") %></td>
                    <td><%# Eval("Descripcion") %></td>
                    <td><%# Eval("Importe") %></td>
                </tr>
            </ItemTemplate>

        </asp:Repeater>
    </div>

</body>
</html>

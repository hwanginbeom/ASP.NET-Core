<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmButton.aspx.cs" Inherits="DevStandardControl.FrmButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>버튼 컨트롤</title>
</head>
<body>
  <form id="form1" runat="server">
      <div>
          <asp:TextBox ID"txtNum" runat="server" />
          <asp:Button ID="btnUp" runat="server"
              OnClick="btnUp_Click" Text=" 증가 " />
          <asp:Button ID="btnDown" runat="server"
              OnClick="btnDown_Click" Text=" 감소 " />
    </form>
</body>
</html>


5.8 | 실습_ Button 컨트롤을 사용해 명령어 실행하기
5.8.1 소개

버튼 컨트롤은 사용 빈도가 꽤 높다. 이 실습에서는 버튼을 클릭할 때마다 텍스트박스에 있는 숫자 값을 1 증가시키거나 1 감소시키는 코드를 작성해보자.
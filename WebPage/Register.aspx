<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebPage.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>  </title>
    <link href="style/register.css" rel="stylesheet" />
    <script src="http://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/jquery-1.7.2.min.js"></script>
    <script src="http://code.jquery.com/jquery-1.7.2.js"></script>
</head>

<body>
    <div id="register_box">
        <input type="text" value="İsim..." id="Name" class="register_text_mini"/>
        <input type="text" value="Soyisim..." id="Surname" class="register_text_mini"/>
        <input type="text" value="Kullanıcı Adı..." id="Account_ID" class="register_text"/>
        <input type="text" value="Şifre..." id="Password" class="register_text"/>
        <input type="text" value="Şifre Tekrar..." id="Re_Password" class="register_text"/>
        <input type="text" value="E-Mail..." id="E_Mail" class="register_text"/>
        <textarea id="Adress" class="register_text"> Adres Bilgisi... </textarea>   
        <input type="button" class="singin_button" onclick="SendForm()" value="Kayıt Ol"/>

        <script src="Js/basicSystem/Register.js"></script>
    </div>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

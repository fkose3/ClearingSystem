
$("#Name").focus(function () {
    var val = $(this).val();
    if (val == "İsim...") {
        $(this).val("");
    }
});

$("#Surname").focus(function () {
    var val = $(this).val();
    if (val == "Soyisim...") {
        $(this).val("");
    }
});

$("#Account_ID").focus(function () {
    var val = $(this).val();
    if (val == "Kullanıcı Adı...") {
        $(this).val("");
    }
});

$("#Password").focus(function () {
    var val = $(this).val();
    if (val == "Şifre...") {
        $(this).val("");
        $(this).attr('type', 'password');
    }
});

$("#Re_Password").focus(function () {
    var val = $(this).val();
    if (val == "Şifre Tekrar...") {
        $(this).val("");
        $(this).attr('type', 'password');
    }
});

$("#E_Mail").focus(function () {
    var val = $(this).val();
    if (val == "E-Mail...") {
        $(this).val("");
    }
});

$("#Adress").focus(function () {
    var val = $(this).val();
    if (val == " Adres Bilgisi... ") {
        $(this).val("");
    }
});

function SendForm() {
    $.ajax({
        type: "POST",
        url: 'Register.aspx/SendForm',
        data: '{ "Name":' + $("#Name").Val() + ',"Surname":' + $("#Surname").Val() + ' ,"Account":' + $("#Account_ID").Val() + ' ,"Password":' + $("#Password").Val() + ' ,"E_Mail":' + $("#E_Mail").Val() + ' ,"Adress":' + $("#Adress").Val() + ' }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (result) {
            alert(result.d);
        }
    });
}
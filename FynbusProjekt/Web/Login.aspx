<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <style>
            @import url(http://fonts.googleapis.com/css?family=Open+Sans:300,400,700);

            * {
                margin: 0;
                padding: 0;
            }

            body {
                background: #567;
                font-family: 'Open Sans', sans-serif;
            }

            .button {
                -webkit-transition: background .3s;
                background: #3399cc;
                color: #fff;
                cursor: pointer;
                display: block;
                margin: 0 auto;
                margin-top: 1%;
                padding: 10px;
                text-align: center;
                text-decoration: none;
                transition: background .3s;
                width: 100px;
            }
            
            .button:hover { background: #2288bb; }

            #login {
                -webkit-transition: opacity 1s;
                margin: 0 auto;
                margin-bottom: 2%;
                margin-top: 8px;
                transition: opacity 1s;
                width: 400px;
            }

            #triangle {
                border-bottom: 12px solid #3399cc;
                border-left: 12px solid transparent;
                border-right: 12px solid transparent;
                border-top: 12x solid transparent;
                margin: 0 auto;
                width: 0;
            }

            #login h1 {
                background: #3399cc;
                color: #fff;
                font-size: 140%;
                font-weight: 300;
                padding: 20px 0;
                text-align: center;
            }

            form {
                background: #f0f0f0;
                padding: 6% 4%;
            }

            input[type="text"], input[type="password"] {
                background: #fff;
                border: 1px solid #ccc;
                color: #555;
                font-family: 'Open Sans', sans-serif;
                font-size: 95%;
                margin-bottom: 4%;
                padding: 4%;
                width: 92%;
            }

            input[type="submit"] {
                -webkit-transition: background .3s;
                background: #3399cc;
                border: 0;
                color: #fff;
                cursor: pointer;
                font-family: 'Open Sans', sans-serif;
                font-size: 100%;
                padding: 4%;
                transition: background .3s;
                width: 100%;
            }

            input[type="submit"]:hover { background: #2288bb; }
        </style>
        <script>
            (function() {
                $('#toggle-login').click(function() {
                    $('#login').toggle();
                });
            })(jQuery);
        </script>
    </head>
    <body>
        <form id="form1" runat="server">
            <span href="#" class="button" id="toggle-login">Log in</span>

            <div id="login">
                <div id="triangle"></div>
                <h1>Log in</h1>
                <form>
                    <input type="text" placeholder="Brugernavn" id="Brugernavn" runat="server"/>
                    <input type="password" placeholder="Adgangskode"  id="Adgangskode" runat="server"/>
                    <input type="submit" value="Log in" id="submit" runat="server"/>
                </form>
            </div>
        </form>
    </body>
</html>
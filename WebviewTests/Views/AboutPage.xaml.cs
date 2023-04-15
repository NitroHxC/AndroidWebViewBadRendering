using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebviewTests.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            WebContent.Source = @"<!DOCTYPE html>
<html>

<head>
    <title>Space Story</title>
    <style>
        body {
            font-family: 'Verdana', sans-serif;
            font-size: 14px;
            background-color: white;
            color: black;
            font-weight: bold;
            margin: 0;
        }

        .striped-bg {
            background: linear-gradient(0deg, grey 50%, white 50%);
            background-size: 100% 8em !important;
            line-height: 4 !important;
            padding: 0px 18px;
        }
    </style>
</head>

<body>
    <div class=""striped-bg"">
        <p>
        <p>In the year 2050, humanity had reached a new milestone in space exploration. The first manned mission to Mars
            had been successfully completed, and the world was abuzz with excitement about the possibilities that lay
            ahead. As part of the ongoing efforts to expand humanity's presence in the cosmos, a team of six astronauts
            was selected to embark on a long-term mission to a distant planet in the Alpha Centauri system.<br>
            <br>...<br>
        </p>
        </p>
    </div>
</body>

</html>";

            WebContent.Refresh();
        }
    }
}
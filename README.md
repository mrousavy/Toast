# <img src="https://github.com/mrousavy/Toast/blob/master/ToastDemo/Resources/Toast_Icon.ico?raw=true" width="42"> Toast
Android Toast for WPF

[Download the Demo (.exe)](https://github.com/mrousavy/Toast/raw/master/ToastDemo/bin/Release/ToastDemo.zip)

[![NuGet](https://img.shields.io/nuget/dt/AndroidToast.svg)](https://www.nuget.org/packages/AndroidToast/)
      
# How to use

### 1. Add Binaries
   + NuGet
      * [Android Toast is also available on NuGet!](https://www.nuget.org/packages/AndroidToast)   Install by typing `Install-Package AndroidToast` in NuGet Package Manager Console. (Or search for `AndroidToast` on NuGet) 

   + Manually
      1. [Download the latest Library (.dll)](https://github.com/mrousavy/Toast/raw/master/Toast/bin/Release/Toast.dll)
      2. Add the .dll to your Project   (Right click `References` in the Project Tree View, click `Add References` and `Browse` to the `.dll` File)

### 2. Add the reference
   * XAML Window
   ```XAML
   <Window x:Class="ToastDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:ToastDemo"

        //IMPORTANT LINE!
        xmlns:toast="clr-namespace:Toast;assembly=Toast"

        mc:Ignorable="d"
        Title="Toast Demo" Height="350" Width="525">
   ```

   * C# (using)
   ```C#
   using Toast;
   ```
   
   * VB (using)
   ```C#
   Imports Toast;
   ```

### 3. Add Toast to XAML or in Code

   * XAML
   ```XAML
   <toast:Toast x:Name="myToast" Message="Hello World!" Duration="0:0:0:5"/>
   ```

   * C#
   ```C#
   Toast.Toast myToast = new Toast.Toast();
   myToast.DurationToast = Toast.Toast.ToastDuration.Long;
   myToast.Message = "Hello World!";
   
   someControl.Children.Add(myToast);
   someOtherControl.Content = myToast;
   ```
   
   * VB
   ```VB
   Dim myToast As new Toast.Toast()
   myToast.DurationToast = Toast.Toast.ToastDuration.Long
   myToast.Message = "Hello World!"
   
   someControl.Children.Add(myToast)
   someOtherControl.Content = myToast
   ```
### 4. Set desired Parameters:
   * `Toast.Duration`/`Toast.DurationToast`
   * `Toast.Message`/`Toast.Content`
   * `Toast.DurationAnimation`

### 5. Show Toast:
   * `myToast.Show();`
   
### 6. (Optional) Hide Toast:
   * `myToast.Hide();`

# Screenshots
<img src="http://i.imgur.com/Wikjo4z.png">
<img src="https://i.gyazo.com/b9d2f30c6c3d4169f8256e9ea2580b06.gif">

# Thanks for using Toast!

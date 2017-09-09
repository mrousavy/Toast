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
   ```xaml
   <Window x:Class="ToastDemo.MainWindow"
        [...]
        ----IMPORTANT LINE!----
        xmlns:toast="clr-namespace:Toast;assembly=Toast"
        [...] >
   ```

   * C# (using)
   ```cs
   using Toast;
   ```
   
   * VB (using)
   ```vb
   Imports Toast
   ```

### 3. Add Toast to Window/User Control

   * XAML
   ```xaml
   <toast:Toast x:Name="myToast" Message="Hello World!" Duration="0:0:0:5"/>
   ```

   * C#
   ```cs
   // (Or in code)
   Toast myToast = new Toast();
   myToast.DurationToast = Toast.Toast.ToastDuration.Long;
   myToast.Message = "Hello World!";
   
   someControl.Children.Add(myToast);
   someOtherControl.Content = myToast;
   ```
### 4. Set desired Parameters
   * `Toast.Duration`/`Toast.DurationToast`: The display-time of this Toast
   * `Toast.Message`/`Toast.Content`: The Message to display (Can also be a `{Binding}`)
   * `Toast.DurationAnimation`: The duration of the fade-in/out animation

### 5. Show Toast
   ```cs
   myToast.Show();
   ```
   
### 6. (Optional) Hide Toast manually:
   ```cs
   myToast.Hide();
   ```

# Screenshots
<img src="http://i.imgur.com/Wikjo4z.png">
<img src="https://i.gyazo.com/b9d2f30c6c3d4169f8256e9ea2580b06.gif">

# Thanks for using Toast!

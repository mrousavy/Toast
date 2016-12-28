# <img src="https://github.com/mrousavy/Toast/blob/master/ToastDemo/Resources/Toast_Icon.ico?raw=true" width="42"> Toast
Android Toast for WPF

[Download the Demo (.exe)](https://github.com/mrousavy/Toast/raw/master/ToastDemo/bin/Release/ToastDemo.zip)

# How to use
1. [Download the latest Library (.dll)](https://github.com/mrousavy/Toast/raw/master/Toast/bin/Release/Toast.dll)
2. Add the .dll to your Project 
(Right click `References` in the Project Tree View, click `Add References` and `Browse` to the `.dll` File)

3. Add the reference
   * XAML Window
   ```
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
   ```
   using Toast;
   ```

4. Add Toast to XAML or in Code

   * XAML
   ```
   <toast:Toast x:Name="myToast" Message="Hello World!" Duration="0:0:0:5"/>
   ```

   * C#
   ```
   Toast.Toast myToast = new Toast.Toast();
   myToast.DurationToast = Toast.Toast.ToastDuration.Long;
   myToast.Message = "Hello World!";
   
   someControl.Children.Add(myToast);
   someOtherControl.Content = myToast;
   ```

5. Set desired Parameters (`Toast.Duration`/`Toast.DurationToast`, `Toast.Message`/`Toast.Content`, `Toast.DurationAnimation`)
6. Show Toast `myToast.Show();`
7. (Optional) Hide Toast `myToast.Hide();`

# Screenshot
<img src="http://i.imgur.com/l5ACUtr.png">

# Thanks for using Toast!

   M S B A M L   `   `   `  ????C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5   	       ToDoList.NewTaskWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoList     5   	     ? Title$  Нова задача??5   	   $	??350??6   $	??300??6*   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      ?? 5      $??60 ?6   .+?5   
   ?? $??1??6   .+?5      ?? -   5         ??Name$ CancelButton??5      $??Відмінити??6+   $??	15,0,15,0q?6?   6R   ?? 5      -   5        $ 
SaveButton??5      $??Зберегти??6)   $??	15,8,15,8q?6<   6O   5      ?? 5   
   $??15,15,15,15q?6   .+?5      ?? $
??Wrap=?6   $??0,0,0,4q?6,   ?? 6>    ? Language$ uk-ua?6B   $?Назва задачі??6S   6j   ?? 5      -   5         ??Name$ NameTextBox??5       ?? TextWrapping$
 Wrap=?6+   $	??250??6?   $
??Left=?6K   $??0,0,0,8q?6f   ?? 5      -   5         ??Name$ IsCompletedCheckBox??5      $#??Задача виконана??64   $??0,0,0,8q?6N   ?? 5      -   5         ??Name$ TextBlockDescription??5      $
??Wrap=?66   $??0,0,0,4q?6J   ?? 6\   $ uk-ua?6`   $?Опис задачі??6q   6?   ?? 5      -   5        $ TexBoxDescription??5      $
 Wrap=?61   $	??250??6E   $
??Left=?6Q    ?? AcceptsReturn$
 True??6l   	 J? RenderTransformOrigin$	 0.5,0.5&?6?   $	??110??6?   .??6?   z?5      V? 5      .~?5      ?? ?? 5      
 ?? AngleX$
 0Q?6(   ?? 5      T? 5       T? X$ 0Q?6-   5      .??5   +   5       5!      5#      5$      
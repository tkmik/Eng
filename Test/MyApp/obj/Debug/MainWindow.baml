   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyAppMyApp  5   	   D @MyContext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullF1clr-namespace:MyContext.Models;assembly=MyContextMyContext.Models 5   	       MyApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MyApp     5   	   DModels1clr-namespace:MyContext.Models;assembly=MyContext     5   	   -   5          � Title$  English��5	   	   $	��450��6    � WindowStartupLocation$ CenterScreen=�6&   $	��800��6K   $	��450��6W   $	��800��6g   .��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      6   �� 5      $��30 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      $	��125 �6   6-   �� 5      $	��125 �6   6-   �� 5      $	��125 �6   6-   .+�5   
   o� $��0��6   $
��Left=�6   $��0��67   $
��auto��6G   $	��Top=�6U   $
��auto��6m   
�������$��14(�6�   .@�5      m� -   5        $��TableMenuItem��5      $��Table��6,   ���	#FF080808$��5,5,0,0q�6S   $��1q�6e   ���	#FFF5EEA4.@�5      �� -   5        $��FirstTableCheckBox��5      .��6V   	1st group6a   �� 5      -   5        $��SecondTableCheckBox��5      .��6X   	2nd group6c   5      m� 5      -   5        $��TestMenuItem��5      $��10,5,0,0q�6+   $
��Test��6=   ���	#FF080808$��1q�6d   ���	#FFF5EEA46�   5      �� 5   
   $��0��6   $��Right=�6    $��Search��6<   $��0q�6M   $��0,5,0,0q�6a   6t   �� 5    
   -   5         ��Name$ SearchTextBox��5    "   $��1��6   $	��200��69   $��4,5,4,4q�6E   $
��Left=�6V   $��2��6�   $��12(�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ VerbGrid��5!       $��1��6   $��5��62    %� IsVirtualizing .    AutoGenerateColumns .  $��Stretch=�5$      $��5q�5%         CanUserResizeColumns .  	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Infinitive��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Infinitive+6X     5(      $
 Past Simple��6D   $ * 6Y    6%   �� *
PastSimple+6Y     5)      $
 Past Participle��6H   $ * 6a    6%   �� *PastParticiple+6a     5*      $
 Translation��6E   $ * 6Z    6%   �� *Translation+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5+      $
 
It's known��6E   $ SizeToHeader 6Y    6)   �� *	IsKnown+6Y   56      �� 57   
   -   5        $��SaveToDatabaseButton��57      $��2��6-   $��4��6:   $��Save to database��6J   $��5q�6e   $
��auto��6p   $��Right=�6}   6�   �� 58   
   -	   5        $��SaveToJsonButton��58      $��2��6)   $��3��67   $��Save to JSON-file��6G   $��5q�6c   $
��auto��6n   $��Right=�6{   6�   �� 59   
   -
   5        $��LoadFromJsonButton��59      $��2��6+   $��2��69   $��Load from JSON-file��6I   $��5q�6g   $
��auto��6r   $��Right=�6   6�   5:      5;      
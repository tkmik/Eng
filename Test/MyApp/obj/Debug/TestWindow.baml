   M S B A M L   `   `   `  ����@  <MyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyAppMyApp  5   	   p lDotNetProjects.DataVisualization.Toolkit, Version=6.0.85.0, Culture=neutral, PublicKeyToken=79778c5f2eed289b�rclr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=DotNetProjects.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   D @MyContext, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullF1clr-namespace:MyContext.Models;assembly=MyContextMyContext.Models 6?       MyApp.TestWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MyApp     5   	   �chartingToolkitrclr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=DotNetProjects.DataVisualization.Toolkit     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   DModels1clr-namespace:MyContext.Models;assembly=MyContext     6?   -   5          � Title$
  Test��5
   	    � WindowStartupLocation$ CenterScreen=�6   $	��450��6;   $	��800��6H    � 
ResizeMode$ NoResize=�6T   .��5   
   �  � RowDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6   �� 5      $
��0.3* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $
��0.2* �6   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ FirstGroupCheckBox��5      $��0��6/   $��	1st group��6<   $
��Left=�6P   $��10q�6k   $��Center=�6w   6�   �� 5   
   -   5        $ SecondGroupCheckBox��5      $��0��60   $��	2nd group��6=   $
��Left=�6Q   $��100,10,10,10q�6l   $��Center=�6�   6�   �� 5   
   $��Count��6   $��0��6    $��1��6-   $��Center=�6>   $
��Left=�6Y   $��45��6t   �� 5   
   -   5         ��Name$ MaxCountLabelText��5      $��0��6+   $��1��68   $��	max count��6H   $
��Left=�6\   $��Bottom=�6w   $��3��6�   $
��auto��6�   $��10(�6�   �� 5   
   -   5        $ MaxCountLabelNumber��5      $��0��6-   $��2��6:   $
��Left=�6J   $��Bottom=�6e   $��3��6�   $
��auto��6�   $��10(�6�   �� 5   
   -   5         ��Name$ CountTextBox��5      $��0��6(   $��3��65   $
��Left=�6I   $��25��6d   $��250,10,10,10q�6p   $�� ��6�   $��30��6�   $��16(�6�   �� 5    
   -   5         ��Name$ StartButton��5       $��Start��6&   $��25��66   $��0��6B   $��3��6O   $
��Left=�6c   $��300,10,10,10q�6~   $��75��6�   6�   �� 5!   
   -   5        $ TranslationLabel��5!      $��Center=�6*   $
��auto��6G   $
��auto��6T   $��1��6b   $��2��6o   $��16(�6   �� 5"   
   $��
Infinitive��6   $��center=�6%   $	��Top=�6B   $��2��6Z   $��0��6g   $��2��6w   �� 5#   
   -	   5        $ InfinitiveTextBox��5#      $��Center=�6-   $��25��6J   $��2��6V   $��0��6c   $��2��6s   $�� ��6�   {�.  $��Center=�6�   $	��120��6�   $��14(�6�   6�   �� 5$   
   $��Past Simple��6   $��center=�6&   $	��Top=�6C   $��2��6[   $��2��6h   �� 5%   
   -
   5        $ PastSimpleTextBox��5%      $��Center=�6-   $��25��6J   $��2��6V   $��2��6c   $�� ��6s   {�.  $��Center=�6�   $	��120��6�   $��14(�6�   6�   �� 5&   
   $��Past Participle��6   $��center=�6*   $	��Top=�6G   $��2��6_   $��3��6l   �� 5'   
   -   5        $ PastParticipleTextBox��5'      $��Center=�61   $��25��6N   $��2��6Z   $��3��6g   $�� ��6w   {�.  $��Center=�6�   $	��120��6�   $��14(�6�   6�   �� 5(   
   -   5        $ EnterButton��5(      $��Enter��6&   $��2��66   $��3��6F   $��25��6S   $��Center=�6_   {�.  $��Center=�6�   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5)   
   -   5        	  Name$	 
GridLabels��5)   '   $y�Hidden=�6   $��4��6;   {�.  $��4��6Z   
   AutoGenerateColumns
 .  $��Stretch=�5+      $	��Top=�5,         
IsReadOnly .    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ your result��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:     5/      $ you answers��6%   $ * 6:     50      $ must be��6%   $ * 66   52      >  8System.Windows.Controls.DataVisualization.Charting.Chart  53   
   -   5          Name$ DataPieChart��53   4   $y�Hidden=�6    $��0��6J   $��2��6Z   $��5��6n   $��Stretch=�6{   $��Stretch=�6�   ���	#FF688CAF   Series. 54      B  <System.Windows.Controls.DataVisualization.Charting.PieSeries  H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ Value��6M      IndependentValuePath$
 Name��6h   $��0q�6�      ItemsSource 6(   ��  �� Mode$ Default=�6�   56        58   
   -   5        $	 
AnswerGrid��58   '   $y�Hidden=�6   $��5��6;   $��2��6H   $��2��6X    %� IsVirtualizing . 
 .  $��Stretch=�5;       .  5=        5>      $ 
Infinitive��6E   $ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Infinitive1+6Y     5?      $ Past Simple��6E   $ * 6Z    6%   �� *PastSimple1+6Z     5@      $ Past Participle��6I   $ * 6b    6%   �� *PastParticiple1+6b     5A      $ 
Infinitive��6E   $ * 6Y    6%   �� *Infinitive2+6Y     5B      $ Past Simple��6E   $ * 6Z    6%   �� *PastSimple2+6Z     5C      $ Past Participle��6I   $ * 6b    6%   �� *PastParticiple2+6b   5E      5F      5G      
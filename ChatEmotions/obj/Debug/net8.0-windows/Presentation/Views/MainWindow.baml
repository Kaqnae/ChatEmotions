   M S B A M L   `   `   `  ����G  CChatEmotions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ChatEmotionsChatEmotions  5   	   *    $ChatEmotions.Presentation.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ChatEmotions     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $��10,10,10,10q�6B   .+�5      �� $	��200��6   $��25��6'   ��63   �� *EmotionsList+ �� SelectedItem 6X   �� *SelectedEmotion+�� 5      $��25��6   $	��100��6%   $
��Show��61   ��6@   �� *ShowMessagesCommand+5      �� 5      $��2��6   $ 
Horizontal=�6)   $��10,10,10,10q�6B   .+�5      �� $��25��6   $	��200��6&   ��62   �� *
SearchText+�� 5      $��25��6   $	��100��6%   $��Search��61   ��6B   �� *SearchCommand+5      5      �� 5   
   $��1��6   ��6    �� *MsgCollection+ 6F   �� *SelectedMsg+ �� View 5       �� 5!      .P�5"      �� $��Messages��6%    �� DisplayMemberBinding 67   �� *	Content+5#      5%      �� 5&   
   $��2��6   $��Right=�6"   .+�5'      �� $��25��6   $	��100��6!   $��	0,0,10,10q�6-   $��Remove��6@   ��6Q   �� *RemoveCommand+5(      5)      5*      
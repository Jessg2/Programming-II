   M S B A M L   `   `   `  ����Q  MProgrammingIICraftDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ProgrammingIICraftDemoProgrammingIICraftDemo  5   	   '    !ProgrammingIICraftDemo.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ProgrammingIICraftDemo     5   	     � Title$*  $Potions Project by Jess Grosshandler��5   	   $	��450��66   $	��800��6C   .��5	      � -   5         �Name$ MainGrid��5	      ���	#FFE0E0E0 � ColumnDefinitions 5
   
   �� 5      $��9* �6   �� 5      $	��31* �6   .+�5   
   �� -   5         ��Name$ 
PlayerName��5      $
��Left=�6(   $��34��6C   $��
294,10,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��302��6�   
�������$��1��6�   �� 5   
   $��294,59,24,28q�6   $	��302��6-   $
��Auto=�69   
�������$��1��6p   .��5      �� -   5        $ PlayerInventory��5      $
��Left=�61   $
��Wrap=�6M   $	��Top=�6a   5      �� 5   
   $	��247��6   $��26,112,340,75q�6%   $	��434��6>   $
��Auto=�6J   
�������$��2��6�   .��5      �� -   5        $ Output��5      $
��Left=�6(   $
��Wrap=�6C   $	��Top=�6W   5      �� 5   
   -   5         ��Name$ Input��5      $
��Left=�6!   $��37��6<   $��
26,368,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��357��6�   $��ProgrammingIIDemo��6�   $��2��6�   �� 5   
   -   5         ��Name$ Submit��5      $��Submit��6!   $
��Left=�62   $��220,368,0,0q�6M   $	��Top=�6b   $��28��6�   $��60��6�   $��1��6�   �� 5   
   -   5        $ 	CraftMode��5      $��Craft��6$   $
��Left=�64   $��	26,12,0,0q�6O   $	��Top=�6b   $��90��6z   $��95��6�   5      �� 5   
   -   5        $ BuyMode��5      $	��Buy��6"   $
��Left=�60   $��
140,12,0,0q�6K   $	��Top=�6_   $��90��6w   $��95��6�   $��2��6�   5      �� 5   
   -	   5        $ SellMode��5      $
��Sell��6#   $
��Left=�62   $��	75,12,0,0q�6M   $	��Top=�6`   $��90��6x   $��94��6�   $��1��6�   5!      5#      5$      
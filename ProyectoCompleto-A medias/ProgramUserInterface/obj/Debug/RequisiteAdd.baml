   M S B A M L   `   `   `  ����O  KProgramUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProgramUserInterfaceProgramUserInterface  5      '    !ProgramUserInterface.RequisiteAdd   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ProgramUserInterface     5        N� Title$  Requisites - Add��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $	��300 �6   �� 5      $	��100 �6   .+�5   
   �� $��Center=�6   $
��Left=�6+   $��0��6F   $��0��6V   .��6d   Requirements addition5       �� 5$   
   $��Center=�6   $
��Left=�6+   $��0��6F   $��1��6V   .��6d   Nombre del requisito5&      �� 5(   
   -   5        $��RequirementName��5(      $��15(�6)    �� 	MaxLength$ 50��67   $
��Left=�6F   $	��250��6a   $��25��6m   
���   �$��0��6�   $��2��6�   $��2��6�   .��6�   5*      �� 5-   
   $��Center=�6   $��Right=�6+   $��1��6G   $��1��6W   $��2��6d   $��	0,2,162,2q�6x   .��6�   Esfuerzo del requisito (1-5)5/      �� 51   
   -   5        $��RequirementEffort��51      $��15(�6+   $ 1��69    �� TextAlignment$ Center=�6G   $��Right=�6^   $��50��6z   $��25��6�   
���   �$��1q�6�   $��1��6�   $��2��6�   $��
0,12,33,13q�6�   .��6�   53      �� 56   
   -   5        $��Center=�56      $��Center=�6-   $��30��6J   $	��150��6V   $��4��6c   $��2��6s   .��6�   Añadir requisito6�   &   System.Windows.Controls.DataGrid  59   
   -   5        $��ClientsList��59      $��5q�6&      CanUserAddRows .   �� AlternationCount$ 2��6j      AlternatingRowBackground
 ��·�$
��Left=�6�      AutoGenerateColumns .  $	��450��6�   $��0��6�   $��3��6�   $��3��6  ��61   �� *
ClientsL+	   Columns	 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly
 .    Header$ Nombre del cliente��67      Width5  /System.Windows.Controls.DataGridLengthConverter$	 240 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6_   �� *Nombre+4  .System.Windows.Controls.DataGridTemplateColumn  5<      $3 -1          2          3          4          5��6)   $	 200 6`      CellTemplate 5=      �� 5>      .R�5?      ��  � Minimum$ 1Q�6&    � Maximum$ 5Q�62    �� TickFrequency$ 1Q�6>    �� IsSnapToTickEnabled .  � Value 6k   ��  �� Path$ 
Prequisite� �� UpdateSourceTrigger$ PropertyChanged=�5@      5B      5D      �� 5G   
   -   5        $��RequirementsList��5G   ~   $��Right=�6   $��3��6T   $��2��6a   $	��274��6q   $��2��6�   $��0,0,10,0q�6�   ��6/   �� *Requirements+��5H      �� 5I       �� 
TargetType" ��6   .�5J      ��  �� Property � �� �� Value$ 30��6/   5K       �� View 5M      �� 5N      .P�5O      ��  �� Width$	 143��6%   $��Nombre del requisito��61    �� DisplayMemberBinding 6O   �� *NameRe+5Q      �� 5R      $ 50��6%   $��Esfuerzo��60    6B   �� *Effort+5T      �� 5U      $ 65��6%   $��Eliminar��60    �� CellTemplate 5V      �� 5W      .R�5X   "   �� -   5        $	��Top=�5X   )   
�������
�������$��20��6h   $��50��6t   .��6�   X6�   5Y      5[      5]      5_      �� 5b   
   -   5        $	��Top=�5b      $��Right=�6)   $��30��6E   $	��150��6Q   $��3��6]   $��4��6m   $��0,0,10,0q�6z    J� RenderTransformOrigin$ 0.347,0.533&�6�   .��6�   	Siguiente6�   5d      5e      
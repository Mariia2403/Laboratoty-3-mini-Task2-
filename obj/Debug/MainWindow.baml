   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� $��Від��6   $�� 100 25q�6   �� 5   
   $
��До��6   $�� 300 25q�6   �� 5   
   $��З кроком��6   $��Right=�5      $�� 400 25 290 105q�5      �� 5   
   -   5         ��Name$ FromTextBox��5      $��
55,50,0,50q�6(   $
��Left=�6<   $	��140��6W   �� 5   
   -   5        $ 	ToTextBox��5      $��250 ,50,0,50q�6%   $
��Left=�6;   $	��140��6V   �� 5   
   -   5        $ StepTextBox��5      $��0 ,50,200,50q�6'   $��Right=�6=   $	��140��6Y   �� 5   
   -   5        $+��%Треба більше кнопок!��5      $��50q�6E   $��Right=�6Q   �� 5!   
   $Q��KА чи не вилучити мені всі кнопки, кратні...��6   $
��Left=�5"      $��Bottom=�5#      $��100 10q�5$      �� 5&   
   -   5        $ MultipleTextBox��5&      $��Right=�5'      $��200 105 200 10q�5(      $	��140��5)      �� 5+   
   -   5        $�� Вилучити��5+      $��50 15q�5,      $��Right=�5-      $��Bottom=�5.      $	��125��5/      50      � 52   
   -   5         �Name$ ButtonsPanel��52      $��1��6*   $��10q�67   ���#E4D9FF6C   54      56      
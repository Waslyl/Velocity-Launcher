   M S B A M L   `   `   `  ����  VelocityLauncher%    Velocity_Launcher.LoadingScreen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Astro��5   	   $	��620��6   $
��1020��6$    � 
ResizeMode$ CanMinimize=�5   	    � WindowStyle$
 None=�5   	   ��5      �� 5	   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5
      �  � Color$ #0e0f17��6    � Offset$ 0Q�6+   � 5      $ #0f101a��6   $ 1Q�6+   5      .��5      � .+�5   
   �� ���#0d0e17$��416,247,416,269q�6#    �� RadiusX$ 10��5   6    �� RadiusY$ 10��5   6   5      �� 5   
   $��/Images/LoadingBar.png��6   $��30��60   $��30��6;   $��Center=�6G   $	��Top=�6d   $��	0,264,0,0q�6|   z�5      �� 5      -   5        RotationTransform��	 �� CenterX$	 15Q�5   =   
 �� CenterY$
 15Q�6J   5      �� 5   
   -   5         ��Name$ LoadingTextBox��5      
�������$
��Bold"�6C   $	��Top=�6U   $��Center=�6m   $��	0,308,0,0q�6�   $��12(�6�   
Loading!5!      5"       � Triggers 5$      :� 5%   
    :� RoutedEvent$ Loaded��6   .[�5&      �� .��5'      ��  g� RepeatBehavior$ Forever��6   .��5(      W�  �� 
TargetName$ RotationTransform��5)       �� TargetProperty$ Angle�5*       W� From 05+      	 W� To 3606"    g� Duration$ 0:0:2D�6+   5,      5-      5.      50      
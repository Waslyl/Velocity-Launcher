   M S B A M L   `   `   `  ���� K  GVelocityLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Velocity_Launcher.TabsVelocity_Launcher.Tabs  %    Velocity_Launcher.Tabs.Settings   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     D @ModernWpf, Version=0.9.6.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.6.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   2local$clr-namespace:Velocity_Launcher.Tabs     N� Title$  Settings�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� Orientation �� CornerRadius ��Name	 ��Name
 � 	Resources   Key �� TargetProperty �� 
TargetName g� Duration t� From	 t� To t� EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode �� Triggers P� Property P� Value N� ExitActions �� BeginStoryboardName ��Name 	 right �� 
TargetName  left��%�  '��       7  7  �� " ��.���  � �� �� " ��.R��� $ 
Horizontal=�.+�� .+��� $��45��$��20��
�������$ 10��$	��5,0q��� $ button��$��25��$��25��$
 12.5��$
��Left=��� $	 content��$��10,0,0,0q�#��z��$��Center=�
 ���� 	right  .��t� $ Margin�$ button��$ 0:0:0.4D� 0,0,0,0 28,0,0,0   $ EaseOut=��� left  .��t� $ Margin�$ button��$ 0:0:0.4D� 28,0,0,0 0,0,0,0   $ EaseOut=� P�  �@d�	IsChecked$ falseY� �� $ leftt���� $ rightt��8��  . ��� $ button�� � �� �#757575P�  �@d�	IsChecked$
 trueY� �� $ rightt���� $ leftt��8�� . ��� $ button�� � �� �#20BF55.��� .+��� ���#2b3745$��
0,10,0,255q�$ 10��._�� $��Center=�$��Center=�$	��109��$	��936��.+��� 
�������$��Segoe MDL2 Assets)�$��30(�$	����$��89,36,809,43q��� 
�������$��16(�$
��Bold"�$��133,32,672,55q�Edit On Release�� 
�������$7��1Allow builds to edit upon releasing your edit key��$��132,54,539,31q� J� RenderTransformOrigin$ 0.527,0.438&��� -    ��Name$ EditOnReleaseToggle��$
��Left=�$	��Top=�$��26(����#0B4F6C$ 0.5,0.5&�$��
735,36,0,0q�
 � Tag$ False��$��28��z�V� .~��� ��  �� AngleX$ 3.588Q��� T�  T� X$ 1.084Q��� -   
���  ��
������ $��55��$	��125��$��672,292,0,0q�$	��Top=�.���� $ 10�� �� Padding$ 10q�._��� 
�������$
��Bold"�$��16(�$��Center=�$��Log-out��
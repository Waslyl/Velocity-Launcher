   M S B A M L   `   `   `  ���� H  DAstroLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AstroLauncher.TabsAstroLauncher.Tabs  !    AstroLauncher.Tabs.Settings   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     D @ModernWpf, Version=0.9.6.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.6.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   .local clr-namespace:AstroLauncher.Tabs     N� Title$  Settings�� � 	Resources  �� 
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
 trueY� �� $ rightt���� $ leftt��8�� . ��� $ button�� � �� �#20BF55.��� .+��� ���#111111$��
0,10,0,261q�$ 10��._�� $��Center=�$��Center=�$	��109��$	��936��.+��� 
�������$��Segoe MDL2 Assets)�$��30(�$	����$��46,34,-162,-31q��� 
�������$��16(�$
��Bold"�$��84,31,-83,-31q�Edit On Release�� 
�������$7��1Allow builds to edit upon releasing your edit key��$��84,54,-84,-53q� J� RenderTransformOrigin$ 0.527,0.438&��� ���#111111$��
0,95,0,176q�$ 10��._�� $��Center=�$��Center=�$	��109��$	��936��.+��� 
�������$��Segoe MDL2 Assets)�$��30(�$	����$��46,34,-162,-31q��� 
�������$��16(�$
��Bold"�$��84,31,-83,-31q�Instant Reset�� 
�������$%��Allow builds to instantly reset��$��84,54,-84,-53q�$ 0.527,0.438&��� -    ��Name$ EditOnReleaseToggle��$
��Left=�$	��Top=�$��26(����#0B4F6C$ 0.5,0.5&�$��
800,37,0,0q�
 � Tag$ False��z�V� .~��� ��  �� AngleX$ 3.588Q��� T�  T� X$ 1.084Q��� -   $ InstantResetToggle��$
��Left=�$	��Top=�$��26(����#0B4F6C$ 0.5,0.5&�$��800,113,0,0q�$ False��z�V� .~��� �� $ 3.588Q��� T� $ 1.084Q�
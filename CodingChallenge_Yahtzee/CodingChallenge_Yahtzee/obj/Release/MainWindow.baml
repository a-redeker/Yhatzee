   M S B A M L   `   `   `  ���� R  NCodingChallenge_Yahtzee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CodingChallenge_YahtzeeCodingChallenge_Yahtzee  (    "CodingChallenge_Yahtzee.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aF 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  d `DevExpress.Xpf.Docking.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking  ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  ] YDevExpress.Mvvm.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   3local%clr-namespace:CodingChallenge_Yahtzee     � Title$  
MainWindow��$
��1000��$	��800�� � WindowStartupLocation$ CenterScreen=����	#FFD1C786"  DevExpress.Xpf.Core.DXWindow   BorderEffectActiveColor$ 	#FFD1C786��    BorderEffectInactiveColor$ 	#FFD1C786�����	#FFD1C786$��0q� � DataContext 1  +DevExpress.Mvvm.UI.ViewModelSourceExtension     Type1   +CodingChallenge_Yahtzee.MainWindowViewModel"  .��� .+�.  (DevExpress.Xpf.Docking.DockLayoutManager  $��3��   
LayoutRoot. (  "DevExpress.Xpf.Docking.LayoutGroup  +  %DevExpress.Xpf.Docking.BaseLayoutItem   Caption$ 
LayoutRoot��   Orientation$ Vertical=�	   Items.	 (  "DevExpress.Xpf.Docking.LayoutPanel  $ Panel1�����	#FFCA2B27���	#FFCA2B27
   
Background
 �	#FFCA2B27   ShowCaption .  (  "DevExpress.Xpf.Docking.ContentItem   Content. � $��Stretch=�$��Stretch=�.+��� -    ��Name$ Image��$��Center=�$	��200��$��0,0,0,0q�$��Center=�$	��200��$J��Dpack://application:,,,/CodingChallenge_Yahtzee;component/s-l1000.jpg���� -    ��Name$ Button��$��Score��$��116,70,578,189q�$��55��$��Stencil)�$��24(����	#FFCDCDCD&	   DevExpress.Xpf.Core.ThemeManager 	  	ThemeName0
  *DevExpress.Xpf.Core.ThemeNameTypeConverter$
 None
 $��80��{��� *canScore[0]+���� *onesCommand+�� -   $ Button1��$��Score��$��111,130,573,129q�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��80��{��� *canScore[1]+���� *twosCommand+�� -   $ Button2��$��Score��$��111,190,573,69q�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��80��{��� *canScore[2]+���� *threesCommand+�� -   $ Button3��$��Score��$��592,70,106,189q�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��80��{��� *canScore[3]+���� *foursCommand+�� -   $ Button4��$��Score��$��592,128,106,131q�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��80��{��� *canScore[4]+���� *fivesCommand+�� -   $ Button5��$��Score��$��592,189,106,70q�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��80��{��� *canScore[5]+���� *sixesCommand+�� -    ��Name$ ScoreTextBox��$	��1's��$��28,53,681,174q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -	   $ ScoreTextBox1��$	��2's��$��28,113,681,114q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -
   $ ScoreTextBox2��$	��3's��$��28,173,681,54q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -   $ ScoreTextBox3��$	��4's��$��496,53,213,174q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -   $ ScoreTextBox4��$	��5's��$��496,113,213,114q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -   $ ScoreTextBox5��$	��6's��$��496,173,213,54q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -   $ TextBox6��$��228,53,501,174q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[0]+ �� UpdateSourceTrigger$ PropertyChanged=��� -   $ TextBox7��$��228,113,501,114q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[1]+$ PropertyChanged=��� -   $ TextBox8��$��228,173,501,54q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[2]+$ PropertyChanged=��� -   $ TextBox9��$��701,53,28,174q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[3]+$ PropertyChanged=��� -   $ 	TextBox10��$��701,113,28,114q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[4]+$ PropertyChanged=��� -   $ 	TextBox11��$��701,173,28,54q�$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(����� *
scoring[5]+$ PropertyChanged=��� -    ��Name$ TextBlock99��$
��Left=�$��172,263,0,0q�$
��Wrap=�$��Bonus If Over 62:��$	��Top=�$��Stencil)�$��24(�$	��217�����	#FFD1C786�� -   $ 	TextBox99��$��55��$��55��$��Center=�$��Center=�$��Stencil)�$��24(�$��393,249,336,10q����� *
scoring[6]+$ PropertyChanged=�  $ Panel2��   
ItemHeight$
 0.5* � .  
 �	#FFCA2B27. � $��Stretch=�$��Stretch=�.+�%  DevExpress.Xpf.Editors.TextEdit  $	��100��$	��100��$��Center=�$��Center=�$��Stencil)�$��48(�$��343,10,341,44q�)  #DevExpress.Xpf.Editors.TextEditBase   Text �� *
dieIn[2]+  $	��100��$	��100��$��Center=�$��Center=�$��Stencil)�$��48(�$��492,10,192,44q� �� *
dieIn[3]+  $	��100��$	��100��$��Center=�$��Center=�$��Stencil)�$��48(�$��642,10,42,44q� �� *
dieIn[4]+  $	��100��$	��100��$��Center=�$��Center=�$��Stencil)�$��48(�$��193,10,491,44q� �� *
dieIn[1]+  $	��100��$	��100��$��Center=�$��Center=�$��Stencil)�$��48(�$��42,10,642,44q� �� *
dieIn[0]+�� -   $ 	TextBlock��$��	10,0,0,10q�$��21��$��50��$
��Left=�$��Bottom=�$��Stencil)�$��18(�$��Hold:�����	#FFD1C786�� -    ��Name$ CheckBox��$��22��$��22��$��85,123,677,10q� d� 	IsChecked �� *	hold[0]+�� -   $ 	CheckBox1��$��22��$��22��$��236,123,526,10q� �� *	hold[1]+�� -   $ 	CheckBox2��$��22��$��22��$��386,123,376,10q� �� *	hold[2]+�� -   $ 	CheckBox3��$��22��$��22��$��535,123,227,10q� �� *	hold[3]+�� -   $ 	CheckBox4��$��22��$��22��$��685,123,77,10q� �� *	hold[4]+  $ Panel3��$
 0.5* � .  
 �	#FFCA2B27. � $��Stretch=�$��Stretch=�.+��� -   $ textBox��$��55��$��Center=�$��Center=�$��Stencil)�$��24(�$��184,18,535,82q����� *scoring[15]+�� -   $ textBox1��$��55��$��Center=�$��Center=�$��Stencil)�$��24(�$��184,83,535,17q����� *scoring[16]+�� -   $ textBox2��$	��100��$	��100��$��Center=�$��Center=�$��Center=�$��Center=�$��Stencil)�$��36(�$��341,35,343,20q����� *scoring[17]+�� -   $ button��$��	Next Turn��$��Stencil)�$��24(�$��Right=�$	��Top=�$	��223��$��	0,88,20,0q�$��50��$
 None
 ���	#FFCDCDCD���� *nextTurnCommand+{��� *	canNext+�� -    $ button1��$��	Roll Dice��$��Stencil)�$��24(�$��Right=�$	��Top=�$	��223��$��	0,18,20,0q�$��50��$
 None
 ���	#FFCDCDCD���� *rollCommand+{��� *	canRoll+�� -!   $ 	textBlock��$��Lower Score:��$��Stencil)�$��24(�$��30��$	��217�����	#FFD1C786$��10,96,557,28q��� -"   $ 
textBlock1��$��Upper Score:��$��Stencil)�$��24(�$��30��$	��217�����	#FFD1C786$��10,31,556,93q��� -#   $ 
textBlock2��$��Total Score��$��Stencil)�$��24(�$��30��$��Center=�$	��Top=����	#FFD1C786  $ panel4�� .  
 �	#FFCA2B27. � $��Stretch=�$��Stretch=�.+��� -$   $ Image1��$��Center=�$	��150��$��0,0,0,0q�$��Center=�$	��150��$J��Dpack://application:,,,/CodingChallenge_Yahtzee;component/s-l1000.jpg���� -%   $ TextBox��$��3 of a Kind��$��10,35,604,224q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -&   $ TextBox1��$��4 of a Kind��$��10,95,604,164q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -'   $ TextBox2��$��YAHTZEE!��$��10,155,604,104q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -(   $ TextBox3��$��Bonus��$��10,215,604,44q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -)   $ TextBox4��$��Lg Straight��$��459,35,155,224q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -*   $ TextBox5��$��Sm Straight��$��459,95,155,164q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -+   $ 	TextBox12��$��
Full House��$��459,155,155,104q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� -,   $ 	TextBox13��$��Chance��$��459,215,155,44q�$	��170��$��55��$��Center=�$��Center=�$��Stencil)�$��24(��� --   $ Button6��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��629,215,65,44q�{��� *canScore[14]+���� *chanceCommand+�� -.   $ Button7��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��629,155,65,104q�{��� *canScore[13]+���� *fullHouseCommand+�� -/   $ Button8��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��629,94,65,165q�{��� *canScore[12]+���� *smStraightCommand+�� -0   $ Button9��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��629,35,65,224q�{��� *canScore[11]+���� *lgStraightCommand+�� -1   $ Buttona��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��180,215,514,44q�{��� *canScore[10]+���� *yBonusCommand+�� -2   $ Buttonb��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��180,155,514,104q�{��� *canScore[9]+���� *yahtzeeCommand+�� -3   $ Buttonc��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��180,95,514,164q�{��� *canScore[8]+���� *kind4Command+�� -4   $ Buttond��$��Score��$��Center=�$��Center=�$��55��$��Stencil)�$��24(����	#FFCDCDCD$
 None
 $��180,35,514,224q�{��� *canScore[7]+���� *kind3Command+�� -5   $ 	TextBox21��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��270,35,459,224q����� *
scoring[7]+�� -6   $ 	TextBox14��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��270,95,460,164q����� *
scoring[8]+�� -7   $ 	TextBox15��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��270,155,460,104q����� *
scoring[9]+�� -8   $ 	TextBox16��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��270,215,460,44q����� *scoring[10]+�� -9   $ 	TextBox17��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��719,35,10,224q����� *scoring[11]+�� -:   $ 	TextBox18��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��719,94,10,165q����� *scoring[12]+�� -;   $ 	TextBox19��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��719,154,10,105q����� *scoring[13]+�� -<   $ 	TextBox20��$��Center=�$��55��$��Center=�$��55��$��Stencil)�$��24(�$��719,214,10,45q����� *scoring[14]+
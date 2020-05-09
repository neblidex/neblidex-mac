
// This file has been generated by the GUI designer. Do not modify.
namespace NebliDex_Linux
{
	public partial class ExchangeWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action FileAction;

		private global::Gtk.Action ConfigurationsAction;

		private global::Gtk.Action EncryptWalletAction;

		private global::Gtk.Action BackupWalletAction;

		private global::Gtk.Action ImportNebliDexWalletAction;

		private global::Gtk.Action ClearCNDataAction;

		private global::Gtk.Action ExitAction;

		private global::Gtk.Action ChangeDefaultDNSSeedAction;

		private global::Gtk.ToggleAction ActivateAsCriticalNodeAction;

		private global::Gtk.Action ChangeWalletAddressesAction;

		private global::Gtk.Action RunInBackgroundAction;

		private global::Gtk.Action ExportAction;

		private global::Gtk.Action ExportAllTradeHistoryAction;

		private global::Gtk.Action ExportAllCNFeeDataAction;

		private global::Gtk.Action ThemesAction;

		private global::Gtk.ToggleAction DefaultTheme_Action;

		private global::Gtk.ToggleAction LightTheme_Action;

		private global::Gtk.ToggleAction DarkTheme_Action;

		private global::Gtk.ToggleAction ActivateTraderAPIAction;

		private global::Gtk.VBox vbox1;

		private global::Gtk.MenuBar menubar1;

		private global::Gtk.EventBox background;

		private global::Gtk.Table table1;

		private global::Gtk.EventBox Chart_Canvas_Background;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label Chart_Last_Price;

		private global::Gtk.Label Chart_Mouse_Price;

		private global::Gtk.Alignment Chart_Button_Alignment;

		private global::Gtk.Button Chart_Time_Toggle;

		private global::Gtk.DrawingArea Chart_Canvas;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Notebook Trade_Information_Tabs;

		private global::Gtk.ScrolledWindow Recent_Trade_List_Scroller;

		private global::Gtk.NodeView Recent_Trade_List;

		private global::Gtk.Label MTrades;

		private global::Gtk.ScrolledWindow Trade_History_List_Scroller;

		private global::Gtk.NodeView Trade_History_List;

		private global::Gtk.Label MyTrades;

		private global::Gtk.ScrolledWindow Open_Orders_List_Scroller;

		private global::Gtk.NodeView Open_Orders_List;

		private global::Gtk.Label MyOrders;

		private global::Gtk.ScrolledWindow CN_Tx_List_Scroller;

		private global::Gtk.NodeView CN_Tx_List;

		private global::Gtk.Label MyCNInfo;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox2;

		private global::Gtk.ComboBox Market_Box;

		private global::Gtk.Alignment Market_Percent_Align;

		private global::Gtk.EventBox Market_Percent_Background;

		private global::Gtk.Label Market_Percent;

		private global::Gtk.ScrolledWindow Selling_View_Scroller;

		private global::Gtk.NodeView Selling_View;

		private global::Gtk.ScrolledWindow Buying_View_Scroller;

		private global::Gtk.NodeView Buying_View;

		private global::Gtk.Frame Wallet_Box_Frame;

		private global::Gtk.EventBox Wallet_Box;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button Buy_Button;

		private global::Gtk.Button Sell_Button;

		private global::Gtk.ScrolledWindow Wallet_View_Scroller;

		private global::Gtk.NodeView Wallet_View;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Button Deposit_Button;

		private global::Gtk.Button Withdraw_Button;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label Fee_Status;

		private global::Gtk.Label CN_Fee;

		private global::Gtk.Label NEBL_Fee;

		private global::Gtk.Label Base_Pair_Fee;

		private global::Gtk.Label CN_Info;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget NebliDex_Linux.ExchangeWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("_File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
			w1.Add(this.FileAction, "<Alt>f");
			this.ConfigurationsAction = new global::Gtk.Action("ConfigurationsAction", global::Mono.Unix.Catalog.GetString("_Configurations"), null, null);
			this.ConfigurationsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Configurations");
			w1.Add(this.ConfigurationsAction, "<Alt>c");
			this.EncryptWalletAction = new global::Gtk.Action("EncryptWalletAction", global::Mono.Unix.Catalog.GetString("Encrypt Wallet"), null, null);
			this.EncryptWalletAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Encrypt Wallet");
			w1.Add(this.EncryptWalletAction, null);
			this.BackupWalletAction = new global::Gtk.Action("BackupWalletAction", global::Mono.Unix.Catalog.GetString("Backup Wallet"), null, null);
			this.BackupWalletAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Backup Wallet");
			w1.Add(this.BackupWalletAction, null);
			this.ImportNebliDexWalletAction = new global::Gtk.Action("ImportNebliDexWalletAction", global::Mono.Unix.Catalog.GetString("Import NebliDex Wallet"), null, null);
			this.ImportNebliDexWalletAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Import NebliDex Wallet");
			w1.Add(this.ImportNebliDexWalletAction, null);
			this.ClearCNDataAction = new global::Gtk.Action("ClearCNDataAction", global::Mono.Unix.Catalog.GetString("Clear CN Data"), null, null);
			this.ClearCNDataAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Clear CN Data");
			w1.Add(this.ClearCNDataAction, null);
			this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("Exit"), null, null);
			this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
			w1.Add(this.ExitAction, null);
			this.ChangeDefaultDNSSeedAction = new global::Gtk.Action("ChangeDefaultDNSSeedAction", global::Mono.Unix.Catalog.GetString("Change Default DNS Seed"), null, null);
			this.ChangeDefaultDNSSeedAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Change Default DNS Seed");
			w1.Add(this.ChangeDefaultDNSSeedAction, null);
			this.ActivateAsCriticalNodeAction = new global::Gtk.ToggleAction("ActivateAsCriticalNodeAction", global::Mono.Unix.Catalog.GetString("Activate As Critical Node"), null, null);
			this.ActivateAsCriticalNodeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Activate As Critical Node");
			w1.Add(this.ActivateAsCriticalNodeAction, null);
			this.ChangeWalletAddressesAction = new global::Gtk.Action("ChangeWalletAddressesAction", global::Mono.Unix.Catalog.GetString("Change Wallet Addresses"), null, null);
			this.ChangeWalletAddressesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Change Wallet Addresses");
			w1.Add(this.ChangeWalletAddressesAction, null);
			this.RunInBackgroundAction = new global::Gtk.Action("RunInBackgroundAction", global::Mono.Unix.Catalog.GetString("Run in Background"), null, null);
			this.RunInBackgroundAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Run In Background");
			w1.Add(this.RunInBackgroundAction, null);
			this.ExportAction = new global::Gtk.Action("ExportAction", global::Mono.Unix.Catalog.GetString("Export"), null, null);
			this.ExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Export");
			w1.Add(this.ExportAction, null);
			this.ExportAllTradeHistoryAction = new global::Gtk.Action("ExportAllTradeHistoryAction", global::Mono.Unix.Catalog.GetString("Export All Trade History"), null, null);
			this.ExportAllTradeHistoryAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Export All Trade History");
			w1.Add(this.ExportAllTradeHistoryAction, null);
			this.ExportAllCNFeeDataAction = new global::Gtk.Action("ExportAllCNFeeDataAction", global::Mono.Unix.Catalog.GetString("Export All CN Fee Data"), null, null);
			this.ExportAllCNFeeDataAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Export All CN Fee Data");
			w1.Add(this.ExportAllCNFeeDataAction, null);
			this.ThemesAction = new global::Gtk.Action("ThemesAction", global::Mono.Unix.Catalog.GetString("Themes"), null, null);
			this.ThemesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Themes");
			w1.Add(this.ThemesAction, null);
			this.DefaultTheme_Action = new global::Gtk.ToggleAction("DefaultTheme_Action", global::Mono.Unix.Catalog.GetString("Default"), null, null);
			this.DefaultTheme_Action.Active = true;
			this.DefaultTheme_Action.ShortLabel = global::Mono.Unix.Catalog.GetString("Default");
			w1.Add(this.DefaultTheme_Action, null);
			this.LightTheme_Action = new global::Gtk.ToggleAction("LightTheme_Action", global::Mono.Unix.Catalog.GetString("Light"), null, null);
			this.LightTheme_Action.ShortLabel = global::Mono.Unix.Catalog.GetString("Light");
			w1.Add(this.LightTheme_Action, null);
			this.DarkTheme_Action = new global::Gtk.ToggleAction("DarkTheme_Action", global::Mono.Unix.Catalog.GetString("Dark"), null, null);
			this.DarkTheme_Action.ShortLabel = global::Mono.Unix.Catalog.GetString("Dark");
			w1.Add(this.DarkTheme_Action, null);
			this.ActivateTraderAPIAction = new global::Gtk.ToggleAction("ActivateTraderAPIAction", global::Mono.Unix.Catalog.GetString("Activate Trader API"), null, null);
			this.ActivateTraderAPIAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Activate Trader API");
			w1.Add(this.ActivateTraderAPIAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "NebliDex_Linux.ExchangeWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("NebliDex: A Decentralized Neblio Exchange");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("NebliDex_Linux.logo.ico");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.AllowShrink = true;
			this.DefaultWidth = 892;
			this.DefaultHeight = 600;
			// Container child NebliDex_Linux.ExchangeWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='EncryptWalletAction' action='EncryptWalletAction'/><menuitem name='BackupWalletAction' action='BackupWalletAction'/><menuitem name='ImportNebliDexWalletAction' action='ImportNebliDexWalletAction'/><menuitem name='ClearCNDataAction' action='ClearCNDataAction'/><menuitem name='RunInBackgroundAction' action='RunInBackgroundAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='ConfigurationsAction' action='ConfigurationsAction'><menu name='ThemesAction' action='ThemesAction'><menuitem name='DefaultTheme_Action' action='DefaultTheme_Action'/><menuitem name='LightTheme_Action' action='LightTheme_Action'/><menuitem name='DarkTheme_Action' action='DarkTheme_Action'/></menu><menuitem name='ChangeDefaultDNSSeedAction' action='ChangeDefaultDNSSeedAction'/><menuitem name='ActivateAsCriticalNodeAction' action='ActivateAsCriticalNodeAction'/><menuitem name='ChangeWalletAddressesAction' action='ChangeWalletAddressesAction'/><menuitem name='ActivateTraderAPIAction' action='ActivateTraderAPIAction'/></menu><menu name='ExportAction' action='ExportAction'><menuitem name='ExportAllTradeHistoryAction' action='ExportAllTradeHistoryAction'/><menuitem name='ExportAllCNFeeDataAction' action='ExportAllCNFeeDataAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add(this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.background = new global::Gtk.EventBox();
			this.background.Name = "background";
			// Container child background.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(2));
			this.table1.ColumnSpacing = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.Chart_Canvas_Background = new global::Gtk.EventBox();
			this.Chart_Canvas_Background.Name = "Chart_Canvas_Background";
			this.Chart_Canvas_Background.BorderWidth = ((uint)(5));
			// Container child Chart_Canvas_Background.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.Chart_Last_Price = new global::Gtk.Label();
			this.Chart_Last_Price.Name = "Chart_Last_Price";
			this.Chart_Last_Price.Xpad = 10;
			this.Chart_Last_Price.Ypad = 5;
			this.Chart_Last_Price.Xalign = 0F;
			this.Chart_Last_Price.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\"13\"><b>Last Price:</b></span>");
			this.Chart_Last_Price.UseMarkup = true;
			this.hbox6.Add(this.Chart_Last_Price);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.Chart_Last_Price]));
			w3.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.Chart_Mouse_Price = new global::Gtk.Label();
			this.Chart_Mouse_Price.Name = "Chart_Mouse_Price";
			this.Chart_Mouse_Price.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\"13\">0000-00-00 00:00|00.00000</span>");
			this.Chart_Mouse_Price.UseMarkup = true;
			this.Chart_Mouse_Price.Justify = ((global::Gtk.Justification)(2));
			this.hbox6.Add(this.Chart_Mouse_Price);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.Chart_Mouse_Price]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.Chart_Button_Alignment = new global::Gtk.Alignment(1F, 0.5F, 1F, 1F);
			this.Chart_Button_Alignment.Name = "Chart_Button_Alignment";
			this.Chart_Button_Alignment.LeftPadding = ((uint)(70));
			// Container child Chart_Button_Alignment.Gtk.Container+ContainerChild
			this.Chart_Time_Toggle = new global::Gtk.Button();
			this.Chart_Time_Toggle.WidthRequest = 100;
			this.Chart_Time_Toggle.CanFocus = true;
			this.Chart_Time_Toggle.Name = "Chart_Time_Toggle";
			this.Chart_Time_Toggle.UseUnderline = true;
			this.Chart_Time_Toggle.BorderWidth = ((uint)(5));
			this.Chart_Time_Toggle.Label = global::Mono.Unix.Catalog.GetString("24 Hour");
			this.Chart_Button_Alignment.Add(this.Chart_Time_Toggle);
			this.hbox6.Add(this.Chart_Button_Alignment);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.Chart_Button_Alignment]));
			w6.Position = 2;
			this.vbox3.Add(this.hbox6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox6]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.Chart_Canvas = new global::Gtk.DrawingArea();
			this.Chart_Canvas.Name = "Chart_Canvas";
			this.vbox3.Add(this.Chart_Canvas);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.Chart_Canvas]));
			w8.Position = 1;
			this.Chart_Canvas_Background.Add(this.vbox3);
			this.table1.Add(this.Chart_Canvas_Background);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.Chart_Canvas_Background]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.Trade_Information_Tabs = new global::Gtk.Notebook();
			this.Trade_Information_Tabs.Name = "Trade_Information_Tabs";
			this.Trade_Information_Tabs.CurrentPage = 2;
			this.Trade_Information_Tabs.TabPos = ((global::Gtk.PositionType)(3));
			this.Trade_Information_Tabs.BorderWidth = ((uint)(5));
			// Container child Trade_Information_Tabs.Gtk.Notebook+NotebookChild
			this.Recent_Trade_List_Scroller = new global::Gtk.ScrolledWindow();
			this.Recent_Trade_List_Scroller.Name = "Recent_Trade_List_Scroller";
			this.Recent_Trade_List_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Recent_Trade_List_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child Recent_Trade_List_Scroller.Gtk.Container+ContainerChild
			this.Recent_Trade_List = new global::Gtk.NodeView();
			this.Recent_Trade_List.Name = "Recent_Trade_List";
			this.Recent_Trade_List_Scroller.Add(this.Recent_Trade_List);
			this.Trade_Information_Tabs.Add(this.Recent_Trade_List_Scroller);
			// Notebook tab
			this.MTrades = new global::Gtk.Label();
			this.MTrades.Name = "MTrades";
			this.MTrades.LabelProp = global::Mono.Unix.Catalog.GetString("Recent Market Trades");
			this.Trade_Information_Tabs.SetTabLabel(this.Recent_Trade_List_Scroller, this.MTrades);
			this.MTrades.ShowAll();
			// Container child Trade_Information_Tabs.Gtk.Notebook+NotebookChild
			this.Trade_History_List_Scroller = new global::Gtk.ScrolledWindow();
			this.Trade_History_List_Scroller.Name = "Trade_History_List_Scroller";
			this.Trade_History_List_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Trade_History_List_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child Trade_History_List_Scroller.Gtk.Container+ContainerChild
			this.Trade_History_List = new global::Gtk.NodeView();
			this.Trade_History_List.Name = "Trade_History_List";
			this.Trade_History_List_Scroller.Add(this.Trade_History_List);
			this.Trade_Information_Tabs.Add(this.Trade_History_List_Scroller);
			global::Gtk.Notebook.NotebookChild w14 = ((global::Gtk.Notebook.NotebookChild)(this.Trade_Information_Tabs[this.Trade_History_List_Scroller]));
			w14.Position = 1;
			// Notebook tab
			this.MyTrades = new global::Gtk.Label();
			this.MyTrades.CanFocus = true;
			this.MyTrades.Name = "MyTrades";
			this.MyTrades.LabelProp = global::Mono.Unix.Catalog.GetString("My Trade History");
			this.Trade_Information_Tabs.SetTabLabel(this.Trade_History_List_Scroller, this.MyTrades);
			this.MyTrades.ShowAll();
			// Container child Trade_Information_Tabs.Gtk.Notebook+NotebookChild
			this.Open_Orders_List_Scroller = new global::Gtk.ScrolledWindow();
			this.Open_Orders_List_Scroller.Name = "Open_Orders_List_Scroller";
			this.Open_Orders_List_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Open_Orders_List_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child Open_Orders_List_Scroller.Gtk.Container+ContainerChild
			this.Open_Orders_List = new global::Gtk.NodeView();
			this.Open_Orders_List.CanFocus = true;
			this.Open_Orders_List.Name = "Open_Orders_List";
			this.Open_Orders_List_Scroller.Add(this.Open_Orders_List);
			this.Trade_Information_Tabs.Add(this.Open_Orders_List_Scroller);
			global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.Trade_Information_Tabs[this.Open_Orders_List_Scroller]));
			w16.Position = 2;
			// Notebook tab
			this.MyOrders = new global::Gtk.Label();
			this.MyOrders.Name = "MyOrders";
			this.MyOrders.LabelProp = global::Mono.Unix.Catalog.GetString("My Open Orders");
			this.Trade_Information_Tabs.SetTabLabel(this.Open_Orders_List_Scroller, this.MyOrders);
			this.MyOrders.ShowAll();
			// Container child Trade_Information_Tabs.Gtk.Notebook+NotebookChild
			this.CN_Tx_List_Scroller = new global::Gtk.ScrolledWindow();
			this.CN_Tx_List_Scroller.Name = "CN_Tx_List_Scroller";
			this.CN_Tx_List_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.CN_Tx_List_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child CN_Tx_List_Scroller.Gtk.Container+ContainerChild
			this.CN_Tx_List = new global::Gtk.NodeView();
			this.CN_Tx_List.Name = "CN_Tx_List";
			this.CN_Tx_List_Scroller.Add(this.CN_Tx_List);
			this.Trade_Information_Tabs.Add(this.CN_Tx_List_Scroller);
			global::Gtk.Notebook.NotebookChild w18 = ((global::Gtk.Notebook.NotebookChild)(this.Trade_Information_Tabs[this.CN_Tx_List_Scroller]));
			w18.Position = 3;
			// Notebook tab
			this.MyCNInfo = new global::Gtk.Label();
			this.MyCNInfo.Name = "MyCNInfo";
			this.MyCNInfo.LabelProp = global::Mono.Unix.Catalog.GetString("My Critical Node Fees");
			this.Trade_Information_Tabs.SetTabLabel(this.CN_Tx_List_Scroller, this.MyCNInfo);
			this.MyCNInfo.ShowAll();
			this.hbox4.Add(this.Trade_Information_Tabs);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.Trade_Information_Tabs]));
			w19.Position = 0;
			this.table1.Add(this.hbox4);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox4]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			this.vbox6.BorderWidth = ((uint)(5));
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.Market_Box = global::Gtk.ComboBox.NewText();
			this.Market_Box.WidthRequest = 150;
			this.Market_Box.HeightRequest = 40;
			this.Market_Box.Name = "Market_Box";
			this.hbox2.Add(this.Market_Box);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.Market_Box]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.Market_Percent_Align = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.Market_Percent_Align.Name = "Market_Percent_Align";
			this.Market_Percent_Align.TopPadding = ((uint)(5));
			this.Market_Percent_Align.BottomPadding = ((uint)(5));
			// Container child Market_Percent_Align.Gtk.Container+ContainerChild
			this.Market_Percent_Background = new global::Gtk.EventBox();
			this.Market_Percent_Background.Name = "Market_Percent_Background";
			// Container child Market_Percent_Background.Gtk.Container+ContainerChild
			this.Market_Percent = new global::Gtk.Label();
			this.Market_Percent.HeightRequest = 35;
			this.Market_Percent.Name = "Market_Percent";
			this.Market_Percent.Xpad = 10;
			this.Market_Percent.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\'16\'><b>00.00%</b></span>");
			this.Market_Percent.UseMarkup = true;
			this.Market_Percent_Background.Add(this.Market_Percent);
			this.Market_Percent_Align.Add(this.Market_Percent_Background);
			this.hbox2.Add(this.Market_Percent_Align);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.Market_Percent_Align]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox6.Add(this.hbox2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox2]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.Selling_View_Scroller = new global::Gtk.ScrolledWindow();
			this.Selling_View_Scroller.Name = "Selling_View_Scroller";
			this.Selling_View_Scroller.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.Selling_View_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Selling_View_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child Selling_View_Scroller.Gtk.Container+ContainerChild
			this.Selling_View = new global::Gtk.NodeView();
			this.Selling_View.CanFocus = true;
			this.Selling_View.Name = "Selling_View";
			this.Selling_View_Scroller.Add(this.Selling_View);
			this.vbox6.Add(this.Selling_View_Scroller);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.Selling_View_Scroller]));
			w27.Position = 1;
			// Container child vbox6.Gtk.Box+BoxChild
			this.Buying_View_Scroller = new global::Gtk.ScrolledWindow();
			this.Buying_View_Scroller.Name = "Buying_View_Scroller";
			this.Buying_View_Scroller.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.Buying_View_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Buying_View_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child Buying_View_Scroller.Gtk.Container+ContainerChild
			this.Buying_View = new global::Gtk.NodeView();
			this.Buying_View.CanFocus = true;
			this.Buying_View.Name = "Buying_View";
			this.Buying_View.HeadersVisible = false;
			this.Buying_View_Scroller.Add(this.Buying_View);
			this.vbox6.Add(this.Buying_View_Scroller);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.Buying_View_Scroller]));
			w29.Position = 2;
			this.table1.Add(this.vbox6);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox6]));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.Wallet_Box_Frame = new global::Gtk.Frame();
			this.Wallet_Box_Frame.Name = "Wallet_Box_Frame";
			this.Wallet_Box_Frame.ShadowType = ((global::Gtk.ShadowType)(4));
			// Container child Wallet_Box_Frame.Gtk.Container+ContainerChild
			this.Wallet_Box = new global::Gtk.EventBox();
			this.Wallet_Box.Name = "Wallet_Box";
			// Container child Wallet_Box.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.TopPadding = ((uint)(5));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			this.hbox3.BorderWidth = ((uint)(3));
			// Container child hbox3.Gtk.Box+BoxChild
			this.Buy_Button = new global::Gtk.Button();
			this.Buy_Button.WidthRequest = 120;
			this.Buy_Button.CanFocus = true;
			this.Buy_Button.Name = "Buy_Button";
			this.Buy_Button.UseUnderline = true;
			this.Buy_Button.Label = global::Mono.Unix.Catalog.GetString("Buy NDEX");
			this.hbox3.Add(this.Buy_Button);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Buy_Button]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Sell_Button = new global::Gtk.Button();
			this.Sell_Button.WidthRequest = 120;
			this.Sell_Button.CanFocus = true;
			this.Sell_Button.Name = "Sell_Button";
			this.Sell_Button.UseUnderline = true;
			this.Sell_Button.Label = global::Mono.Unix.Catalog.GetString("Sell NDEX");
			this.hbox3.Add(this.Sell_Button);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Sell_Button]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			this.alignment1.Add(this.hbox3);
			this.vbox2.Add(this.alignment1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment1]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.Wallet_View_Scroller = new global::Gtk.ScrolledWindow();
			this.Wallet_View_Scroller.Name = "Wallet_View_Scroller";
			this.Wallet_View_Scroller.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.Wallet_View_Scroller.ShadowType = ((global::Gtk.ShadowType)(1));
			this.Wallet_View_Scroller.BorderWidth = ((uint)(5));
			// Container child Wallet_View_Scroller.Gtk.Container+ContainerChild
			this.Wallet_View = new global::Gtk.NodeView();
			this.Wallet_View.CanFocus = true;
			this.Wallet_View.Name = "Wallet_View";
			this.Wallet_View_Scroller.Add(this.Wallet_View);
			this.vbox2.Add(this.Wallet_View_Scroller);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.Wallet_View_Scroller]));
			w36.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Homogeneous = true;
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.Deposit_Button = new global::Gtk.Button();
			this.Deposit_Button.WidthRequest = 100;
			this.Deposit_Button.CanFocus = true;
			this.Deposit_Button.Name = "Deposit_Button";
			this.Deposit_Button.UseUnderline = true;
			this.Deposit_Button.Label = global::Mono.Unix.Catalog.GetString("Deposit");
			this.hbox5.Add(this.Deposit_Button);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.Deposit_Button]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.Withdraw_Button = new global::Gtk.Button();
			this.Withdraw_Button.WidthRequest = 100;
			this.Withdraw_Button.CanFocus = true;
			this.Withdraw_Button.Name = "Withdraw_Button";
			this.Withdraw_Button.UseUnderline = true;
			this.Withdraw_Button.Label = global::Mono.Unix.Catalog.GetString("Withdraw");
			this.hbox5.Add(this.Withdraw_Button);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.Withdraw_Button]));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			this.vbox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			w39.Padding = ((uint)(5));
			this.Wallet_Box.Add(this.vbox2);
			this.Wallet_Box_Frame.Add(this.Wallet_Box);
			this.table1.Add(this.Wallet_Box_Frame);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table1[this.Wallet_Box_Frame]));
			w42.TopAttach = ((uint)(1));
			w42.BottomAttach = ((uint)(2));
			w42.XPadding = ((uint)(5));
			w42.YPadding = ((uint)(5));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			this.background.Add(this.table1);
			this.vbox1.Add(this.background);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.background]));
			w44.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.Fee_Status = new global::Gtk.Label();
			this.Fee_Status.Name = "Fee_Status";
			this.Fee_Status.Xpad = 5;
			this.Fee_Status.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Not Fully Connected:</b>");
			this.Fee_Status.UseMarkup = true;
			this.hbox1.Add(this.Fee_Status);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Fee_Status]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.CN_Fee = new global::Gtk.Label();
			this.CN_Fee.Name = "CN_Fee";
			this.CN_Fee.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\"12\">CN Fee: 10 NDEX</span>");
			this.CN_Fee.UseMarkup = true;
			this.hbox1.Add(this.CN_Fee);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.CN_Fee]));
			w46.Position = 1;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.NEBL_Fee = new global::Gtk.Label();
			this.NEBL_Fee.Name = "NEBL_Fee";
			this.NEBL_Fee.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\"12\"> | NEBL Fee: N/A</span>");
			this.NEBL_Fee.UseMarkup = true;
			this.hbox1.Add(this.NEBL_Fee);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.NEBL_Fee]));
			w47.Position = 2;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.Base_Pair_Fee = new global::Gtk.Label();
			this.Base_Pair_Fee.Name = "Base_Pair_Fee";
			this.Base_Pair_Fee.LabelProp = global::Mono.Unix.Catalog.GetString("<span font=\"12\"> | BTC Fee: N/A</span>");
			this.Base_Pair_Fee.UseMarkup = true;
			this.hbox1.Add(this.Base_Pair_Fee);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Base_Pair_Fee]));
			w48.Position = 3;
			w48.Expand = false;
			w48.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.CN_Info = new global::Gtk.Label();
			this.CN_Info.Name = "CN_Info";
			this.CN_Info.LabelProp = global::Mono.Unix.Catalog.GetString("CN Info");
			this.CN_Info.UseMarkup = true;
			this.hbox1.Add(this.CN_Info);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.CN_Info]));
			w49.Position = 4;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w50.Position = 2;
			w50.Expand = false;
			w50.Fill = false;
			w50.Padding = ((uint)(2));
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.CN_Info.Hide();
			this.Show();
			this.ExitAction.Activated += new global::System.EventHandler(this.Exit_Button_Close);
			this.ChangeDefaultDNSSeedAction.Activated += new global::System.EventHandler(this.Open_DNS_Seed);
			this.ExportAllTradeHistoryAction.Activated += new global::System.EventHandler(this.Save_All_Trades);
			this.ExportAllCNFeeDataAction.Activated += new global::System.EventHandler(this.Save_All_CNHx);
			this.DefaultTheme_Action.Activated += new global::System.EventHandler(this.Select_UI_Look);
			this.LightTheme_Action.Activated += new global::System.EventHandler(this.Select_UI_Look);
			this.DarkTheme_Action.Activated += new global::System.EventHandler(this.Select_UI_Look);
		}
	}
}

using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.SystemSetup.Menu
{

    public partial class FSymbols : UIEditForm
    {
        private UISymbolPanel fontAwesomeV4;
        private UISymbolPanel elegantIcons;
        private UISymbolPanel fontAweSomeV6Regular;
        private UISymbolPanel fontAweSomeV6Solid;
        private UISymbolPanel fontAweSomeV6Brands;
        private UISymbolPanel materialIcons;
        private UISymbolPanel searchSymbolPanel;
        public FSymbols()
        {
            InitializeComponent();

            fontAwesomeV4 = new UISymbolPanel(typeof(FontAwesomeIcons), UISymbolType.FontAwesomeV4);
            elegantIcons = new UISymbolPanel(typeof(FontElegantIcons), UISymbolType.FontAwesomeV4);
            fontAweSomeV6Regular = new UISymbolPanel(typeof(FontAweSomeV6Regular), UISymbolType.FontAwesomeV6Regular);
            fontAweSomeV6Solid = new UISymbolPanel(typeof(FontAweSomeV6Solid), UISymbolType.FontAwesomeV6Solid);
            fontAweSomeV6Brands = new UISymbolPanel(typeof(FontAweSomeV6Brands), UISymbolType.FontAwesomeV6Brands);
            materialIcons = new UISymbolPanel(typeof(MaterialIcons), UISymbolType.MaterialIcons);
            searchSymbolPanel = new UISymbolPanel();

            lpV6Solid.Add(fontAweSomeV6Solid);
            lpV6Regular.Add(fontAweSomeV6Regular);
            lpV6Brands.Add(fontAweSomeV6Brands);
            lpElegant.Add(elegantIcons);
            lpMaterialIcons.Add(materialIcons);
            lblResult.Add(searchSymbolPanel);
            lpAwesome.Add(fontAwesomeV4);

            fontAwesomeV4.ValueChanged += CustomSymbolPanel_ValueChanged;
            elegantIcons.ValueChanged += CustomSymbolPanel_ValueChanged;
            fontAweSomeV6Brands.ValueChanged += CustomSymbolPanel_ValueChanged;
            fontAweSomeV6Regular.ValueChanged += CustomSymbolPanel_ValueChanged;
            fontAweSomeV6Solid.ValueChanged += CustomSymbolPanel_ValueChanged;
            materialIcons.ValueChanged += CustomSymbolPanel_ValueChanged;
            searchSymbolPanel.ValueChanged += CustomSymbolPanel_ValueChanged;
        }

        private void CustomSymbolPanel_ValueChanged(object sender, SymbolValue symbol)
        {
            uiTextBox2.IntValue = symbol.Value;
            uiSymbolLabel1.Symbol = symbol.Value;
            ShowInfoTip(symbol.ToString());
        }


        // 在这里添加一个方法来获取文本框中的值
        public string GetTextBoxValue()
        {
            return this.uiTextBox2.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

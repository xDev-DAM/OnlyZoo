using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.utils
{
    internal class FontManager 
    {
            private static PrivateFontCollection pfc = new PrivateFontCollection();

            public FontManager()
            {
                pfc.AddFontFile(AppConstants.ONLYZOO_FONT);
                pfc.AddFontFile(AppConstants.ROBOTO_FONT);
            }
            public Font TitleFont()
            {
                return new Font(pfc.Families[1], 25);
            }
            public Font MediumFont()
            {
                return new Font(pfc.Families[1], 16);
            }
            public Font SmallFont()
            {
                return new Font(pfc.Families[1], 12);
            }
            public Font OnlyZooFont() {
                return new Font(pfc.Families[0], 30);
            }
    }
}


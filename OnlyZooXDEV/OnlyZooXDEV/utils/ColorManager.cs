using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OnlyZooXDEV.utils
{
    internal class ColorManager
    {
        public static Color GetPaletteColor1() {
            return ColorTranslator.FromHtml(AppConstants.PALETTE_FIRST);
        }
        public static Color GetPaletteColor2()
        {
            return ColorTranslator.FromHtml(AppConstants.PALETTE_TWO);
        }
        public static Color GetPaletteColor3()
        {
            return ColorTranslator.FromHtml(AppConstants.PALETTE_THREE);
        }
        public static Color GetPaletteColor4()
        {
            return ColorTranslator.FromHtml(AppConstants.PALETTE_FOUR);
        }
    }
}

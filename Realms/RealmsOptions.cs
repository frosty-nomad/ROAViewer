using System.Collections.Generic;
using System.Drawing;

namespace Realms
{
    public class RealmsOptions
    {
        public int PixelSize { get; set; } = 3;
        public int Shading { get; set; } = 0;
        public bool ShowGrid { get; set; }

        private Dictionary<RealmsInfoType, Color> _infoColors = new Dictionary<RealmsInfoType, Color>
        {
            { RealmsInfoType.Map, Color.Lime },
            { RealmsInfoType.Info, Color.HotPink },
            { RealmsInfoType.Vendor, Color.Cyan },
            { RealmsInfoType.NPC, Color.Plum },
            { RealmsInfoType.Quest, Color.Goldenrod },
            { RealmsInfoType.Chest, Color.Yellow },
            { RealmsInfoType.Monster, Color.Red },
            { RealmsInfoType.Secret, Color.HotPink },
            { RealmsInfoType.Boat, Color.LightBlue },
            { RealmsInfoType.Door, Color.Gainsboro },
            { RealmsInfoType.Trap, Color.Orange },
            { RealmsInfoType.PitTrap, Color.DarkOrange },
            { RealmsInfoType.Marker, Color.LightBlue }
        };

        private Dictionary<RealmsInfoType, bool> _showInfo = new Dictionary<RealmsInfoType, bool>()
        {
            { RealmsInfoType.Map, true },
            { RealmsInfoType.Info, true },
            { RealmsInfoType.Vendor, true },
            { RealmsInfoType.NPC, true },
            { RealmsInfoType.Quest, true },
            { RealmsInfoType.Chest, true },
            { RealmsInfoType.Monster, true },
            { RealmsInfoType.Secret, true },
            { RealmsInfoType.Boat, true },
            { RealmsInfoType.Door, true },
            { RealmsInfoType.Trap, true },
            { RealmsInfoType.PitTrap, true },
            { RealmsInfoType.Marker, true }
        };

        public RealmsOptions(int pixelSize, bool showGrid, int shading)
        {
            PixelSize = pixelSize;
            ShowGrid = showGrid;
            Shading = shading;
        }

        public Color GetInfoColor(RealmsInfoType type)
        {
            return _infoColors.ContainsKey(type) ? _infoColors[type] : Color.White;
        }

        public Dictionary<RealmsInfoType, Color> GetInfoColors()
        {
            return _infoColors;
        }

        public bool GetShowInfo(RealmsInfoType type)
        {
            return _showInfo.ContainsKey(type) ? _showInfo[type] : true;
        }

        public Dictionary<RealmsInfoType, bool> GetShowInfos()
        {
            return _showInfo;
        }

        public void SetInfoColor(RealmsInfoType type, Color color)
        {
            if (_infoColors.ContainsKey(type))
            {
                _infoColors[type] = color;
            }
            else
            {
                _infoColors.Add(type, color);
            }
        }

        public void SetShowInfo(RealmsInfoType type, bool show)
        {
            if (_showInfo.ContainsKey(type))
            {
                _showInfo[type] = show;
            }
            else
            {
                _showInfo.Add(type, show);
            }
        }
    }
}

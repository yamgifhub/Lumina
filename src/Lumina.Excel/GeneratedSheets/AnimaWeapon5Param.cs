// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5Param", columnHash: 0x5eb59ccb )]
    public class AnimaWeapon5Param : IExcelRow
    {
        
        public LazyRow< BaseParam > BaseParam;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BaseParam = new LazyRow< BaseParam >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}
// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringType", columnHash: 0x182c5eea )]
    public class GatheringType : IExcelRow
    {
        
        public SeString Name;
        public int IconMain;
        public int IconOff;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            IconMain = parser.ReadColumn< int >( 1 );
            IconOff = parser.ReadColumn< int >( 2 );
        }
    }
}
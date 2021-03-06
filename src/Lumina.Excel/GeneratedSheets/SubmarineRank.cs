// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineRank", columnHash: 0x697b9c75 )]
    public class SubmarineRank : IExcelRow
    {
        
        public ushort Rank;
        public uint ExpToNext;
        public byte SurveillanceBonus;
        public byte RetrievalBonus;
        public byte SpeedBonus;
        public byte RangeBonus;
        public byte FavorBonus;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Rank = parser.ReadColumn< ushort >( 0 );
            ExpToNext = parser.ReadColumn< uint >( 1 );
            SurveillanceBonus = parser.ReadColumn< byte >( 2 );
            RetrievalBonus = parser.ReadColumn< byte >( 3 );
            SpeedBonus = parser.ReadColumn< byte >( 4 );
            RangeBonus = parser.ReadColumn< byte >( 5 );
            FavorBonus = parser.ReadColumn< byte >( 6 );
        }
    }
}
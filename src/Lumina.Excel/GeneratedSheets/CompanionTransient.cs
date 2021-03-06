// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
    public class CompanionTransient : IExcelRow
    {
        
        public SeString Description;
        public SeString DescriptionEnhanced;
        public SeString Tooltip;
        public SeString SpecialActionName;
        public SeString SpecialActionDescription;
        public byte Attack;
        public byte Defense;
        public byte Speed;
        public bool HasAreaAttack;
        public bool StrengthGate;
        public bool StrengthEye;
        public bool StrengthShield;
        public bool StrengthArcana;
        public LazyRow< MinionSkillType > MinionSkillType;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< SeString >( 0 );
            DescriptionEnhanced = parser.ReadColumn< SeString >( 1 );
            Tooltip = parser.ReadColumn< SeString >( 2 );
            SpecialActionName = parser.ReadColumn< SeString >( 3 );
            SpecialActionDescription = parser.ReadColumn< SeString >( 4 );
            Attack = parser.ReadColumn< byte >( 5 );
            Defense = parser.ReadColumn< byte >( 6 );
            Speed = parser.ReadColumn< byte >( 7 );
            HasAreaAttack = parser.ReadColumn< bool >( 8 );
            StrengthGate = parser.ReadColumn< bool >( 9 );
            StrengthEye = parser.ReadColumn< bool >( 10 );
            StrengthShield = parser.ReadColumn< bool >( 11 );
            StrengthArcana = parser.ReadColumn< bool >( 12 );
            MinionSkillType = new LazyRow< MinionSkillType >( lumina, parser.ReadColumn< byte >( 13 ), language );
        }
    }
}
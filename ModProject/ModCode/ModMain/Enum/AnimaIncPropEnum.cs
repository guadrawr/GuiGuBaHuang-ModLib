﻿using ModLib.Enum;
using ModLib.Object;
using System.Collections.Generic;
using System.Linq;

namespace MOD_JhUKQ7.Enum
{
    public class AnimaIncPropEnum : EnumObject
    {
        public static AnimaIncPropEnum Anima100 { get; } = new AnimaIncPropEnum(100)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 1),
            }
        };
        public static AnimaIncPropEnum Anima200 { get; } = new AnimaIncPropEnum(200)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 2),
                MultiValue.Create(UnitPropertyEnum.MpMax, 1),
            }
        };
        public static AnimaIncPropEnum Anima400 { get; } = new AnimaIncPropEnum(400)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 3),
                MultiValue.Create(UnitPropertyEnum.MpMax, 1),
            }
        };
        public static AnimaIncPropEnum Anima800 { get; } = new AnimaIncPropEnum(800)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 4),
                MultiValue.Create(UnitPropertyEnum.MpMax, 1),
                MultiValue.Create(UnitPropertyEnum.Attack, 1),
            }
        };
        public static AnimaIncPropEnum Anima1600 { get; } = new AnimaIncPropEnum(1600)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 8),
                MultiValue.Create(UnitPropertyEnum.MpMax, 2),
                MultiValue.Create(UnitPropertyEnum.Attack, 2),
            }
        };
        public static AnimaIncPropEnum Anima3200 { get; } = new AnimaIncPropEnum(3200)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 12),
                MultiValue.Create(UnitPropertyEnum.MpMax, 4),
                MultiValue.Create(UnitPropertyEnum.Attack, 2),
            }
        };
        public static AnimaIncPropEnum Anima6400 { get; } = new AnimaIncPropEnum(6400)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 25),
                MultiValue.Create(UnitPropertyEnum.MpMax, 6),
                MultiValue.Create(UnitPropertyEnum.Attack, 3),
                MultiValue.Create(UnitPropertyEnum.Defense, 1),
            }
        };
        public static AnimaIncPropEnum Anima12800 { get; } = new AnimaIncPropEnum(12800)
        {
            PropIncRatio = new List<MultiValue>()
            {
                MultiValue.Create(UnitPropertyEnum.HpMax, 50),
                MultiValue.Create(UnitPropertyEnum.MpMax, 15),
                MultiValue.Create(UnitPropertyEnum.Attack, 7),
                MultiValue.Create(UnitPropertyEnum.Defense, 2),
            }
        };

        public IList<MultiValue> PropIncRatio { get; private set; }
        private AnimaIncPropEnum(int minAnima) : base(minAnima.ToString())
        {
        }

        public void Cal(WorldUnitBase wunit)
        {
            foreach (var item in PropIncRatio)
            {
                wunit.AddProperty<int>(item.Values[0] as UnitPropertyEnum, (int)item.Values[1]);
            }
        }
    }
}

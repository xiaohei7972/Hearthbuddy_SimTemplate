using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_691 : SimTemplate //* 大法师阿鲁高 Archmage Arugal
//Whenever you draw a minion, add a copy of it to_your hand.
//每当你抽到一张随从牌，将一张它的复制置入你的手牌。 
	{
		
		
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnChromaggus++;
            else p.anzEnemyChromaggus++;
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnChromaggus--;
            else p.anzEnemyChromaggus--;
        }
	}
}

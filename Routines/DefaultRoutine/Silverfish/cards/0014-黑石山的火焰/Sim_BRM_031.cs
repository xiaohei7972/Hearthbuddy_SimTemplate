using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRM_031 : SimTemplate //* 克洛玛古斯 Chromaggus
//Whenever you draw a card, put another copy into your hand.
//每当你抽一张牌时，将该牌的另一张复制置入你的手牌。 
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

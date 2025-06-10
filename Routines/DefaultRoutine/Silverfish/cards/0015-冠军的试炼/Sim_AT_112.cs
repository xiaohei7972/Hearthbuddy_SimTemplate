using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_112 : SimTemplate //* 大师级枪骑士 Master Jouster
//<b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
//<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得<b>嘲讽</b>和<b>圣盾</b>。 
	{
		
			
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			own.divineshild = true; 
            if (!own.taunt)
            {
                own.taunt = true;
                if (own.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
	}
}
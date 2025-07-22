using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_131 : SimTemplate //* 维克洛尔大帝 Twin Emperor Vek'lor
//[x]<b><b>Taunt</b>Battlecry:</b> If your C'Thun hasat least 10 Attack, summonanother Emperor.
//<b><b>嘲讽</b>，战吼：</b>如果你的克苏恩具有至少10点攻击力，则召唤另一名双子皇帝。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_319);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.anzOgOwnCThunAngrBonus + 6 > 9) p.callKid(kid, own.zonepos, own.own);
                else p.evaluatePenality += 5;
            }
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_156 : SimTemplate //* 恐龙大师布莱恩 Dinotamer Brann
//<b>Battlecry:</b> If your deck has no duplicates, summon King Krush.
//<b>战吼：</b>如果你的牌库里没有相同的牌，则召唤暴龙王克鲁什。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_543);
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) p.callKid(kid, m.zonepos, m.own);
        }
    }
}
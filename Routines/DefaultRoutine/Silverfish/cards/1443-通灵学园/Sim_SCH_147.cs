using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_147 : SimTemplate //* 骨网之卵 Boneweb Egg
	{
		//[x]<b>Deathrattle:</b> Summontwo 2/1 Spiders. If youdiscard this, trigger its<b>Deathrattle</b>.
		//<b>亡语：</b>召唤两只2/1的蜘蛛。如果你弃掉这张牌，触发其<b>亡语</b>。
		CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_147t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
        }
        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;
            if (own != null) return false;

            bool ownplay = true;
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            p.callKid(hc.card, temp.Count, ownplay, false);
            p.callKid(hc.card, temp.Count, ownplay );

            return true;
        }


    }
}

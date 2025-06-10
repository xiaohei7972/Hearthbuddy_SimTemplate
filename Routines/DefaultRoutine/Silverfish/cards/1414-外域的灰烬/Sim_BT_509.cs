using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_509 : SimTemplate //* 邪能召唤师 Fel Summoner
	{
        //<b>Deathrattle:</b> Summon a random Demon from your_hand.
        //<b>亡语：</b>随机从你的手牌中召唤一个恶魔。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ( hc.card.race == CardDB.Race.DEMON || hc.card.race == CardDB.Race.ALL)
                    {
                        p.callKid(hc.card, m.zonepos - 1, true);
                        p.removeCard(hc);
                        break;
                    }
                }
            }
            else
            {
                if (p.enemyAnzCards > 2)
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_223), m.zonepos - 1, false);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_325 : SimTemplate //* 剃刀野猪 Razorboar
	{
        //<b>Deathrattle:</b> Summon a <b>Deathrattle</b> minion that costs (3) or less from your hand.
        //<b>亡语：</b>从你的手牌中召唤一个法力值消耗小于或等于（3）点的<b>亡语</b>随从。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach(Handmanager.Handcard hc in p.owncards)
                {
                    if(hc.manacost <= 3 && hc.card.deathrattle && hc.card.type == CardDB.cardtype.MOB)
                    {
                        p.callKid(hc.card, m.zonepos - 1, true);
                        p.removeCard(hc);
                        break;
                    }
                }
            }else
            {
                if(p.enemyAnzCards > 2)
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_026), m.zonepos - 1, false);
            }
        }

    }
}

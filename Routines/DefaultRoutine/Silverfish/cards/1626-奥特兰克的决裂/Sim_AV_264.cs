using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_264 : SimTemplate //* 清算咒符 sigilofreckoning
	{
		//在你的下个回合开始时，从你的手牌中召唤一个恶魔。
        public override void onAuraStarts(Playfield p, Minion own)
        {
            int pos_ = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB && (TAG_RACE)hc.card.race == TAG_RACE.DEMON)
                {
                    p.callKid(hc.card, pos_, true);
                    break;
                }
            }
        }
		
	}
}

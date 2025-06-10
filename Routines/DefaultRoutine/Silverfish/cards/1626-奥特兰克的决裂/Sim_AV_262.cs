using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_262 : SimTemplate //* 锁链守望者 wardenofchains
	{
		//<b>嘲讽</b>，<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的恶魔牌，便获得+1/+2。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.cost >= 5 && (TAG_RACE)hc.card.race == TAG_RACE.DEMON)
                    p.minionGetBuffed(own, 1, 2);
            }
        }
		
	}
}

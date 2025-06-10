using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_130 : SimTemplate //* 军团士兵 legionnaire
	{
        //<b>亡语：</b>使你手牌中的所有随从牌获得+2/+2。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack+=2;
                        hc.addHp+=2;
                        p.anzOwnExtraAngrHp += 2;
                    }
                }
            }
        }
    }
 }


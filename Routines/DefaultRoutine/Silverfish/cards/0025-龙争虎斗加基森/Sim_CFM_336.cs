using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_336 : SimTemplate //* 豺狼人土枪手 Shaky Zipgunner
//[x]<b>Deathrattle:</b> Give a randomminion in your hand +2/+2.
//<b>亡语：</b>随机使你手牌中的一张随从牌获得+2/+2。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                if (hc != null)
                {
                    hc.addattack += 2;
                    hc.addHp += 2;
                    p.anzOwnExtraAngrHp += 4;
                }
            }
        }
	}
}
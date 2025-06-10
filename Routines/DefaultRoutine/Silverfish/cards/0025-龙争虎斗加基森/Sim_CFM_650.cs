using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_650 : SimTemplate //* 暗鳞劫掠者 Grimscale Chum
//[x]<b>Battlecry:</b> Give a randomMurloc in your hand +1/+1.
//<b>战吼：</b>随机使你手牌中的一张鱼人牌获得+1/+1。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.CARDRACE, TAG_RACE.MURLOC);
                if (hc != null)
                {
                    hc.addattack++;
                    hc.addHp++;
                    p.anzOwnExtraAngrHp += 2;
                }
            }
        }
	}
}
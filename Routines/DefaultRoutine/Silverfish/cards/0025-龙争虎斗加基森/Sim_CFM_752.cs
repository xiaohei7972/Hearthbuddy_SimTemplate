using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_752 : SimTemplate //* 失窃物资 Stolen Goods
//Give a random <b>Taunt</b> minion in your hand +3/+3.
//随机使你手牌中的一张具有<b>嘲讽</b>的随从牌获得+3/+3。 
	{
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.TAUNT);
                if (hc != null)
                {
                    hc.addattack += 3;
                    hc.addHp += 3;
                    p.anzOwnExtraAngrHp += 6;
                }
            }
        }
	}
}
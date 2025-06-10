using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_410 : SimTemplate //* 猩红织网蛛 Scarlet Webweaver
//<b>Battlecry:</b> Reduce the Cost of a random Beast in your_hand by (5).
//<b>战吼：</b>随机使你手牌中的一张野兽牌的法力值消耗减少（5）点。 
	{
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.CARDRACE, TAG_RACE.PET);
                if (hc != null)
                {
                    hc.manacost = Math.Max(0, hc.manacost - 5);
                }
            }
        }
	}
}
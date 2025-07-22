using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_754 : SimTemplate //* 污手玩具商 Grimy Gadgeteer
//At the end of your turn, give a random minion in your hand +2/+2.
//在你的回合结束时，随机使你手牌中的一张随从牌获得+2/+2。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                if (triggerEffectMinion.own)
                {
                    Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                    if (hc != null)
                    {
                        hc.addattack += 2;
                        hc.addHp += 2;
                        p.anzOwnExtraAngrHp += 4;
                    }
                }
                else
                {
                    if (p.enemyAnzCards > 0) p.anzEnemyExtraAngrHp += 4;
                }
            }
        }
    }
}
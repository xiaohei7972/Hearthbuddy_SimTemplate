using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_251 : SimTemplate //* 蝙蝠之灵 Spirit of the Bat
//<b>Stealth</b> for 1 turn.After a friendly minion dies, give a minion in your hand +1/+1.
//<b>潜行</b>一回合。在一个友方随从死亡后，使你手牌中的一张随从牌获得+1/+1。 
	{
        

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            for (int i = 0; i < residual; i++)
            {
                if (m.own)
                {
                    Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
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
}
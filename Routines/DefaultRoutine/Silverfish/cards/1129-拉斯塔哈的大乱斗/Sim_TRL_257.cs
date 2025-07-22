using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_257 : SimTemplate //* 鲜血巨魔工兵 Blood Troll Sapper
//After a friendly minion dies, deal 2 damage to the enemy hero.
//在一个友方随从死亡后，对敌方英雄造成2点伤害。 
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
                p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 2);
            }
        }
	}
}
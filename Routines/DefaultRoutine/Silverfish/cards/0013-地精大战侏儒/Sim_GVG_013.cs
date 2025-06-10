using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_013 : SimTemplate //* 齿轮大师 Cogmaster
//Has +2 Attack while you have a Mech.
//如果你控制任何机械，便获得+2攻击力。 
    {

        

        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MECHANICAL)
            {
                List<Minion> temp = (triggerEffectMinion.own) ? p.ownMinions : p.enemyMinions;

                foreach (Minion m in temp)
                {
                    
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL) return; 
                }

                
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }

		public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.ownMechanicDied : p.tempTrigger.enemyMechanicDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            if (residual >= 1)
			{
				List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
				bool hasmechanics = false;
                foreach (Minion mTmp in temp) 
                {
                    if (mTmp.Hp >=1 && (TAG_RACE)mTmp.handcard.card.race == TAG_RACE.MECHANICAL) hasmechanics = true;
                }
				
                if (!hasmechanics)
                {
                    p.minionGetBuffed(m, -2, 0);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_008 : SimTemplate //* 黑铁潜藏者 Dark Iron Skulker
//<b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
//<b>战吼：</b>对所有未受伤的敌方随从造成2点伤害。 
	{
		
	
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			List<Minion> temp = (m.own) ? p.enemyMinions : p.ownMinions;
			
            foreach (Minion mnn in temp)
            {
                if (!mnn.wounded)
                {
					p.minionGetDamageOrHeal(mnn, 2);
                }
            }
        }
	}
}
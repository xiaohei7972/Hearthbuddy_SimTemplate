using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_581 : SimTemplate //* 诺萨莉 Nozari
//<b>Battlecry:</b> Restore both heroes to full Health.
//<b>战吼：</b>为双方英雄恢复所有生命值。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) 
			{
				p.minionGetDamageOrHeal(p.ownHero, p.ownHero.Hp - p.ownHero.maxHp);
				p.minionGetDamageOrHeal(p.enemyHero, p.enemyHero.Hp - p.enemyHero.maxHp);
			}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_238 : SimTemplate //* 考古专家雷诺 Reno the Relicologist
//<b>Battlecry:</b> If your deck has no duplicates, deal 10 damage randomly split among all enemy minions.
//<b>战吼：</b>如果你的牌库里没有相同的牌，则造成10点伤害，随机分配到所有敌方随从身上。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) 
			{				
		        int times = (m.own) ? p.getSpellDamageDamage(10) : p.getEnemySpellDamageDamage(10);
                p.allCharsOfASideGetRandomDamage(!m.own, times);
			}	
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_251 : SimTemplate //* 作弊的狗头人 cheatysnobold
	{
		//在一个敌人被<b>冻结</b>后，对其造成3点 伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null) return;
            foreach (Minion em in p.enemyMinions)
            {
                if (em.frozen) p.minionGetDamageOrHeal(em, 3);
            }
        }
		
	}
}

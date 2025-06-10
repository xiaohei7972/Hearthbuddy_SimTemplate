using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DREAM_02 : SimTemplate //* 伊瑟拉苏醒 Ysera Awakens
    {
        //Deal $5 damage to all minions except Ysera.
        //对除了伊瑟拉之外的所有随从造成$5点伤害。


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            foreach (Minion m in p.ownMinions)
            {
                if (m.name != CardDB.cardNameEN.ysera) p.minionGetDamageOrHeal(m, dmg);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.name != CardDB.cardNameEN.ysera) p.minionGetDamageOrHeal(m, dmg);
            }
		}

	}
}
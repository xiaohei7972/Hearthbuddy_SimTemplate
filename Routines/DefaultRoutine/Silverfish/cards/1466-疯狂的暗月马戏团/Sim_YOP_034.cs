using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_034 : SimTemplate //* 窜逃的黑翼龙 Runaway Blackwing
	{
        //[x]At the end of your turn,deal 9 damage to arandom enemy minion.
        //在你的回合结束时，随机对一个敌方随从造成9点伤害。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> temp = (triggerEffectMinion.own) ? p.enemyMinions : p.ownMinions;
                int times = (triggerEffectMinion.own) ? p.getSpellDamageDamage(9) : p.getEnemySpellDamageDamage(9);

                if (temp.Count >= 1)
                {
                    //search Minion with lowest hp
                    Minion enemy = temp[0];
                    int minhp = 10000;
                    foreach (Minion m in temp)
                    {
                        if (m.Hp >= times + 1 && minhp > m.Hp)
                        {
                            enemy = m;
                            minhp = m.Hp;
                        }
                    }
                    p.minionGetDamageOrHeal(enemy, times);
                }
            }
        }
    }
}

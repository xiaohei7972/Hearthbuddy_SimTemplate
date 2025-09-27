using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BT_199 : SimTemplate //* 不稳定的邪能箭 Unstable Felbolt
    {
        //Deal $3 damage to an enemy minion and a random friendly one.
        //对一个敌方随从和一个随机友方随从造成$3点伤害。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                p.minionGetDamageOrHeal(target, damage);
                foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
                {
                    if (minion.untouchable) continue;
                    p.minionGetDamageOrHeal(minion, damage);

                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};
        }
    }
}

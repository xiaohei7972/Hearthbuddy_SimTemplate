using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_020 : SimTemplate //* 永恒之火 Perpetual Flame
	{
        //Deal $3 damage to a random enemy minion. If it dies, recast this. <b>Overload:</b> (1)
        //随机对一个敌方随从造成$3点伤害。如果该随从死亡，则再次施放此法术。<b>过载：</b>（1）
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(3);
            foreach(Minion m in p.enemyMinions)
            {
                p.lockedMana++;
                p.evaluatePenality += 5;
                if(m.Hp <= dmg && !m.divineshild)
                {
                    p.minionGetDamageOrHeal(m, dmg);
                }
                else
                {
                    p.minionGetDamageOrHeal(m, dmg);
                    break;
                }
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
    }
}

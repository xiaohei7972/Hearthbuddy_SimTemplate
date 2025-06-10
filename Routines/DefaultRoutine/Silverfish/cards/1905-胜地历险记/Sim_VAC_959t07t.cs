using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Warding
	//守卫护符
	//Deal $6 damage.
	//造成$6点伤害。
	class Sim_VAC_959t07t : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);

            // 对目标造成6点伤害
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, damage);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY)  // 需要选择一个目标
            };
        }

    }
}

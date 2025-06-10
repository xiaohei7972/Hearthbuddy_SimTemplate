using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Warding
	//守卫护符
	//Deal $6 damage.<i>(To a minion!)</i>
	//造成$6点伤害。<i>（仅可对随从！）</i>
	class Sim_VAC_959t07 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);

            // 对一个随从造成6点伤害
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, damage);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }

    }
}

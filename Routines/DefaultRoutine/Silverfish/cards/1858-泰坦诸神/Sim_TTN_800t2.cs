
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_800t2 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = p.getSpellDamageDamage(20);
			p.minionGetDamageOrHeal(target, dmg);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),  // 目标必须是敌方
            };
        }
    }
}

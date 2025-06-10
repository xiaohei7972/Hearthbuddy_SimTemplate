using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：3
	//Vampiric Fangs
	//吸血鬼之牙
	//Destroy a minion. Restore its Health to your hero.
	//消灭一个随从。为你的英雄恢复生命值，数值相当于该随从的生命值。
	class Sim_VAC_464t28 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int heal = target.Hp; // 获取随从的生命值
                p.minionGetDestroyed(target); // 消灭目标随从
                p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal); // 为英雄恢复等同于该随从生命值的血量
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }
    }
}

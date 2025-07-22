using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Crusty the Crustacean
	//硬壳横行蟹
	//[x]<b>Battlecry:</b> Destroy a minion.Gain its Attack and Health.
	//<b>战吼：</b>消灭一个随从。获得其攻击力和生命值。
	class Sim_VAC_464t8 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                int attackGain = target.Angr;
                int healthGain = target.Hp;
                p.minionGetDestroyed(target); // 消灭目标随从

                // 增加硬壳横行蟹的攻击力和生命值
                p.minionGetBuffed(own, attackGain, healthGain);
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

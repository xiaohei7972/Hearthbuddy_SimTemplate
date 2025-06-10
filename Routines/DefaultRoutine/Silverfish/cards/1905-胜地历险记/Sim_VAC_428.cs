using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Go with the Flow
	//顺水漂流
	//Choose a minion.If it's an enemy, <b>Freeze</b> it. If it's friendly, give it <b>Spell Damage +1</b>.
	//选择一个随从。如果是敌方随从，将其<b>冻结</b>；如果是友方随从，使其获得<b>法术伤害+1</b>。
	class Sim_VAC_428 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                if (target.own != ownplay) // 如果目标是敌方随从
                {
                    // 将其冻结
                    target.frozen = true;
                }
                else // 如果目标是友方随从
                {
                    // 给其法术伤害+1
                    target.spellpower++;
                    // 增加全局法术伤害
                    p.spellpower++;
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标必须是一个随从
            };
        }
    }
}

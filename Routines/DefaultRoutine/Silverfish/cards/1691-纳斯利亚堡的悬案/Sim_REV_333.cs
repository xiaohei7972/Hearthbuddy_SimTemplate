using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 德鲁伊 费用：3
	//Hedge Maze
	//树篱迷宫
	//Trigger a friendly minion's <b>Deathrattle</b>.
	//触发一个友方随从的<b>亡语</b>。
	class Sim_REV_333 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效随从，并且是否具有亡语效果
            if (target != null && target.silenced == false && target.handcard.card.deathrattle)
            {
                // 触发目标随从的亡语效果
                target.handcard.card.sim_card.onDeathrattle(p, target);
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE), // 目标必须是一个亡语
            };
        }
    }
}

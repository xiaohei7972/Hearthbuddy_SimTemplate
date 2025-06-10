using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 萨满祭司 费用：1
	//Muck Pools
	//淤泥之池
	//[x]{0}{1}
	//{0}{1}
	class Sim_REV_798 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查 target 是否为 null
            if (target != null && target.own && target.entitiyID != 0)
            {
                int newCost = target.handcard.card.cost + 1; // 新随从的法力值消耗增加1点
                p.minionTransform(target, p.getRandomCardForManaMinion(newCost)); // 变形为一个新的随从
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
            };
        }
    }
}

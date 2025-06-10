using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 法师 费用：3
	//Nightcloak Sanctum
	//夜隐者圣所
	//[x]{0}{1}
	//{0}{1}
	class Sim_REV_796 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 冻结目标随从
            if (target != null)
            {
                target.frozen = true;
            }

            // 召唤一个2/2的不稳定的骷髅
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_845), p.ownMinions.Count, triggerMinion.own);
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
            };
        }
    }
}

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
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_845);
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                // 冻结目标随从
                if (target != null)
                {
                    int pos = triggerMinion.own ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.minionGetFrozen(target);
                    // 召唤一个2/2的不稳定的骷髅
                    p.callKid(kid, pos, triggerMinion.own);
                }

            }
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

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 巫妖王 费用：3
	//Construct Quarter
	//构造区
	//[x]Destroy a friendlyminion to summon a4/5 Undead with <b>Rush</b>.
	//消灭一个友方随从，召唤一个4/5并具有<b>突袭</b>的亡灵。
	class Sim_NX2_036 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效随从
            if (target != null && target.own)
            {
                // 消灭目标友方随从
                p.minionGetDestroyed(target);

                // 召唤一个 4/5 的亡灵随从并赋予突袭
                int position = p.ownMinions.Count; // 召唤的位置在己方随从的最后
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NX2_036t), position, triggerMinion.own); // 使用一个假设的卡牌ID，需要替换为实际亡灵随从的ID
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

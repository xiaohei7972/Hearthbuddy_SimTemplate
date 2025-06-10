using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 巫妖王 费用：2
	//Mosh Pit
	//狂欢舞台
	//[x]Spend 3 <b>Corpses</b> to givea friendly minion <b>Reborn</b>.
	//消耗3具<b>尸体</b>，使一个友方随从获得<b>复生</b>。
	class Sim_ETC_533 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 获取当前可用的尸体数量
            int availableCorpses = p.getCorpseCount();

            // 检查是否有足够的尸体
            if (availableCorpses >= 3)
            {
                // 消耗 3 具尸体
                p.corpseConsumption(3);

                // 检查目标是否为有效随从
                if (target != null && target.own)
                {
                    // 赋予目标随从复生能力
                    target.reborn = true;
                }
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

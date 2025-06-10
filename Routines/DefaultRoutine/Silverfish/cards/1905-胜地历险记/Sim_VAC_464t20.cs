using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：5
	//Banana Split
	//香蕉分裂
	//Give a friendly minion +2/+2. Summon two copies of it.
	//使一个友方随从获得+2/+2，并召唤两个它的复制。
	class Sim_VAC_464t20 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 2, 2); // 给目标随从+2/+2
                for (int i = 0; i < 2; i++)
                {
                    p.callKid(target.handcard.card, target.zonepos + 1, ownplay); // 召唤两个它的复制
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET)   // 目标必须是友方随从
            };
        }
    }
}

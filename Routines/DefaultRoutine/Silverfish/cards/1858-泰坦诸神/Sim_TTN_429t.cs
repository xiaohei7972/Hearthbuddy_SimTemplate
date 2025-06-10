using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：0
	//Shape the Stars
	//塑造星辰
	//Choose a non-<b>Titan</b> minion. Summon a copy of it with +2/+2.
	//选择一个非<b>泰坦</b>随从，召唤一个具有+2/+2的复制。
	class Sim_TTN_429t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (target != null)
            {
                target.Angr += 2;
                target.Hp += 2;
                p.callKid(target.handcard.card, p.ownMinions.Count, true, false); // 召唤一个具有+2/+2的复制
            }
            p.drawACard(CardDB.cardIDEnum.None, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),        // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),          // 目标必须是随从
            };
        }
    }
}

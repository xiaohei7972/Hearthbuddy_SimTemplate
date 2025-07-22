using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：4
	//Matching Outfits
	//统一着装
	//Transform a minion into a random one that costs (1) more, thensummon a copy of it.
	//将一个随从随机变形成为一个法力值消耗增加（1）点的随从，然后召唤一个它的复制。
	class Sim_VAC_324 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //法力值消耗增加（1）点的随从
            CardDB.Card kid = p.getRandomCardForManaMinion(target.handcard.card.cost + 1);
            p.minionTransform(target, kid);

            //召唤一个它的复制。
            if (target != null && ownplay && p.ownMinions.Count < 6)
            {
                int pos = p.ownMinions.Count;
                p.callKid(kid, pos, ownplay);
            }

        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),  // 目标必须是友方随从
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Buy One, Get One Freeze
	//买一冻一
	//<b>Freeze</b> a minion. Summon a <b>Frozen</b>copy of it.
	//<b>冻结</b>一个随从，召唤一个它的<b>被冻结</b>的复制。
	class Sim_MIS_302 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 冻结目标随从
                target.frozen = true;

                // 创建目标随从的复制
                CardDB.Card copyCard = target.handcard.card;
                p.callKid(copyCard, target.zonepos, ownplay);
            }
        }
    }
}

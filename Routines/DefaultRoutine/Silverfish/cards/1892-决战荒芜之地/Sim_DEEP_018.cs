using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Shroomscavate
	//魔菇采掘
	//Give a minion <b>Divine Shield</b>. <b>Excavate</b> a treasure.
	//使一个随从获得<b>圣盾</b>。<b>发掘</b>一个宝藏。
	class Sim_DEEP_018 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 给目标随从赋予圣盾
            if (target != null&&target.divineshild==false)
            {
                target.divineshild = true;
            }

            // 发掘一个宝藏
            CardDB.Card treasure = p.handleExcavation();
            p.drawACard(treasure.cardIDenum, ownplay, true);
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }
    }
}

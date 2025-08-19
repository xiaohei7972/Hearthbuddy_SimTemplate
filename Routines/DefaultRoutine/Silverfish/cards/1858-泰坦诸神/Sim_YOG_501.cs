using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：2 攻击力：2 生命值：2
	//Battleworn Faceless
	//历战无面者
	//<b>Battlecry:</b> Transform into acopy of a damaged minion.
	//<b>战吼：</b>变形成为一个受伤的随从的复制。
	class Sim_YOG_501 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                //p.copyMinion(own, target);
                bool source = own.own;
                own.setMinionToMinion(target);
                own.own = source;
                own.handcard.card.sim_card.onAuraStarts(p, own);
            }
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}

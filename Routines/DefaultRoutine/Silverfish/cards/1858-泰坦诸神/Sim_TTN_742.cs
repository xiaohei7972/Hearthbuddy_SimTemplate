using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：3 生命值：2
	//Celestial Projectionist
	//星空投影师
	//[x]<b>Battlecry:</b> Choose afriendly minion. Add a<b>Temporary</b> copy of itto your hand.
	//<b>战吼：</b>选择一个友方随从，将它的一张<b>临时</b>复制置入你的手牌。
	class Sim_TTN_742 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
				p.drawTemporaryCard(target.handcard.card.cardIDenum, own.own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}

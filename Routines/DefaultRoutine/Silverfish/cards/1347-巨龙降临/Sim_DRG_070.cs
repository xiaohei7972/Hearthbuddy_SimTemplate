using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_070 : SimTemplate //* 幼龙饲养员 Dragon Breeder
	{
		//<b>Battlecry:</b> Choose a friendly Dragon. Add a copy of it to your hand.
		//<b>战吼：</b>选择一条友方的龙。将它的一张复制置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (target != null)
			{
				if (m.own)
				{
					p.drawACard(target.handcard.card.nameEN, m.own, true);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 24),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
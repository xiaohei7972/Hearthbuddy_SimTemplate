using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Mark of the Spikeshell
	//尖壳印记
	//Give a minion +2/+2.If it has <b>Taunt</b>, add a copy of it to your hand.
	//使一个随从获得+2/+2。如果该随从拥有<b>嘲讽</b>，则将该随从的一张复制置入你的手牌。
	class Sim_BAR_549 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 2, 2);
                if (target.taunt)
                {
					p.drawACard(target.handcard.card.cardIDenum, ownplay, true);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}

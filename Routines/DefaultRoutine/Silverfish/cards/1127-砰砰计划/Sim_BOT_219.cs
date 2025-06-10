using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_219 : SimTemplate //* 增生手臂 Extra Arms
//[x]Give a minion +2/+2.Add 'More Arms!' to yourhand that gives +2/+2.
//使一个随从获得+2/+2。将一张可使一个随从获得+2/+2的“更多手臂”置入你的手牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 2);
			p.drawACard(CardDB.cardIDEnum.BOT_219t, ownplay, true);
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
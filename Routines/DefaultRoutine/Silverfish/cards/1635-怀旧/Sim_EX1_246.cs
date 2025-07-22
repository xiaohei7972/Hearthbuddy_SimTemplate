using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_246 : SimTemplate //* 妖术 Hex
	{
		//Transform a minion into a 0/1 Frog with <b>Taunt</b>.
		//使一个随从变形成为一个0/1并具有<b>嘲讽</b>的青蛙。
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.hexfrog);
//    verwandelt einen diener in einen frosch (0/1) mit spott/.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionTransform(target, card);
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
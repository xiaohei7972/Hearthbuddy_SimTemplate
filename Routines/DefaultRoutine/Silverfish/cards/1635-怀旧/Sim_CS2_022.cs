using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_022 : SimTemplate //* 变形术 Polymorph
	{
		//Transform a minioninto a 1/1 Sheep.
		//使一个随从变形成为1/1的绵羊。

        private CardDB.Card sheep = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_tk1);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, sheep);
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

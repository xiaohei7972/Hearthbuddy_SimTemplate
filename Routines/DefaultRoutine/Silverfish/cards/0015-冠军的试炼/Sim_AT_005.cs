using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_005 : SimTemplate //* 变形术：野猪 Polymorph: Boar
//Transform a minion into a 4/2 Boar with <b>Charge</b>.
//使一个随从变形成为一个4/2并具有<b>冲锋</b>的野猪。 
	{
		

        CardDB.Card boar = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_005t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, boar);
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
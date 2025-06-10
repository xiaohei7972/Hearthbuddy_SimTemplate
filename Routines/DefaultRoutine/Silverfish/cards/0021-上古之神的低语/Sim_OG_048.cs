using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_048 : SimTemplate //* 亚煞极印记 Mark of Y'Shaarj
//Give a minion +2/+2.If it's a Beast, drawa card.
//使一个随从获得+2/+2。如果该随从是野兽，抽一张牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 2);
			if ((TAG_RACE)target.handcard.card.race == TAG_RACE.PET) p.drawACard(CardDB.cardIDEnum.None, ownplay);
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
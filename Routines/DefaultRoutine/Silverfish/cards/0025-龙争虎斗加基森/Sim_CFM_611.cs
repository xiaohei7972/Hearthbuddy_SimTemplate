using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_611 : SimTemplate //* 血怒药水 Bloodfury Potion
//[x]Give a minion +3 Attack.If it's a Demon, alsogive it +3 Health.
//使一个随从获得+3攻击力。如果该随从是恶魔，还会获得+3生命值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int hpbaff = 0;
            if ((TAG_RACE)target.handcard.card.race == TAG_RACE.DEMON) hpbaff = 3;
            p.minionGetBuffed(target, 3, hpbaff);
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
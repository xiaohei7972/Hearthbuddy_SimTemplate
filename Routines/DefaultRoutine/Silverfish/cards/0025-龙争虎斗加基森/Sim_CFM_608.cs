using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_608 : SimTemplate //* 爆晶药水 Blastcrystal Potion
//Destroy a minion and one of your Mana Crystals.
//消灭一个随从，和你的一个法力水晶。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDestroyed(target);
            if (ownplay) p.ownMaxMana--;
            else p.enemyMaxMana--;
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
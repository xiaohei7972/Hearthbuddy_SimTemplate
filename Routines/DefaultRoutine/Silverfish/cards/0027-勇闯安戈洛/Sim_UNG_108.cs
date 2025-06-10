using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_108 : SimTemplate //* 大地之鳞 Earthen Scales
//Give a friendly minion +1/+1, then gain Armor equal to its Attack.
//使一个友方随从获得+1/+1，然后获得等同于其攻击力的护甲值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 1, 1);
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, target.Angr);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}

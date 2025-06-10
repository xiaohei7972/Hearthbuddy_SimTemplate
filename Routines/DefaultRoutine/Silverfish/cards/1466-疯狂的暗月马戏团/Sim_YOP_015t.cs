using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_015t : SimTemplate //* 氮素制剂 Nitroboost Poison
	{
        //<b>Corrupted</b>Give a minion and your weapon +2 Attack.
        //<b>已腐蚀</b>使一个随从和你的武器获得+2攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            if (ownplay && target != null)
            {
                p.minionGetBuffed(target, 2, 0);
                if (p.ownWeapon.Durability >= 1)
                {
                    p.ownWeapon.Angr += 2;
                    p.minionGetBuffed(p.ownHero, 2, 0);
                }
            }
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

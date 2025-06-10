using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_221 : SimTemplate //* 吸血药膏 Leeching Poison
//Give your weapon <b>Lifesteal</b> this turn.
//在本回合中，你的武器获得<b>吸血</b>。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.ownWeapon.lifesteal = true;
            else p.enemyWeapon.lifesteal = true;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
    }
}
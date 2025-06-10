using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_079 : SimTemplate //* 铁齿铜牙 Gnash
//Give your hero +3_Attack this turn. Gain 3 Armor.
//使你的英雄获得3点护甲值，并在本回合中获得+3攻击力。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 3);
                p.minionGetTempBuff(p.ownHero, 3, 0);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 3);
                p.minionGetTempBuff(p.enemyHero, 3, 0);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
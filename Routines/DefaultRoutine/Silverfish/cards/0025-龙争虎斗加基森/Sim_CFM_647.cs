using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 吹箭鱼人 Blowgill Sniper
    //<b>Battlecry:</b> Deal 1 damage.
    //<b>战吼：</b>造成1点伤害。 
    class Sim_CFM_647 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 1);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
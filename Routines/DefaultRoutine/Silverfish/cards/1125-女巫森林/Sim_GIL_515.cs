using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 捕鼠人 Ratcatcher
    //<b>Rush</b><b>Battlecry:</b> Destroy a friendly minion and gain its Attack and Health.
    //<b>突袭，战吼：</b>消灭一个友方随从，并获得其攻击力和生命值。 

    class Sim_GIL_515 : SimTemplate
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
                p.minionGetBuffed(own, target.Angr, target.Hp);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
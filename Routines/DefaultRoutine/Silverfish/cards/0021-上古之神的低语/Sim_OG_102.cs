using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_102 : SimTemplate //* 黑暗低语者 Darkspeaker
//<b>Battlecry:</b> Swap stats with a friendly minion.
//<b>战吼：</b>与另一个友方随从交换属性值。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null) return;

            int tmpHp = target.Hp;
            int tmpMHp = target.maxHp;
            int tmpAngr = target.Angr;

            target.Hp = own.Hp;
            target.maxHp = own.maxHp;
            target.Angr = own.Angr;

            own.Hp = tmpHp;
            own.maxHp= tmpMHp;
            own.Angr = tmpAngr;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_014 : SimTemplate //* 沃金 Vol'jin
//<b>Battlecry:</b> Swap Health with another minion.
//<b>战吼：</b>与另一个随从交换生命值。 
    {
       

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target == null) return;

            own.maxHp = target.Hp;
            target.maxHp = own.Hp;

            own.Hp = own.maxHp;
            target.Hp = target.maxHp;
            if (target.wounded)
            {
                target.wounded = false;
                target.handcard.card.sim_card.onEnrageStop(p, target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
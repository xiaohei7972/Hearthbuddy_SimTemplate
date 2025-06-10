using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_030 : SimTemplate //* 阴暗的人影 Shadowy Figure
//<b>Battlecry:</b> Transform into a_2/2 copy of a friendly <b>Deathrattle</b> minion.
//<b>战吼：</b>变形成为一个友方<b>亡语</b>随从的2/2复制。 
    {

        
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                bool source = own.own;
                own.setMinionToMinion(target);
                own.own = source;
                own.Angr = 2;
                own.Hp = 2;
                own.maxHp = 2;
                own.handcard.card.sim_card.onAuraStarts(p, own);
            }
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_616 : SimTemplate //* 妙手空空 Pilfered Power
//Gain an empty Mana Crystal for each friendly minion.
//每控制一个友方随从，便获得一个空的法力水晶。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.ownMaxMana = Math.Min(10, p.ownMaxMana + p.ownMinions.Count);
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + p.enemyMinions.Count);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
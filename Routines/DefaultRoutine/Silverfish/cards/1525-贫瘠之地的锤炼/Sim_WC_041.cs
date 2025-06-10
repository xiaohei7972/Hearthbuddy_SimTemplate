using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_041 : SimTemplate //* 冰爆冲击 Shattering Blast
	{
        //Destroy all <b>Frozen</b> minions.
        //消灭所有被<b>冻结</b>的随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach(Minion m in p.ownMinions)
            {
                if (m.frozen)
                {
                    p.minionGetDestroyed(m);
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.frozen)
                {
                    p.minionGetDestroyed(m);
                }
            }
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FROZEN_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}

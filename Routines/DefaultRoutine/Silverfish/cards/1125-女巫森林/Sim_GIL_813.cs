using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_813 : SimTemplate //* 鲜活梦魇 Vivid Nightmare
//[x]Choose a friendly minion.Summon a copy of it with1 Health remaining.
//选择一个友方随从，召唤一个该随从的复制，且剩余生命值为1点。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            int pos = temp.Count;
            if (pos < 7)
            {
                p.callKid(target.handcard.card, pos, ownplay);
                temp[pos].setMinionToMinion(target);
                p.ownMinions[pos].Hp = 1;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
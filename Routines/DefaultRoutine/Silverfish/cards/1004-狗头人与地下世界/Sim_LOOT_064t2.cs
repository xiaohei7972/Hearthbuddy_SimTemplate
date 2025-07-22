using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_064t2 : SimTemplate //* 大型法术蓝宝石 Greater Sapphire Spellstone
//Summon 3 copies of a friendly minion.
//选择一个友方随从，召唤三个它的复制。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            int pos = temp.Count;
            if (pos < 6)
            {
                p.callKid(target.handcard.card, pos, ownplay);
				p.callKid(target.handcard.card, pos, ownplay);
				p.callKid(target.handcard.card, pos, ownplay);
                temp[pos].setMinionToMinion(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
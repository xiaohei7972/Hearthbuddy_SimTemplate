using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_521 : SimTemplate //* 炼魂术 Ectomancy
//Summon copies of all Demons you control.
//召唤你控制的所有恶魔的复制。 
    {
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			List<Minion> CopiesMinion = new List<Minion>();
			foreach (Minion t in temp)
				if ((TAG_RACE)t.handcard.card.race == TAG_RACE.DEMON)
					CopiesMinion.Add(t);
			foreach (Minion t in CopiesMinion)
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				if (pos < 7)
				{
					p.callKid(t.handcard.card, pos, ownplay);
					if (ownplay) p.ownMinions[pos].setMinionToMinion(t);
					else p.enemyMinions[pos].setMinionToMinion(t);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
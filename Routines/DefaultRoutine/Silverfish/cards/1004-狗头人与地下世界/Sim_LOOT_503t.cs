using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_503t : SimTemplate //* 法术黑曜石 Onyx Spellstone
//Destroy up to 2 random enemy minions.@
//随机消灭两个敌方随从。@ 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (m != null) p.minionGetDestroyed(m);
			p.minionGetDestroyed(m);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
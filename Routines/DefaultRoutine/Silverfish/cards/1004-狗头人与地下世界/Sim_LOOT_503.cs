using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_503 : SimTemplate //* 小型法术黑曜石 Lesser Onyx Spellstone
//Destroy 1 random enemy minion.@<i>(Play 3 <b>Deathrattle</b> cards to upgrade.)</i>
//随机消灭一个敌方随从。@<i>（使用三张<b>亡语</b>牌后升级。）</i> 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (m != null) p.minionGetDestroyed(m);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
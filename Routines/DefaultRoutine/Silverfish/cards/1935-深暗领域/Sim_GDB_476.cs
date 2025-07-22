using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Suffocate
	//难以喘息
	//Destroy a minion. If you're building a <b>Starship</b>, also destroy a random neighbor.
	//消灭一个随从。如果你正在构筑<b>星舰</b>，还会消灭一个随机相邻随从。
	class Sim_GDB_476 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetDestroyed(target);
			//TODO：如果有星舰，消灭两个
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}		
		
	}
}

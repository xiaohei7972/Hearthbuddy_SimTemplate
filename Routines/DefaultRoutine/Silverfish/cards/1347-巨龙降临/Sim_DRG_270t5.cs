using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Malygos's Nova
	//玛里苟斯的冰霜新星
	//<b>Freeze</b> all enemy minions.
	//<b>冻结</b>所有敌方随从。
	class Sim_DRG_270t5 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> minions = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion minion in minions)
            {
                p.minionGetFrozen(minion);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS,1),
            };
        }
		
	}
}

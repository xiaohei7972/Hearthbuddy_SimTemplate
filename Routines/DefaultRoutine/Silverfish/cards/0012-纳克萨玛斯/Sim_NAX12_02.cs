using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX12_02 : SimTemplate //* 残杀 Decimate
//<b>Hero Power</b>Change the Health of all minions to 1.
//<b>英雄技能</b>将所有随从的生命值变为1。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                p.minionSetLifetoX(m, 1);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionSetLifetoX(m, 1);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}
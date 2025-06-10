using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t29 : SimTemplate //* 神秘羊毛 Mystic Wool
//Transform all minions into 1/1 Sheep.
//使所有随从变形成为1/1的绵羊。 
	{
		
		
		private CardDB.Card sheep = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_621_m5);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
				p.minionTransform(m, sheep);
            }
            foreach (Minion m in p.enemyMinions)
            {
				p.minionTransform(m, sheep);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
    }
}
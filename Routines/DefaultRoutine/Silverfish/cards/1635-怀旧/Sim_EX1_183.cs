using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：8
	//Gift of the Wild
	//野性赐福
	//Give your minions +2/+2 and <b>Taunt</b>.
	//使你的所有随从获得+2/+2和<b>嘲讽</b>。
	class Sim_EX1_183 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.allMinionOfASideGetBuffed(ownplay, 2, 2);
			foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
			{
				minion.taunt = true;
				minion.updateReadyness();
			}
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 2),
            };
        }

	}
}

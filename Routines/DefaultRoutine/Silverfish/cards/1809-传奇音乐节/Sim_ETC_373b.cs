using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：7
	//Good Vibrations
	//美妙振动
	//Give your minions +2/+4 and <b>Taunt</b>.
	//使你的所有随从获得+2/+4和<b>嘲讽</b>。
	class Sim_ETC_373b : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
			{
				p.minionGetBuffed(minion, 2, 4);
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

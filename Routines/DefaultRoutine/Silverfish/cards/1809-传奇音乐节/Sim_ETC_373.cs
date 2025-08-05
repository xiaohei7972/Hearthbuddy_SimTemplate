using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：7
	//Drum Circle
	//集会鼓圈
	//<b>Choose One -</b> Summon five 2/2 Treants;or Give your minions +2/+4 and <b>Taunt</b>.
	//<b>抉择：</b>召唤五个2/2的树人；或者使你的所有随从获得+2/+4和<b>嘲讽</b>。
	class Sim_ETC_373 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ETC_373t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay, false);
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
				{
					p.minionGetBuffed(minion, 2, 4);
					minion.taunt = true;
					minion.updateReadyness();
				}
			}

		}

	}
}

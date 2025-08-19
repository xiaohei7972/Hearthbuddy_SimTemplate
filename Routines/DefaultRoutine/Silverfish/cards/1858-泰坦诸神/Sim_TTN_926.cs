using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：7 攻击力：5 生命值：5
	//Ancient of Growth
	//生长古树
	//[x]<b>Choose One -</b> Summonthree 2/2 Treants; or__Transform your Treants into___5/5 Ancients with <b>Taunt</b>.
	//<b>抉择：</b>召唤三个2/2的树人；或者将你的树人变形成为5/5并具有<b>嘲讽</b>的古树。
	class Sim_TTN_926 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_950t2);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4);
		public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
			{
				p.callKid(kid, own.zonepos, own.own);
				p.callKid(kid, own.zonepos, own.own);
				p.callKid(kid, own.zonepos, own.own);
			}

			if (choice == 2 || (target != null && p.ownFandralStaghelm > 0 && own.own))
			{
				foreach (Minion minion in p.ownMinions.ToArray())
				{
					if (minion.handcard.card.Treant)
					{
						p.minionTransform(minion, kid1);
					}
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：7
	//Ancient Growth
	//古树生长
	//Transform your Treants into 5/5 Ancientswith <b>Taunt</b>.
	//将你的树人变形成为5/5并具有<b>嘲讽</b>的古树。
	class Sim_TTN_926b : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_903t4);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (Minion minion in p.ownMinions.ToArray())
			{
				if (minion.handcard.card.Treant)
				{
					p.minionTransform(minion, kid);
				}
			}
		}

	}
}

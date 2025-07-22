using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Bones
	//骸骨
	//Give a minion +{0}/+{1}.
	//使一个随从获得+{0}/+{1}。
	class Sim_TLC_829t : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_829t);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, card.TAG_SCRIPT_DATA_NUM_1, card.TAG_SCRIPT_DATA_NUM_2);

			}
		}

	}
}

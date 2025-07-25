using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Flight of the Bronze
	//青铜龙军团
	//[x]<b>Discover</b> a Dragon.<b>Manathirst (7):</b> Summona 5/5 Drake with <b>Taunt</b>.
	//<b>发现</b>一张龙牌。<b>法力渴求（7）：</b>召唤一条5/5并具有<b>嘲讽</b>的幼龙。
	class Sim_RLK_917 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_917t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
			if (p.ownMaxMana >= hc.card.Manathirst)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}

		}

	}
}

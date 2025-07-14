using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//Showdown!
	//决战！
	//Both players summon three 3/3 Outlaws.Give yours <b>Rush</b>.
	//双方玩家各召唤三个3/3的歹徒，使你召唤的获得<b>突袭</b>。
	class Sim_WW_051 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_051t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			for (int i = 0; i < 3; i++)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
				if (pos < 7)
				{
					p.ownMinions[0 > pos - 1 ? 0 : pos - 1].rush = 1;
				}

			}

			for (int i = 0; i < 3; i++)
			{
				int pos1 = ownplay ? p.enemyMinions.Count : p.ownMinions.Count;
				p.callKid(kid, pos1, !ownplay);
			}
		}


	}
}

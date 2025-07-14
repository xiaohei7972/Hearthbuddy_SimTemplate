using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Dragonscale Armaments
	//龙鳞军备
	//Draw a spell that started in your deck and one that didn't.
	//抽取你套牌中和套牌之外的法术牌各一张。
	class Sim_EDR_251 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			/*
			//TODO:还没有检测套牌之外的属性
			if (p.prozis)
			{
				p.drawACard(CardDB.cardIDEnum.None, ownplay);

			}
			*/

		}

	}
}

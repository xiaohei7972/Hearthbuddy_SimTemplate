using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：0
	//Unlimited Potential
	//无限潜能
	//[x]Cast @ randomMage |4(<b>Secret</b>, <b>Secrets</b>).
	//随机施放@个法师<b>奥秘</b>。
	class Sim_TTN_075t3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
		}
	}
}

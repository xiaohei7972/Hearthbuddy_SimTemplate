using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_204 : SimTemplate //* 裂魔者库尔特鲁斯 kurtrusdemonrender
	{
		//<b>战吼：</b>召唤两个1/4并具有<b>突袭</b>的恶魔。<i>（在本局对战中，你的英雄每攻击一次都会提升。）</i>
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_204t2);
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			p.callKid(kid, m.zonepos, m.own);
			p.callKid(kid, m.zonepos - 1, m.own);

		}

	}
}

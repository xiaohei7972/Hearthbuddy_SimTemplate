using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Gravedawn Sunbloom
	//墓晨太阳花
	//Draw 2 cards. <b>Kindred:</b> This costs (2) less.
	//抽两张牌。<b>延系：</b>本牌法力值消耗减少（2）点。
	class Sim_TLC_816 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}

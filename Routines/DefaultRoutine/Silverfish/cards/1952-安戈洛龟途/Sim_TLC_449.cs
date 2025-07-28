using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 术士 费用：1
	//Bloodpetal Biome
	//血瓣群系
	//<b>Discover</b> a <b>Temporary</b> 1-Cost minion.
	//<b>发现</b>一张<b>临时</b>的法力值消耗为（1）的随从牌。
	class Sim_TLC_449 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
		{
			if (triggerMinion.handcard.card.CooldownTurn == 0)
				p.drawTemporaryCard(CardDB.cardIDEnum.None, triggerMinion.own);
        }
		
	}
}

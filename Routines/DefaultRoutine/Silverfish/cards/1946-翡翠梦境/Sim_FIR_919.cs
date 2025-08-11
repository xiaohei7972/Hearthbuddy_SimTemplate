using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：4 攻击力：3 生命值：2
	//Everburning Phoenix
	//永燃火凤
	//[x]Costs (1) less for each cardyou've played this turn.<b>Deathrattle: </b>At end of turn,get another Phoenix.
	//在本回合中你每使用过一张牌，本牌的法力值消耗便减少（1）点。<b>亡语：</b>在回合结束时，获取另一张永燃火凤。
	class Sim_FIR_919 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
			p.cardsToReturnAtEndOfTurn.Add(CardDB.cardIDEnum.FIR_919);
			// p.drawACard(CardDB.cardIDEnum.FIR_919, m.own, true);
        }
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_840: SimTemplate //* 白衣幽魂 Lady in White
//[x]<b>Battlecry:</b> Cast 'Inner Fire'_on every minion in your deck_<i>(set Attack equal to Health).</i>
//<b>战吼：</b>对你牌库中的所有随从施放“心灵之火”<i>（使其攻击力等同于生命值）</i>。 
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own && p.prozis.getDeckCardsForCost(6) == CardDB.cardIDEnum.None) p.evaluatePenality -= 20;
		}
	}
}
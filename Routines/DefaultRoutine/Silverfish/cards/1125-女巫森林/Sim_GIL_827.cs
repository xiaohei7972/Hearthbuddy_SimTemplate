using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_827 : SimTemplate //* 闪狐 Blink Fox
//<b>Battlecry:</b> Add a random card to your hand <i>(from your opponent's class).</i>
//<b>战吼：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
		}
	}
}
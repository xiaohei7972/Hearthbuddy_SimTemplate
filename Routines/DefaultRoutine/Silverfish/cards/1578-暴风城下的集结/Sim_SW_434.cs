using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_434 : SimTemplate //* 放贷的鲨鱼 Loan Shark
	{
		//[x]<b>Battlecry:</b> Give youropponent a Coin.__<b>Deathrattle:</b> You get two.
		//<b>战吼：</b>使你的对手获得一个幸运币。<b>亡语：</b>使你获得两个幸运币。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.thecoin, !m.own);
		}
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.drawACard(CardDB.cardNameEN.thecoin, m.own);
			p.drawACard(CardDB.cardNameEN.thecoin, m.own);
		}
	}
}

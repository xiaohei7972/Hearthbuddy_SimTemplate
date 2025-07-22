using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_070 : SimTemplate //* 邮箱舞者 Mailbox Dancer
	{
		//[x]<b>Battlecry:</b> Give you a Coin.__<b>Deathrattle:</b> Your opponent get two.
		//<b>战吼：</b>使你获得一个幸运币。<b>亡语：</b>使你的对手获得一个幸运币。
		public override void getBattlecryEffect(Playfield p, Minion own,Minion target,int choice)
        {
            p.drawACard(CardDB.cardNameEN.thecoin, !own.own, true);
            if (own.own)
            {
                p.owncarddraw -= 1;
            }  
        }
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.drawACard(CardDB.cardNameEN.thecoin, m.own);
			p.drawACard(CardDB.cardNameEN.thecoin, m.own);
		}
	}
}

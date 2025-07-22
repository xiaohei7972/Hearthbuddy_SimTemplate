using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_307 : SimTemplate //* 旅行商人 Traveling Merchant
	{
		//[x]<b>Tradeable</b><b>Battlecry:</b> Gain +1/+1for each other friendly_minion you control.
		//<b>可交易</b><b>战吼：</b>你每控制一个其他友方随从，便获得+1/+1。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int buff = (own.own) ? p.ownMinions.Count - 1 : p.enemyMinions.Count - 1;
            p.minionGetBuffed(own, buff, buff);
		}
		
	}
}

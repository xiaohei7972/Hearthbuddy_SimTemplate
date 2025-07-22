using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_612 : SimTemplate //* 肯瑞托法师 Kirin Tor Mage
	{
		//[x]<b>Battlecry:</b> The next <b>Secret</b>you play this turn costs (0).
		//<b>战吼：</b>在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（0）点。
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.nextSecretThisTurnCost0 = true;
		}


	}
}
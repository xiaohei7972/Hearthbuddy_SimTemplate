using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_029 : SimTemplate //* 米尔豪斯·法力风暴 Millhouse Manastorm
	{
		//<b>Battlecry:</b> Enemy spells cost (0) next turn.
		//<b>战吼：</b>下个回合敌方法术的法力值消耗为（0）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.weHavePlayedMillhouseManastorm = true;
		}


	}
}
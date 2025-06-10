using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_002 : SimTemplate //* 邪刃豹 Felsaber
	{
		//Can only attack if your hero attacked this turn.
		//在本回合中，除非你的英雄进行过攻击，否则无法进行攻击。
		public override void onHeroattack(Playfield p, Minion own, Minion target)
		{
			if (own.own)
			{
				own.cantAttack = false;
				own.updateReadyness();
			}
		}
	}
}

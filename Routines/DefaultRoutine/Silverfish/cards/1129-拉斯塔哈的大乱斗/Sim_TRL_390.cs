using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_390 : SimTemplate //* 大胆的吞火者 Daring Fire-Eater
//<b>Battlecry:</b> Your next Hero Power this turn deals 2_more damage.
//<b>战吼：</b>在本回合中，你的下一个英雄技能会额外造成2点伤害。 
	{     


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ownHeroPowerExtraDamage+=2;
            else p.enemyHeroPowerExtraDamage+=2;
		}


	}
}
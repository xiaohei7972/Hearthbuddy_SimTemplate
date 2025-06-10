using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_204p : SimTemplate //* 陨烬之怒 ashfallensfury
	{
		//<b>英雄技能</b> 在本回合中+2攻击力。在一个友方随从攻击后，复原此技能。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			//[x]<b>Hero Power</b>+2 Attack this turn.
			//<b>英雄技能</b>在本回合中获得+2攻击力。
			p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 2, 0);
		}
		//需要增加个使技能复原的虚函数 public override void 
        //{
        //    if (ownplay) p.ownAbilityReady = true;
        //    else p.enemyAbilityReady = true;
        //  }
}
}

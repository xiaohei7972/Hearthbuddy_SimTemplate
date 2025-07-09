using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：10
	//Story of Amara
	//阿玛拉的故事
	//Set your hero'sHealth to 40.
	//将你英雄的生命值变为40。
	class Sim_TLC_835 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.ownHero.Hp = 40;
				p.ownHero.maxHp = 40;
			}
			else
			{
				p.enemyHero.Hp = 40;
				p.enemyHero.maxHp = 40;
			}
        }
		
	}
}

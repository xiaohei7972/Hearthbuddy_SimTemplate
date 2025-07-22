using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：4 生命值：4
	//Hound Dreadseed
	//犬魔之种
	//[x]<b>Dormant</b> for 2 turns.When this awakens, give yourhero +3 Attack this turn.
	//<b>休眠</b>2回合。唤醒时，使你的英雄在当回合获得+3攻击力。
	class Sim_EDR_840t : SimTemplate
	{
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			if (m.own)
			{
				p.ownHero.Angr += 3;
			}
			else
			{
				p.enemyHero.Angr += 3;
			}
		}

	}
}

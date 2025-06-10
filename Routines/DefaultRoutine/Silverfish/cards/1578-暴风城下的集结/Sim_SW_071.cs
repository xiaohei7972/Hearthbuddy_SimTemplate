using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_071 : SimTemplate //* 雄狮卫士 Lion's Guard
	{
		//[x]<b>Battlecry:</b> If you have 15or less Health, gain+2/+4 and <b>Taunt</b>.
		//<b>战吼：</b>如果你的生命值小于或等于15点，则获得+2/+4和<b>嘲讽</b>。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			int heroHealth = (m.own) ? p.ownHero.Hp : p.enemyHero.Hp;
			if (heroHealth <= 15)
			{
				p.minionGetBuffed(m, 2, 4);
				m.taunt = true;
				p.anzOwnTaunt++;
			}
		}
	}
}

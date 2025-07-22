using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：3 生命值：8
	//Fleshshaper
	//血肉塑造者
	//<b>Taunt</b>. <b>Battlecry:</b> If you have 5 or more Armor, summon a copy of this.
	//<b>嘲讽</b>。<b>战吼：</b>如果你的护甲值大于或等于5点，召唤一个本随从的复制。
	class Sim_NX2_027 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (p.ownHero.armor >= 5)
			{
				var minionsCnt = (m.own ? p.ownMinions : p.enemyMinions).Count;
				if (minionsCnt < 7)
				{
					p.callKid(m.handcard.card, m.zonepos, m.own);
					(m.own ? p.ownMinions : p.enemyMinions)[minionsCnt].setMinionToMinion(m);
				}
			}
		}	
	}
}

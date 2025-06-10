using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：2 攻击力：2 生命值：2
	//Cactus Cutter
	//仙人掌割水工
	//<b>Battlecry:</b> Draw a spell. If you cast it this turn, gain +1/+2 and <b>Taunt</b>.
	//<b>战吼：</b>抽一张法术牌。如果你在本回合中施放抽到的牌，则获得+1/+2和<b>嘲讽</b>。
	class Sim_WW_327 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.frostbolt, own.own); // 抽一张冰枪
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if (p.owncards.Find(c => c.card.nameEN == CardDB.cardNameEN.frostbolt) != null)	 // 如果抽到的牌是冰枪
				{
					own.Angr += 1;
					own.Hp += 2;
					own.taunt = true;
				}
			}
		}
		
	}
}

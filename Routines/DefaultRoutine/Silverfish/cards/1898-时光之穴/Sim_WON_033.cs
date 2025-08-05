using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：3 生命值：4
	//Soot Spewer
	//煤烟喷吐装置
	//<b>Spell Damage +1</b><b>Battlecry:</b> If you controlanother Mech, get a random Fire spell.
	//<b>法术伤害+1</b><b>战吼：</b>如果你控制着其他机械，随机获取一张火焰法术牌。
	class Sim_WON_033 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				bool flag = false;
				foreach (Minion minion in p.ownMinions)
				{
					if (RaceUtils.IsRaceOrAll(minion.handcard.card.race, CardDB.Race.MECHANICAL))
					{
						flag = true;
						break;
					}
				}

				if (flag)
					p.drawACard(CardDB.cardIDEnum.None, own.own, true);
			}
		}
		
		public override void onAuraStarts(Playfield p, Minion m)
		{
			if (m.own) p.spellpower += m.spellpower;
			else p.enemyspellpower += m.spellpower;

		}

		public override void onAuraEnds(Playfield p, Minion m)
		{
			if (m.own) p.spellpower -= m.spellpower;
			else p.enemyspellpower -= m.spellpower;
		}



	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：3 生命值：2
	//Living Flame
	//活体烈焰
	//<b>Deathrattle:</b> Draw aFire spell.
	//<b>亡语：</b>抽一张火焰法术牌。
	class Sim_FIR_929 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			if (m.own)
			{
				foreach (var item in p.prozis.turnDeck)
				{
					CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
					if (card.SpellSchool == CardDB.SpellSchool.FIRE)
					{
						p.drawACard(item.Key, m.own);
					}
				}
			}
			else
			{
				p.drawACard(CardDB.cardIDEnum.None, m.own);
			}

		}

	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_814 : SimTemplate //* 伊利达雷邪刃武士 Illidari Felblade
	{
		//<b>Rush</b><b>Outcast:</b> Gain <b>Immune</b> this_turn.
		//<b>突袭</b><b>流放：</b>在本回合中获得<b>免疫</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				foreach (Minion m in p.ownMinions)
				{
					if (m.handcard.card.cardIDenum == CardDB.cardIDEnum.BAR_333)
					{
						m.immune = true;
						break;
					}
				}
			}
		}

	}
}

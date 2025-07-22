using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_010 : SimTemplate //* 被禁锢的星骓 Imprisoned Celestial
	{
		//[x]<b>Dormant</b> for 2 turns.<b>Spellburst</b>: Give your minions<b>Divine Shield</b>.
		//<b>休眠</b>两回合。<b>法术迸发：</b>使你的随从获得<b>圣盾</b>。m.divineshild = true;		
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			m.Spellburst = true;
		}
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

			foreach (Minion mnn in temp)
			{
				if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
				{
					m.Spellburst = false;
					mnn.souloftheforest++;
				}
			}
		}
	}
}

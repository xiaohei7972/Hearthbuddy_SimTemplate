using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_538 : SimTemplate //* 平原德鲁伊 Druid of the Plains
	{
		//<b>Rush</b><b>Frenzy:</b> Transform into a 6/7 Kodo with <b>Taunt</b>.
		//<b>突袭</b>，<b>暴怒：</b>变形成为一只6/7并具有<b>嘲讽</b>的科多兽。
		public override void onEnrageStart(Playfield p, Minion m)
		{
			p.minionSetAngrToX(m, 6);
			p.minionSetLifetoX(m, 7);
			m.taunt = true;
			if (m.own) p.anzOwnTaunt++;
			else p.anzEnemyTaunt++;
		}
		
	}
}

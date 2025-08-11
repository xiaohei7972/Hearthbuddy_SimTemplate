using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Murloc Warleader
	//鱼人领军
	//Your other Murlocs have +2 Attack.
	//你的其他鱼人拥有+2攻击力。
	class Sim_BG_EX1_507 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion m)
		{
			List<Minion> ownMinions = (m.own) ? p.ownMinions : p.ownMinions;
			foreach (Minion minion in ownMinions)
			{
				if ((TAG_RACE)minion.handcard.card.race == TAG_RACE.MURLOC && minion.entitiyID != m.entitiyID) p.minionGetBuffed(m, 2, 0);
			}
		}


        public override void onAuraEnds(Playfield p, Minion m)
        {
            List<Minion> ownMinions = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion minion in ownMinions)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC && minion.entitiyID != m.entitiyID) p.minionGetBuffed(m, -2, 0);
            }
        }

	}
}

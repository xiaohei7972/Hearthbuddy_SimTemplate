using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_078 : SimTemplate //* 剑圣萨穆罗 Blademaster Samuro
	{
		//[x]<b>Rush</b><b>Frenzy:</b> Deal damage equalto this minion's Attack_to all enemy minions.
		//<b>突袭</b>，<b>暴怒：</b>对所有敌方随从造成等同于该随从攻击力的伤害。
		public override void onEnrageStart(Playfield p, Minion m)
		{
			if (!m.cantAttackHeroes) return;
			if(m.Hp > 0)
				p.allMinionOfASideGetDamage(!m.own, m.Angr);
			foreach(Minion mm in p.enemyMinions){
				if(mm.Hp <= m.Angr){
					p.evaluatePenality -= (mm.Hp + mm.Angr) * 2;
				}else
                {
					p.evaluatePenality += 5;
				}
			}
		}
	}
}

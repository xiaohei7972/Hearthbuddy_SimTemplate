using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：3 生命值：4
	//Warhorse Trainer
	//战马训练师
	//Your Silver Hand Recruits have +2 Attack and <b>Taunt</b>.
	//你的白银之手新兵拥有+2攻击力和<b>嘲讽</b>。
	class Sim_RLK_Prologue_AT_075 : SimTemplate
	{
		public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnWarhorseTrainer++;
            else p.anzEnemyWarhorseTrainer++;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, 2, 0);
                    m.taunt = true;
                }
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own) p.anzOwnWarhorseTrainer--;
            else p.anzEnemyWarhorseTrainer--;

            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, -2, 0);
                    m.taunt = false;
                }
            }
        }
		
	}
}

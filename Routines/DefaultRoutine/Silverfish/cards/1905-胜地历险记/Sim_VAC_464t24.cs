using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：14
	//Book of the Dead
	//亡者之书
	//Deal $7 damage to all enemies. Costs (1) less for each minion that's died this game.
	//对所有敌人造成$7点伤害。在本局对战中，每有一个随从死亡，本牌的法力值消耗便减少（1）点。
	class Sim_VAC_464t24 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getSpellDamageDamage(7) : p.getEnemySpellDamageDamage(7);
            p.allCharsOfASideGetDamage(!ownplay, dmg); // 对所有敌人造成7点伤害
        }
    }
}

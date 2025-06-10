using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_606 : SimTemplate //* 爆爆机器人 Kaboom Bot
//<b>Deathrattle:</b> Deal 4_damage to a random enemy minion.
//<b>亡语：</b>随机对一个敌方随从造成4点伤害。 
	{
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            Minion target = null;
            if (m.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(4, true);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
            }
            if (target != null) p.minionGetDamageOrHeal(target, 4);
        }
    }
}
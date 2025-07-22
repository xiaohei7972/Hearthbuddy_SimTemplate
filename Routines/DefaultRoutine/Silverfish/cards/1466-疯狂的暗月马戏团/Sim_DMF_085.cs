using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_085 : SimTemplate //* 暗月坦克 Darkmoon Tonk
	{
        //<b>Deathrattle:</b> Fire four  missiles at random enemies that deal 2 damage each.
        //<b>亡语：</b>随机对敌人发射四枚飞弹，每枚飞弹造成2点伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {

            int times = (m.own) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            Minion target = null;
            while (times > 0)
            {
                if (m.own) target = p.getEnemyCharTargetForRandomSingleDamage(4);
                else
                {
                    target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); //damage the Highest (pessimistic)
                    if (target == null) target = p.ownHero;
                }
                p.minionGetDamageOrHeal(target, 2);
                times--;
            }
        }
    }
}

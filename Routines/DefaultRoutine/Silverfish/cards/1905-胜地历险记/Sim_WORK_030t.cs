using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Blackrock Brochure
	//黑石山宣传单
	//Deal $3 damage to a minion and $1 toits neighbors.<i>(Flips each turn.)</i>
	//对一个随从造成$3点伤害并对其相邻随从造成$1点。<i>（每回合翻面。）</i>
	class Sim_WORK_030t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmgMain = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            int dmgAdj = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, dmgMain);
            List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
                {
                    p.minionGetDamageOrHeal(m, dmgAdj);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }

    }
}

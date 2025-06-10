using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 萨满祭司 费用：2
    //Icecrown Brochure
    //冰冠堡垒宣传单
    //Deal $3 damage to a minion and <b>Freeze</b> its neighbors.<i>(Flips each turn.)</i>
    //对一个随从造成$3点伤害并<b>冻结</b>其相邻随从。<i>（每回合翻面。）</i>
    class Sim_WORK_030 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
            List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
                {
                    p.minionGetFrozen(m);
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

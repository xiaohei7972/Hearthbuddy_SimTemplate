using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_836: SimTemplate //* 冰龙吐息 Breath of Sindragosa
//Deal $2 damage to a random enemy minion and <b>Freeze</b> it.
//随机对一个敌方随从造成$2点伤害，并使其<b>冻结</b>。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            target = null;
            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg, true);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
            }
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, dmg);
                p.minionGetFrozen(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
    }
}
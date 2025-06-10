using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_707 : SimTemplate //* 青玉闪电 Jade Lightning
//Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>.
//造成$4点伤害，召唤一个{0}的<b>青玉魔像</b>。@造成$4点伤害，召唤一个<b>青玉魔像</b>。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
                p.minionGetDamageOrHeal(target, dmg);
            }

            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getNextJadeGolem(ownplay), pos, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
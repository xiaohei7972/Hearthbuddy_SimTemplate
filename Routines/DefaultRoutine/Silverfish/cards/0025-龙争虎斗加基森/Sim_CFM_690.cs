using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_690 : SimTemplate //* 青玉飞镖 Jade Shuriken
//Deal $2 damage.<b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.@Deal $2 damage.<b>Combo:</b> Summon a <b>Jade Golem</b>.
//造成$2点伤害。<b>连击：</b>召唤一个{0}的<b>青玉魔像</b>。@造成$2点伤害。<b>连击：</b>召唤一个<b>青玉魔像</b>。 
	{
        
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);

            if (p.cardsPlayedThisTurn > 0)
            {
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getNextJadeGolem(ownplay), pos, ownplay);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
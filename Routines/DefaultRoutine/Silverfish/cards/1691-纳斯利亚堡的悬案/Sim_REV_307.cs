using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 自然死亡 Natural Causes
    //造成2点伤害。召唤一个2/2的树人。
    //Deal 2 damage.Summon a 2/2 Treant.
    class Sim_REV_307 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_336t2);//Treant
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.minionGetDamageOrHeal(target, dmg);
                p.callKid(kid, pos, ownplay);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),//目标只能是敌方
            };
        }

    }
}

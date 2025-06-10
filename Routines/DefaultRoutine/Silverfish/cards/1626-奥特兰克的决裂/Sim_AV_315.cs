using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AV_315 : SimTemplate //* 超脱 deliverance
    {
        //对一个随从造成$3点伤害。<b>荣誉消灭：</b>召唤该随从的一个3/3的新的复制。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {

            int dmg = p.getSpellDamageDamage(3);
            if (target != null && !target.isHero)
            {
                p.minionGetDamageOrHeal(target, dmg);
                if (dmg == target.Hp)
                {
                    //CardDB.Card kid = CardDB.Instance.getCardDataFromID(target.id);
                    List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
                    int pos = temp.Count;
                    if (pos < 7)
                    {
                        p.callKid(target.handcard.card, pos, (target.own) ? true : false);
                        temp[pos].setMinionToMinion(target);
                        p.ownMinions[pos].Hp = 3;
                        p.ownMinions[pos].Hp = 3;
                        p.ownMinions[pos].maxHp = 3;
                    }
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }

    }
}
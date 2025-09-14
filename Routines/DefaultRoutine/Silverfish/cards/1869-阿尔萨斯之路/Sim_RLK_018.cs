
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 凋零打击 Plague Strike
    //对一个随从造成3点伤害。如果该随从死亡，召唤一个2/2并具有&lt;b&gt;突袭&lt;/b&gt;的僵尸。
    //Deal 3 damage toa minion. If that kills it,summon a 2/2 Zombiewith &lt;b&gt;Rush&lt;/b&gt;.
    class Sim_RLK_018 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_018t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                p.minionGetDamageOrHeal(target, dmg);
                if (target.Hp <= dmg)
                {
                    int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(kid, pos, ownplay);
                }
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_517 : SimTemplate //* 奥术溢爆 Arcane Overflow
    {
        //对一个敌方随从造成8点伤害。召唤一滩残渣，属性值等同于超过目标生命值的伤害。
        //Deal 8 damage to an enemy minion. Summon a Remnant with stats equal to the excess damage.
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_517t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(8) : p.getEnemySpellDamageDamage(8);
            p.minionGetDamageOrHeal(target, dmg);
            if (dmg - target.Hp > 0)
            {
                kid.Health += dmg - target.Hp;
                kid.Attack += dmg - target.Hp;
            }
            p.callKid(kid, 1, ownplay);
        }
    }
}

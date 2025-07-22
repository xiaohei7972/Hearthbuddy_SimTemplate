using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 术士 费用：4
    //Felfire Bonfire
    //邪能篝火
    //[x]Deal $4 damage toa minion. If it dies, yournext <b>Deathrattle</b> minioncosts (3) less.
    //对一个随从造成$4点伤害。如果该随从死亡，你的下一个<b>亡语</b>随从的法力值消耗减少（3）点。
    class Sim_VAC_952 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

                // 对一个随从造成4点伤害
                p.minionGetDamageOrHeal(target, damage);
                if (target.Hp <= 0)
                {
                    //TODO:没有下个一个亡语随从法力值减少的属性
                }
            }


        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
            };
        }

    }
}

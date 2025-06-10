using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_022 : SimTemplate //* 临终之息 Final Gasp
	{
        //[x]Deal $1 damage to aminion. If it dies, summona 2/2 Adventurer with arandom bonus effect.
        //对一个随从造成$1点伤害。如果该随从死亡，召唤一个2/2并具有随机效果的冒险者。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
            if(target.Hp <= 0)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_034t2), p.ownMinions.Count, true);
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

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 蜂群来袭 BEEEES!!!
    //[x]Choose a minion.Summon four 1/1 Beesthat attack it.
    //选择一个随从。召唤四只1/1的蜜蜂攻击该随从。 
    class Sim_ULD_134 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_134t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                List<Minion> minions = new List<Minion>();
                for (int i = 0; i < 4; i++)
                {
                    int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    if (pos < 7)
                    {
                        p.callKid(kid, pos, ownplay);
                        minions.Add(p.ownMinions[pos - 1]);
                    }
                }
                foreach (Minion minion in minions)
                {
                    p.minionAttacksMinion(minion, target);
                }
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1),
            };
        }


        // CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_134t);

        // public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        // {
        //     int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
        //     p.minionGetDamageOrHeal(target, dmg);

        //     int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
        //     p.callKid(kid, pos, ownplay, false);
        //     p.callKid(kid, pos, ownplay);
        //     p.callKid(kid, pos, ownplay);
        //     p.callKid(kid, pos, ownplay);
        // }

        // public override PlayReq[] GetPlayReqs()
        // {
        //     return new PlayReq[] {
        //         new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
        //         new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
        //         new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
        //     };
        // }
    }
}
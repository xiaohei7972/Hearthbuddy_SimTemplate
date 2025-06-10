using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_004 : SimTemplate//* Mad Scientist 疯狂的科学家
    {
        // Deathrattle: Put a Secret: from your deck into the battlefield.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                if (p.ownHeroStartClass == TAG_CLASS.MAGE)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_289);
                }
                if (p.ownHeroStartClass == TAG_CLASS.HUNTER)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_554);
                }
                if (p.ownHeroStartClass == TAG_CLASS.PALADIN)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_130);
                }
            }
            else
            {
                p.evaluatePenality += 100;
                //if (p.enemyHeroStartClass == TAG_CLASS.MAGE || p.enemyHeroStartClass == TAG_CLASS.HUNTER || p.enemyHeroStartClass == TAG_CLASS.PALADIN)
                //{
                //    if (p.enemySecretCount <= 4)
                //    {
                //        p.enemySecretCount++;
                //        SecretItem si = Probabilitymaker.Instance.getNewSecretGuessedItem(p.getNextEntity(), p.ownHeroStartClass);
                //        if (p.enemyHeroStartClass == TAG_CLASS.PALADIN)
                //        {
                //            si.canBe_redemption = false;
                //        }
                //        p.enemySecretList.Add(si);
                //    }
                //}
            }
        }
    }

}

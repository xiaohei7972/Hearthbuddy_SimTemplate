using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_079 : SimTemplate //* 低调的游客 Inconspicuous Rider
	{
		//<b>Battlecry:</b> Cast a <b>Secret</b> from your deck.
		//<b>战吼：</b>从你的牌库中施放一个<b>奥秘</b>。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.ownHeroStartClass == TAG_CLASS.MAGE)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.None);
                }
                if (p.ownHeroStartClass == TAG_CLASS.HUNTER)
                {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_554);
                }
                // if (p.ownHeroStartClass == TAG_CLASS.PALADIN)
                // {
                //     p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_130);
                // }
            }
            else
            {
                // if (p.enemyHeroStartClass == TAG_CLASS.MAGE || p.enemyHeroStartClass == TAG_CLASS.HUNTER || p.enemyHeroStartClass == TAG_CLASS.PALADIN)
                // {
                //     if (p.enemySecretCount <= 4)
                //     {
                //         p.enemySecretCount++;
                //         SecretItem si = Probabilitymaker.Instance.getNewSecretGuessedItem(p.getNextEntity(), p.ownHeroStartClass);
                //         if (p.enemyHeroStartClass == TAG_CLASS.PALADIN)
                //         {
                //             si.canBe_redemption = false;
                //         }
                //         if (Settings.Instance.useSecretsPlayAround)
                //         {
                //             p.enemySecretList.Add(si);
                //         }
                //     }
                // }
            }
        }
		
	}
}

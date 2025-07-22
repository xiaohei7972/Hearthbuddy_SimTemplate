using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_tt_010 : SimTemplate //* 扰咒术 Spellbender
	{
		//<b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
		//<b>奥秘：</b>当一个敌方法术以一个随从为目标时，召唤一个1/3的随从并使其成为新的目标。
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_tt_010a);

        public override void onSecretPlay(Playfield p, bool ownplay, Minion attacker, Minion target, out int number)
        {
            number = 0;
            if (ownplay)
            {
                int posi = p.ownMinions.Count;
                if (posi > 6) return;
                p.callKid(kid, posi, true);
                if (p.ownMinions.Count >= 1)
                {
                    if (p.ownMinions[p.ownMinions.Count - 1].name == CardDB.cardNameEN.spellbender)
                    {
                        number = p.ownMinions[p.ownMinions.Count - 1].entitiyID;
                    }
                }
            }
            else
            {
                int posi = p.enemyMinions.Count;
                if (posi > 6) return;
                p.callKid(kid, posi, false);

                if (p.enemyMinions.Count >= 1)
                {
                    if (p.enemyMinions[p.enemyMinions.Count - 1].name == CardDB.cardNameEN.spellbender)
                    {
                        number = p.enemyMinions[p.enemyMinions.Count - 1].entitiyID;
                    }
                }
            }

        }

    }

}
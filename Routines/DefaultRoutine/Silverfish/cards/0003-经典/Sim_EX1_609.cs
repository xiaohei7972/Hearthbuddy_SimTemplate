using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_609 : SimTemplate //* 狙击 Snipe
	{
		//<b>Secret:</b> After your opponent plays a minion, deal $4 damage to it.
		//<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$4点伤害。

        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            p.minionGetDamageOrHeal(target, dmg);
        }

	}

}

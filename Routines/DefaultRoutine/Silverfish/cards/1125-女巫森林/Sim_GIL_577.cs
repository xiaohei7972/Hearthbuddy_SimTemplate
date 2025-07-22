using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_577 : SimTemplate //* 捕鼠陷阱 Rat Trap
//[x]<b>Secret:</b> After youropponent plays threecards in a turn, summona 6/6 Rat.
//<b>奥秘：</b>当你的对手在一回合中使用三张牌后，召唤一只6/6的老鼠。 
	{
        


        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            p.minionGetDamageOrHeal(target, dmg);
        }

	}

}

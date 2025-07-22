using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_097 : SimTemplate //* 憎恶 Abomination
	{
		//<b>Taunt</b>. <b>Deathrattle:</b> Deal 2damage to ALL characters.
		//<b>嘲讽，亡语：</b>对所有角色造成2点伤害。

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allCharsGetDamage(2);
        }

	}
}
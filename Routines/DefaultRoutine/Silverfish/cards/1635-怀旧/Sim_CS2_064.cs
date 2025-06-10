using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_064 : SimTemplate //* 恐惧地狱火 Dread Infernal
	{
		//<b>Battlecry:</b> Deal 1 damage to ALL other characters.
		//<b>战吼：</b>对所有其他角色造成1点伤害。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allCharsGetDamage(1, own.entitiyID);
		}
	}
}
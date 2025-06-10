using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_751 : SimTemplate //* 渊狱惩击者 Abyssal Enforcer
//<b>Battlecry:</b> Deal 3 damage to all other characters.
//<b>战吼：</b>对所有其他角色造成3点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allCharsGetDamage(3, own.entitiyID);
        }
    }
}
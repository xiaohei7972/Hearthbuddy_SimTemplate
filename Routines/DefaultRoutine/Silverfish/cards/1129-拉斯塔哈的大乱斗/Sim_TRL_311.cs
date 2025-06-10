using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_311 : SimTemplate //* 奥术暴龙 Arcanosaur
//<b>Battlecry:</b> If you played an_Elemental last turn, deal_3_damage_to_all other minions.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则对所有其他随从造成3点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.anzOwnElementalsLastTurn > 0 && own.own)p.allMinionsGetDamage(3);
        }
    }
}
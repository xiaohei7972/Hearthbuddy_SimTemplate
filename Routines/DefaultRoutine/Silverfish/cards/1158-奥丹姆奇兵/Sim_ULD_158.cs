using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_158 : SimTemplate //* 沙暴元素 Sandstorm Elemental
//<b>Battlecry:</b> Deal 1 damage to all enemy minions. <b>Overload:</b> (1)
//<b>战吼：</b>对所有敌方随从造成1点伤害。<b>过载：</b>（1） 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.allMinionOfASideGetDamage(!own.own, 1);
			if (own.own) p.ueberladung++;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_070 : SimTemplate //* 托维尔塑石师 Tol'vir Stoneshaper
//[x]<b>Battlecry:</b> If you played anElemental last turn, gain_<b>Taunt</b> and <b>Divine_Shield</b>.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则获得<b>嘲讽</b>和<b>圣盾</b>。 
	{
		


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.anzOwnElementalsLastTurn > 0 && own.own)
			{
				own.divineshild = true;
				own.taunt = true;
                p.anzOwnTaunt++;
			}
        }
    }
}
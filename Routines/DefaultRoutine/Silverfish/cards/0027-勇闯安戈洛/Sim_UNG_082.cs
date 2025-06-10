using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_082 : SimTemplate //* 雷霆蜥蜴 Thunder Lizard
//<b>Battlecry</b>: If you played an_Elemental last turn, <b>Adapt</b>.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则获得<b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.anzOwnElementalsLastTurn > 0 && own.own) p.getBestAdapt(own);
        }
    }
}
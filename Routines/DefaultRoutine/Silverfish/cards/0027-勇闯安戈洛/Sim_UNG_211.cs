using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_211 : SimTemplate //* 荒蛮之主卡利莫斯 Kalimos, Primal Lord
//[x]<b>Battlecry:</b> If you played anElemental last turn, cast anElemental Invocation.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则施放一个元素祈咒。 
	{
		


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.anzOwnElementalsLastTurn > 0 && own.own) p.evaluatePenality -= 12;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_021 : SimTemplate //* 蒸汽涌动者 Steam Surger
//[x]<b>Battlecry:</b> If you playedan Elemental last turn,add a 'Flame Geyser'to your hand.
//<b>战吼：</b>如果你在上个回合使用过元素牌，将一张“烈焰喷涌”置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.anzOwnElementalsLastTurn > 0 && own.own) p.drawACard(CardDB.cardNameEN.flamegeyser, own.own, true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_091t4 : SimTemplate //* 枯萎化身塔姆辛 Blightborn Tamsin
	{
        //[x]<b>Battlecry:</b> For the rest ofthe game, damage you takeon your turn damages your__opponent instead.
        //<b>战吼：</b>在本局对战的剩余时间内，你在你的回合受到的伤害改为伤害你的对手。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.anzTamsin = true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_841 : SimTemplate //* 匿名线人 anonymousinformant
									//* 战吼：你使用的下一张奥秘牌的法力值消耗为（0）点。
									//* Battlecry: The next Secret you play costs (0).
	{
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.nextSecretThisTurnCost0 = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_389 : SimTemplate //* 狗头人拾荒者 Rummaging Kobold
//<b>Battlecry:</b> Return one of your destroyed weapons to your hand.
//<b>战吼：</b>将你的一把被摧毁的武器置入你的手牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.fierywaraxe, own.own, true);
        }
}
}
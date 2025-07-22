using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_348 : SimTemplate //* 魔泉山猫 Springpaw
//[x]<b>Rush</b><b>Battlecry:</b> Add a 1/1 Lynxwith <b>Rush</b> to your hand.
//<b>突袭，战吼：</b>将一张1/1并具有<b>突袭</b>的山猫置入你的手牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.rivercrocolisk, own.own, true);
		}
    }
}
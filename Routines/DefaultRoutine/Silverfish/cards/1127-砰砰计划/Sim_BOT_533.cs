using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_533 : SimTemplate //* 凶恶的雨云 Menacing Nimbus
//<b>Battlecry:</b> Add a random Elemental to your hand.
//<b>战吼：</b>随机将一张元素牌置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
		}
	}
}
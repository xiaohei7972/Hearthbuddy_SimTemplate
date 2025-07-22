using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_400 : SimTemplate //* 怪盗布缆鼠 EVIL Cable Rat
//<b>Battlecry:</b> Add a <b>Lackey</b> to_your hand.
//<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}


	}
}
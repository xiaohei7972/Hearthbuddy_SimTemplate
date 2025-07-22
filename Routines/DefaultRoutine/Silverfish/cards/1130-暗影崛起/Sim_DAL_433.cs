using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_433 : SimTemplate //* 淤泥吞食者 Sludge Slurper
//<b>Battlecry:</b> Add a <b>Lackey</b> to your hand. <b>Overload:</b> (1)
//<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。<b>过载：</b>（1） 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ueberladung++;
			p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}
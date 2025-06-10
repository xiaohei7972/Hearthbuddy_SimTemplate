using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_026 : SimTemplate //* 永恒哨卫 Eternal Sentinel
//<b>Battlecry:</b> Unlock your <b>Overloaded</b> Mana Crystals.
//<b>战吼：</b>将你所有<b>过载</b>的法力水晶解锁。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.unlockMana();
		}
	}
}
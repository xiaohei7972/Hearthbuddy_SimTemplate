using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_086 : SimTemplate //* 夺日者间谍 Sunreaver Spy
//<b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1.
//<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetBuffed(own, 1, 1);
		}
	}
}